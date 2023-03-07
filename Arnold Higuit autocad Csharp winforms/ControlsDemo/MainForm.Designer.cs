namespace ControlsDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLinetype = new System.Windows.Forms.RadioButton();
            this.radioButtonTextstyle = new System.Windows.Forms.RadioButton();
            this.radioButtonLayer = new System.Windows.Forms.RadioButton();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTextstyleCount = new System.Windows.Forms.Label();
            this.labelLintetypeCount = new System.Windows.Forms.Label();
            this.labelLayerCount = new System.Windows.Forms.Label();
            this.listTextstyle = new System.Windows.Forms.ListBox();
            this.listLinetype = new System.Windows.Forms.ListBox();
            this.listLayer = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxLayer = new System.Windows.Forms.CheckBox();
            this.checkBoxLinetype = new System.Windows.Forms.CheckBox();
            this.checkBoxTextstyle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.ItemtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonClearAll);
            this.groupBox1.Controls.Add(this.buttonDisplay);
            this.groupBox1.Controls.Add(this.comboBoxOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLinetype);
            this.groupBox3.Controls.Add(this.radioButtonTextstyle);
            this.groupBox3.Controls.Add(this.radioButtonLayer);
            this.groupBox3.Location = new System.Drawing.Point(21, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Radio Buttons";
            // 
            // radioButtonLinetype
            // 
            this.radioButtonLinetype.AutoSize = true;
            this.radioButtonLinetype.Location = new System.Drawing.Point(81, 34);
            this.radioButtonLinetype.Name = "radioButtonLinetype";
            this.radioButtonLinetype.Size = new System.Drawing.Size(65, 17);
            this.radioButtonLinetype.TabIndex = 2;
            this.radioButtonLinetype.TabStop = true;
            this.radioButtonLinetype.Text = "Linetype";
            this.radioButtonLinetype.UseVisualStyleBackColor = true;
            // 
            // radioButtonTextstyle
            // 
            this.radioButtonTextstyle.AutoSize = true;
            this.radioButtonTextstyle.Location = new System.Drawing.Point(157, 34);
            this.radioButtonTextstyle.Name = "radioButtonTextstyle";
            this.radioButtonTextstyle.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTextstyle.TabIndex = 1;
            this.radioButtonTextstyle.TabStop = true;
            this.radioButtonTextstyle.Text = "Textstyle";
            this.radioButtonTextstyle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLayer
            // 
            this.radioButtonLayer.AutoSize = true;
            this.radioButtonLayer.Location = new System.Drawing.Point(19, 34);
            this.radioButtonLayer.Name = "radioButtonLayer";
            this.radioButtonLayer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLayer.TabIndex = 0;
            this.radioButtonLayer.TabStop = true;
            this.radioButtonLayer.Text = "Layer";
            this.radioButtonLayer.UseVisualStyleBackColor = true;
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Location = new System.Drawing.Point(137, 82);
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(121, 20);
            this.ItemtextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter item to Display";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(178, 350);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(80, 30);
            this.buttonClearAll.TabIndex = 3;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(21, 350);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(81, 30);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Show";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.ItemHeight = 13;
            this.comboBoxOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "Linetype",
            "Textstyle"});
            this.comboBoxOptions.Location = new System.Drawing.Point(137, 33);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select item to Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTextstyleCount);
            this.groupBox2.Controls.Add(this.labelLintetypeCount);
            this.groupBox2.Controls.Add(this.labelLayerCount);
            this.groupBox2.Controls.Add(this.listTextstyle);
            this.groupBox2.Controls.Add(this.listLinetype);
            this.groupBox2.Controls.Add(this.listLayer);
            this.groupBox2.Location = new System.Drawing.Point(316, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // labelTextstyleCount
            // 
            this.labelTextstyleCount.AutoSize = true;
            this.labelTextstyleCount.Location = new System.Drawing.Point(320, 370);
            this.labelTextstyleCount.Name = "labelTextstyleCount";
            this.labelTextstyleCount.Size = new System.Drawing.Size(16, 13);
            this.labelTextstyleCount.TabIndex = 6;
            this.labelTextstyleCount.Text = "...";
            // 
            // labelLintetypeCount
            // 
            this.labelLintetypeCount.AutoSize = true;
            this.labelLintetypeCount.Location = new System.Drawing.Point(168, 370);
            this.labelLintetypeCount.Name = "labelLintetypeCount";
            this.labelLintetypeCount.Size = new System.Drawing.Size(16, 13);
            this.labelLintetypeCount.TabIndex = 5;
            this.labelLintetypeCount.Text = "...";
            // 
            // labelLayerCount
            // 
            this.labelLayerCount.AutoSize = true;
            this.labelLayerCount.Location = new System.Drawing.Point(19, 370);
            this.labelLayerCount.Name = "labelLayerCount";
            this.labelLayerCount.Size = new System.Drawing.Size(16, 13);
            this.labelLayerCount.TabIndex = 4;
            this.labelLayerCount.Text = "...";
            // 
            // listTextstyle
            // 
            this.listTextstyle.FormattingEnabled = true;
            this.listTextstyle.Location = new System.Drawing.Point(323, 35);
            this.listTextstyle.Name = "listTextstyle";
            this.listTextstyle.Size = new System.Drawing.Size(133, 329);
            this.listTextstyle.TabIndex = 2;
            // 
            // listLinetype
            // 
            this.listLinetype.FormattingEnabled = true;
            this.listLinetype.Location = new System.Drawing.Point(171, 35);
            this.listLinetype.Name = "listLinetype";
            this.listLinetype.Size = new System.Drawing.Size(133, 329);
            this.listLinetype.TabIndex = 1;
            // 
            // listLayer
            // 
            this.listLayer.FormattingEnabled = true;
            this.listLayer.Location = new System.Drawing.Point(22, 35);
            this.listLayer.Name = "listLayer";
            this.listLayer.Size = new System.Drawing.Size(133, 329);
            this.listLayer.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxTextstyle);
            this.groupBox4.Controls.Add(this.checkBoxLinetype);
            this.groupBox4.Controls.Add(this.checkBoxLayer);
            this.groupBox4.Location = new System.Drawing.Point(21, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 71);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CheckBox ";
            // 
            // checkBoxLayer
            // 
            this.checkBoxLayer.AutoSize = true;
            this.checkBoxLayer.Location = new System.Drawing.Point(19, 29);
            this.checkBoxLayer.Name = "checkBoxLayer";
            this.checkBoxLayer.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLayer.TabIndex = 0;
            this.checkBoxLayer.Text = "Layer";
            this.checkBoxLayer.UseVisualStyleBackColor = true;
            // 
            // checkBoxLinetype
            // 
            this.checkBoxLinetype.AutoSize = true;
            this.checkBoxLinetype.Location = new System.Drawing.Point(81, 29);
            this.checkBoxLinetype.Name = "checkBoxLinetype";
            this.checkBoxLinetype.Size = new System.Drawing.Size(66, 17);
            this.checkBoxLinetype.TabIndex = 1;
            this.checkBoxLinetype.Text = "Linetype";
            this.checkBoxLinetype.UseVisualStyleBackColor = true;
            // 
            // checkBoxTextstyle
            // 
            this.checkBoxTextstyle.AutoSize = true;
            this.checkBoxTextstyle.Location = new System.Drawing.Point(157, 29);
            this.checkBoxTextstyle.Name = "checkBoxTextstyle";
            this.checkBoxTextstyle.Size = new System.Drawing.Size(68, 17);
            this.checkBoxTextstyle.TabIndex = 2;
            this.checkBoxTextstyle.Text = "Textstyle";
            this.checkBoxTextstyle.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listLayer;
        private System.Windows.Forms.Label labelTextstyleCount;
        private System.Windows.Forms.Label labelLintetypeCount;
        private System.Windows.Forms.Label labelLayerCount;
        private System.Windows.Forms.ListBox listTextstyle;
        private System.Windows.Forms.ListBox listLinetype;
        private System.Windows.Forms.TextBox ItemtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonLinetype;
        private System.Windows.Forms.RadioButton radioButtonTextstyle;
        private System.Windows.Forms.RadioButton radioButtonLayer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxTextstyle;
        private System.Windows.Forms.CheckBox checkBoxLinetype;
        private System.Windows.Forms.CheckBox checkBoxLayer;
    }
}