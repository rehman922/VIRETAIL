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
    public partial class Terms : DevExpress.XtraEditors.XtraForm
    {
        
        public Terms()
        {
            InitializeComponent();
        }
        private void Terms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPOSSTORE.PAYTYPEMAST' table. You can move, or remove it, as needed.
            this.pAYTYPEMASTTableAdapter.Fill(this.dSPOSSTORE.PAYTYPEMAST);
            this.pAYMENTONMASTTableAdapter.Fill(this.dSPOSSTORE.PAYMENTONMAST);
          //this.tERMSDETAILMASTTableAdapter.Fill(this.dSPOSSTORE.TERMSDETAILMAST);
            var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
            t.Fill(this.dSPOSSTORE.TERMSMAST);
            //this.posMenu1.DataSource = this.dSPOSSTORE;
            //this.posMenu1.DataMember ="TERMSMAST";
            
            this.tERMSDETAILMASTTableAdapter.FillBy(this.dSPOSSTORE.TERMSDETAILMAST,string.Empty);
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
                this.tERMSDETAILMASTTableAdapter.FillBy(this.dSPOSSTORE.TERMSDETAILMAST, textBox1.Text);
                t.FillBy(this.dSPOSSTORE.TERMSMAST, textBox1.Text);
                if (this.dSPOSSTORE.TERMSMAST.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Duplicate code found");
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
        private void posMenu1_Load(object sender, EventArgs e)
        {}
        private void posMenu1_Click(object sender, EventArgs e)
        {}
       private void posMenu1_ToolbarClick(object sender, EventArgs e)
        {
            //if (posMenu1.ToolClicked.ToString()=="New")
            //{
            //    DoNew();
            //}
            //if (posMenu1.ToolClicked.ToString() == "Save")
            //{
            //    DoSave();
            //}
            //if (posMenu1.ToolClicked.ToString() == "Delete")
            //{
            //    DoDelete();
            //}
        }
        void DoDelete()
        {
            //*********** Note Check in Supplier terms table that this terms is used or not
            //*********** Note If used in supplier terms then dont delete
            if (XtraMessageBox.Show("Do you want to delete this record", "Admin", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int deleteQuery = this.tERMSDETAILMASTTableAdapter.DeleteQuery(textBox1.Text);
                var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
                t.Delete(textBox1.Text, textBox2.Text);
            }
        }
        void DoNew()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
            t.Fill(this.dSPOSSTORE.TERMSMAST); 
            this.tERMSDETAILMASTTableAdapter.FillBy(this.dSPOSSTORE.TERMSDETAILMAST,string.Empty);
        }
        void DoSave()
        {
            foreach (DataRow d in dSPOSSTORE.TERMSDETAILMAST.Rows)
            {
                d[1] = textBox1.Text;
            }
            if (textBox1.Tag.ToString() == "0")
            {
                var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
                t.Insert(textBox1.Text, textBox2.Text);
                this.tERMSDETAILMASTTableAdapter.Update(this.dSPOSSTORE.TERMSDETAILMAST);
            }
            else
            {
                var t = new DSPOSSTORETableAdapters.TERMSMASTTableAdapter();
                t.Update(textBox2.Text, textBox1.Text, textBox2.Text);
                this.tERMSDETAILMASTTableAdapter.Update(this.dSPOSSTORE.TERMSDETAILMAST);
            }
        }

        private void c1TrueDBGrid1_BeforeUpdate(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
      
            c1TrueDBGrid1.Columns[1].Value = textBox1.Text;
        }

        private void c1TrueDBGrid1_BeforeColUpdate(object sender, C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs e)
        {
            
        }

        private void posMenu1_NavigatorMoveFirstClick(object sender, EventArgs e)
        {
            MoveRecord();
        }
        private void posMenu1_NavigatorMoveLastClick(object sender, EventArgs e)
        {
            MoveRecord();
        }

        private void posMenu1_NavigatorMoveNextClick(object sender, EventArgs e)
        {

            MoveRecord();
        }

        private void posMenu1_NavigatorMovePreviousClick(object sender, EventArgs e)
        {
            MoveRecord();
        }

        private void MoveRecord()
        {
            //textBox1.Text = this.dSPOSSTORE.TERMSMAST.Rows[posMenu1.NavigatorPosition]["TERMCODE"].ToString();
            //textBox2.Text = this.dSPOSSTORE.TERMSMAST.Rows[posMenu1.NavigatorPosition]["PAYNAME"].ToString();
            this.tERMSDETAILMASTTableAdapter.FillBy(this.dSPOSSTORE.TERMSDETAILMAST, textBox1.Text);
  
        }

    }
}