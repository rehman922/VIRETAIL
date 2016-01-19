using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL;
using VIRETAILENTITIES;

namespace Store
{
    public partial class ItemCategory : XtraForm
    {
        public ItemCategory()
        {InitializeComponent();}
        private void ItemCategory_Load(object sender, EventArgs e)
        {
            var proxy = new DataManager();
            proxy.GetCategory();
            dsMaster1.Merge(proxy.GetCategory());
        }
        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            cATEGORYBindingSource.EndEdit();
            var proxy = new DataManager();
            var changes = (DsMaster)dsMaster1.GetChanges();
            if (changes != null)
            {
               if(proxy.SaveCategory(changes))
                {
                    var addedRows = from row in dsMaster1.CATEGORY
                                    where row.RowState == DataRowState.Added
                                    select row;

                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    dsMaster1.Merge(changes);
                    dsMaster1.AcceptChanges();
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not saved");
                }
            }
        }

        private void cATEGORYBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
         //   cATEGORYBindingSource.AddNew();
        }
    }
}