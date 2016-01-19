using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.Masters;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    
    public partial class SetPrinterSettings : XtraForm
    {
        private  int tid;
        public SetPrinterSettings()
        {
            InitializeComponent();
        }
        private void PrinterSettings_Load(object sender, EventArgs e)
        {
            LoadPrinter(comboBoxEdit1);
            LoadPrinter(comboBoxEdit2);
            LoadPrinter(comboBoxEdit3);
            LoadPrinter(comboBoxEdit4);
            var ds = ClsGetData.GetPrinters();
            foreach (DataRow dr in ds.Rows)
            {
                tid = int.Parse(dr["TID"].ToString());
                comboBoxEdit1.SelectedText = dr["BarcodePrinter"].ToString();
                comboBoxEdit2.SelectedText = dr["InvoicePrinter"].ToString();
                comboBoxEdit3.SelectedText = dr["DrugPrinter"].ToString();
                comboBoxEdit4.SelectedText = dr["DefaultPrinter"].ToString();
                if (!string.IsNullOrEmpty(dr["ISDEFAULT"].ToString()))
                    checkBox1.Checked = Boolean.Parse(dr["ISDEFAULT"].ToString()); 
            }
        }
        private void LoadPrinter(ComboBoxEdit cmb)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmb.Properties.Items.Add(printer);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var newrow =(DsMaster.PRINTERSRow) new DsMaster().PRINTERS.NewRow();
                newrow.TID = tid;
                if(comboBoxEdit1.SelectedIndex < 0 &&  comboBoxEdit2.SelectedIndex < 0 )
                {
                    XtraMessageBox.Show("Nothing to save", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                newrow.BarcodePrinter = !string.IsNullOrEmpty(comboBoxEdit1.Text) ? comboBoxEdit1.Text: String.Empty;
                newrow.Invoiceprinter = !string.IsNullOrEmpty(comboBoxEdit2.Text) ? comboBoxEdit2.Text : String.Empty;

                newrow.Drugprinter = !string.IsNullOrEmpty(comboBoxEdit3.Text) ? comboBoxEdit3.Text : String.Empty; ;
                newrow.Defaultprinter = !string.IsNullOrEmpty(comboBoxEdit4.Text) ? comboBoxEdit4.Text : String.Empty; ;
                newrow.Computer = Environment.MachineName;
                newrow.ISDEFAULT = checkBox1.Checked;
                var ret = new DefaultPrinters().DoSave(newrow);
                if(ret=="1")
                {
                    XtraMessageBox.Show("Data Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.DefaultPrinterRow = newrow;
                }
                else
                {
                    XtraMessageBox.Show(ret, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
              XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}