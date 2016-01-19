using System;
using System.IO.Ports;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;

namespace Store
{
    public partial class CustomerDisplaySetup : Form
    {
        private SerialPort ComPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);

        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);




        public CustomerDisplaySetup()
        {
            InitializeComponent();
         ////   SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
         //   ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

//Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);


            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
//Baud Rate
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[4].ToString();
//Data Bits
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[1].ToString();

//Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();
//Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");
            //get the first item print in the text
            cboParity.Text = cboParity.Items[0].ToString();
//Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString();

        }
       

        private void btnPortState_Click(object sender, EventArgs e)
        {

            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPort.StopBits = (StopBits) Enum.Parse(typeof (StopBits), cboStopBits.Text);
                ComPort.Handshake = (Handshake) Enum.Parse(typeof (Handshake), cboHandShaking.Text);
                ComPort.Parity = (Parity) Enum.Parse(typeof (Parity), cboParity.Text);
                ComPort.Open();
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                ComPort.Close();

            }
        }

   

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (!ComPort.IsOpen)
                ComPort.Open();
            ComPort.Write("Hello World!");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ClsGetData.CheckSysCode("POLE");
            string peram =  cboPorts.Text + "," + cboBaudRate.Text + "," + cboDataBits.Text + ",";
            peram += cboStopBits.Text + "," + cboHandShaking.Text + "," +  cboParity.Text;
            ClsGetData.UpdateSysCode(peram, "POLE");
            XtraMessageBox.Show("Setting Saved", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomerDisplaySetup_Load(object sender, EventArgs e)
        {

        }

       
    }
}

         
