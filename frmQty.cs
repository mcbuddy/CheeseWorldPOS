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
    public partial class frmQty : Form
    {
        public decimal Quantity;
        public frmQty(decimal quantity)
        {
            
            InitializeComponent();
            Quantity = quantity;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "."; //add point
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "1"; //add value
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "2"; //add value
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "3"; //add value
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "4"; //add value
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "5"; //add value
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "6"; //add value
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "7"; //add value
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "8"; //add value
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "9"; //add value
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "0"; //add value
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_qty.Text = ""; //clear
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            txt_qty.Text += "00"; //add value
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                Quantity = decimal.Parse(txt_qty.Text);
            }
            catch
            {
                MessageBox.Show("Error Has Occured. Please enter a valid Amount"); // display message if payment is not valid
                return;
            }


            this.Close();
        }
    }
}
