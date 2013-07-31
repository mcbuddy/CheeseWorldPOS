using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheeseWorldPOS
{
    public partial class frmManagerFuntions : Form
    {
        public frmManagerFuntions()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frm_Add_Item fai = new frm_Add_Item();
            fai.Show();
            //this.Hide();
        }

        

        private void btnReports_Click(object sender, EventArgs e)
        {
            SalesReport objSalesReport = new SalesReport();
            objSalesReport.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
