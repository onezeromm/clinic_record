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
    public partial class frmRecord : Form
    {
        string filePath = "";
        bool isUpdate = false;

        public frmRecord()
        {
            InitializeComponent();
            dtDate.DateTime = DateTime.Now;
        }

        public frmRecord(string filePath, bool isUpdate)
            : this()
        {
            this.isUpdate = isUpdate;
            this.filePath = filePath;

            if (isUpdate)
            {
                String[] data = File.ReadAllLines(filePath);
                dtDate.DateTime = Convert.ToDateTime(data[0]);
                txtDescription.Text = data[1];
                txtOrderedMedicine.Text = data[2];
                txtRemark.Text = data[3];
                txtSpecialCase.Text = data[4];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                if (!File.Exists(filePath + "\\" + dtDate.DateTime.ToString("yyyy.MM.dd")))
                {
                    File.WriteAllLines(filePath + "\\" + dtDate.DateTime.ToString("yyyy.MM.dd"), new string[] { dtDate.DateTime.ToString("yyyy-MM-dd"),
                txtDescription.Text.Trim(), txtOrderedMedicine.Text.Trim(), txtRemark.Text.Trim(), txtSpecialCase.Text.Trim()});

                    if (MessageBox.Show("သိမ်းဆည်းပြီးပါပြီ။", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ယနေ့ရက်စွဲဖြင့် သိမ်းဆည်းပြီးသား ရှိနေပါသည်။", "Same date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                File.Delete(filePath);

                File.WriteAllLines(filePath, new string[] { dtDate.DateTime.ToString("yyyy-MM-dd"),
                txtDescription.Text.Trim(), txtOrderedMedicine.Text.Trim(), txtRemark.Text.Trim(), txtSpecialCase.Text.Trim()});
                
                if (MessageBox.Show("သိမ်းဆည်းပြီးပါပြီ။", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    this.Close();
                }
            }


        }
    }
}
