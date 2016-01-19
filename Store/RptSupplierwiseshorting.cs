using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting;
using Store.BusinessLogic;
using Store.COMMON;
using Store.Reports;
using VIRETAILDAL;
using VIRETAILDAL.Purchasing;
using VIRETAILENTITIES;
using BorderSide = DevExpress.XtraPrinting.BorderSide;
using Utils = VIRETAILDAL.COMMON.Utils;

namespace Store
{
    public partial class RptSupplierwiseshorting : XtraForm
    {
        string prno = string.Empty;
        private int LoadReport;
        DataTable ds ;

        public RptSupplierwiseshorting()
        {
            InitializeComponent();
        }
        private void Supplierwiseshorting_Load(object sender, EventArgs e)
        {
            LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            iTEMMASTBindingSource.DataSource = ClsGetData.GetItemMastList();
            comboBoxEdit1.SelectedIndex = 0;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(LookupSupplier.EditValue!=null)
            {
                 if (comboBoxEdit1.SelectedIndex == 0)
                 {
                     ds = new BLReports().GetSupplierWiseShortage(LookupSupplier.EditValue.ToString());
                 }
                 else
                 {
                     ds = new BLReports().GetShortingbyCategory(LookupSupplier.EditValue.ToString());
                 }
                 if (ds.Rows.Count > 0)
                         gridControl1.DataSource = ds;
                     else
                     {
                         XtraMessageBox.Show("Data not found", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
            }
        }
        void LoadGrid(DataRow dr1)
        {
           
            if(dsPurchase1.PURCHASEREQUEST.Rows.Count==0)
            {
                var dm = new DataManager();
                int auto = dm.GetAutoId(16);
                dm.UpdateAutoNum(16);
                auto++;
                prno = dm.CreateFormatedAutoNo(auto);
            }
                var dr = dsPurchase1.PURCHASEREQUEST.NewRow();
                dr["PRNO"] = prno;
                dr["COMPANY"] = Utils.Company;
                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    dr["SUPPLIERNO"] = LookupSupplier.EditValue == null ? ClsGetData.GetDefaultSupplier(dr1[0].ToString()) : LookupSupplier.EditValue;
                }
                else
                {
                    dr["SUPPLIERNO"] = ClsGetData.GetDefaultSupplier(dr1[0].ToString());
                }
                dr["ITEMNO"] = dr1[0];
                dr["QTY"] = string.IsNullOrEmpty(dr1[3].ToString())? 1 : int.Parse(dr1[3].ToString());
              //dr["REQDATE"] = null;
                dr["CDATE"] = DateTime.Now;
                dr["USERID"] = Utils.Userid;
                dr["INORDER"] = 0;
                dsPurchase1.PURCHASEREQUEST.Rows.Add(dr);
        }
        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
                gridView1.PostEditor();
                var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//gridView1.PostEditor();
                if(bool.Parse(dr["sel"].ToString()))
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSel, true);
                    LoadGrid(dr);
                }
                else
                {
                    if (XtraMessageBox.Show("Already in list do you want remove", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteFromList(dr[0].ToString());
                    }
                }
        }
        private void Supplierwiseshorting_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode==Keys.F4)
            //{
            //    if(gridControl2.Focused)
            //    {
            //        if(gridView2.FocusedRowHandle>=0)
            //        {
            //            if (XtraMessageBox.Show("Do you want to delete the selected line","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //            {
            //                gridView2.DeleteRow(gridView2.FocusedRowHandle);
            //            }
            //        }
            //    }
            //}
            if(e.KeyCode==Keys.F10)
            {
                this.InvokeEx(x => AddItems(string.Empty));
            }
        }
        private void repositoryItemCheckEdit1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            //if((bool) e.OldValue)
            //{
            //    if (XtraMessageBox.Show("Already in list do you want remove", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        var dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //        DeleteFromList(dr[0].ToString());
            //        e.NewValue = false;
            //    }
            //}
        }
        void  DeleteFromList(string itemno)
        {
            foreach(DataRow dr in dsPurchase1.PURCHASEREQUEST.Rows)
            {
                if(itemno==dr["itemno"].ToString())
                {
                    dr.Delete();
                    return;
                }
            }
        }
        void SaveRequest()
        {
            if(XtraMessageBox.Show("Do you want to save the request","POS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(dsPurchase1.PURCHASEREQUEST.Rows.Count==0)
                {
                    XtraMessageBox.Show("Nothing to save", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach(DataRow dr in dsPurchase1.PURCHASEREQUEST.Rows)
                {
                    string qty = dr["QTY"].ToString();
                    if(string.IsNullOrEmpty(dr["QTY"].ToString()))
                    {
                        dr.SetColumnError("QTY","Please check Qty");    
                    }
                    else if(int.Parse(dr["QTY"].ToString())==0)
                    {
                        dr.SetColumnError("QTY", "Please check Qty");    
                    }
                    else
                    {
                        dr.SetColumnError("QTY",null);  
                    }
                }
                if(dsPurchase1.PURCHASEREQUEST.HasErrors)
                {
                    XtraMessageBox.Show("Purchase request not saved due to errors", "POS", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    return;
                }
                var dm = new PrDataManager {Purchaserequest = dsPurchase1.PURCHASEREQUEST};
                var changes = (DsPurchase.PURCHASEREQUESTDataTable)dsPurchase1.PURCHASEREQUEST.GetChanges();
                var retval =   dm.DoSave();
                if(retval=="1")
                {
                    XtraMessageBox.Show("Purchase request created", "POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    var addedRows = from row in dsPurchase1.PURINVDETAIL
                                    where row.RowState == DataRowState.Added
                                    select row;
                    foreach (var row in addedRows.ToArray())
                    {
                        row.Delete();
                    }
                    
                    if (changes != null) dsPurchase1.Merge(changes);
                    dsPurchase1.AcceptChanges();
                    dsPurchase1.Clear();
                    dsPurchase1.PURCHASEREQUEST.Merge(dm.GetPurchaseRequest(prno));
                }


            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveRequest();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(gridView2.DataRowCount > 0)
            {
                LoadReport = 1;
                CreateReport();
            }   
        }
        public void CreateReport()
        {
            var link = new PrintableComponentLink(new PrintingSystem());
            link.Margins.Left = 100;
            link.Margins.Right = 100;
            link.Margins.Top = 100;
            link.Margins.Bottom = 90;
            link.PaperKind = PaperKind.A4;
            if (LoadReport == 0)
                link.Component = gridControl1;
            if (LoadReport == 1)
            {
                link.Component = gridControl2;
                link.Landscape = true;
            }

            PageFooterArea footer = new PageFooterArea();
            footer.Content.Add("Printed on " + "[Date Printed]" + " by " + Utils.Username);
            footer.LineAlignment = BrickAlignment.Near;
            PageHeaderArea header = new PageHeaderArea();
            link.CreateMarginalHeaderArea += CreateMarginalHeaderArea;
            link.PageHeaderFooter = new PageHeaderFooter(header, footer);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SubmitParameters, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.None, CommandVisibility.None);
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.DocumentMap, CommandVisibility.None);
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Document"].Visible = false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Background"].Visible = false;
            link.PrintingSystem.PreviewRibbonFormEx.RibbonControl.Pages["Print Preview"].Groups["Zoom"].Visible = false;
            link.CreateDocument();
            link.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            link.ShowRibbonPreview(UserLookAndFeel.Default);
        }
        void CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick;
            string phead = "";
            
            if (LoadReport == 0)
                phead = LookupSupplier.Text + " shortage report as of " + DateTime.Now.ToShortDateString();
            if (LoadReport == 1)
                phead =  " Purchase request List " ;
            // var sz  = Windows.Forms.TextRenderer.MeasureText(SelectedLocationText, e.Graph.Font);
            //New RectangleF(0, 0, e.Graph.ClientPageSize.Width, sz.Height)
            var txh = TextRenderer.MeasureText(phead, e.Graph.Font);
            var cm = Utils.Companyname;
            brick = e.Graph.DrawString(Utils.Companyname, Color.Black, new RectangleF(0, 0, e.Graph.ClientPageSize.Width, txh.Height),
                                        BorderSide.None);
            brick.Font = new Font("Tahoma", 12, FontStyle.Bold);
            brick.StringFormat = new BrickStringFormat(StringAlignment.Center);
            TextBrick brick1;
            brick1 = e.Graph.DrawString(phead, Color.Black, new RectangleF(0, 20, e.Graph.ClientPageSize.Width, txh.Height),
                                      BorderSide.None);
            brick1.Font = new Font("Tahoma", 10, FontStyle.Regular);
            brick1.StringFormat = new BrickStringFormat(StringAlignment.Center);
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                LoadReport = 0;
                CreateReport();
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var pur = new PurchaseRequestList();
            pur.LoadPurchaseData(Utils.Company);
            pur.ShowDialog();
        }
        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                LookupSupplier.Properties.Columns.Clear();


               LookupSupplier.Properties.Columns.AddRange(new[] {
            new LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, FormatType.None, "", false, HorzAlignment.Near),
            new LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, FormatType.None, "", true, HorzAlignment.Near),
            new LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, FormatType.Numeric, "", false, HorzAlignment.Far)});
      

                LookupSupplier.Properties.DisplayMember ="SUPPLIERNAME";
                LookupSupplier.Properties.ValueMember  ="SUPPLIERNO";
                LookupSupplier.Properties.DataSource = ClsGetData.GetSupplier();
            }
            else
            {
                LookupSupplier.Properties.Columns.Clear();
                LookupSupplier.Properties.Columns.AddRange(new[] {
            new LookUpColumnInfo("GROUPID", "GROUPID", 85, FormatType.None, "", false, HorzAlignment.Near),
            new LookUpColumnInfo("GROUPNAME", "GROUPNAME", 85, FormatType.None, "", true, HorzAlignment.Near)});
 
                LookupSupplier.Properties.DisplayMember ="GROUPNAME";
                LookupSupplier.Properties.ValueMember = "GROUPID";
                LookupSupplier.Properties.DataSource = ClsGetData.GetItemGroup();
            }

        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.InvokeEx(x => AddItems(string.Empty));
        }
        void AddItems(string itemno)
        {
            var frm = new FrmItemLookUp();
            frm.EventSelectedItem += AdditemsToList;
            frm.closeonselect = false;
            frm.ShowDialog();
            if (ActiveControl.Name != "gridControl1")
                gridControl1.Focus();
        }
        private void AdditemsToList(object sender, GetDataRowEventArgs e)
        {
            var d = e.SelectedRow;
            AddItemsToList(d["sel"].ToString(), d);
        }
        private void AddItemsToList(string selected, DataRow adr)
        {
            //if (gridView1.DataRowCount > 0)
            //{
                if (selected == bool.TrueString)
                {
                    bool itemfound = false;

                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        // object cellValue = gridView1.GetRowCellValue(i, col);
                        if (gridView1.GetRowCellValue(i, colItemno).ToString() == adr["ITEMNO"].ToString())
                        {
                            itemfound = true;
                        }
                    }
                    if (!itemfound)
                    {
                        var bls = new BLSales().GetAvailableQty(adr["itemno"].ToString());
                        gridView1.AddNewRow();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemno, adr["itemno"]);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colBarcode, adr["Barcode"]);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemname, adr["ITEMNAME"]);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colStock, bls);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colMinQty, string.IsNullOrEmpty(adr["REORDER"].ToString())?"1":adr["REORDER"].ToString());
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSUPPLIERNO, adr["SUPPLIERNO"]);
                        gridView1.UpdateCurrentRow();
                    }

                }
                else
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        // object cellValue = gridView1.GetRowCellValue(i, col);
                        if (gridView1.GetRowCellValue(i, colItemno).ToString() == adr["ITEMNO"].ToString())
                        {
                            gridView1.DeleteRow(i);
                        }
                    }
                }
            }
  
    }
}