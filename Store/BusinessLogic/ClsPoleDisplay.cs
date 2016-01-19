using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Store.BusinessLogic
{
    public class ClsPoleDisplay
    {
        SerialPort ComPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        public void SendData(string line1,string line2)
        {

            //ComPort.PortName = Convert.ToString();
            //ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
            //ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
            //ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
            //ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
            //ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
            //ComPort.Open();
        }
     }
}
