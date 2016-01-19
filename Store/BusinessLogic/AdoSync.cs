using System;
using System.IO.Ports;
using System.Text;
using Store.COMMON;

namespace Store.BusinessLogic
{
    public class AdoSync
    {
        //First check the itemmaster , supplier in local data base 
        //if having zero rows use bulk copy
        //Get max BINID and store in local table
        //if having rows then select the morethan the BINID
      static SerialPort ComPort = new SerialPort();

      public string UpdateSettings(string perm)
        {
          return "1";
        }
      public void DisplayComm(string line1,string line2)
        {
            
            if (!ComPort.IsOpen)
            {
                SetUpComm();
            }
            else
            {
                ComPort.Write("\f");
                ComPort.Write("\v");
                ComPort.WriteLine(SpaceswithString(line1));
                ComPort.Write("\r");
                ComPort.WriteLine(SpaceswithString(line2, false));
            }
        }
      void SetUpComm()
        {
            var st = ClsGetData.GetSysCode("POLE");
            if (string.IsNullOrEmpty(st)) return;
            var stall = st.Split(',');
            if (stall.Length > 0)
            {
                ComPort.PortName = Convert.ToString(stall[0]);
                string[] ArrayComPortsNames = SerialPort.GetPortNames();
                bool comok = false;
                foreach (string cportname in ArrayComPortsNames)
                {
                    if (cportname == Convert.ToString(stall[0]))
                    {
                        comok = true;
                    }
                }
                if (!comok)
                {
                   // XtraMessageBox.Show("Customer display not setup Please check", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                ComPort.BaudRate = Convert.ToInt32(stall[1]);
                ComPort.DataBits = Convert.ToInt16(stall[2]);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stall[3]);
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), stall[4]);
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), stall[5]);

                if (ComPort.IsOpen)
                {
                    ComPort.Close();
                }

                ComPort.Open();
            }
        }
      string SpaceswithString(string iname, bool isleft = true)
        {
            var sb = new StringBuilder();
            if (isleft) sb.Append(iname);
           
              for (int i = 0; i < (20 - iname.Length); i++)
                    {
                           sb.Append(" ");
                    }   
            if (!isleft) sb.Append(iname);
            return sb.ToString().Length > 20 ? sb.ToString().Substring(1,20):sb.ToString();
        }

    }
}
