using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace VIRETAILSTORE
{
    public partial class FrmCompany : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompany()
        {
            InitializeComponent();
        }
        private void cURRENCYNAMESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {}
        private void FrmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPOSSTORE.CURRENCYNAMES' table. You can move, or remove it, as needed.
            this.cURRENCYNAMESTableAdapter.Fill(this.dSPOSSTORE.CURRENCYNAMES);
            // TODO: This line of code loads data into the 'dSPOSSTORE.BUSINESSTYPES' table. You can move, or remove it, as needed.
            this.bUSINESSTYPESTableAdapter.Fill(this.dSPOSSTORE.BUSINESSTYPES);
            // TODO: This line of code loads data into the 'dSPOSSTORE.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.dSPOSSTORE.COMPANY);
      // TODO: This line of code loads data into the 'dSPOSSTORE.CURRENCYNAMES' table. You can move, or remove it, as needed.
        }
        private void cOMPANYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);
        }
        private void cOMPANYBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);
        }
    }
}
