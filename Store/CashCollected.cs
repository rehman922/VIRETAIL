using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Store
{
    public partial class CashCollected : XtraForm
    {
        public int paytype1 {get; set;}
        bool FirtButtonclick;
        private int cardtype = 0;
        public bool issucess;
        public bool Negativeamt;
        public bool iscredit 
        {
            set
            {
              
               // if(btncredit.Visible==false)
                if(!value)
                {
                    button3.Top = btncredit.Top;
                    btncredit.Visible = false;
                }
                else
                {
                    btncredit.Top = button1.Top;
                    button3.Top = button2.Top;
                    button1.Visible = false;
                    button2.Visible = false;
                    btncredit.Visible = value;
                    btncredit.Focus();
                }
            }
        }
        public CashCollected()
        {
            InitializeComponent();
        }
        public decimal Netamount
        {
            set
            {
                if (value < 0)
                {
                    btncredit.Location = button2.Location;
                    button2.Visible = false;
                    Negativeamt = true;
                }
            }
        }
        private void CashCollected_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 | e.KeyCode == Keys.D1)
            {
                Key1();
            }
            if (e.KeyCode == Keys.NumPad2 | e.KeyCode == Keys.D2)
            {
                if (!Negativeamt)
                    Key2();
            }
            if (e.KeyCode == Keys.NumPad3 | e.KeyCode == Keys.D3)
            {
                    Key3();
            }
            if (e.KeyCode == Keys.NumPad4 | e.KeyCode == Keys.D4)
            {
                Key4();
            }
            if(e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Key1();
        }
        private void button2_Click(object sender, EventArgs e)
        {   Key2(); }
        private void btncredit_Click(object sender, EventArgs e)
        { Key3(); }
        private void button8_Click(object sender, EventArgs e)
        { Key4(); }
        void Key1()
        {
            if (FirtButtonclick)
            {
                paytype1 = 1;
                issucess = true;
                Close();
            }
            else
            {
                if (button1.Visible)
                {
                    paytype1 = 0;
                    issucess = true;
                    Close();
                }
            }
        }
        void Key2()
        {
            if (FirtButtonclick)
            {
                paytype1 = 2;
                issucess = true;
                Close();
            }
            else
            {
                if (button2.Visible)
                {
                    FirtButtonclick = true;
                    panelcards.Visible = true;
                    panelcards.BringToFront();
                    button5.Focus();
                }
            }
        }
        void Key3()
        {
            if (FirtButtonclick)
            {
                paytype1 = 2;
                issucess = true;
                Close();
            }
            else
            {
                if (btncredit.Visible)
                {
                    paytype1 = 3;
                    issucess = true;
                    Close();
                }
            }
        }
        void Key4()
        {
            if (FirtButtonclick)
            {
                paytype1 = 2;
                issucess = true;
                Close();
            }
            else
            {
                if (btncredit.Visible)
                {
                    paytype1 = 5;
                    issucess = true;
                    Close();
                }
                else
                {
                    paytype1 = 4;
                    issucess = true;
                    Close();
                }
            }

            }
        private void button3_Click(object sender, EventArgs e)
        {
            Key4();
        }
        }
  }
 