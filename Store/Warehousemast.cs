using System;
using System.Windows.Forms;

namespace Store
{
    public partial class Warehousemast : Form
    {
        public Warehousemast()
        {
            InitializeComponent();
        }

        private void wAREHOUSEMASTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            wAREHOUSEMASTBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dsMaster1);

        }

        private void Warehousemast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.WAREHOUSEMAST' table. You can move, or remove it, as needed.
            warehousemastTableAdapter.Fill(dsMaster1.WAREHOUSEMAST);

        }
    }
}
