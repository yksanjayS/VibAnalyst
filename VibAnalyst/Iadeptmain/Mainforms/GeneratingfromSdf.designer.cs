namespace Iadeptmain.Mainforms
{
    partial class GeneratingfromSdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratingfromSdf));
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new DevExpress.XtraEditors.TextEdit();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtdb = new DevExpress.XtraEditors.TextEdit();
            this.rbfolder = new System.Windows.Forms.RadioButton();
            this.rbfile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(276, 54);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(62, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 57);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Properties.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(262, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(99, 162);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(83, 28);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a File";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 102);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Enter Database Name";
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(14, 130);
            this.txtdb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(262, 22);
            this.txtdb.TabIndex = 5;
            this.txtdb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdb_KeyPress);
            // 
            // rbfolder
            // 
            this.rbfolder.AutoSize = true;
            this.rbfolder.Checked = true;
            this.rbfolder.Location = new System.Drawing.Point(14, 5);
            this.rbfolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbfolder.Name = "rbfolder";
            this.rbfolder.Size = new System.Drawing.Size(66, 21);
            this.rbfolder.TabIndex = 6;
            this.rbfolder.TabStop = true;
            this.rbfolder.Text = "Folder";
            this.rbfolder.UseVisualStyleBackColor = true;
            this.rbfolder.Visible = false;
            // 
            // rbfile
            // 
            this.rbfile.AutoSize = true;
            this.rbfile.Location = new System.Drawing.Point(154, 5);
            this.rbfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbfile.Name = "rbfile";
            this.rbfile.Size = new System.Drawing.Size(47, 21);
            this.rbfile.TabIndex = 7;
            this.rbfile.Text = "File";
            this.rbfile.UseVisualStyleBackColor = true;
            this.rbfile.Visible = false;
            // 
            // GeneratingfromSdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 198);
            this.ControlBox = false;
            this.Controls.Add(this.rbfile);
            this.Controls.Add(this.rbfolder);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneratingfromSdf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generating Database";
            ((System.ComponentModel.ISupportInitialize)(this.textBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit textBox2;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtdb;
        public System.Windows.Forms.RadioButton rbfolder;
        public System.Windows.Forms.RadioButton rbfile;
    }
}