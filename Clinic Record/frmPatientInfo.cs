using DevExpress.XtraGrid.Views.Grid;
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

namespace Clinic_Record
{
    public partial class frmPatientInfo : Form
    {
        bool isNew = false;
        string filePath = "";

        public frmPatientInfo()
        {
            InitializeComponent();
            this.dtBirthDate.DateTime = DateTime.Now;
        }

        public frmPatientInfo(bool isNew, string filePath)
            : this()
        {
            this.isNew = isNew;

            if (isNew)
            {
                tabControl1.TabPages.RemoveAt(1);
            }
            else
            {
                this.filePath = filePath;

                String[] data = File.ReadAllLines(filePath + "\\detail");
                txtBookNo.Text = data[0];
                txtName.Text = data[1];
                txtFatherName.Text = data[2];
                txtNRCNo.Text = data[3];
                dtBirthDate.DateTime = Convert.ToDateTime(data[4]);
                txtAddress.Text = data[5];
                txtRemark.Text = data[6];
                try
                {
                    pic.ImageLocation = data[7];
                }
                catch
                {
                }
                loadCures();
            }
        }

        private void loadCures()
        {
            if (Directory.Exists(filePath + "\\cureRecords"))
            {
                DirectoryInfo info = new DirectoryInfo(filePath + "\\cureRecords");

                List<String> dateOnly = new List<string>();
                List<String> dateWithPath = new List<string>();

                dateWithPath = info.GetFiles().Select(fi => fi.FullName).ToList();
                dateOnly = info.GetFiles().Select(fi => fi.Name).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("record");
                dt.Columns.Add("filePath");
                DataRow row;

                for (int i = 0; i < dateOnly.Count; i++)
                {
                    row = dt.NewRow();
                    row["record"] = dateOnly[i];
                    row["filePath"] = dateWithPath[i];
                    dt.Rows.Add(row);
                }

                gridControlPatienList.DataSource = dt;
            }
            else
            {
                Directory.CreateDirectory(filePath + "\\cureRecords");
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            imageFile.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dataPath = clsGlobal.dataPath + "\\" + txtName.Text.Trim();
            if (isNew)
            {
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);

                    File.WriteAllLines(dataPath + "\\detail", new string[] { txtBookNo.Text.Trim(),
                    txtName.Text.Trim(),txtFatherName.Text.Trim(), txtNRCNo.Text.Trim(),
                    dtBirthDate.DateTime.ToString(), txtAddress.Text.Trim(), txtRemark.Text.Trim(), pic.ImageLocation });
                    if (MessageBox.Show("သိမ်းဆည်းပြီးပါပြီ။", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("နာမည်တူ တစ်ယောက်ရှိနေပါသည်။", "Same name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                File.Delete(dataPath + "\\detail");

                File.WriteAllLines(dataPath + "\\detail", new string[] { txtBookNo.Text.Trim(),
                        txtName.Text.Trim(),txtFatherName.Text.Trim(), txtNRCNo.Text.Trim(),
                        dtBirthDate.DateTime.ToString(), txtAddress.Text.Trim(), txtRemark.Text.Trim(), pic.ImageLocation });

                if (MessageBox.Show("သိမ်းဆည်းပြီးပါပြီ။", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    this.Close();
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewPatienList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridViewPatienList_DoubleClick(object sender, EventArgs e)
        {
            GridView gView = gridControlPatienList.MainView as GridView;
            DataRow row = gView.GetDataRow(gView.FocusedRowHandle);

            new frmRecord(row["filePath"].ToString(), true).ShowDialog();
            loadCures();
        }

        private void dtBirthDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int birthYear = dtBirthDate.DateTime.Year;
                int currentYear = DateTime.Now.Year;

                int age = currentYear - birthYear;
                lblBirthDate.Text = age.ToString() + " နှစ်";
            }
            catch
            {
                MessageBox.Show("အချက်အလက်မှားယွင်းနေပါသည်။", "သိပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmRecord(filePath + "\\cureRecords", false).ShowDialog();
            loadCures();
        }

        private void imageFile_FileOk(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(imageFile.FileName))
            {
                pic.ImageLocation = imageFile.FileName;
            }
        }

        private void gridViewPatienList_KeyDown(object sender, KeyEventArgs e)
        {
            GridView gView = gridControlPatienList.MainView as GridView;
            DataRow row = gView.GetDataRow(gView.FocusedRowHandle);

            if (e.KeyCode.Equals(Keys.Delete))
            {
                if (MessageBox.Show("ဖျက်ရန်သေချာပါသလား။", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    File.Delete(row["filePath"].ToString());
                    loadCures();
                }
            }
        }
    }
}
