using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            string choice = "";

            // using Combobox
            //choice = comboBoxOptions.SelectedItem.ToString();
            //DisplayItem(choice);

            // using TextBox
            choice = ItemtextBox.Text.Trim();
            DisplayItem(choice);

            // Using radioButtons 
            /*
            if (radioButtonLayer.Checked)
            {
                choice = radioButtonLayer.Text;
            }
            else if (radioButtonLinetype.Checked)
            {
                choice = radioButtonLinetype.Text;
            }
            else if (radioButtonTextstyle.Checked)
            {
                choice = radioButtonTextstyle.Text;
            }
            else
            {
                choice = "All";
            }
            DisplayItem(choice);
            */

            // ------- using checkbox
            /*
            if (checkBoxLayer.Checked)
            {
                choice = checkBoxLayer.Text + ",";
            }
            if (checkBoxLinetype.Checked)
            {
                choice += checkBoxLinetype.Text + ",";
            }
            if (checkBoxTextstyle.Checked)
            {
                choice += checkBoxTextstyle.Text + ",";
            }
            if (checkBoxLayer.Checked && checkBoxLinetype.Checked && checkBoxTextstyle.Checked)
            {
                choice = "All";
            }

            string[] choices = choice.Split(',');

            for (int i = 0; i < choices.Length; i++)
            {
                choice = choices[i];
                DisplayItem(choice);
            }
            */

            /*
            ControlsDemoUtils cutil = new ControlsDemoUtils();

            if (choice == "Layer")
            {
                ArrayList layers = cutil.GetLayers();

                listLayer.DataSource = layers;
                listLinetype.DataSource = null;
                listTextstyle.DataSource = null;


                labelLayerCount.Text = "Layers Count = " + layers.Count;
                labelLintetypeCount.Text = "...";
                labelTextstyleCount.Text = "...";
            }
            else if (choice == "Linetype")
            {
                ArrayList linetypes = cutil.GetLinetypes();

                listLayer.DataSource = null;
                listLinetype.DataSource = linetypes;
                listTextstyle.DataSource = null;

                labelLayerCount.Text = "...";
                labelLintetypeCount.Text = "Linetypes Count = " + linetypes.Count;
                labelTextstyleCount.Text = "...";
            }
            else if (choice == "Textstyle")
            {
                ArrayList textstyles = cutil.GetTextstyles();

                listLayer.DataSource = null;
                listLinetype.DataSource = null;
                listTextstyle.DataSource = textstyles;

                labelLayerCount.Text = "...";
                labelLintetypeCount.Text = "...";
                labelTextstyleCount.Text = "Textstyles Count = " + textstyles.Count;

            }
            else if (choice == "All")
            {
                ArrayList layers = cutil.GetLayers();
                listLayer.DataSource = layers;

                ArrayList linetypes = cutil.GetLinetypes();
                listLinetype.DataSource = linetypes;

                ArrayList textstyles = cutil.GetTextstyles();
                listTextstyle.DataSource = textstyles;

                labelLayerCount.Text = "Layers Count = " + layers.Count;
                labelLintetypeCount.Text = "Linetypes Count = " + linetypes.Count;
                labelTextstyleCount.Text = "Textstyles Count = " + textstyles.Count;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Value.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void DisplayItem(string choice)
        {
            ControlsDemoUtils cutil = new ControlsDemoUtils();

            if (choice == "Layer")
            {
                ArrayList layers = cutil.GetLayers();

                listLayer.DataSource = layers;
                listLinetype.DataSource = null;
                listTextstyle.DataSource = null;


                labelLayerCount.Text = "Layers Count = " + layers.Count;
                labelLintetypeCount.Text = "...";
                labelTextstyleCount.Text = "...";
            }
            else if (choice == "Linetype")
            {
                ArrayList linetypes = cutil.GetLinetypes();

                listLayer.DataSource = null;
                listLinetype.DataSource = linetypes;
                listTextstyle.DataSource = null;

                labelLayerCount.Text = "...";
                labelLintetypeCount.Text = "Linetypes Count = " + linetypes.Count;
                labelTextstyleCount.Text = "...";
            }
            else if (choice == "Textstyle")
            {
                ArrayList textstyles = cutil.GetTextstyles();

                listLayer.DataSource = null;
                listLinetype.DataSource = null;
                listTextstyle.DataSource = textstyles;

                labelLayerCount.Text = "...";
                labelLintetypeCount.Text = "...";
                labelTextstyleCount.Text = "Textstyles Count = " + textstyles.Count;

            }
            else if (choice == "All")
            {
                ArrayList layers = cutil.GetLayers();
                listLayer.DataSource = layers;

                ArrayList linetypes = cutil.GetLinetypes();
                listLinetype.DataSource = linetypes;

                ArrayList textstyles = cutil.GetTextstyles();
                listTextstyle.DataSource = textstyles;

                labelLayerCount.Text = "Layers Count = " + layers.Count;
                labelLintetypeCount.Text = "Linetypes Count = " + linetypes.Count;
                labelTextstyleCount.Text = "Textstyles Count = " + textstyles.Count;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Value.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            listLayer.DataSource = null;
            listLinetype.DataSource = null;
            listTextstyle.DataSource = null;

            labelLayerCount.Text = "...";
            labelLintetypeCount.Text = "...";
            labelTextstyleCount.Text = "...";
        }
    }
}
