namespace AutomateUpdateLayer
{
    partial class LayerUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxDWGs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldLayer = new System.Windows.Forms.TextBox();
            this.textBoxNewLayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonUpdateLayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Path : ";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(87, 33);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(236, 20);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.Text = "C:\\Users\\ultra\\OneDrive\\Desktop\\testDWG";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(340, 32);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // listBoxDWGs
            // 
            this.listBoxDWGs.FormattingEnabled = true;
            this.listBoxDWGs.Location = new System.Drawing.Point(18, 78);
            this.listBoxDWGs.Name = "listBoxDWGs";
            this.listBoxDWGs.Size = new System.Drawing.Size(397, 186);
            this.listBoxDWGs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Old Layer : ";
            // 
            // textBoxOldLayer
            // 
            this.textBoxOldLayer.Location = new System.Drawing.Point(116, 286);
            this.textBoxOldLayer.Name = "textBoxOldLayer";
            this.textBoxOldLayer.Size = new System.Drawing.Size(236, 20);
            this.textBoxOldLayer.TabIndex = 5;
            // 
            // textBoxNewLayer
            // 
            this.textBoxNewLayer.Location = new System.Drawing.Point(116, 322);
            this.textBoxNewLayer.Name = "textBoxNewLayer";
            this.textBoxNewLayer.Size = new System.Drawing.Size(236, 20);
            this.textBoxNewLayer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter New Layer : ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(15, 366);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(19, 13);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "....";
            // 
            // buttonUpdateLayer
            // 
            this.buttonUpdateLayer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateLayer.Location = new System.Drawing.Point(308, 381);
            this.buttonUpdateLayer.Name = "buttonUpdateLayer";
            this.buttonUpdateLayer.Size = new System.Drawing.Size(107, 40);
            this.buttonUpdateLayer.TabIndex = 9;
            this.buttonUpdateLayer.Text = "Update Layer";
            this.buttonUpdateLayer.UseVisualStyleBackColor = true;
            this.buttonUpdateLayer.Click += new System.EventHandler(this.ButtonUpdateLayer_Click);
            // 
            // LayerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.buttonUpdateLayer);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxNewLayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOldLayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDWGs);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LayerUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LayerUpdateForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LayerUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxDWGs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOldLayer;
        private System.Windows.Forms.TextBox textBoxNewLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonUpdateLayer;
    }
}