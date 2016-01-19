using System;
using System.Windows.Forms;
using VIRETAILDAL.Masters;

namespace Store
{
    public partial class Dosages : Form
    {
        public Dosages()
        {
            InitializeComponent();
        }
        private void Dosages_FormClosing(object sender, FormClosingEventArgs e)
        {
            var cl = new DrugDispatch();
            cl.UpdateDosageTable(dsMaster1.DOSAGES);
        }
        private void Dosages_Load(object sender, EventArgs e)
        {
            var cl = new DrugDispatch();
            dsMaster1.Merge(cl.GetDosagesDataTable());

        }
        
    }
}
