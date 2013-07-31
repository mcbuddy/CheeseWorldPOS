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
    public partial class frmCoupon : Form
    {
        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities();
        public frmCoupon()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "1"; //add value
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "00"; //add value
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "0"; //add value
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "2"; //add value
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "3"; //add value
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "4"; //add value
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "5"; //add value
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "6"; //add value
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "7"; //add value
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "8"; //add value
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_cCode.Text += "9"; //add value
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cCode.Text = ""; //clear
        }

        public int couponCode;
        public decimal? couponValue;
        public int? couponCodeDtbse;

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                couponCode = int.Parse(txt_cCode.Text); // set value entered in textbox to variable
                var couponList = cheeseEntity.ExecuteStoreQuery<tblCoupon>("Select * FROM tblCoupons WHERE CouponCode = " + couponCode, null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblCoupon c in couponList)
                {
                    couponValue = c.CouponValue; // assign coupon value
                    couponCodeDtbse = c.CouponCode; // retrieve code for validation
                }
            }

            catch
            {
                MessageBox.Show("Error Has Occured. Please enter a Coupon Code."); // display message no code is entered
                return;
            }
            if (couponCodeDtbse != couponCode)
            {
                MessageBox.Show("Error Has Occured. Please enter a Valid Coupon Code."); // display message code is wrong.
            }
            else
            {
                this.Close();
            }
        }
    }
}
