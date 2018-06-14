namespace Iadeptmain.Mainforms
{
    partial class frmNewDataBaseCreation
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
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbCreateProgbar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnCreateDatabase = new DevExpress.XtraEditors.SimpleButton();
            this.tbNewMySqlDB = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbInstNameSelected = new DevExpress.XtraEditors.ComboBoxEdit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewMySqlDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstNameSelected.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Instrument";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar,
            this.dbCreateProgbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 79);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(425, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(208, 21);
            this.lblStatusBar.Text = "Database Creation In Progress";
            // 
            // dbCreateProgbar
            // 
            this.dbCreateProgbar.Name = "dbCreateProgbar";
            this.dbCreateProgbar.Size = new System.Drawing.Size(117, 20);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(318, 43);
            this.btnCreateDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(68, 28);
            this.btnCreateDatabase.TabIndex = 11;
            this.btnCreateDatabase.Text = "Create";
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // tbNewMySqlDB
            // 
            this.tbNewMySqlDB.Location = new System.Drawing.Point(174, 39);
            this.tbNewMySqlDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewMySqlDB.Name = "tbNewMySqlDB";
            this.tbNewMySqlDB.Size = new System.Drawing.Size(126, 22);
            this.tbNewMySqlDB.TabIndex = 10;
            this.tbNewMySqlDB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewMySqlDB_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Database Name";
            // 
            // cmbInstNameSelected
            // 
            this.cmbInstNameSelected.Location = new System.Drawing.Point(174, 10);
            this.cmbInstNameSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInstNameSelected.Name = "cmbInstNameSelected";
            this.cmbInstNameSelected.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstNameSelected.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInstNameSelected.Size = new System.Drawing.Size(212, 22);
            this.cmbInstNameSelected.TabIndex = 12;
            // 
            // frmNewDataBaseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 105);
            this.Controls.Add(this.cmbInstNameSelected);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.tbNewMySqlDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewDataBaseCreation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New DataBase";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewMySqlDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstNameSelected.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ToolStripProgressBar dbCreateProgbar;
        private DevExpress.XtraEditors.SimpleButton btnCreateDatabase;
        private DevExpress.XtraEditors.TextEdit tbNewMySqlDB;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInstNameSelected;
    }
}