namespace AutoBlockExtractor
{
    partial class BlockExtractorForm
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
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.checkedListBoxDWG = new System.Windows.Forms.CheckedListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.maskedTextBoxPath = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProcessBlockExtraction = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxBlockName = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.groupBox1.Controls.Add(this.checkBoxSelectAll);
            this.groupBox1.Controls.Add(this.checkedListBoxDWG);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.maskedTextBoxPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(23, 194);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSelectAll.TabIndex = 4;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.CheckBoxSelectAll_CheckedChanged);
            // 
            // checkedListBoxDWG
            // 
            this.checkedListBoxDWG.FormattingEnabled = true;
            this.checkedListBoxDWG.Location = new System.Drawing.Point(23, 74);
            this.checkedListBoxDWG.Name = "checkedListBoxDWG";
            this.checkedListBoxDWG.Size = new System.Drawing.Size(412, 94);
            this.checkedListBoxDWG.TabIndex = 3;
            this.checkedListBoxDWG.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxDWG_SelectedIndexChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(360, 31);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // maskedTextBoxPath
            // 
            this.maskedTextBoxPath.Location = new System.Drawing.Point(103, 33);
            this.maskedTextBoxPath.Name = "maskedTextBoxPath";
            this.maskedTextBoxPath.Size = new System.Drawing.Size(251, 20);
            this.maskedTextBoxPath.TabIndex = 1;
            this.maskedTextBoxPath.Text = "C:\\Users\\ultra\\OneDrive\\Desktop\\testDWG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawing Path: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonProcessBlockExtraction);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 556);
            this.panel1.TabIndex = 1;
            // 
            // buttonProcessBlockExtraction
            // 
            this.buttonProcessBlockExtraction.Enabled = false;
            this.buttonProcessBlockExtraction.Location = new System.Drawing.Point(337, 477);
            this.buttonProcessBlockExtraction.Name = "buttonProcessBlockExtraction";
            this.buttonProcessBlockExtraction.Size = new System.Drawing.Size(148, 34);
            this.buttonProcessBlockExtraction.TabIndex = 2;
            this.buttonProcessBlockExtraction.Text = "Process Block Extraction";
            this.buttonProcessBlockExtraction.UseVisualStyleBackColor = true;
            this.buttonProcessBlockExtraction.Click += new System.EventHandler(this.ButtonProcessBlockExtraction_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(15, 426);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(77, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Process info ...";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.groupBox2.Controls.Add(this.maskedTextBoxBlockName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // maskedTextBoxBlockName
            // 
            this.maskedTextBoxBlockName.Location = new System.Drawing.Point(175, 33);
            this.maskedTextBoxBlockName.Name = "maskedTextBoxBlockName";
            this.maskedTextBoxBlockName.Size = new System.Drawing.Size(162, 20);
            this.maskedTextBoxBlockName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Block Name to EXtract: ";
            // 
            // BlockExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 556);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "BlockExtractorForm";
            this.Text = "Block Extractor Form";
            this.Load += new System.EventHandler(this.BlockExtractorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxDWG;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button buttonProcessBlockExtraction;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBlockName;
        private System.Windows.Forms.Label label3;
    }
}