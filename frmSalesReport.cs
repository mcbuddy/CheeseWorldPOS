using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CheeseWorldPOS
{
    public partial class SalesReport : Form
    {

        CheeseWorld_DatabaseEntities objCheeseEntities = new CheeseWorld_DatabaseEntities();
        DateTime dtFrom;
        DateTime dtTo;

        public SalesReport()
        {
            InitializeComponent();


            //fill the combo list for products.
            cmbProduct.DataSource = objCheeseEntities.tblMiscProducts;
            cmbProduct.DisplayMember = "MiscProductName";
            cmbProduct.ValueMember = "MiscProductName";
            cmbProduct.Visible = true;
            cmbProduct.Enabled = true;
        }
        //btn search event for start and end dates.
        private void btnSearchRange_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "dd/mm/yy" || txtTo.Text == "dd/mm/yy")
            { MessageBox.Show("Dates not Given"); return; }
            dtFrom = DateTime.Parse(txtFrom.Text);
            dtTo = DateTime.Parse(txtTo.Text);

            dgdViewTransactions.DataSource = this.GetDateBaseTransaction(dtFrom, dtTo);

        }
        //btn search event for transaction id.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTransactionID.Text != "")
                dgdViewTransactions.DataSource = this.GetTransactionByTransactionID(Convert.ToInt32(txtTransactionID.Text));
            else
                MessageBox.Show("Transaction ID is Empty");
        }
        //get transactions based on transation id.
        private System.Linq.IQueryable<tblTransaction> GetTransactionByTransactionID(int iTransactionID)
        {
            return objCheeseEntities.tblTransactions.Where(x => x.TransactionID == iTransactionID);
        }
        //get full transactions.
        private System.Linq.IQueryable<tblTransaction> GetfullTransactions()
        {
            return objCheeseEntities.tblTransactions;
        }

        //get transactions based on dates.
        private System.Linq.IQueryable<tblTransaction> GetDateBaseTransaction(DateTime dtFrom, DateTime dtTo)
        {
            return objCheeseEntities.tblTransactions.Where(x => x.TransactionDate >= dtFrom && x.TransactionDate <= dtTo);
        }

        //event of button ot save excel file.
        private void btnSavetoCSV_Click(object sender, EventArgs e)
        {
            Process_GridtoCSV();
        }

        //pprocess tranaction in grid and save to excel.
        private void Process_GridtoCSV()
        {
            int cols;
            //open file 
            StreamWriter wr = new StreamWriter("CheeseDatabaseInformation.csv");

            //determine the number of columns and write columns to file 
            cols = dgdViewTransactions.Columns.Count;
            for (int i = 0; i < cols - 1; i++)
            {
                wr.Write(dgdViewTransactions.Columns[i].Name.ToString().ToUpper() + ",");
            }
            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dgdViewTransactions.Rows.Count - 1); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgdViewTransactions.Rows[i].Cells[j].Value != null)
                    {
                        wr.Write(dgdViewTransactions.Rows[i].Cells[j].Value.ToString().Replace("\n", " ").Replace(",", ":") + ",");
                    }
                    else
                    {
                        wr.Write(",");
                    }
                }

                wr.WriteLine();
            }
            //close file
            wr.Close();

            MessageBox.Show("File have been saved Sucessfully!");
        }


        //monitor selected index change and refresh transaction
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblMiscProduct product = ((tblMiscProduct)cmbProduct.SelectedItem);
            dgdViewTransactions.DataSource = GetTransactionByProductName(product.MiscProductName);

        }

        //get transaction of a product.
        public System.Linq.IQueryable<tblMiscProduct> GetTransactionByProductName(string strProductName)
        {
            return objCheeseEntities.tblMiscProducts.Where(x => x.MiscProductName == strProductName);
        }

        private void dgdViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
