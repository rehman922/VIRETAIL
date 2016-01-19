using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Store
{
    public partial class unzipform : Form
    {
        public unzipform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoJob();
        }
        void DoJob()
        {
            //find files in directory and extract and rename the file rename extention
            var di = new DirectoryInfo(@"D:\Links");
            FileInfo[] filepaths = di.GetFiles("*.rar");

            foreach (var fps in filepaths)
            {
                unzip(fps.FullName);
            }
            //foreach (string txtName in Directory.GetFiles(@"D:\Links", "*.rar"))
            //{
            //    unzip(txtName);
            //}
        }

        void unzip(string src)
        {

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //Put the path of installed winrar.exe
            proc.StartInfo.FileName = @"C:\Program Files (x86)\WinRAR\unrar.exe";
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.EnableRaisingEvents = true;
            //PWD: Password if the file has any
            //SRC: The path of your rar file. e.g: c:\temp\abc.rar
            //DES: The path you want it to be extracted. e.g: d:\extracted
            //ATTENTION: DESTINATION FOLDER MUST EXIST!
            proc.StartInfo.Arguments = String.Format("x -{0} {1} ", src, @"D:\Links\");
            proc.Start();
        }
    }
}
