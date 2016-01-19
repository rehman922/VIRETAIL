using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using VIRETAILENTITIES;

namespace Store
{
    partial class ConsolidatedInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition8 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition9 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition10 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition11 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition12 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition13 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition14 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition15 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition16 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition17 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition18 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition19 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition20 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition21 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition22 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidatedInventory));
            this.colSTORE01 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE02 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE03 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE04 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE05 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE06 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE07 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE08 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE09 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTORE20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.progressBar1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LookupSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource();
            this.dsMaster1 = new VIRETAILENTITIES.DsMaster();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.iTEMGROUPBindingSource = new System.Windows.Forms.BindingSource();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.sTOREMASTDBBindingSource = new System.Windows.Forms.BindingSource();
            this.txtbarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.pURCHASEREQUESTBindingSource = new System.Windows.Forms.BindingSource();
            this.dsPurchase1 = new VIRETAILENTITIES.DsPurchase();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLIERNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colITEMNO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.iTEMMASTBindingSource = new System.Windows.Forms.BindingSource();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cONSOLIDATEINVENTORYBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRUNDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRGEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPURQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSOLIDATEINVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colSTORE01
            // 
            this.colSTORE01.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE01.AppearanceCell.Options.UseFont = true;
            this.colSTORE01.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE01.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE01.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE01.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE01.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE01.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE01.FieldName = "STORE01";
            this.colSTORE01.MaxWidth = 60;
            this.colSTORE01.Name = "colSTORE01";
            this.colSTORE01.OptionsColumn.AllowEdit = false;
            this.colSTORE01.OptionsColumn.ReadOnly = true;
            this.colSTORE01.Visible = true;
            this.colSTORE01.VisibleIndex = 8;
            this.colSTORE01.Width = 60;
            // 
            // colSTORE02
            // 
            this.colSTORE02.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE02.AppearanceCell.Options.UseFont = true;
            this.colSTORE02.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE02.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE02.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE02.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE02.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE02.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE02.FieldName = "STORE02";
            this.colSTORE02.MaxWidth = 60;
            this.colSTORE02.Name = "colSTORE02";
            this.colSTORE02.OptionsColumn.AllowEdit = false;
            this.colSTORE02.OptionsColumn.ReadOnly = true;
            this.colSTORE02.Width = 55;
            // 
            // colSTORE03
            // 
            this.colSTORE03.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE03.AppearanceCell.Options.UseFont = true;
            this.colSTORE03.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE03.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE03.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE03.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE03.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE03.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE03.FieldName = "STORE03";
            this.colSTORE03.MaxWidth = 60;
            this.colSTORE03.Name = "colSTORE03";
            this.colSTORE03.OptionsColumn.AllowEdit = false;
            this.colSTORE03.OptionsColumn.ReadOnly = true;
            this.colSTORE03.Width = 55;
            // 
            // colSTORE04
            // 
            this.colSTORE04.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE04.AppearanceCell.Options.UseFont = true;
            this.colSTORE04.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE04.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE04.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE04.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE04.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE04.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE04.FieldName = "STORE04";
            this.colSTORE04.MaxWidth = 60;
            this.colSTORE04.Name = "colSTORE04";
            this.colSTORE04.OptionsColumn.AllowEdit = false;
            this.colSTORE04.OptionsColumn.ReadOnly = true;
            this.colSTORE04.Width = 55;
            // 
            // colSTORE05
            // 
            this.colSTORE05.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE05.AppearanceCell.Options.UseFont = true;
            this.colSTORE05.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE05.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE05.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE05.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE05.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE05.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE05.FieldName = "STORE05";
            this.colSTORE05.MaxWidth = 60;
            this.colSTORE05.Name = "colSTORE05";
            this.colSTORE05.OptionsColumn.AllowEdit = false;
            this.colSTORE05.OptionsColumn.ReadOnly = true;
            this.colSTORE05.Width = 55;
            // 
            // colSTORE06
            // 
            this.colSTORE06.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE06.AppearanceCell.Options.UseFont = true;
            this.colSTORE06.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE06.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE06.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE06.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE06.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE06.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE06.FieldName = "STORE06";
            this.colSTORE06.MaxWidth = 60;
            this.colSTORE06.Name = "colSTORE06";
            this.colSTORE06.OptionsColumn.AllowEdit = false;
            this.colSTORE06.OptionsColumn.ReadOnly = true;
            this.colSTORE06.Width = 55;
            // 
            // colSTORE07
            // 
            this.colSTORE07.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE07.AppearanceCell.Options.UseFont = true;
            this.colSTORE07.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE07.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE07.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE07.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE07.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE07.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE07.FieldName = "STORE07";
            this.colSTORE07.MaxWidth = 60;
            this.colSTORE07.Name = "colSTORE07";
            this.colSTORE07.OptionsColumn.AllowEdit = false;
            this.colSTORE07.OptionsColumn.ReadOnly = true;
            this.colSTORE07.Width = 55;
            // 
            // colSTORE08
            // 
            this.colSTORE08.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE08.AppearanceCell.Options.UseFont = true;
            this.colSTORE08.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE08.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE08.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE08.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE08.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE08.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE08.FieldName = "STORE08";
            this.colSTORE08.MaxWidth = 60;
            this.colSTORE08.Name = "colSTORE08";
            this.colSTORE08.OptionsColumn.AllowEdit = false;
            this.colSTORE08.OptionsColumn.ReadOnly = true;
            this.colSTORE08.Width = 55;
            // 
            // colSTORE09
            // 
            this.colSTORE09.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE09.AppearanceCell.Options.UseFont = true;
            this.colSTORE09.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE09.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE09.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE09.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE09.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE09.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE09.FieldName = "STORE09";
            this.colSTORE09.MaxWidth = 60;
            this.colSTORE09.Name = "colSTORE09";
            this.colSTORE09.OptionsColumn.AllowEdit = false;
            this.colSTORE09.OptionsColumn.ReadOnly = true;
            this.colSTORE09.Width = 55;
            // 
            // colSTORE10
            // 
            this.colSTORE10.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE10.AppearanceCell.Options.UseFont = true;
            this.colSTORE10.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE10.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE10.FieldName = "STORE10";
            this.colSTORE10.MaxWidth = 60;
            this.colSTORE10.Name = "colSTORE10";
            this.colSTORE10.OptionsColumn.AllowEdit = false;
            this.colSTORE10.OptionsColumn.ReadOnly = true;
            this.colSTORE10.Width = 55;
            // 
            // colSTORE11
            // 
            this.colSTORE11.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE11.AppearanceCell.Options.UseFont = true;
            this.colSTORE11.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE11.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE11.FieldName = "STORE11";
            this.colSTORE11.MaxWidth = 60;
            this.colSTORE11.Name = "colSTORE11";
            this.colSTORE11.OptionsColumn.AllowEdit = false;
            this.colSTORE11.OptionsColumn.ReadOnly = true;
            this.colSTORE11.Width = 55;
            // 
            // colSTORE12
            // 
            this.colSTORE12.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE12.AppearanceCell.Options.UseFont = true;
            this.colSTORE12.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE12.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE12.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE12.FieldName = "STORE12";
            this.colSTORE12.MaxWidth = 60;
            this.colSTORE12.Name = "colSTORE12";
            this.colSTORE12.OptionsColumn.AllowEdit = false;
            this.colSTORE12.OptionsColumn.ReadOnly = true;
            this.colSTORE12.Width = 55;
            // 
            // colSTORE13
            // 
            this.colSTORE13.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE13.AppearanceCell.Options.UseFont = true;
            this.colSTORE13.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE13.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE13.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE13.FieldName = "STORE13";
            this.colSTORE13.MaxWidth = 60;
            this.colSTORE13.Name = "colSTORE13";
            this.colSTORE13.OptionsColumn.AllowEdit = false;
            this.colSTORE13.OptionsColumn.ReadOnly = true;
            this.colSTORE13.Width = 55;
            // 
            // colSTORE14
            // 
            this.colSTORE14.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE14.AppearanceCell.Options.UseFont = true;
            this.colSTORE14.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE14.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE14.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE14.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE14.FieldName = "STORE14";
            this.colSTORE14.MaxWidth = 60;
            this.colSTORE14.Name = "colSTORE14";
            this.colSTORE14.OptionsColumn.AllowEdit = false;
            this.colSTORE14.OptionsColumn.ReadOnly = true;
            this.colSTORE14.Width = 55;
            // 
            // colSTORE15
            // 
            this.colSTORE15.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE15.AppearanceCell.Options.UseFont = true;
            this.colSTORE15.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE15.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE15.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE15.FieldName = "STORE15";
            this.colSTORE15.MaxWidth = 60;
            this.colSTORE15.Name = "colSTORE15";
            this.colSTORE15.OptionsColumn.AllowEdit = false;
            this.colSTORE15.OptionsColumn.ReadOnly = true;
            this.colSTORE15.Width = 55;
            // 
            // colSTORE16
            // 
            this.colSTORE16.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE16.AppearanceCell.Options.UseFont = true;
            this.colSTORE16.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE16.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE16.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE16.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE16.FieldName = "STORE16";
            this.colSTORE16.MaxWidth = 60;
            this.colSTORE16.Name = "colSTORE16";
            this.colSTORE16.OptionsColumn.AllowEdit = false;
            this.colSTORE16.OptionsColumn.ReadOnly = true;
            this.colSTORE16.Width = 55;
            // 
            // colSTORE17
            // 
            this.colSTORE17.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE17.AppearanceCell.Options.UseFont = true;
            this.colSTORE17.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE17.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE17.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE17.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE17.FieldName = "STORE17";
            this.colSTORE17.MaxWidth = 60;
            this.colSTORE17.Name = "colSTORE17";
            this.colSTORE17.OptionsColumn.AllowEdit = false;
            this.colSTORE17.OptionsColumn.ReadOnly = true;
            this.colSTORE17.Width = 55;
            // 
            // colSTORE18
            // 
            this.colSTORE18.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE18.AppearanceCell.Options.UseFont = true;
            this.colSTORE18.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE18.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE18.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE18.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE18.FieldName = "STORE18";
            this.colSTORE18.MaxWidth = 60;
            this.colSTORE18.Name = "colSTORE18";
            this.colSTORE18.OptionsColumn.AllowEdit = false;
            this.colSTORE18.OptionsColumn.ReadOnly = true;
            this.colSTORE18.Width = 55;
            // 
            // colSTORE19
            // 
            this.colSTORE19.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE19.AppearanceCell.Options.UseFont = true;
            this.colSTORE19.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE19.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE19.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE19.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE19.FieldName = "STORE19";
            this.colSTORE19.MaxWidth = 60;
            this.colSTORE19.Name = "colSTORE19";
            this.colSTORE19.OptionsColumn.AllowEdit = false;
            this.colSTORE19.OptionsColumn.ReadOnly = true;
            this.colSTORE19.Width = 55;
            // 
            // colSTORE20
            // 
            this.colSTORE20.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTORE20.AppearanceCell.Options.UseFont = true;
            this.colSTORE20.AppearanceCell.Options.UseTextOptions = true;
            this.colSTORE20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE20.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE20.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTORE20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTORE20.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTORE20.FieldName = "STORE20";
            this.colSTORE20.MaxWidth = 60;
            this.colSTORE20.Name = "colSTORE20";
            this.colSTORE20.OptionsColumn.AllowEdit = false;
            this.colSTORE20.OptionsColumn.ReadOnly = true;
            this.colSTORE20.Width = 55;
            // 
            // colTOTAL
            // 
            this.colTOTAL.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTOTAL.AppearanceCell.Options.UseFont = true;
            this.colTOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.colTOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.colTOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTOTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTOTAL.Caption = "Total";
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.MaxWidth = 50;
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.OptionsColumn.AllowEdit = false;
            this.colTOTAL.OptionsColumn.ReadOnly = true;
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 6;
            this.colTOTAL.Width = 50;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem6,
            this.barButtonItem7,
            this.progressBar1,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem10, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save - Report";
            this.barButtonItem1.Glyph = global::Store.Properties.Resources.Save16;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Print";
            this.barButtonItem2.Glyph = global::Store.Properties.Resources.printer1;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Generate P.O";
            this.barButtonItem10.Glyph = global::Store.Properties.Resources.tickwhite;
            this.barButtonItem10.Id = 13;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Show Purchase History - F8";
            this.barButtonItem3.Glyph = global::Store.Properties.Resources.date_magnify;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Collapse all";
            this.barButtonItem8.Glyph = global::Store.Properties.Resources.listadd;
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem12, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.progressBar1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Save Purchase Request";
            this.barButtonItem6.Glyph = global::Store.Properties.Resources.Save16;
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Print P.R List";
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.progressBar1.Caption = "barEditItem1";
            this.progressBar1.Edit = this.repositoryItemProgressBar1;
            this.progressBar1.Id = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Width = 550;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.LookAndFeel.SkinName = "Office 2013";
            this.repositoryItemProgressBar1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(908, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Size = new System.Drawing.Size(908, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 363);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(908, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 363);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Generate P.O";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.LookupSupplier);
            this.panel1.Controls.Add(this.comboBoxEdit1);
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.checkedComboBoxEdit1);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 31);
            this.panel1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 21);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(645, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Last Run Dt. :";
            // 
            // LookupSupplier
            // 
            this.LookupSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LookupSupplier.EnterMoveNextControl = true;
            this.LookupSupplier.Location = new System.Drawing.Point(604, 5);
            this.LookupSupplier.Name = "LookupSupplier";
            this.LookupSupplier.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.LookupSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LookupSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.LookupSupplier.Properties.Appearance.Options.UseFont = true;
            this.LookupSupplier.Properties.Appearance.Options.UseForeColor = true;
            this.LookupSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNO", "SUPPLIERNO", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIERNAME", "SUPPLIERNAME", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUEDAYS", "DUEDAYS", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.LookupSupplier.Properties.DataSource = this.sUPPLIERBindingSource;
            this.LookupSupplier.Properties.DisplayMember = "SUPPLIERNAME";
            this.LookupSupplier.Properties.NullText = "";
            this.LookupSupplier.Properties.ShowHeader = false;
            this.LookupSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupSupplier.Properties.ValueMember = "SUPPLIERNO";
            this.LookupSupplier.Size = new System.Drawing.Size(35, 20);
            this.LookupSupplier.TabIndex = 20;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.dsMaster1;
            // 
            // dsMaster1
            // 
            this.dsMaster1.DataSetName = "DsMaster";
            this.dsMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.Location = new System.Drawing.Point(211, 5);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Category",
            "Item No",
            "Supplier"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(107, 20);
            this.comboBoxEdit1.TabIndex = 19;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit2.Location = new System.Drawing.Point(324, 5);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPID", "GROUPID", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUPNAME", "GROUPNAME", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARGROUPNAME", "ARGROUPNAME", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FIXDISC", "FIXDISC", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UPD", "UPD", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.iTEMGROUPBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "GROUPNAME";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "GROUPID";
            this.lookUpEdit2.Size = new System.Drawing.Size(250, 20);
            this.lookUpEdit2.TabIndex = 18;
            // 
            // iTEMGROUPBindingSource
            // 
            this.iTEMGROUPBindingSource.DataMember = "ITEMGROUP";
            this.iTEMGROUPBindingSource.DataSource = this.dsMaster1;
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(75, 5);
            this.checkedComboBoxEdit1.MenuManager = this.barManager1;
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DataSource = this.sTOREMASTDBBindingSource;
            this.checkedComboBoxEdit1.Properties.DisplayMember = "STORENAME";
            this.checkedComboBoxEdit1.Properties.ValueMember = "DBNAME";
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(118, 20);
            this.checkedComboBoxEdit1.TabIndex = 17;
            this.checkedComboBoxEdit1.EditValueChanged += new System.EventHandler(this.checkedComboBoxEdit1_EditValueChanged);
            // 
            // sTOREMASTDBBindingSource
            // 
            this.sTOREMASTDBBindingSource.DataMember = "STOREMASTDB";
            this.sTOREMASTDBBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbarcode.Location = new System.Drawing.Point(580, 5);
            this.txtbarcode.MenuManager = this.barManager1;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(18, 20);
            this.txtbarcode.TabIndex = 16;
            this.txtbarcode.Visible = false;
            this.txtbarcode.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Store name :";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Image = global::Store.Properties.Resources.run;
            this.simpleButton4.Location = new System.Drawing.Point(818, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(83, 23);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Create";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 106);
            this.panel2.TabIndex = 27;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.pURCHASEREQUESTBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 6);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl2.Size = new System.Drawing.Size(908, 100);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pURCHASEREQUESTBindingSource
            // 
            this.pURCHASEREQUESTBindingSource.DataMember = "PURCHASEREQUEST";
            this.pURCHASEREQUESTBindingSource.DataSource = this.dsPurchase1;
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DsPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPRNO,
            this.colCOMPANY,
            this.colSUPPLIERNO,
            this.colITEMNO1,
            this.colQTY,
            this.colREQDATE,
            this.colUSERID,
            this.colINORDER});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 24;
            // 
            // colPRNO
            // 
            this.colPRNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceCell.Options.UseFont = true;
            this.colPRNO.AppearanceCell.Options.UseTextOptions = true;
            this.colPRNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPRNO.AppearanceHeader.Options.UseFont = true;
            this.colPRNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPRNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPRNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPRNO.Caption = "P.R No.";
            this.colPRNO.FieldName = "PRNO";
            this.colPRNO.MaxWidth = 80;
            this.colPRNO.Name = "colPRNO";
            this.colPRNO.Visible = true;
            this.colPRNO.VisibleIndex = 0;
            this.colPRNO.Width = 80;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceCell.Options.UseFont = true;
            this.colCOMPANY.AppearanceCell.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCOMPANY.AppearanceHeader.Options.UseFont = true;
            this.colCOMPANY.AppearanceHeader.Options.UseTextOptions = true;
            this.colCOMPANY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCOMPANY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            // 
            // colSUPPLIERNO
            // 
            this.colSUPPLIERNO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceCell.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceCell.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSUPPLIERNO.AppearanceHeader.Options.UseFont = true;
            this.colSUPPLIERNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSUPPLIERNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSUPPLIERNO.Caption = "Supplier name";
            this.colSUPPLIERNO.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colSUPPLIERNO.FieldName = "SUPPLIERNO";
            this.colSUPPLIERNO.Name = "colSUPPLIERNO";
            this.colSUPPLIERNO.Visible = true;
            this.colSUPPLIERNO.VisibleIndex = 1;
            this.colSUPPLIERNO.Width = 280;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.sUPPLIERBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "SUPPLIERNAME";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "SUPPLIERNO";
            // 
            // colITEMNO1
            // 
            this.colITEMNO1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceCell.Options.UseFont = true;
            this.colITEMNO1.AppearanceCell.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colITEMNO1.AppearanceHeader.Options.UseFont = true;
            this.colITEMNO1.AppearanceHeader.Options.UseTextOptions = true;
            this.colITEMNO1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colITEMNO1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colITEMNO1.Caption = "Item no";
            this.colITEMNO1.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colITEMNO1.FieldName = "ITEMNO";
            this.colITEMNO1.Name = "colITEMNO1";
            this.colITEMNO1.Visible = true;
            this.colITEMNO1.VisibleIndex = 2;
            this.colITEMNO1.Width = 360;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.iTEMMASTBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "ITEMNO";
            // 
            // iTEMMASTBindingSource
            // 
            this.iTEMMASTBindingSource.DataMember = "ITEMMAST";
            this.iTEMMASTBindingSource.DataSource = this.dsMaster1;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceCell.Options.UseFont = true;
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQTY.Caption = "Req.Qty";
            this.colQTY.FieldName = "QTY";
            this.colQTY.MaxWidth = 80;
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            this.colQTY.Width = 80;
            // 
            // colREQDATE
            // 
            this.colREQDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceCell.Options.UseFont = true;
            this.colREQDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colREQDATE.AppearanceHeader.Options.UseFont = true;
            this.colREQDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colREQDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREQDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colREQDATE.Caption = "Req. Date";
            this.colREQDATE.FieldName = "REQDATE";
            this.colREQDATE.MaxWidth = 90;
            this.colREQDATE.Name = "colREQDATE";
            this.colREQDATE.Visible = true;
            this.colREQDATE.VisibleIndex = 4;
            this.colREQDATE.Width = 90;
            // 
            // colUSERID
            // 
            this.colUSERID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceCell.Options.UseFont = true;
            this.colUSERID.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUSERID.AppearanceHeader.Options.UseFont = true;
            this.colUSERID.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            // 
            // colINORDER
            // 
            this.colINORDER.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceCell.Options.UseFont = true;
            this.colINORDER.AppearanceCell.Options.UseTextOptions = true;
            this.colINORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colINORDER.AppearanceHeader.Options.UseFont = true;
            this.colINORDER.AppearanceHeader.Options.UseTextOptions = true;
            this.colINORDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colINORDER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colINORDER.FieldName = "INORDER";
            this.colINORDER.Name = "colINORDER";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ITEMNAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ITEMNO";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.cONSOLIDATEINVENTORYBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(908, 226);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cONSOLIDATEINVENTORYBindingSource
            // 
            this.cONSOLIDATEINVENTORYBindingSource.DataMember = "CONSOLIDATEINVENTORY";
            this.cONSOLIDATEINVENTORYBindingSource.DataSource = typeof(VIRETAILENTITIES.DsReports);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTID,
            this.colRUNDATE,
            this.colItemCategory,
            this.colSuppliername,
            this.colPRGEN,
            this.colItemname,
            this.colItemno,
            this.colbarcode,
            this.colTOTAL,
            this.colPURQTY,
            this.colSTORE01,
            this.colSTORE02,
            this.colSTORE03,
            this.colSTORE04,
            this.colSTORE05,
            this.colSTORE06,
            this.colSTORE07,
            this.colSTORE08,
            this.colSTORE09,
            this.colSTORE10,
            this.colSTORE11,
            this.colSTORE12,
            this.colSTORE13,
            this.colSTORE14,
            this.colSTORE15,
            this.colSTORE16,
            this.colSTORE17,
            this.colSTORE18,
            this.colSTORE19,
            this.colSTORE20});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colSTORE01;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = 0;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colSTORE02;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition2.Value1 = 0;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colSTORE03;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition3.Value1 = 0;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Column = this.colSTORE04;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition4.Value1 = 0;
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colSTORE05;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition5.Value1 = 0;
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.Column = this.colSTORE06;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition6.Value1 = 0;
            styleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition7.Appearance.Options.UseForeColor = true;
            styleFormatCondition7.Column = this.colSTORE07;
            styleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition7.Value1 = 0;
            styleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition8.Appearance.Options.UseForeColor = true;
            styleFormatCondition8.Column = this.colSTORE08;
            styleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition8.Value1 = 0;
            styleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition9.Appearance.Options.UseForeColor = true;
            styleFormatCondition9.Column = this.colSTORE09;
            styleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition9.Value1 = 0;
            styleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition10.Appearance.Options.UseForeColor = true;
            styleFormatCondition10.Column = this.colSTORE10;
            styleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition10.Value1 = 0;
            styleFormatCondition11.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition11.Appearance.Options.UseForeColor = true;
            styleFormatCondition11.Column = this.colSTORE11;
            styleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition11.Value1 = 0;
            styleFormatCondition12.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition12.Appearance.Options.UseForeColor = true;
            styleFormatCondition12.Column = this.colSTORE12;
            styleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition12.Value1 = 0;
            styleFormatCondition13.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition13.Appearance.Options.UseForeColor = true;
            styleFormatCondition13.Column = this.colSTORE13;
            styleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition13.Value1 = 0;
            styleFormatCondition14.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition14.Appearance.Options.UseForeColor = true;
            styleFormatCondition14.Column = this.colSTORE14;
            styleFormatCondition14.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition14.Value1 = 0;
            styleFormatCondition15.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition15.Appearance.Options.UseForeColor = true;
            styleFormatCondition15.Column = this.colSTORE15;
            styleFormatCondition15.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition15.Value1 = 0;
            styleFormatCondition16.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition16.Appearance.Options.UseForeColor = true;
            styleFormatCondition16.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition16.Value1 = 0;
            styleFormatCondition17.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition17.Appearance.Options.UseForeColor = true;
            styleFormatCondition17.Column = this.colSTORE16;
            styleFormatCondition17.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition17.Value1 = 0;
            styleFormatCondition18.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition18.Appearance.Options.UseForeColor = true;
            styleFormatCondition18.Column = this.colSTORE17;
            styleFormatCondition18.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition18.Value1 = 0;
            styleFormatCondition19.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition19.Appearance.Options.UseForeColor = true;
            styleFormatCondition19.Column = this.colSTORE18;
            styleFormatCondition19.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition19.Value1 = 0;
            styleFormatCondition20.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition20.Appearance.Options.UseForeColor = true;
            styleFormatCondition20.Column = this.colSTORE19;
            styleFormatCondition20.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition20.Value1 = 0;
            styleFormatCondition21.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition21.Appearance.Options.UseForeColor = true;
            styleFormatCondition21.Column = this.colSTORE20;
            styleFormatCondition21.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition21.Value1 = 0;
            styleFormatCondition22.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition22.Appearance.Options.UseForeColor = true;
            styleFormatCondition22.ApplyToRow = true;
            styleFormatCondition22.Column = this.colTOTAL;
            styleFormatCondition22.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition22.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6,
            styleFormatCondition7,
            styleFormatCondition8,
            styleFormatCondition9,
            styleFormatCondition10,
            styleFormatCondition11,
            styleFormatCondition12,
            styleFormatCondition13,
            styleFormatCondition14,
            styleFormatCondition15,
            styleFormatCondition16,
            styleFormatCondition17,
            styleFormatCondition18,
            styleFormatCondition19,
            styleFormatCondition20,
            styleFormatCondition21,
            styleFormatCondition22});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTID
            // 
            this.colTID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTID.AppearanceCell.Options.UseFont = true;
            this.colTID.AppearanceCell.Options.UseTextOptions = true;
            this.colTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTID.FieldName = "TID";
            this.colTID.Name = "colTID";
            this.colTID.OptionsColumn.ReadOnly = true;
            // 
            // colRUNDATE
            // 
            this.colRUNDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRUNDATE.AppearanceCell.Options.UseFont = true;
            this.colRUNDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colRUNDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRUNDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colRUNDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRUNDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRUNDATE.FieldName = "RUNDATE";
            this.colRUNDATE.Name = "colRUNDATE";
            // 
            // colItemCategory
            // 
            this.colItemCategory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemCategory.AppearanceCell.Options.UseFont = true;
            this.colItemCategory.AppearanceCell.Options.UseTextOptions = true;
            this.colItemCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemCategory.FieldName = "ItemCategory";
            this.colItemCategory.Name = "colItemCategory";
            this.colItemCategory.OptionsColumn.AllowEdit = false;
            this.colItemCategory.OptionsColumn.ReadOnly = true;
            this.colItemCategory.Visible = true;
            this.colItemCategory.VisibleIndex = 1;
            // 
            // colSuppliername
            // 
            this.colSuppliername.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSuppliername.AppearanceCell.Options.UseFont = true;
            this.colSuppliername.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliername.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSuppliername.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliername.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSuppliername.FieldName = "Suppliername";
            this.colSuppliername.Name = "colSuppliername";
            this.colSuppliername.OptionsColumn.AllowEdit = false;
            this.colSuppliername.OptionsColumn.ReadOnly = true;
            this.colSuppliername.Visible = true;
            this.colSuppliername.VisibleIndex = 0;
            // 
            // colPRGEN
            // 
            this.colPRGEN.Caption = "In. P.R";
            this.colPRGEN.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPRGEN.FieldName = "PRGEN";
            this.colPRGEN.MaxWidth = 25;
            this.colPRGEN.Name = "colPRGEN";
            this.colPRGEN.Visible = true;
            this.colPRGEN.VisibleIndex = 2;
            this.colPRGEN.Width = 25;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // colItemname
            // 
            this.colItemname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemname.AppearanceCell.Options.UseFont = true;
            this.colItemname.AppearanceCell.Options.UseTextOptions = true;
            this.colItemname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemname.Caption = "Item Name";
            this.colItemname.FieldName = "Itemname";
            this.colItemname.MaxWidth = 350;
            this.colItemname.Name = "colItemname";
            this.colItemname.OptionsColumn.AllowEdit = false;
            this.colItemname.OptionsColumn.ReadOnly = true;
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 3;
            this.colItemname.Width = 350;
            // 
            // colItemno
            // 
            this.colItemno.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItemno.AppearanceCell.Options.UseFont = true;
            this.colItemno.AppearanceCell.Options.UseTextOptions = true;
            this.colItemno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemno.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colItemno.Caption = "Item No.";
            this.colItemno.FieldName = "Itemno";
            this.colItemno.MaxWidth = 150;
            this.colItemno.Name = "colItemno";
            this.colItemno.OptionsColumn.AllowEdit = false;
            this.colItemno.OptionsColumn.ReadOnly = true;
            this.colItemno.Visible = true;
            this.colItemno.VisibleIndex = 4;
            this.colItemno.Width = 150;
            // 
            // colbarcode
            // 
            this.colbarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbarcode.AppearanceCell.Options.UseFont = true;
            this.colbarcode.AppearanceCell.Options.UseTextOptions = true;
            this.colbarcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.colbarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbarcode.Caption = "Barcode";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.MaxWidth = 150;
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 5;
            this.colbarcode.Width = 150;
            // 
            // colPURQTY
            // 
            this.colPURQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPURQTY.AppearanceCell.Options.UseFont = true;
            this.colPURQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colPURQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colPURQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPURQTY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPURQTY.Caption = "P.R Qty";
            this.colPURQTY.FieldName = "PURQTY";
            this.colPURQTY.MaxWidth = 50;
            this.colPURQTY.Name = "colPURQTY";
            this.colPURQTY.Visible = true;
            this.colPURQTY.VisibleIndex = 7;
            this.colPURQTY.Width = 50;
            // 
            // ConsolidatedInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 416);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ConsolidatedInventory";
            this.Text = "Consolidated Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsolidatedInventory_FormClosing);
            this.Load += new System.EventHandler(this.ConsolidatedInventory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsolidatedInventory_KeyDown);
            this.Resize += new System.EventHandler(this.ConsolidatedInventory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookupSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREMASTDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEREQUESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMMASTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSOLIDATEINVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BarManager barManager1;
        private Bar bar2;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private Panel panel1;
        private LabelControl labelControl1;
        private SimpleButton simpleButton4;
        private TextEdit txtbarcode;
        private RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private CheckedComboBoxEdit checkedComboBoxEdit1;
        private LookUpEdit lookUpEdit2;
        private BindingSource iTEMGROUPBindingSource;
        private BarButtonItem barButtonItem6;
        private GridControl gridControl1;
        private GridView gridView1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Panel panel2;
        private BarButtonItem barButtonItem7;
        private ComboBoxEdit comboBoxEdit1;
        private BindingSource cONSOLIDATEINVENTORYBindingSource;
        private GridColumn colTID;
        private GridColumn colRUNDATE;
        private GridColumn colItemCategory;
        private GridColumn colSuppliername;
        private GridColumn colItemno;
        private GridColumn colbarcode;
        private GridColumn colItemname;
        private GridColumn colTOTAL;
        private GridColumn colPURQTY;
        private GridColumn colSTORE01;
        private GridColumn colSTORE02;
        private GridColumn colSTORE03;
        private GridColumn colSTORE04;
        private GridColumn colSTORE05;
        private GridColumn colSTORE06;
        private GridColumn colSTORE07;
        private GridColumn colSTORE08;
        private GridColumn colSTORE09;
        private GridColumn colSTORE10;
        private GridColumn colSTORE11;
        private GridColumn colSTORE12;
        private GridColumn colSTORE13;
        private GridColumn colSTORE14;
        private GridColumn colSTORE15;
        private GridColumn colSTORE16;
        private GridColumn colSTORE17;
        private GridColumn colSTORE18;
        private GridColumn colSTORE19;
        private GridColumn colSTORE20;
        protected LookUpEdit LookupSupplier;
        private BarEditItem progressBar1;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private BarButtonItem barButtonItem8;
        private BarButtonItem barButtonItem9;
        private DateTimePicker dateTimePicker1;
        private LabelControl labelControl2;
        private BarButtonItem barButtonItem10;
        private GridColumn colPRGEN;
        private GridControl gridControl2;
        private GridView gridView2;
        private GridColumn colPRNO;
        private GridColumn colCOMPANY;
        private GridColumn colSUPPLIERNO;
        private GridColumn colITEMNO1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridColumn colQTY;
        private GridColumn colREQDATE;
        private GridColumn colUSERID;
        private GridColumn colINORDER;
        private DsPurchase dsPurchase1;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BindingSource sUPPLIERBindingSource;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private BindingSource iTEMMASTBindingSource;
        private BindingSource pURCHASEREQUESTBindingSource;
        private DsMaster dsMaster1;
        private BarButtonItem barButtonItem12;
        private BarButtonItem barButtonItem11;
        private BindingSource sTOREMASTDBBindingSource;
    }
}