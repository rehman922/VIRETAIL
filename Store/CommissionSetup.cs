using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Store.BusinessLogic;
using Store.COMMON;
using VIRETAILENTITIES;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class CommissionSetup : BaseRibbonForm
    {
        protected BindingSource Bsnav = new BindingSource();
        public TextBox Tnav = new TextBox();
        BindingSource bsS = new BindingSource();
        private string _COMID;
        public CommissionSetup()
        {
            InitializeComponent();
        }
        private void CommionSetup_Load(object sender, EventArgs e)
        {
            RibbonPageMoreOptionsVisible = false;
            RibbonPrintVisible = false;
            BPrint.Visibility=BarItemVisibility.Never;
            ItemClick += RibbonButtonsClick;
            SetNavigation();
            if (Utils.Company != "00")
            {
                RibbonSaveEnable = false;
            }

            Ribbonname = "Commision Setup";
            var dsW = ClsGetData.GetStoreList();
            var bsW = new BindingSource(dsW, "") { Filter = "STORETYPE = 'SS'" };
            LookuptoStore.Properties.DataSource = bsW;
          //var dsu = ClsGetData.GetUserInfo();
          //var bsW1 = new BindingSource(dsu, "USERINFO");
            var d1 = ClsGetData.GetUserInfo();

            lookupsalesman.Properties.DataSource = d1;// ClsGetData.GetUserInfo();

            repositoryItemLookUpEdit2.DataSource = d1;
            repositoryItemLookUpEdit3.DataSource = dsW;
            
            repositoryItemLookUpEdit1.DataSource = ClsGetData.GetItemMastList();
            Loginname = Utils.Username;


        }
        void AddItems(string itemno)
        {
            var frm = new FrmItemLookUp(ledgers1.COMMISIONDETAIL, itemno);
            frm.EventSelectedItem += AdditemsToList;
            var fcd = gridView1.FocusedRowHandle;
            frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
            {
                gridControl1.Focus();
               // barEditItem2.EditValue = null;
                if (gridView1.FocusedRowHandle >= 0)
                {
                    gridView1.FocusedRowHandle = fcd;
                }
                else
                {
                   gridView1.FocusedRowHandle = 0;
                }
            }
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            DataRow d = e.SelectedRow;
            if (d["sel"].ToString() == bool.TrueString)
            {
                var dr = ledgers1.COMMISIONDETAIL.NewRow();
                
                dr["ITEMNO"] = d["ITEMNO"];
                dr["STDATE"] = Frmdate.DateTime;
                dr["TODATE"] = Todate.DateTime;
                ledgers1.COMMISIONDETAIL.Rows.Add(dr);
            }
            else
            {
                var i = 0;
                foreach (DataRow dr in ledgers1.COMMISIONDETAIL.Rows)
                {
                    if (d.RowState != DataRowState.Deleted)
                        if (d["ITEMNO"].ToString() == dr["ITEMNO"].ToString())
                        {
                            ledgers1.COMMISIONDETAIL.Rows.RemoveAt(i);
                            break;
                        }
                    i++;
                }
            }
        }
        void DoDelete()
        {
            if (gridView1.FocusedRowHandle < 0) return;
            string itname = "[ " + gridView1.FocusedRowHandle + 1 + " ] - " + gridView1.GetDisplayTextByColumnValue(colITEMID, gridView1.GetFocusedRowCellValue("ITEMID"));
            if (XtraMessageBox.Show("Do you want to delete the selected  row..?", itname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }
        void SetNavigation()
        {
            Bsnav.DataSource = ClsGetData.GetCommissionMast();
            gridControl2.DataSource = Bsnav;
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "COMID", true));
            if (Bsnav.Count == 0)
            {
                MovePrevEnable = false;
                MoveNextEnable = false;
            }
            else
            {
                Bsnav.MoveLast();
                MoveNextEnable = false;
            }
        }
        void DoSaveClose(){}
        void DoHold()
        {
           
        }
        void DoNotes() {}
        void DoPrint()
        {
          //  if (_COMID != null)
             //   Blitemmove.DoPrint(_COMID);
        }
        void DoClear() { }
        void DoSaveNew() { }
        void DoNew()
        {
            _COMID = null;
            txtdocno.Text = _COMID;
            Frmdate.EditValue = DateTime.Now;
            Todate.EditValue =  DateTime.Now.AddMonths(1);
            Promoname.EditValue = null;
            LookuptoStore.EditValue = null;
            lookupsalesman.EditValue = null;
            ledgers1.COMMISIONDETAIL.Clear();
            gridControl1.ResetBindings();
            RibbonSaveEnable = true;
        }
        void DoMovePrev(){
            if (Bsnav.Position <= 0)
            {
                MoveNextEnable = true;
                MovePrevEnable = false;
            }
            else
            {
                MovePrevEnable = true;
            }
            Bsnav.MovePrevious();
            MoveNextEnable = true;
            var current = (DataRowView)Bsnav.Current;
            _COMID = current["COMID"].ToString();
            DoView();
             
            
        }
        void DoView()
        {
            if (Utils.Company != "00")
            {
                RibbonSaveEnable = false;
            }
            if (!string.IsNullOrEmpty(_COMID))
            {
                var bl = new BlCommissionSetup();
                var dt = bl.GetCommissionMast(_COMID);
                foreach(Ledgers.COMMISIONMASTRow dr in dt.Rows)
                {
                    txtdocno.Text = _COMID;
                    Frmdate.EditValue = dr.PRMOFRM;
                    Todate.EditValue = dr.PRMOTO;
                    Promoname.EditValue = dr.PROMONAME;
                    LookuptoStore.EditValue = null;
                    if(!dr.IsSTOREIDNull())
                        LookuptoStore.EditValue = dr.STOREID;
                    lookupsalesman.EditValue = dr.EMPNO;
                    RibbonSaveEnable =true;
                    labelControl1.Visible = false;
                    if (!dr.IsUPLOADNull())
                    {
                        if (dr.UPLOAD)
                        {
                            RibbonSaveEnable = false;
                            labelControl1.Visible = true;
                        }
                    }
                }
                if (ledgers1.COMMISIONDETAIL.Rows.Count > 0)
                {
                    ledgers1.COMMISIONDETAIL.Clear();
                }
                ledgers1.Merge(bl.GetCommissionDetail(_COMID));
            }
        }
        void DoMoveNext()
        {
            if (Bsnav.Position == Bsnav.Count - 1)
            {
                MoveNextEnable = false;
                MovePrevEnable = true;
            }
            else
            {
                MovePrevEnable = true;
            }
            Bsnav.MoveNext();
            var current = (DataRowView)Bsnav.Current;
            _COMID = current["COMID"].ToString();
            
            DoView();
            HoldButtonVisibility = BarItemVisibility.Never;
        }
        bool DoSave()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            bool retval = false;
            if (Frmdate.EditValue == null)
            {
                XtraMessageBox.Show("Please select start date", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(Todate.EditValue==null)
            {
                XtraMessageBox.Show("Please select End date", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(ledgers1.COMMISIONDETAIL.Count==0)
            {
                XtraMessageBox.Show("Nothing to save", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //if (LookuptoStore.EditValue == null)
            //{
            //    XtraMessageBox.Show("Please select store", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            if (lookupsalesman.EditValue == null)
            {
                XtraMessageBox.Show("Please select salesman", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            foreach(Ledgers.COMMISIONDETAILRow drd in ledgers1.COMMISIONDETAIL.Rows)
            {
                if(drd.RowState!=DataRowState.Deleted)
                {
                    drd.SetColumnError("STDATE", drd.IsSTDATENull() ? "Please enter start date" : null);
                    drd.SetColumnError("TODATE", drd.IsTODATENull() ? "Please enter start date" : null);
                }
            }if (ledgers1.COMMISIONDETAIL.HasErrors)
                {
                    XtraMessageBox.Show("Document not saved due to error, please check the errors", "POS",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            var dr = (Ledgers.COMMISIONMASTRow)ledgers1.COMMISIONMAST.NewRow();
            if (!string.IsNullOrEmpty(_COMID))
                dr.COMID = _COMID;
                dr.PRMOFRM = Frmdate.DateTime;
                dr.PRMOTO = Todate.DateTime;
                dr.EMPNO = lookupsalesman.EditValue.ToString();
                if (LookuptoStore.EditValue!=null)
                        dr.STOREID = LookuptoStore.EditValue.ToString();
                dr.PROMONAME = Promoname.EditValue == null ? dr.PRMOFRM + " - " + dr.PRMOTO  : Promoname.EditValue.ToString();
                dr.STATUS = true;
                var bhl = new  BlCommissionSetup { CommisionmastRow = dr };
                cOMMISIONDETAILBindingSource.EndEdit();
                var changes = (Ledgers.COMMISIONDETAILDataTable)ledgers1.COMMISIONDETAIL.GetChanges(DataRowState.Modified | DataRowState.Added);
                bhl.Commisiondetail = ledgers1.COMMISIONDETAIL;
                try
                    {
                        var strstatus = bhl.DoSave();
                        if (strstatus == "1")
                        {
                        _COMID = bhl.tranid;
                        txtdocno.Text = _COMID ;
            
                        XtraMessageBox.Show("Data Saved Sucessfully", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (DataRow d in ledgers1.COMMISIONDETAIL.Rows)
                        {
                        if (d.RowState != DataRowState.Deleted)
                        {
                        d["COMID"] = _COMID;
                        }
                        }
                        var addedRows = from row in ledgers1.COMMISIONDETAIL
                        where row.RowState == DataRowState.Added
                        select row;
                        foreach (var row in addedRows.ToArray())
                        {
                        row.Delete();
                        }
                        if (changes != null)
                        {
                            //ledgers1.Merge(changes);
                            ledgers1.COMMISIONDETAIL.Clear();
                            ledgers1.Merge(ClsGetData.GetCommissionDetail(_COMID));
                        }
                       // ledgers1.AcceptChanges();
                        retval = true;
                        }
                        else
                        {
                        XtraMessageBox.Show(strstatus);
                        }
                  }
                    catch (Exception ex)
                    {
                    XtraMessageBox.Show(ex.ToString());
                    }
            return retval;
        }
        void ItemsClone()
        {
            if(Bsnav.Count > 0)
                popupControlContainer1.ShowPopup(new Point(219, 219));
            else
            {
                XtraMessageBox.Show("No data found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
                case "BNEW":
                    DoNew();
                    break;
                case "BSAVE":
                    DoSave();
                    break;
                case "BSAVEANDCLOSE":
                    DoSaveClose();
                    break;
                case "BSAVEANDNEW":
                    DoSaveNew();
                    break;
                case "BCLEAR":
                    DoClear();
                    break;
                case "BDELETE":
                    DoDelete();
                    break;
                case "BPRINT":
                    DoPrint();
                    break;
                case "BNOTES":
                    DoNotes();
                    break;
                case "BHOLD":
                    DoHold();
                    break;
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
        private void CommissionSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            { AddItems(string.Empty); }
            if (e.KeyCode == Keys.F5)
             { ItemsClone(); }
            if (e.KeyCode == Keys.F4)
            { DoDelete(); }

        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            //if(!iserroricon)
            e.Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            e.Info.DisplayText = (1 + int.Parse(e.RowHandle.ToString())).ToString();
            e.Info.ImageIndex = -1;
        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var cs = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            var rs = ClsGetData.GetCommissionDetail(cs[0].ToString());
            foreach (DataRow dr in rs.Rows)
            {
                //ledgers1.COMMISIONDETAIL.BeginLoadData();
                var obj = dr.ItemArray;
                obj[0] = null;
                obj[1] = _COMID;
                ledgers1.COMMISIONDETAIL.BeginLoadData();
                ledgers1.COMMISIONDETAIL.LoadDataRow(obj, false);
                ledgers1.COMMISIONDETAIL.EndLoadData();
                //ledgers1.COMMISIONDETAIL.LoadDataRow(dr.ItemArray,false);
                //var drnew = ledgers1.COMMISIONDETAIL.NewRow();
                //drnew[1] = dr[1];drnew[2] = dr[2];drnew[3] = dr[3];drnew[4] = dr[4];drnew[5] = dr[5];
                //ledgers1.COMMISIONDETAIL.Rows.Add(drnew);
            }
        }
    }
}
