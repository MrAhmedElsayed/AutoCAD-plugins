using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;


namespace AutomateUpdateLayer
{
    public class UpdateLayerUtil
    {
        [CommandMethod("UL")]
        public void UpdateLayer()
        {
            LayerUpdateForm form = new LayerUpdateForm();
            form.Show();
        }

        public void ProcessLayerUpdate(string dwgPath, string oldLayer, string newLayer)
        {
            Document doc = Application.DocumentManager.Open(dwgPath);
            Database db = doc.Database;
            Editor edt = doc.Editor;
            doc.LockDocument();

            try
            {
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.LayerName, oldLayer), 0);

                    SelectionFilter sFilter = new SelectionFilter(tv);
                    PromptSelectionResult psr = edt.SelectAll(sFilter);

                    if (psr.Status == PromptStatus.OK)
                    {
                        SelectionSet ss = psr.Value;
                        // Loop through the selection and chang the layer
                        foreach (SelectedObject sObj in ss)
                        {
                            if (sObj != null)
                            {
                                // create a new entity and design the project to the entity
                                Entity ent = trans.GetObject(sObj.ObjectId, OpenMode.ForWrite) as Entity;
                                ent.Layer = newLayer;
                            }
                        }
                    }
                    else
                    {
                        edt.WriteMessage("\nThere Is no Object selected.");
                    }
                    trans.Commit();
                }
                db.SaveAs(dwgPath, DwgVersion.Current);
                doc.CloseAndDiscard();
            }
            catch (Autodesk.AutoCAD.Runtime.Exception ex)
            {
                edt.WriteMessage($"Error encountered: {ex.Message}");
            }
        }

    }
}
