using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;

namespace Store
{
    public partial class Settings : XtraForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(maxdisc.Visible && maxdisc.EditValue==null)
            {
                XtraMessageBox.Show("Please enter the maximum discount allowed", "POS", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                return;
            }
            string peram = "";
            foreach (Control t in groupControl1.Controls)
            {
                if(t is CheckEdit)
                {
                    var m = t as CheckEdit;
                    peram += m.Checked ? 1 : 0;
                    peram += ",";
                }
            }
            if(maxdisc.EditValue!=null)
                peram += maxdisc.EditValue + ",";
            else
            {
                peram += "0" + ",";
            }
                peram += "-";
            if(radioGroup1.EditValue!=null)
                peram += radioGroup1.EditValue + ",";
            else
            { peram += 0 + ",";  }
            if(comboBoxEdit1.EditValue!=null)
              peram += comboBoxEdit1.SelectedIndex + ",";
            else
            { peram += 0 + "-"; }
            if(comboBoxEdit1.SelectedIndex==1)
            {
                peram += runevery.EditValue + ",";
            }
            else
            {
                peram += timeedit.EditValue;
            }
            ClsGetData.UpdateSysCode(peram, "PERM");
            XtraMessageBox.Show("Setting Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEdit1.SelectedIndex==2)
            {
                lblsttime.Visible = true;
                timeedit.Visible = true;
            }
            else
            {
                lblsttime.Visible = false;
                timeedit.Visible = false;
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.SelectedIndex = 0;
            var st = ClsGetData.GetSysCode("PERM");
            var mainstring = st.Split('-');
            var stall = mainstring[0].Split(',');
            var stal2= mainstring[1].Split('-');

            //foreach (var s in stall)
            //{
                int i = 0;
               //foreach (CheckEdit t in this.groupControl1.Controls)
                foreach (Control t in groupControl1.Controls)
                {
                    if (t is CheckEdit)
                    {
                        var m = t as CheckEdit;
                        m.Checked = stall[i] == "1";
                        i++;
                    }
                }
                maxdisc.EditValue = stall[stall.Length];
            //}
            if (stal2.Length > 0)
            {
                radioGroup1.EditValue = stal2[0];
                comboBoxEdit1.EditValue = stal2[1];
                runevery.EditValue = stal2[2];
                if (stal2.Length > 2)
                {
                    timeedit.EditValue = stal2[3];
                }
            }
        }
        private void radioGroup1_EditValueChanged(object sender, EventArgs e)
        {
            if(radioGroup1.EditValue.ToString() =="3")
            {
                lblfreq.Enabled = true;
                comboBoxEdit1.Properties.Enabled = true;
                lblrunevery.Enabled = true;
                runevery.Properties.Enabled = true;
            }
            else
            {
                lblfreq.Enabled = false;
                comboBoxEdit1.Properties.Enabled = false;
                lblrunevery.Enabled = false;
                runevery.Properties.Enabled = false;
                lblsttime.Visible = false;
                timeedit.Visible = false;
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            lblmaxdisc.Visible = c1.Checked;
            maxdisc.Visible = c1.Checked;
        }
    }
     
}