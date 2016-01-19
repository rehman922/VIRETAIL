using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace VIRETAILSTORE
{
    public partial class SplashScreen1 : SplashScreen
    {
        public int i = 0;
        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            SplashScreenCommand command = (SplashScreenCommand)cmd;
            if (command == SplashScreenCommand.SetProgress)
            {
               // int pos = (int)arg;
                labelControl2.Text = (string) arg;
                i=i+10;
                progressBarControl1.Position = i;
            }
        }

        #endregion


        public enum SplashScreenCommand
        {
            SetProgress,
            Command2,
            Command3
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}