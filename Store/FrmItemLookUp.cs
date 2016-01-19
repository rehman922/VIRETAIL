using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Store.COMMON;
using Store.Properties;

namespace Store
{
     
    public delegate void GetSelectedRow(object sender, GetDataRowEventArgs e);
    public partial class FrmItemLookUp : XtraForm
    {
        public event GetSelectedRow EventSelectedItem;
        public static string _lasttext = string.Empty;
      //public event RefershGrid Itemadded;
        bool isselected;
        private bool isbarcode;
        private bool ismfbarcode;
        private bool _closeonselect;
        public bool closeonselect 
        {
         get { return _closeonselect; }
         set
         {
             _closeonselect = value;
            if(!closeonselect)
                barButtonItem3.Visibility = BarItemVisibility.Always;
            }
        }
        private DataTable _ds;
        public FrmItemLookUp()
        {
            InitializeComponent();
        }
        public FrmItemLookUp(DataTable ds,string itemno):this()
        {
            if(!string.IsNullOrEmpty(itemno))
                gridView1.FindFilterText =  itemno ;
            if (gridView1.DataRowCount == 0)
                gridView1.FindFilterText = "";
            _ds = ds;
            DoCheckTheItemsInList();
            //foreach (DataRow d in ds.Rows)
            //{
            //    var rows = dsMaster1.ITEMMAST.Select("itemno= '" + d["itemno"].ToString() + "' ");
            //    foreach (DataRow dr in rows)
            //    {
            //        dr["sel"] = bool.TrueString;
            //    }
            //}
        }
        void DoCheckTheItemsInList()
        {
            foreach (DataRow d in _ds.Rows)
            {
                if (d.RowState != DataRowState.Deleted)
                {
                    var rows = dsMaster1.ITEMMAST.Select("itemno= '" + d["itemno"] + "' ");
                    foreach (DataRow dr in rows)
                    {
                        dr["sel"] = bool.TrueString;
                    }
                }
            } 
        }
        private void FrmItemLookUpShown(object sender, EventArgs e)
        {
            
        }
        #region DBGrid
        void DoSelectRow(object sender)
        {
            if (gridView1.FocusedRowHandle < 0) return;
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SEL").ToString() == bool.TrueString)
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", false);
                isselected = true;
            }
            else
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SEL", true);
                isselected = false;
            }
            var drs = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var args = new GetDataRowEventArgs(drs);
            EventSelectedItem(sender, args);
            //gridView1.ApplyFindFilter("");
            if(closeonselect)
                Close();
        }
        #endregion
        private void BarButtonItem2ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new ItemMast();
            f.ShowDialog();
            iTEMMASTBindingSource.Filter = "";
            LoadItemList();
            DoCheckTheItemsInList();
        }
        private void BarManager2EditorKeyDown(object sender, KeyEventArgs e)
         {
        //    if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return) return;
        //    barManager2.ActiveEditItemLink.PostEditor();
        //    if (barEditItem2.EditValue == null) return;
        //    var sitemno = barEditItem2.EditValue.ToString().ToUpper(CultureInfo.InvariantCulture);
        //    //sitemno = "%" + sitemno + "%";
        //    DataRow[] rows;
        //    if (COMMON.Functions.IsAlpha(sitemno))
        //    {
        //          rows = DS.ITEMMAST1.Select(" BARCODE LIKE '" + @sitemno + "'");
        //    }
        //    else
        //    {
        //          rows = dataSet1.ITEMMAST1.Select(" ITEMNAME LIKE '" + @sitemno + "'");
         //    }

            //c1TrueDBGrid1.DataSource = rows;
            //c1TrueDBGrid1.Rebind(true);
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                      textEdit1.SelectAll(); 
                      DoSelectRow(this);
                      break;
                case Keys.Up:
                     textEdit1.SelectAll(); 
                    break;
                case Keys.Down:
                     textEdit1.SelectAll(); 
                    break;
                case Keys.Left :
                     textEdit1.SelectAll(); 
                    break;
                case Keys.Right:
                    textEdit1.SelectAll(); 
                    break;
                default:
                    textEdit1.Focus();
                    Keys key = e.KeyCode;
                    SendKeys.Send(key.ToString());
                    
                    break;
            }
        }
        private void FrmItemLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                ismfbarcode = false;
                F1Key();  
            }
            if(e.KeyCode==Keys.F2)
            {
                ismfbarcode = true;
                F2Key();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if(e.KeyCode==Keys.Down)
            {
                gridControl1.Focus();
            }
            if(e.KeyCode==Keys.Up)
            {
                if(gridView1.FocusedRowHandle==0)
                {
                    textEdit1.Focus();
                }
            }
        }
        void F1Key()
        {
            if (!isbarcode)
            {
                isbarcode = true;
                textEdit1.EditValue = string.Empty;
                textEdit1.Properties.NullText = "Enter Barcode";
                textEdit1.Properties.NullValuePrompt = "Enter Barcode";
                barButtonItem1.Glyph = Resources.viewlist16;
                barButtonItem1.Caption = "F1 For Item Selection";
                colBARCODE.VisibleIndex = 1;
                colITEMNAME.VisibleIndex = 2;
                // gridView1.OptionsFind.FindFilterColumns = "BARCODE";
            }
            else
            {
                isbarcode = false;
                barButtonItem1.Caption = "F1 For Barcode Selection";
                textEdit1.EditValue = string.Empty;
                textEdit1.Properties.NullText = "Enter Item name";
                textEdit1.Properties.NullValuePrompt = "Enter Item name";
                barButtonItem1.Glyph = Resources.barcode;
                colBARCODE.VisibleIndex = 2;
                colITEMNAME.VisibleIndex = 1;
                // gridView1.OptionsFind.FindFilterColumns = "ITEMNAME";  
            }
        }
        void F2Key()
        {

            textEdit1.EditValue = string.Empty;
            textEdit1.Properties.NullText = "Enter Barcode";
            textEdit1.Properties.NullValuePrompt = "Enter Barcode";
            colBARCODE.VisibleIndex = 3;
            colITEMNAME.VisibleIndex = 2;
            colITEMNO.VisibleIndex = 1;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           DoSelectRow(this);
           textEdit1.Focus();
           textEdit1.SelectAll();
         //  textEdit1.EditValue = string.Empty;
        }
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
           if (e.Column.VisibleIndex== 0)
            { 
                if (gridView1.ActiveEditor!=null)
                    isselected = gridView1.ActiveEditor.OldEditValue.ToString() == bool.TrueString;
                else
                {
                        isselected = true;
                }
            }
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
       {
           if (textEdit1.EditValue == null)
           {
               iTEMMASTBindingSource.RemoveFilter();
               return;
           }
           if (String.IsNullOrEmpty(textEdit1.EditValue.ToString()))
           {
               iTEMMASTBindingSource.RemoveFilter();
               return;
           }
           string searchstr;
           if (isbarcode)
               searchstr = " ITEMNO  =  '" + textEdit1.EditValue + "'   OR    BARCODE =  '" + textEdit1.EditValue + "' ";
           //else if(ismfbarcode)
           //    searchstr = "ITEMNAME LiKE  '" + textEdit1.EditValue + "%' ";
            else
               searchstr = "ITEMNAME LiKE  '" + textEdit1.EditValue + "%' ";
           iTEMMASTBindingSource.Filter = searchstr;
           _lasttext = textEdit1.Text;
       }
        public string filtertext
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    textEdit1.EditValue = _lasttext;
                }
                else
                {
                    textEdit1.EditValue = value;
                }
            }
        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
       {
           if(e.KeyCode==Keys.Enter)
           {
               if(iTEMMASTBindingSource.Count > 0 )
               {
                   gridView1.FocusedRowHandle = 0;
                   DoSelectRow(this);
                   textEdit1.Focus();
                   textEdit1.SelectAll();
                  // textEdit1.EditValue = string.Empty;
               }
           }
       }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           F1Key();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close();
        }
        private void FrmItemLookUp_Load(object sender, EventArgs e)
        {
           // ThreadPool.QueueUserWorkItem(delegate { LoadItemList(); });
         //   Task t1 = Task.Factory.StartNew(LoadItemList);
            this.InvokeEx(lv => LoadItemList());
          
        }
        void LoadItemList()
        {
            iTEMMASTBindingSource.DataSource = ClsGetData.GetItemMastList();
            iTEMMASTBindingSource.Sort = "ITEMNAME"; 
        }
   }
    public class GetDataRowEventArgs : EventArgs
    {
        // add local member variable to hold text
        private readonly DataRow _selectedRow;
        // class constructor
        public GetDataRowEventArgs(DataRow dr)
        {
            _selectedRow = dr;
        }
        // Properties - Accessible by the listener
        public DataRow SelectedRow
        {
            get
            {
                return _selectedRow;
            }
        }

    }
    public static class SynchronizeInvokeExtensions
    {
    public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
    {
    if (@this.InvokeRequired)
    {
        @this.Invoke(action, new object[] { @this });
    }
    else
    {
        action(@this);
    }
    }
}
}