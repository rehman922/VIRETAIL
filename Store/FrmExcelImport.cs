using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace Store
{
    public partial class FrmExcelImport : Form
    {
        public FrmExcelImport()
        {
            InitializeComponent();
        }
        private string _filename;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
            _filename = openFileDialog1.FileName;
            ReadExcel();
        }
        void ReadExcel()
        {
            var _oleConn = new OleDbConnection(ExcelConnection());
           _oleConn.Open();
           var _oleCmdSelect = new OleDbCommand(@"SELECT * FROM Sheet1", _oleConn);
            var ta = new OleDbDataAdapter(_oleCmdSelect);
            var dt = new DataTable();
            ta.Fill(dt);
            gridControl1.DataSource = dt;

            // select * from [sheetname$[range]
        }
        private string ExcelConnection()
        {
            return
                @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=" + _filename + ";" +
                @"Extended Properties=" + Convert.ToChar(34).ToString() +
                @"Excel 8.0;" + "HDR=Yes" + Convert.ToChar(34).ToString();
            //Extended Properties='Excel 8.0;HDR=Yes
        }

    }
}
