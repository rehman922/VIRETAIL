using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using VIRETAILENTITIES;

namespace Store
{
    public partial class Terms : XtraForm
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var t = new VIRETAILDAL.Masters.Terms().GetTermMast(textBox1.Text);
                if(t.Rows.Count > 0)
                {
                    dsMaster1.Merge(new VIRETAILDAL.Masters.Terms().GetTerms(textBox1.Text));
                    XtraMessageBox.Show("Duplicate code found","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox1.Tag = 1;
                    textBox1.Enabled = true;
                    e.Cancel = false;
                }
                else
                {
                    textBox1.Tag = 0;
                }
            }
        }

        private void Terms_Load(object sender, EventArgs e)
        {
            pAYMENTONMASTBindingSource.DataSource = new VIRETAILDAL.Masters.Terms().GetPayMentonMast();
            pAYTYPEMASTBindingSource.DataSource = new VIRETAILDAL.Masters.Terms().GetPayTypeMast();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (DataRow d in dsMaster1.TERMSDETAILMAST.Rows)
            {
                d[1] = textBox1.Text;
            }
            var t = new VIRETAILDAL.Masters.Terms().DoSave(textBox1.Text, textBox1.Text, dsMaster1.TERMSDETAILMAST);
            var changes = (DsMaster.TERMSDETAILMASTDataTable)dsMaster1.TERMSDETAILMAST.GetChanges(DataRowState.Modified | DataRowState.Added);
            if(t=="1")
            {
              var addedRows = from row in dsMaster1.TERMSDETAILMAST
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    if (changes != null) dsMaster1.Merge(changes);
                    dsMaster1.AcceptChanges(); 
                }
                else
                {
                    XtraMessageBox.Show(t, "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}