using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Store.COMMON;
using VIRETAILDAL.DALCOMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class Notes : XtraForm
    {
        int msgid;
        string supid;
        private int sourecid;
        public Notes()
        {
            InitializeComponent();
        }
        public Notes(string sid, string supname,int mod):this()
        {
            supid = sid;
            sourecid = mod;
            label1.Text = supname;
            var cl = ClsGetData.GetNotes(supid,mod);
            if (cl == null) return;
            msgid = cl.NOTEID;
            textBox1.Text = cl.NOTES;
        }
        private void NotesLoad(object sender, EventArgs e)
        {}
        public bool CheckNotesAvailable(string sid,int sourceid)
        {
            return ClsGetData.GetNotesCount(sid, sourceid) > 0;
        }
        private void NotesKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape || e.KeyCode==Keys.F4)
            {
                UpdateNotes();
            }
        }
        private void Button1Click(object sender, EventArgs e)
        {
            if (msgid > 0)
            {
                var ms = new NotesDataManger().DeleteNotes(msgid);
            }
            textBox1.Text = string.Empty;
            Dispose();
        }
        private void Button2Click(object sender, EventArgs e)
        {
            UpdateNotes();
        }
        void UpdateNotes()
        {
            var dm = new NotesDataManger {Supid = supid, Notes = textBox1.Text};
            if (msgid == 0)
            {
                dm.SaveNotes();
            }
            else
            {
                DsInventory.NOTESMASTRow dr = null;
                dr.SUPID = supid;
                dr.SOURCEID = sourecid;
                dr.NOTES = textBox1.Text;
                dm.DNotesmastRow = dr;
                dm.UpdateNotes();
            }
            Dispose();
        }
    }
}