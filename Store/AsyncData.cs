using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class AsyncData : XtraForm
    {
        private delegate void DisplayInfoDelegate(string Text);
        private delegate void DisplayReaderDelegate(SqlDataReader reader);
        public DsInventory DsInventory { get; set; }
        private bool items;
        private bool supplier;
        private bool isExecuting;
        
        private SqlConnection connection;
        private SqlConnection connection1;
        public AsyncData()
        {
           InitializeComponent();
           Thread.Sleep(100);
           
        }
        private void AsyncData_Load(object sender, EventArgs e)
        {
            GetData(); 
        }
        void Additems(SqlDataReader reader)
        {
            try
            {
                   // this.Text = reader[1].ToString();
                    DsInventory.ITEMMAST1.Load(reader);
                 
              
                items = true;
               // supplier = true;
                if (supplier)
                {
                    isExecuting = false;
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void AddSupplier(SqlDataReader reader)
        {
             try
            {
                 
                     //this.Text = reader[1].ToString();
                     DsInventory.SUPPLIER.Load(reader); ;
                
                supplier = true;
                if (items)
                {
                isExecuting = false;
                Close();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
        }
        private void HandleCallback1(IAsyncResult result)
        {
            try
            {
                SqlCommand command = (SqlCommand)result.AsyncState;
                var reader = command.EndExecuteReader(result);
                var del = new DisplayReaderDelegate(AddSupplier);
                Invoke(del, reader);
            }
            catch (Exception ex)
            {
                Invoke(new DisplayInfoDelegate(DisplayStatus),
                            String.Format("Ready(last error: {0}", ex.Message));
            }

            finally
            {
                isExecuting = false;
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }
        private void HandleCallback(IAsyncResult result)
        {
            try
            {
                var command = (SqlCommand)result.AsyncState;
                var reader = command.EndExecuteReader(result);
                var del = new DisplayReaderDelegate(Additems);
                Invoke(del, reader);
            }
            catch (Exception ex)
            {
                Invoke(new DisplayInfoDelegate(DisplayStatus),ex.Message);
            }

            finally
            {
                isExecuting = false;
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }
        private void DisplayStatus(string Text)
        {
            progressPanel1.Description = Text;
        }
        private void AsyncData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExecuting)
            {
                progressPanel1.Text =
                    "Cannot close the form until the pending asynchronous command has completed. Please wait...";
                //MessageBox.Show(this, "Cannot close the form until " +
                //                      "the pending asynchronous command has completed. Please wait...");
                e.Cancel = true;
            }
        }
        private void AsyncData_Activated(object sender, EventArgs e)
        {
            

           
        }
        void GetData()
        {

            try
            {
                DisplayStatus("Connecting...");
                var constr = new SqlAsyncConnectionString();
                connection = new SqlConnection(constr);
                string commandText = " Select top 1 * from ITEMMAST order by 1 desc  ";

                var command = new SqlCommand(commandText, connection);
                connection.Open();

                DisplayStatus("Executing...");
                
                
                isExecuting = true;
                AsyncCallback callback = HandleCallback;
                command.BeginExecuteReader(callback, command);

               //  "WAITFOR DELAY '00:00:05';" + FOR XML raw ,  ELEMENTS XSINIL
                commandText = " SELECT top 1 * FROM supplier  ";
                connection1 = new SqlConnection(constr);
                connection1.Open();
                var command1 = new SqlCommand(commandText, connection1);
                AsyncCallback callback1 = HandleCallback1;

                command1.BeginExecuteReader(callback1, command1);

            }
            catch (Exception ex)
            {
                isExecuting = false;
                DisplayStatus(string.Format("Ready (last error:{0})", ex.Message));
                if (connection != null)
                {
                    connection.Close();
                }
                if (connection1 != null)
                {
                    connection1.Close();
                }
            }
        }
    }
}