namespace Clinic_Record
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPatienList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPatienList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkPath = new System.Windows.Forms.LinkLabel();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatienList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatienList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.Appearance.Options.UseFont = true;
            this.btnAddPatient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.ImageOptions.Image")));
            this.btnAddPatient.Location = new System.Drawing.Point(12, 27);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(151, 39);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "လူနာစာရင်း ထည့်ရန်";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // gridControlPatienList
            // 
            this.gridControlPatienList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPatienList.Location = new System.Drawing.Point(0, 72);
            this.gridControlPatienList.MainView = this.gridViewPatienList;
            this.gridControlPatienList.Name = "gridControlPatienList";
            this.gridControlPatienList.Size = new System.Drawing.Size(912, 451);
            this.gridControlPatienList.TabIndex = 2;
            this.gridControlPatienList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPatienList});
            // 
            // gridViewPatienList
            // 
            this.gridViewPatienList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewPatienList.GridControl = this.gridControlPatienList;
            this.gridViewPatienList.IndicatorWidth = 50;
            this.gridViewPatienList.Name = "gridViewPatienList";
            this.gridViewPatienList.OptionsBehavior.Editable = false;
            this.gridViewPatienList.OptionsFind.AlwaysVisible = true;
            this.gridViewPatienList.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPatienList.OptionsView.ShowGroupPanel = false;
            this.gridViewPatienList.RowHeight = 30;
            this.gridViewPatienList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewPatienList_CustomDrawRowIndicator);
            this.gridViewPatienList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewPatienList_KeyDown);
            this.gridViewPatienList.DoubleClick += new System.EventHandler(this.gridViewPatienList_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 8.25F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.Caption = "လူနာ အမည်";
            this.gridColumn1.FieldName = "patient_name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "filePath";
            this.gridColumn2.FieldName = "filePath";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data လမ်းကြောင်း";
            // 
            // linkPath
            // 
            this.linkPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkPath.Location = new System.Drawing.Point(126, 535);
            this.linkPath.Name = "linkPath";
            this.linkPath.Size = new System.Drawing.Size(774, 25);
            this.linkPath.TabIndex = 3;
            this.linkPath.TabStop = true;
            this.linkPath.Text = "linkLabel1";
            this.linkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPath_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 568);
            this.Controls.Add(this.linkPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControlPatienList);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ဆေးခန်းမှတ်တမ်း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatienList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatienList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddPatient;
        private DevExpress.XtraGrid.GridControl gridControlPatienList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPatienList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}

