using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VIRETAILDAL.COMMON
{
    public sealed class SqlAsyncConnectionString
    {
        private readonly string _connectionString;

        /// <summary>
        /// Creates a connection string prepared for enabling asynchronous processing with an optional connection timeout.
        /// </summary>
        /// <param name="connectionString">The initial connection string to modify.</param>
        /// <param name="connectTimeout">Time to wait for a connection to open (in seconds). Default is 5.</param>
        public SqlAsyncConnectionString([Optional] int? connectTimeout,bool tomain=false)
        {
            // Make sure asynchronous processing is enabled for the connection string:
            var csb = new SqlConnectionStringBuilder();
            if (tomain)
            {
                csb.DataSource = Utils.StaticIp;  // "78.93.190.90";
                csb.InitialCatalog = "SYNC";
            }
            else
            {
                csb.DataSource = Utils.StaticIp;  // "78.93.190.90";
                csb.InitialCatalog = "POS";
            }
            csb.UserID = "sa";
            csb.Password = "mutawa2011";
            
            csb.NetworkLibrary = "DBMSSOCN";

            csb.IntegratedSecurity = false;
           
            csb.AsynchronousProcessing = true;
            csb.ConnectTimeout = connectTimeout ?? 5;

            csb.ConnectTimeout = 40;

            _connectionString = csb.ConnectionString;
        }
        /// <summary>
        /// Creates a connection string prepared for enabling asynchronous processing with a default connection timeout of 5 seconds.
        /// </summary>
        /// <param name="connectionString">The initial connection string to modify.</param>
        public static implicit operator string(SqlAsyncConnectionString cstr)
        {
            return cstr._connectionString;
        }

    }
}
