using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VIRETAILDAL.COMMON;
namespace VIRETAILSTORE
{
    public partial class AddressDetails : DevExpress.XtraEditors.XtraForm
    {
        public AddressDetails()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Address.CITY = city.Text;
            Address.STREET = street.Text;
            Address.ZIPCODE = zipcode.Text;
            Address.COUNTRY = country.Text;
            this.Dispose();
        }

        private void AddressDetails_Load(object sender, EventArgs e)
        {
           city.Text= Address.CITY   ;
           street.Text= Address.STREET  ;
           zipcode.Text= Address.ZIPCODE ;
           country.Text = Address.COUNTRY  ;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
