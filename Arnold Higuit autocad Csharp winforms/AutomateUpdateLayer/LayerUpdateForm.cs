using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomateUpdateLayer
{
    public partial class LayerUpdateForm : Form
    {
        public LayerUpdateForm()
        {
            InitializeComponent();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = textBoxPath.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PopulateListBox(fbd.SelectedPath);
                    textBoxPath.Text = fbd.SelectedPath;
                }

            }
        }

        private void LayerUpdateForm_Load(object sender, EventArgs e)
        {
            PopulateListBox(textBoxPath.Text.Trim());
        }

        private void PopulateListBox(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");
                if (files.Length > 0)
                {
                    // Load all drawing files into the list box
                    listBoxDWGs.DataSource = files;
                    labelInfo.Text = "Total Number of Drawings = " + listBoxDWGs.Items.Count;
                }
            }
        }

        private void ButtonUpdateLayer_Click(object sender, EventArgs e)
        {
            string oldLayer = textBoxOldLayer.Text.Trim();
            string newLayer = textBoxNewLayer.Text.Trim();

            int i = 1;

            UpdateLayerUtil ULutil = new UpdateLayerUtil();

            int totalCount = listBoxDWGs.Items.Count;

            // Loop through the ListBox and process the drawing one at a time
            foreach (string dwgFile in listBoxDWGs.Items)
            {
                labelInfo.Text = $"Processing ( {i.ToString()} of {totalCount.ToString()} ) : {dwgFile}";
                labelInfo.ForeColor = Color.Green;

                ULutil.ProcessLayerUpdate(dwgFile, oldLayer, newLayer);

                i += 1;
            }
            labelInfo.Text = "Updating of layers completed successfully.";
        }

    }
}
