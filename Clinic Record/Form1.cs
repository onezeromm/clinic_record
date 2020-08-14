using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] st = File.ReadAllLines("info");
            if (st.Length == 0)
            {
                string dataPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Data";
                if (!File.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                    File.WriteAllLines(@"info", new string[] { dataPath });
                    linkPath.Text = dataPath;
                    clsGlobal.dataPath = linkPath.Text;
                }
            }
            else
            {
                clsGlobal.dataPath = st[0];
                linkPath.Text = clsGlobal.dataPath;
            }
            loadPatients();
        }

        private void loadPatients()
        {
            String[] patients = Directory.GetDirectories(clsGlobal.dataPath);
            List<String> patientNameOnly = new List<string>();
            List<char> patientNameOnlyTemp = new List<char>();

            foreach (string s in patients)
            {
                patientNameOnlyTemp = new List<char>();

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != '\\')
                    {
                        patientNameOnlyTemp.Add(s[i]);
                    }
                    else
                    {
                        break;
                    }
                }
                patientNameOnlyTemp.Reverse();
                string name = "";
                foreach (char n in patientNameOnlyTemp)
                {
                    name += n;
                }
                patientNameOnly.Add(name);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("patient_name");
            dt.Columns.Add("filePath");
            DataRow row;

            for (int i = 0; i < patients.Length; i++)
            {
                row = dt.NewRow();
                row["patient_name"] = patientNameOnly[i];
                row["filePath"] = patients[i];
                dt.Rows.Add(row);
            }

            gridControlPatienList.DataSource = dt;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

            new frmPatientInfo(false, row["filePath"].ToString()).ShowDialog();
            loadPatients();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void linkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string dataPath = folderBrowser.SelectedPath + "\\ဆေးခန်းမှတ်တမ်း";
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                    File.WriteAllLines(@"info", new string[] { dataPath });
                    linkPath.Text = dataPath;
                    clsGlobal.dataPath = dataPath;
                }
                else
                {
                    File.WriteAllLines(@"info", new string[] { dataPath });
                    linkPath.Text = dataPath;
                    clsGlobal.dataPath = dataPath;
                }
            }

            loadPatients();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new frmPatientInfo(true, "").ShowDialog();
            loadPatients();
        }

        private void gridViewPatienList_KeyDown(object sender, KeyEventArgs e)
        {
            GridView gView = gridControlPatienList.MainView as GridView;
            DataRow row = gView.GetDataRow(gView.FocusedRowHandle);

            if (e.KeyCode.Equals(Keys.Delete))
            {
                if (MessageBox.Show("ဖျက်ရန်သေချာပါသလား။", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Directory.Delete(row["filePath"].ToString(), true);
                    loadPatients();
                }
            }
        }
    }
}
