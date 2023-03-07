using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using System.IO;


namespace AutoBlockExtractor
{
    public class BlockExtractorUtil
    {
        [CommandMethod("EB")]
        public void ExtractBlocks()
        {
            BlockExtractorForm form = new BlockExtractorForm();
            form.Show();
        }

        internal void ProcessBlockExtraction(string dwgFile, string blockName, string filename)
        {
            Document doc = Application.DocumentManager.Open(dwgFile);
            doc.LockDocument();

            // Get the database and editor object
            Database db = doc.Database;
            Editor edt = doc.Editor;

            edt.WriteMessage($"\nSelecting All The { blockName} in the drawing.");

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;

                if (!bt.Has(blockName))
                {
                    edt.WriteMessage($"No { blockName} block found in the drawing.");
                    return;
                }

                // Create a TypedValue for the selectionset filter
                TypedValue[] tv = new TypedValue[2];
                tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                tv.SetValue(new TypedValue((int)DxfCode.BlockName, blockName), 1);

                // create a filter with these values
                SelectionFilter filter = new SelectionFilter(tv);
                PromptSelectionResult psr = edt.SelectAll(filter);

                // check if there is object selected
                if (psr.Status == PromptStatus.OK)
                {
                    SelectionSet ss = psr.Value;
                    string attrVal = "";
                    string header = "";

                    StreamWriter writer = new StreamWriter(filename);

                    // Constract the header by looping through the list of attributes of block
                    SelectedObject selObj = ss[0];
                    BlockReference bref = trans.GetObject(selObj.ObjectId, OpenMode.ForWrite) as BlockReference;

                    if (bref.AttributeCollection.Count > 0)
                    {
                        header = "InsertionPtX, InsertionPtY,";

                        foreach (ObjectId attReferenceId in bref.AttributeCollection)
                        {
                            DBObject obj = trans.GetObject(attReferenceId, OpenMode.ForRead);
                            AttributeReference attRef = obj as AttributeReference;
                            if (attRef != null)
                            {
                                header += attRef.Tag + ",";
                            }
                        }
                        writer.WriteLine(header.Substring(0, header.Length - 1));
                    }

                    // loop through the selectionset and extract the block attribute values
                    foreach (SelectedObject sObj in ss)
                    {
                        BlockReference br = trans.GetObject(sObj.ObjectId, OpenMode.ForWrite) as BlockReference;
                        if (br.AttributeCollection.Count > 0)
                        {
                            // Get the insertion points
                            attrVal += $"{br.Position.X.ToString()} , {br.Position.Y.ToString()}";

                            foreach (ObjectId attrReferenceID in br.AttributeCollection)
                            {
                                DBObject obj = trans.GetObject(attrReferenceID, OpenMode.ForRead);
                                AttributeReference attRef = obj as AttributeReference;
                                if (attRef != null)
                                {
                                    attrVal += attRef.TextString + ",";
                                }
                            }
                            writer.WriteLine(attrVal.Substring(0, attrVal.Length - 1));
                            attrVal = "";
                        }
                    }
                    // Display the count of the block selected
                    edt.WriteMessage($"Number of {blockName} found is: {ss.Count.ToString()}");
                    writer.Close();
                }
                else
                {
                    edt.WriteMessage("There are no Block Found.");
                }
            }
            // Close the drawing
            doc.CloseAndDiscard();
        }
    }
}
