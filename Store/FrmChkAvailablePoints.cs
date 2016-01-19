using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.BusinessLogic;

namespace Store
{
    public partial class FrmChkAvailablePoints : XtraForm
    {
        public string _custno;

        public string _customername
        {
            set { textEdit1.Text = value; }
        }

        public decimal _redmipoints = 0m;

        public FrmChkAvailablePoints()
        {
            InitializeComponent();
        }
        private void FrmChkAvailablePoints_Load(object sender, EventArgs e)
        {
        }
        public void GetCustomerPoints(string custno)
        {
            progressPanel1.Visible = true;

            var bl = new BlCustomer().GetAvailablePointsInServer(_custno);
            if (bl > 0)
            {
                txtactualpoints.EditValue = Math.Round(bl/100, 2);
            }
            else
            {
                txtactualpoints.EditValue = 0;
                simpleButton1.Enabled = false;
            }
            progressPanel1.Visible = false;
        }
        private void txtactualpoints_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to make re-dim", "Re-dim", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var bl = new BlCustomer();
                try
                {
                    _redmipoints = decimal.Parse(txtactualpoints.EditValue.ToString());
                    var _points = bl.GetAvailablePointsInServer(_custno);
                    progressPanel1.Visible = true;
                    if (_points > 0)
                    {
                        txtactualpoints.EditValue = Math.Round(_points/100, 2);
                    }
                    else
                    {
                        txtactualpoints.EditValue = 0;
                    }
                    if (_redmipoints != Math.Round(_points/100, 2))
                    {
                        XtraMessageBox.Show("Customer points has changed", "Re-dim", MessageBoxButtons.OK);
                    }
                    _redmipoints = decimal.Parse(txtactualpoints.EditValue.ToString());
                    bl.UpdateCustomrePointsInServer(_custno,-_points);
                    Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error checking the available points try again", "Re-dim", MessageBoxButtons.OK);
                    _redmipoints = 0;
                    progressPanel1.Visible = false;
                }
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}