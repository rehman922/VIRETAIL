using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Store.COMMON;

namespace Store
{
    public partial class SmartDevices : Form
    {
        public SmartDevices()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string[] _files = { };
            List<string> files = new List<string>();
            List<string> drives = new List<string>(); //Environment.GetLogicalDrives();
           // DriveInfo[] allDrives = DriveInfo.GetDrives();
            var allDrives = Utils.GetUSBDevices();

            foreach (var usbDevice in allDrives)
            {
                drives.Add(usbDevice.Systemname);
                //drives.Add(usbDevice.PnpDeviceID);
                //drives.Add(usbDevice.Description);
            }
            foreach (string strDrive in drives)
            {
                _files = Directory.GetFiles(strDrive, "*.sdf");
                foreach (string f in _files)
                {
                    files.Add(f);
                }
            }
            MessageBox.Show(files[0]);
      
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
