using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIRETAILSTORE
{
    public partial class FrmImp : Form
    {
        public FrmImp()
        {
            InitializeComponent();
        }

        private string _filename = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
            _filename = openFileDialog1.FileName;
            gridControl1.DataSource = ReadExcelFile().Tables[0];
         }
        void ReadExcel()
        {
            var _oleConn = new OleDbConnection(ExcelConnection());
            _oleConn.Open();
            var _oleCmdSelect = new OleDbCommand("SELECT * FROM Sheet", _oleConn);
            OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
            oleAdapter.SelectCommand = _oleCmdSelect;
            DataTable dt = new DataTable("stock");
            oleAdapter.FillSchema(dt, SchemaType.Source);
            oleAdapter.Fill(dt);
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
        private DataSet ReadExcelFile()
        {
            DataSet ds = new DataSet();

            string connectionString = GetConnectionString();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Get all Sheets in Excel File
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                // Loop through all Sheets to get data
                foreach (DataRow dr in dtSheet.Rows)
                {
                    string sheetName = dr["TABLE_NAME"].ToString();

                    if (!sheetName.EndsWith("$"))
                        continue;

                    // Get all rows from the Sheet
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                    DataTable dt = new DataTable();
                    dt.TableName = sheetName;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);

                    ds.Tables.Add(dt);}

                cmd = null;
                conn.Close();
            }

            return ds;
        }
        private string GetConnectionString()
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            // XLSX - Excel 2007, 2010, 2012, 2013
            //props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            //props["Extended Properties"] = "Excel 12.0 XML";
            //props["Data Source"] = _filename;

            // XLS - Excel 2003 and Older
            props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            props["Extended Properties"] = "Excel 8.0";
            props["Data Source"] = _filename;

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }
        
    }
}
