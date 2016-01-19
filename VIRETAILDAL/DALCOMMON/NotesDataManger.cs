using VIRETAILDAL.COMMON;
using VIRETAILDAL.DsInventoryTableAdapters;
using VIRETAILENTITIES;

namespace VIRETAILDAL.DALCOMMON
{

    public class NotesDataManger
    {
        private readonly string _constr = Utils.Connectionstring;
        public string Supid { get; set; }
        public string Notes { get; set; }
        public int Sourceid { get; set; }
        public DsInventory.NOTESMASTRow DNotesmastRow { get; set; }
        public void SaveNotes()
        {
            bool saved = false;
            var ta = new NOTESMASTTableAdapter {Connection = {ConnectionString = _constr}};
            saved =   ta.Insert(Notes, Supid, Sourceid, Utils.Userid, System.DateTime.Now, Utils.Company) > 0;
             
        }
        public void UpdateNotes()
        {
            bool saved = false;
            var ta = new NOTESMASTTableAdapter {Connection = {ConnectionString = _constr}};
            saved = ta.Update(DNotesmastRow) > 0;
     
        }
        public bool SaveNotes(DsInventory.NOTESMASTDataTable notesmastDataTable)
        {
            bool saved = false;
            if (!notesmastDataTable.HasErrors)
            {
                var manager = new TableAdapterManager
                                  {   Connection = {ConnectionString = _constr},
                                      NOTESMASTTableAdapter = new NOTESMASTTableAdapter(),
                                      BackupDataSetBeforeUpdate = true
                                  };
                saved = manager.NOTESMASTTableAdapter.Update(notesmastDataTable) > 0;
            }
            return saved;
        }
        public void GetNotes(string supid,int sourceid)
        {
            var ta = new NOTESMASTTableAdapter {Connection = {ConnectionString = _constr}};
            var ds = new DsInventory().NOTESMAST;
            ta.FillByID(ds, supid, sourceid);
            foreach (DsInventory.NOTESMASTRow d in ds.Rows)
            {
                DNotesmastRow = d;
            }
        }
        public int GetNotesCount(string supid,int sourceid)
        {
            var ta = new NOTESMASTTableAdapter {Connection = {ConnectionString = _constr}};
            return ta.GetNotesCount(supid, sourceid) ?? 0;
        }
        public bool DeleteNotes(int noteid)
        {
            var ta = new NOTESMASTTableAdapter { Connection = { ConnectionString = _constr } };
            return ta.DeleteQuery(noteid) > 0;
        }
    }
    
}
