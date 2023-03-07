using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System.Collections;

namespace ControlsDemo
{
    public class ControlsDemoUtils
    {
        [CommandMethod("Demo")]
        public void Demo()
        {
            MainForm mf = new MainForm();
            mf.Show();
        }

        public ArrayList GetLayers()
        {
            ArrayList layers = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LayerTable LayTab = trans.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (var ly in LayTab)
                {
                    LayerTableRecord lytr = trans.GetObject(ly, OpenMode.ForRead) as LayerTableRecord;
                    layers.Add(lytr.Name);
                }
            }

            return layers;
        }

        public ArrayList GetLinetypes()
        {
            ArrayList linetypes = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                LinetypeTable ltTab = trans.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;
                foreach (var lt in ltTab)
                {
                    LinetypeTableRecord lttr = trans.GetObject(lt, OpenMode.ForRead) as LinetypeTableRecord;
                    linetypes.Add(lttr.Name);
                }
            }

            return linetypes;
        }


        public ArrayList GetTextstyles()
        {
            ArrayList textstyles = new ArrayList();

            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                TextStyleTable tsTab = trans.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                foreach (var ts in tsTab)
                {
                    TextStyleTableRecord tstr = trans.GetObject(ts, OpenMode.ForRead) as TextStyleTableRecord;
                    textstyles.Add(tstr.Name);
                }
            }

            return textstyles;
        }

    }
}
