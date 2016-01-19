using System;
using System.Collections;
using System.Drawing.Printing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

namespace Store.BusinessLogic
{
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "POS Barcode";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }
        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static void UniSendStringToPrinter(string szPrinterName, string szString)
        {

            IntPtr pBytes;



            // create a temp byte buffer

            byte[] encodedBytes = Encoding.Unicode.GetBytes(szString);



            // allocate some memory for the copy

            pBytes = Marshal.AllocCoTaskMem(encodedBytes.Length + 1);



            // copy the byte arry to the allocated memory

            Marshal.Copy(encodedBytes, 0, pBytes, encodedBytes.Length);



            // send to the printer method

            SendBytesToPrinter(szPrinterName, pBytes, encodedBytes.Length);



            // free the allocated memory

            Marshal.FreeCoTaskMem(pBytes);

        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
        public static void OpenCashDrawer(string cashdrawername)
        {
            byte[] codeOpenCashDrawer = { 27, 112, 48, 55, 121 };
            IntPtr pUnmanagedBytes = new IntPtr(0);
            pUnmanagedBytes = Marshal.AllocCoTaskMem(5);
            Marshal.Copy(codeOpenCashDrawer, 0, pUnmanagedBytes, 5);
            SendBytesToPrinter("cashdrawername", pUnmanagedBytes, 5);
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
        }
    }

    public static class MyDefaultPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
        public static string GetDefaultPrinter()
        {
            var settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = settings.IsDefaultPrinter ? printer : null;
            }
            return settings.PrinterName;
        }
        public static Hashtable GetPrinterProperties()
        {
            Hashtable properties = new Hashtable();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            //now loop thorugh all the objects in the searcher
            foreach (ManagementObject obj in searcher.Get())
            {
                string[] printerStatus = { "Other", "Unknown", "Idle", "Printing", "WarmUp", "Stopped Printing", "Offline" };
                string[] printerState = {"Paused","Error","Pending Deletion","Paper Jam","Paper Out","Manual Feed","Paper Problem", "Offline","IO Active","Busy","Printing",
            "Output Bin Full","Not Available","Waiting", "Processing","Initialization","Warming Up","Toner Low","No Toner","Page Punt", "User Intervention Required",
            "Out of Memory","Door Open","Server_Unknown","Power Save"};
                //now loop through all the properties
                foreach (PropertyData data in obj.Properties)
                {
                    //make sure we have the default printer
                    if ((bool)obj["Default"])
                    {
                        switch (data.Name.ToLower())
                        {
                            case "printerstate":
                                properties.Add("State", printerState[Convert.ToInt32(data.Value)]);
                                break;
                            case "printerstatus":
                                properties.Add("Status", printerStatus[Convert.ToInt32(data.Value)]);
                                break;
                        }
                    }
                }
              
            }
            return properties;
        }


    }

}
 
