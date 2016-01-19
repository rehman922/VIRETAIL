using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL;
using VIRETAILENTITIES;

namespace Store
{
    public partial class ItemGroup : XtraForm
    {
        public ItemGroup()
        {
            InitializeComponent();
        }

        private void ItemGroup_Load(object sender, EventArgs e)
        {
            var proxy = new DataManager();
            proxy.GetItemGroup();
            dsMaster.Merge(proxy.GetItemGroup());
        }

        private void iTEMGROUPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            iTEMGROUPBindingSource.EndEdit();
             
            var proxy = new DataManager();
            var changes = (DsMaster)dsMaster.GetChanges();
            
            //NorthwindEntities.OrdersDataSet changes = (NorthwindEntities.OrdersDataSet)this.ordersDataSet.GetChanges();
            if (changes != null)
            {
                if (proxy.SaveItemGroup(changes))
                {
                    var addedRows = from row in dsMaster.CATEGORY
                                    where row.RowState == DataRowState.Added
                                    select row;

                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    dsMaster.Merge(changes);
                    dsMaster.AcceptChanges();
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not saved");
                }
            }
        }
    }
}