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
    public partial class Frmcurrency : DevExpress.XtraEditors.XtraForm
    {
        public Frmcurrency()
        {
            InitializeComponent();
        }

        private void cOMPANYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);
        }

        private void Frmcurrency_Load(object sender, EventArgs e)
        {
          // TODO: This line of code loads data into the 'dSPOSSTORE.CURRENCYNAMES' table. You can move, or remove it, as needed.
            this.cURRENCYNAMESTableAdapter.Fill(this.dSPOSSTORE.CURRENCYNAMES);
         // TODO: This line of code loads data into the 'dSPOSSTORE.COMPANY' table. You can move, or remove it, as needed.
           // bindingNavigatorAddNewItem.PerformClick();
           // bindingNavigatorAddNewItem.Enabled = false;
            //    bindingNavigatorMovePreviousItem.Enabled = false;
            //   bindingNavigatorMoveFirstItem.Enabled = false;

        }
        private void cURRENCYNAMESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cURRENCYNAMESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);
           // bindingNavigatorAddNewItem.Enabled = true;
        }

        private void cURRENCYNAMESBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cURRENCYNAMESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void cURRENCYNAMESBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cURRENCYNAMESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void cURRENCYNAMESBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.cURRENCYNAMESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPOSSTORE);

        }

        private void Frmcurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject data = Clipboard.GetDataObject();
                foreach (var item in data.GetFormats(true))
                {
                    object o = data.GetData(item);
                    // do something with o

                }
                // Console.WriteLine(data.GetFormats(true));
            }
        }
    }
}
