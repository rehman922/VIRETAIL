using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VIRETAILSTORE
{
    public partial class Shipping : DevExpress.XtraEditors.XtraForm
    {
        public Shipping()
        {
            InitializeComponent();
        }

        private void sHIPPINGMASTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sHIPPINGMASTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPOSSTORE.SHIPPINGMAST' table. You can move, or remove it, as needed.
            this.sHIPPINGMASTTableAdapter.Fill(this.dSPOSSTORE.SHIPPINGMAST);

        }
    }
}