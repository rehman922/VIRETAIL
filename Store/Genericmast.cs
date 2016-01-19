using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL;
using VIRETAILENTITIES;

namespace Store
{
    public partial class Genericmast : XtraForm
    {
        public Genericmast()
        {
            InitializeComponent();
        }

        private void gENERICMASTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           // this.Validate();
           // this.gENERICMASTBindingSource.EndEdit();
            
            
            
        }

        private void gENERICMASTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

            Validate();
            gENERICMASTBindingSource.EndEdit();

            // NorthwindService.ServiceClient proxy = new NorthwindClient.NorthwindService.ServiceClient();
            var proxy = new DataManager();
            var changes = (DsMaster)dsMaster.GetChanges();
            //NorthwindEntities.OrdersDataSet changes = (NorthwindEntities.OrdersDataSet)this.ordersDataSet.GetChanges();
            if (changes != null)
            {
                if (proxy.SaveItemGenric(changes))
                {
                    var addedRows = from row in dsMaster.GENERICMAST
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

        private void Genericmast_Load(object sender, EventArgs e)
        {
            var proxy = new DataManager();
            proxy.GetGeneric();
            dsMaster.Merge(proxy.GetGeneric());
        }
 
    }
}