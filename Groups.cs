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
    public partial class Groups : DevExpress.XtraEditors.XtraForm
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void cUSTSUPGROUPSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTSUPGROUPSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPOSSTORE.GROUPTYPEMAST' table. You can move, or remove it, as needed.
            this.gROUPTYPEMASTTableAdapter.Fill(this.dSPOSSTORE.GROUPTYPEMAST);
            // TODO: This line of code loads data into the 'dSPOSSTORE.CUSTSUPGROUPS' table. You can move, or remove it, as needed.
            this.cUSTSUPGROUPSTableAdapter.Fill(this.dSPOSSTORE.CUSTSUPGROUPS);
            // TODO: This line of code loads data into the 'dSPOSSTORE.GROUPTYPEMAST' table. You can move, or remove it, as needed.
            this.gROUPTYPEMASTTableAdapter.Fill(this.dSPOSSTORE.GROUPTYPEMAST);
            // TODO: This line of code loads data into the 'dSPOSSTORE.CUSTSUPGROUPS' table. You can move, or remove it, as needed.
            this.cUSTSUPGROUPSTableAdapter.Fill(this.dSPOSSTORE.CUSTSUPGROUPS);
            // TODO: This line of code loads data into the 'dSPOSSTORE.CUSTSUPGROUPS' table. You can move, or remove it, as needed.
            this.cUSTSUPGROUPSTableAdapter.Fill(this.dSPOSSTORE.CUSTSUPGROUPS);
            // TODO: This line of code loads data into the 'dSPOSSTORE.GROUPTYPEMAST' table. You can move, or remove it, as needed.
            this.gROUPTYPEMASTTableAdapter.Fill(this.dSPOSSTORE.GROUPTYPEMAST);
            // TODO: This line of code loads data into the 'dSPOSSTORE.CUSTSUPGROUPS' table. You can move, or remove it, as needed.
            this.cUSTSUPGROUPSTableAdapter.Fill(this.dSPOSSTORE.CUSTSUPGROUPS);
        }

        private void cUSTSUPGROUPSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTSUPGROUPSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void cUSTSUPGROUPSBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTSUPGROUPSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void cUSTSUPGROUPSBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTSUPGROUPSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }
    }
}