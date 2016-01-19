using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL;
using VIRETAILENTITIES;

namespace Store
{
    public partial class UOMMAST : XtraForm
    {
        public UOMMAST()
        {
            InitializeComponent();
        }

        private void uOMMASTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            uOMMASTBindingSource.EndEdit();

            // NorthwindService.ServiceClient proxy = new NorthwindClient.NorthwindService.ServiceClient();
            var proxy = new DataManager();
            DsMaster changes = (DsMaster)dsMaster.GetChanges();
            //NorthwindEntities.OrdersDataSet changes = (NorthwindEntities.OrdersDataSet)this.ordersDataSet.GetChanges();
            if (changes != null)
            {
                if (proxy.SaveUom(changes))
                {
                    var addedRows = from row in dsMaster.UOMMAST
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

        private void UOMMAST_Load(object sender, EventArgs e)
        {
            var proxy = new DataManager();
            proxy.GetUom();
            dsMaster.Merge(proxy.GetUom());
        }
    }
}