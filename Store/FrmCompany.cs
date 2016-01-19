using System;
using System.Data;
using System.Windows.Forms;
using BaseClasses;
using DevExpress.XtraBars;
using Store.COMMON;
using VIRETAILENTITIES;

namespace Store
{
    public partial class FrmCompany : BaseRibbonForm
    {
        private BindingSource Bsnav = new BindingSource();
        private readonly TextBox Tnav = new TextBox();
        private DsMaster dsMaster = new DsMaster();
        private string _ccode = string.Empty;
        public FrmCompany()
        {
            InitializeComponent();
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            ItemClick += RibbonButtonsClick;
            RibbonPageMoreOptionsVisible = false;
            RibbonPrintVisible = false;
            Ribbonname = "Company";
            DeleteButtonVisibility = BarItemVisibility.Never;
            HoldButtonVisibility = BarItemVisibility.Never;
            dsMaster.COMPANY.Merge(ClsGetData.GetCompanies());
            SetNavigation();
        }
        void DoSaveClose()
        { }
        void DoSaveNew()
        { }
        void SetNavigation()
        {
            Bsnav.DataSource = dsMaster.COMPANY;
            Tnav.DataBindings.Add(new Binding("Text", Bsnav, "CCODE", true));
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
        void DoMovePrev()
        {
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
            _ccode = current["CCODE"].ToString();
            DoView();
           // IsNew = false;
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
            //IsNew = false;
            var current = (DataRowView)Bsnav.Current;
            _ccode = current["CCODE"].ToString();
            DoView();
        }
        void DoView()
        {
            
        }
        void DoSave()
        {

        }
        void DoNew()
        {}
        void RibbonButtonsClick(object sender, ItemClickEventArgs name)
        {
            switch (name.Item.Name.ToUpper())
            {
                //  BNew BSave BSaveandClose BSaveandNew BClear BDelete BPrint BNotes BHold BMovePrev BMoveNext
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
                case "BMOVEPREV":
                    DoMovePrev();
                    break;
                case "BMOVENEXT":
                    DoMoveNext();
                    break;
            }
        }
    }
}