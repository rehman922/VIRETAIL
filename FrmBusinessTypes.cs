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
    public partial class FrmBusinessTypes : DevExpress.XtraEditors.XtraForm
    {
        public FrmBusinessTypes()
        {
            InitializeComponent();
        }

        private void bUSINESSTYPESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bUSINESSTYPESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void FrmBusinessTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPOSSTORE.BUSINESSTYPES' table. You can move, or remove it, as needed.
            this.bUSINESSTYPESTableAdapter.Fill(this.dSPOSSTORE.BUSINESSTYPES);

        }
    }
}
