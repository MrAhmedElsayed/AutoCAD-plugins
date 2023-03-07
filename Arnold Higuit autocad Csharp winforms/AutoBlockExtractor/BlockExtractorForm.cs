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

namespace AutoBlockExtractor
{
    public partial class BlockExtractorForm : Form
    {
        public BlockExtractorForm()
        {
            InitializeComponent();
        }

        private void BlockExtractorForm_Load(object sender, EventArgs e)
        {
            LoadingDrawings(maskedTextBoxPath.Text);
        }

        private void LoadingDrawings(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");
                if (files.Length > 0)
                {
                    // Load all drawing files into the list box
                    foreach (string dwg in files)
                    {
                        checkedListBoxDWG.Items.Add(dwg);
                    }
                    labelInfo.Text = "Total Number of Drawings = " + checkedListBoxDWG.Items.Count;
                }
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = maskedTextBoxPath.Text;
                DialogResult result = fbd.ShowDialog();
               
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) 
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");
                    
                    // clear the list box and load all the drawing files in the folder
                    checkedListBoxDWG.Items.Clear();

                    // Load All drawing files
                    foreach (string dwg in files)
                    {
                        checkedListBoxDWG.Items.Add(dwg);
                    }
                    labelInfo.Text = "Total Number of Drawings = " + checkedListBoxDWG.Items.Count;
                    maskedTextBoxPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void CheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                for (int i = 0; i < checkedListBoxDWG.Items.Count; i++)
                {
                    checkedListBoxDWG.SetItemChecked(i, true);
                }
                buttonProcessBlockExtraction.Enabled = true;
            }
            else
            {
                for (int i = 0; i < checkedListBoxDWG.Items.Count; i++)
                {
                    checkedListBoxDWG.SetItemChecked(i, false);
                }
                buttonProcessBlockExtraction.Enabled = false;
            }

            labelInfo.Text = "Total Number of Drawings = " + checkedListBoxDWG.Items.Count;

        }

        private void ButtonProcessBlockExtraction_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxBlockName.Text == "")
            {
                labelInfo.Text = "Please Enter The Block Name to Extract.";
                labelInfo.ForeColor = Color.Red;
                maskedTextBoxBlockName.Focus();
                return;
            }

            int i = 1;
            int totalCount = checkedListBoxDWG.CheckedItems.Count;
            string blockName = maskedTextBoxBlockName.Text.Trim();

            BlockExtractorUtil beu = new BlockExtractorUtil();

            foreach (string dwgFile in checkedListBoxDWG.CheckedItems)
            {
                labelInfo.Text = $"Processing ({i.ToString()}) of ({totalCount.ToString()}): {dwgFile}";
                labelInfo.ForeColor = Color.Green;
                string filename = dwgFile + "_blocks.txt";
                beu.ProcessBlockExtraction(dwgFile, blockName, filename);
                i += 1;
            }
            labelInfo.Text = "Extraction of Blocks Completed Successfully.";
        }

        private void CheckedListBoxDWG_SelectedIndexChanged(object sender, EventArgs e)
        {
            // same functionality
            //buttonProcessBlockExtraction.Enabled = checkedListBoxDWG.CheckedItems.Count > 0 ?  true : false;

            if (checkedListBoxDWG.CheckedItems.Count > 0)
            {
                buttonProcessBlockExtraction.Enabled = true;
            }
            else
            {
                buttonProcessBlockExtraction.Enabled = false;
            }
            labelInfo.Text = "Number of Selected Drawings = " + checkedListBoxDWG.CheckedItems.Count;
        }
    }
}
