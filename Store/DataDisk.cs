using System;
using System.Data;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;

//required for performing RSA encryption
//required to use EncryptedXml object, requires the System.Security assembly to be referenced

namespace Store
{
    public partial class DataDisk : RibbonForm
    {
       
        DsInventory.ITEMTRANSFERMAINDataTable ds = new DsInventory().ITEMTRANSFERMAIN;
        DsInventory.ITEMTRANSFERMAINDataTable dt = new DsInventory().ITEMTRANSFERMAIN;
        BindingSource bs = new BindingSource();
        public DataDisk()
        {
            InitializeComponent();
            
            bs = new BindingSource(dt, "");
            gridControl2.DataSource = bs;
            FillDriversCombo();
            
        }
        void FillDriversCombo()
        {
            string[] drives = Environment.GetLogicalDrives();
            DriveInfo[] ListDrives = DriveInfo.GetDrives();

            foreach (DriveInfo Drive in ListDrives)
            {
                if (Drive.DriveType == DriveType.Removable)
                {
                    repositoryItemComboBox1.Items.Add(Drive.Name);
                    targetloc.EditValue = Drive.Name;
                }
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if(gridView1.FocusedRowHandle >= 0 )
            {
                
                AddItemToList(gridView1.GetDataRow(gridView1.FocusedRowHandle));
                RemoveItemInList();
            }
        }
        void AddItemToList(DataRow dr)
        {
            dt.LoadDataRow(dr.ItemArray,true);
            if(dt.Rows.Count > 0)
            {
                barButtonItem2.Enabled = true;
                barButtonItem1.Enabled = true;
            }
        }
        void RemoveItemInList()
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            if(dt.Rows.Count==0)
            {
                barButtonItem1.Enabled = false;
                barButtonItem2.Enabled = false;
            }
        }
        private void GridControl2DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.FocusedRowHandle >= 0)
            {
                AddItem(gridView2.GetDataRow(gridView2.FocusedRowHandle));
                RemoveItem();
            }
        }
        void AddItem(DataRow dr)
        {ds.LoadDataRow(dr.ItemArray, true);}
        void RemoveItem()
        {gridView2.DeleteRow(gridView2.FocusedRowHandle);}
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (targetloc.EditValue == null)
            {
                XtraMessageBox.Show("Please select the target location to save the file", "POS",
                                                           MessageBoxButtons.OK);
                return;
            }
            if (gridView2.DataRowCount == 0)
            {
                XtraMessageBox.Show("Please select the invoices to transfer", "POS",
                                                           MessageBoxButtons.OK);
                return;
            }
            // if(file.MoveTo(@"C:\DestinationFolder\Zip\" + fileName);)
            var samplefile = targetloc.EditValue + "\\";
            var permissionSet = new PermissionSet(PermissionState.None);
            var writePermission = new FileIOPermission(FileIOPermissionAccess.Write, samplefile);
            permissionSet.AddPermission(writePermission);
            if (permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet))
            {
                DoCreatingFile();
            }
            else
            {
                XtraMessageBox.Show("You don't have write permission on selected drive please select another drive", "POS",
                                                          MessageBoxButtons.OK);
            }
        }
        void DoCreatingFile()
        {
            gridControl1.Enabled = false;
            gridControl2.Enabled = false;
            string tranids = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                if(dr.RowState!=DataRowState.Deleted)
                     tranids += dr["TRANID"] + ",";
            }
            var dsxml = Functions.CreateDataSetForXmlFile(tranids);
            var fno = Functions.GetFormatedAutoNo(5);
            var dsm = new BLDiskManager();
            var createdfile =  fno + ".pml";
            try
            {
                string movefilename = targetloc.EditValue + "\\" + createdfile;
                dsxml.WriteXml(movefilename,XmlWriteMode.WriteSchema);
                dsm.fileno = fno;
                dsm.tranid = tranids;
                dsm.ftype = 0;
                dsm.DoSave();
                XtraMessageBox.Show("File created sucessfully", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "POS", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            gridControl1.Enabled = true;
            gridControl2.Enabled = true;
        }
        private void savelocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Please select the invoices to transfer", "POS",
                                                           MessageBoxButtons.OK);
        }
        private void savelocation_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Please select the invoices to transfer", "POS",
                                                         MessageBoxButtons.OK);
        }
        private void DataDisk_Load(object sender, EventArgs e)
        {
            //progressPanel1.Left = (Width + progressPanel1.Width)/2;
             
            ds = ClsGetData.GetItemTransferFileNotGenereted();//ds.Constraints.Remove("TRANID");
            iTEMTRANSFERMAINBindingSource.DataSource = ds;
        }
        public void LoadGridList()
        {
            ds = ClsGetData.GetItemTransferFileNotGenereted();//ds.Constraints.Remove("TRANID");
            iTEMTRANSFERMAINBindingSource.DataSource = ds;
        }
        private void barEditItem4_EditValueChanged(object sender, EventArgs e)
        {
            if (barEditItem3.EditValue!=null && barEditItem4.EditValue != null)
            {
                barButtonItem2.Enabled = true;
                ds = ClsGetData.GetItemTransferFileNotGenereted();//ds.Constraints.Remove("TRANID");
                iTEMTRANSFERMAINBindingSource.DataSource = ds;
            }
            else
            {
                barButtonItem2.Enabled = false;
            }
        }
        private void DataDisk_Activated(object sender, EventArgs e)
        {
            if (repositoryItemComboBox1.Items.Count == 0)
                FillDriversCombo();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            bs = new BindingSource(dt, "");
            gridControl2.DataSource = bs;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadGridList();
        }
    }
    public static class Extensions
    {
        public static string ToXml(this DataSet ds)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(DataSet));
                    xmlSerializer.Serialize(streamWriter, ds);
                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }
    }
}