namespace Clinic_Record
{
    partial class frmPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dtBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNRCNo = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtBookNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlPatienList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPatienList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.imageFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatienList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatienList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.dtBirthDate);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtRemark);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtNRCNo);
            this.tabPage1.Controls.Add(this.txtFatherName);
            this.tabPage1.Controls.Add(this.txtBookNo);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.pic);
            this.tabPage1.Controls.Add(this.lblBirthDate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(761, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "အသေးစိတ်အချက်အလက်";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(386, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ပိတ်မည်(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.EditValue = null;
            this.dtBirthDate.Location = new System.Drawing.Point(444, 161);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthDate.Size = new System.Drawing.Size(306, 20);
            this.dtBirthDate.TabIndex = 4;
            this.dtBirthDate.EditValueChanged += new System.EventHandler(this.dtBirthDate_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(261, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "သိမ်းမည်(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtRemark.Location = new System.Drawing.Point(73, 346);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(677, 170);
            this.txtRemark.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtAddress.Location = new System.Drawing.Point(444, 223);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 100);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNRCNo
            // 
            this.txtNRCNo.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtNRCNo.Location = new System.Drawing.Point(444, 118);
            this.txtNRCNo.Name = "txtNRCNo";
            this.txtNRCNo.Size = new System.Drawing.Size(306, 30);
            this.txtNRCNo.TabIndex = 3;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtFatherName.Location = new System.Drawing.Point(444, 82);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(306, 30);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtBookNo
            // 
            this.txtBookNo.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtBookNo.Location = new System.Drawing.Point(444, 10);
            this.txtBookNo.Name = "txtBookNo";
            this.txtBookNo.Size = new System.Drawing.Size(306, 30);
            this.txtBookNo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.txtName.Location = new System.Drawing.Point(444, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 30);
            this.txtName.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(9, 10);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(310, 313);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(440, 191);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(17, 24);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "မှတ်ချက်";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "လိပ်စာ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "အသက်";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "မွေးနေ့";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "မှတ်ပုံတင် နံပါတ်";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "အဖအမည်";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "စာအုပ်နံပါတ်";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "လူနာအမည်";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControlPatienList);
            this.tabPage2.Controls.Add(this.btnAddNew);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(761, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ဆေးမှတ်တမ်း";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControlPatienList
            // 
            this.gridControlPatienList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPatienList.Location = new System.Drawing.Point(8, 53);
            this.gridControlPatienList.MainView = this.gridViewPatienList;
            this.gridControlPatienList.Name = "gridControlPatienList";
            this.gridControlPatienList.Size = new System.Drawing.Size(745, 511);
            this.gridControlPatienList.TabIndex = 1;
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
            this.gridColumn1.Caption = "ဆေးမှတ်တမ်း ရက်စွဲများ";
            this.gridColumn1.FieldName = "record";
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
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 10F);
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(6, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(204, 39);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "ဆေးမှတ်တမ်း အသစ်သွင်းရန်";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // imageFile
            // 
            this.imageFile.FileName = "openFileDialog1";
            this.imageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.imageFile_FileOk);
            // 
            // frmPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 607);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "လူနာ အချက်အလက်";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatienList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatienList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtBirthDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNRCNo;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtBookNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.GridControl gridControlPatienList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPatienList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog imageFile;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}