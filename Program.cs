using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using Microsoft.VisualBasic.ApplicationServices;
namespace VIRETAILSTORE
{
     class Program :WindowsFormsApplicationBase
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           // Mutex mutex = new System.Threading.Mutex(false, "MyUniqueMutexName");
            //try
            //{
            //    if (mutex.WaitOne(0, false))
            //    {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //DevExpress.UserSkins.BonusSkins.Register();
                     UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
                    DevExpress.Skins.SkinManager.EnableFormSkins();
                     LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
                   // DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Sharp";
                   // DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Sharp";
                   // UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");
                    // Application.ThreadException += new ThreadExceptionHandler().ApplicationThreadException;
                    if(!Properties.Settings.Default.useposdata)
                        VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.POSConnectionString;
                    else
                    {
                        VIRETAILDAL.COMMON.Utils.Connectionstring = Properties.Settings.Default.conmain;
                    }
            var app = new Program();
            app.Run(args);



            //    Application.Run(new FetchData());
            // Application.Run(new RetailSales());
            //    Application.Run(new Form1());
            //  Application.Run(new BarCodePrint());
            //  Application.Run(new MainMenu());
            // Application.Run(new Login());

            //    }
            //    else
            //    {
            //        MessageBox.Show("Duplicate Instance");
            //    }

            //}
            //finally
            //{
            //    if (mutex != null)
            //    {
            //        mutex.Close();
            //        mutex = null;
            //    }//}
        }
        public Program()
        {
            IsSingleInstance = true;
            EnableVisualStyles = true;
            MainForm = new FrmMainFromNew();// new Form1(); //
          //   MainForm = new FrmImp();// new Form1(); //
        }
        public class ThreadExceptionHandler
        {
            public void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
            {
             MessageBox.Show(e.Exception.Message,"Application Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
         {
             if (MainForm.WindowState == FormWindowState.Minimized)
             {
                 MainForm.WindowState = FormWindowState.Normal;
                 MainForm.WindowState = FormWindowState.Maximized;
             }
             MainForm.Activate();
             MainForm.BringToFront();
         }
    }
}
