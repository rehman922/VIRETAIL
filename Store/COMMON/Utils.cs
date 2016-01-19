using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace Store.COMMON
{
    public static class Utils
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out MPOINT lpPoint);
        public static class MyPrinters
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);

        }
        public static Point GetCursorPosition()
        {
            MPOINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct MPOINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(MPOINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        public static byte[] GenerateSALT()
        {
            byte[] data = new byte[6];
            new RNGCryptoServiceProvider().GetBytes(data);
            return data;
        }
        public static string ComputeHash(string plainText, string hashAlgorithm,byte[] saltBytes)
            {
            // If salt is not specified, generate it.
            if (saltBytes == null)
            {
            // Define min and max salt sizes.
            int minSaltSize = 4;
            int maxSaltSize = 8;

            // Generate a random number for the size of the salt.
            Random random = new Random();
            int saltSize = random.Next(minSaltSize, maxSaltSize);

            // Allocate a byte array, which will hold the salt.
            saltBytes = new byte[saltSize];

            // Initialize a random number generator.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Fill the salt with cryptographically strong byte values.
            rng.GetNonZeroBytes(saltBytes);
            }

            // Convert plain text into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // Allocate array, which will hold plain text and salt.
            byte[] plainTextWithSaltBytes =
            new byte[plainTextBytes.Length + saltBytes.Length];

            // Copy plain text bytes into resulting array.
            for (int i=0; i < plainTextBytes.Length; i++)
            plainTextWithSaltBytes[i] = plainTextBytes[i];

            // Append salt bytes to the resulting array.
            for (int i=0; i < saltBytes.Length; i++)
            plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];

            HashAlgorithm hash;

            // Make sure hashing algorithm name is specified.
            if (hashAlgorithm == null)
            hashAlgorithm = "";

            // Initialize appropriate hashing algorithm class.
            switch (hashAlgorithm.ToUpper())
            {

            case "SHA384":
            hash = new SHA384Managed();
            break;

            case "SHA512":
            hash = new SHA512Managed();
            break;

            default:
            hash = new MD5CryptoServiceProvider();
            break;
            }

            // Compute hash value of our plain text with appended salt.
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Create array which will hold hash and original salt bytes.
            byte[] hashWithSaltBytes = new byte[hashBytes.Length +
            saltBytes.Length];

            // Copy hash bytes into resulting array.
            for (int i=0; i < hashBytes.Length; i++)
            hashWithSaltBytes[i] = hashBytes[i];

            // Append salt bytes to the result.
            for (int i=0; i < saltBytes.Length; i++)
            hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];

            // Convert result into a base64-encoded string.
            string hashValue = Convert.ToBase64String(hashWithSaltBytes);

            // Return the result.
            return hashValue;
            }
        public static bool VerifyHash(string plainText, string hashAlgorithm, string hashValue)
            {

            // Convert base64-encoded hash value into a byte array.
            byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

            // We must know size of hash (without salt).
            int hashSizeInBits, hashSizeInBytes;

            // Make sure that hashing algorithm name is specified.
            if (hashAlgorithm == null)
            hashAlgorithm = "";

            // Size of hash is based on the specified algorithm.
            switch (hashAlgorithm.ToUpper())
            {

            case "SHA384":
            hashSizeInBits = 384;
            break;

            case "SHA512":
            hashSizeInBits = 512;
            break;

            default: // Must be MD5
            hashSizeInBits = 128;
            break;
            }

            // Convert size of hash from bits to bytes.
            hashSizeInBytes = hashSizeInBits / 8;

            // Make sure that the specified hash value is long enough.
            if (hashWithSaltBytes.Length < hashSizeInBytes)
            return false;

            // Allocate array to hold original salt bytes retrieved from hash.
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            // Copy salt from the end of the hash to the new array.
            for (int i=0; i < saltBytes.Length; i++)
            saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];

            // Compute a new hash string.
            string expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes);

            // If the computed hash matches the specified hash,
            // the plain text value must be correct.
            return (hashValue == expectedHashString);
            }
        public static List<string> GetFiles()
        {
            string[] _files = { };
            List<string> files = new List<string>();
            List<string> drives = new List<string>(); //Environment.GetLogicalDrives();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady)
                {
                    drives.Add(d.Name);
                }
            }
            foreach (string strDrive in drives)
            {
                _files = Directory.GetFiles(strDrive, "*.pml");
                foreach (string f in _files)
                {
                    files.Add(f);
                }
            }
            return files;
        }
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetGetConnectedState(out int lpdwFlags, int dwReserved);
        [Flags]
        enum ConnectionStates
        {
            Modem = 0x1,
            LAN = 0x2,
            Proxy = 0x4,
            RasInstalled = 0x10,
            Offline = 0x20,
            Configured = 0x40
        }
        public static bool  checkconnection()
        {
                int flags;
                bool isConnected = false;
                try
                {
                  isConnected = InternetGetConnectedState(out flags, 0);
                } 
                catch (Exception err)
                {
                  //Console.WriteLine(err.Message);
                }
                //Console.WriteLine(string.Format("Is connected :{0} Flags:{1}", isConnected, flags));
            return isConnected;
        }

        public static bool PingServer()
        {
            bool retval = VIRETAILDAL.COMMON.Utils.Company == "00" || VIRETAILDAL.COMMON.Utils.Company == "01";
            //bool pingable = false;
            //Ping pinger = new Ping();

            //try
            //{
            //    PingReply reply = pinger.Send(VIRETAILDAL.COMMON.Utils.StaticIp);

            //    if (reply != null) pingable = reply.Status == IPStatus.Success;
            //}
            //catch (PingException)
            //{
            //    // Discard PingExceptions and return false;
            //}
            return retval; 
        }
        public static bool CheckInternetConnectivity()
        {
            bool success = true;
           //var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           // try
           // {
           //     IAsyncResult result = socket.BeginConnect(VIRETAILDAL.COMMON.Utils.StaticIp, 80, null, null );
           //     success = result.AsyncWaitHandle.WaitOne( 3000, true );
           //     if ( !success )
           //      {
           //           //  throw new ApplicationException("Failed to connect server.");
           //      }
           // }
           // finally
           // {
           //     socket.Close();
           // }
            return success;
        }
        public static List<USBDeviceInfo> GetUSBDevices()
        {
           List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

      ManagementObjectCollection collection;
      using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
        collection = searcher.Get();      

      foreach (var device in collection)
      {
        devices.Add(new USBDeviceInfo(
        (string)device.GetPropertyValue("DeviceID"),
        (string)device.GetPropertyValue("PNPDeviceID"),
        (string)device.GetPropertyValue("Description"),
        (string)device.GetPropertyValue("USBVersion"),
        (string)device.GetPropertyValue("Name") 
        ));
      }

      collection.Dispose();
      return devices;
    }

        public static string ReadandWritetoregistry(string keynames, string keyvalue,bool Isread=false)
        {
            string spath = "Software\\VIRETAIL\\USettings";
            string errss = "";
            string evalue = "";
            var regkeyAppRoot = Registry.CurrentUser.CreateSubKey(spath);
            try
            {
                if (Isread)
                {
                    if (regkeyAppRoot != null) regkeyAppRoot.GetValue(keynames).ToString();
                }
                else
                {
                    if (regkeyAppRoot != null) regkeyAppRoot.SetValue(keynames, keyvalue);
  
                }
                return evalue;
            }
            catch (Exception ex)
            {
                errss = ex.ToString();
                return "";
            }
            finally
            {
                if(regkeyAppRoot!=null)regkeyAppRoot.Close();
            }
        }

        

        }
        
    
    public class USBDeviceInfo
    {
    public USBDeviceInfo(string deviceID, string pnpDeviceID, string description,string usbversion,string systemname)
    {
      DeviceID = deviceID;
      PnpDeviceID = pnpDeviceID;
      Description = description;
      Usbversion = usbversion;
      Systemname = systemname;

    }
    public string DeviceID { get; private set; }
    public string PnpDeviceID { get; private set; }
    public string Description { get; private set; }
    public string Usbversion { get; private set; }
    public string Systemname { get; private set; }

    }

    public class CsvBulkCopyDataIntoSqlServer
    {
        private const int _batchsize = 10000;
        public string ReadCsvFile(string filename,string tblname,string macno)
        {
            string retval = string.Empty;
            try
            {
                using (var filered = new TextFieldParser(filename))
                {
                    filered.TextFieldType = FieldType.Delimited;
                    filered.Delimiters = new[] {","};
                    filered.HasFieldsEnclosedInQuotes = true;
                    var dt = new DataTable(tblname);
                    dt.Columns.Add("ITEMNO");
                    dt.Columns.Add("QTY");
                    dt.Columns.Add("MACNO");
                    int readed = 0;
                    using (var cn = new SqlConnection(VIRETAILDAL.COMMON.Utils.Connectionstring))
                    {
                        dt.Columns["MACNO"].DefaultValue = macno;
                        cn.Open();
                        var sqlbulkcopy = new SqlBulkCopy(cn)
                        {
                            DestinationTableName = tblname
                        };
                        sqlbulkcopy.ColumnMappings.Add("ITEMNO", "ITEMNO");
                        sqlbulkcopy.ColumnMappings.Add("QTY", "QTY");
                        sqlbulkcopy.ColumnMappings.Add("MACNO", "MACNO");
                        while (!filered.EndOfData)
                        {
                            dt.Rows.Add(filered.ReadFields());
                            readed++;
                            if (readed%_batchsize == 0)
                            {
                                BulkCopyToServer(sqlbulkcopy, cn, dt);
                            }
                        }
                        BulkCopyToServer(sqlbulkcopy, cn, dt);
                        cn.Close();
                    }
                }
                retval = "Imported";
            }
            catch (Exception ex)
            {
                retval = ex.ToString();
            }
            return retval;
        }
        void BulkCopyToServer(SqlBulkCopy sqlBulkCopy, SqlConnection cn, DataTable dt)
        {
            sqlBulkCopy.WriteToServer(dt);
            dt.Rows.Clear();
        }
    }
}
