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
    public partial class frmPayment : Form
    {
        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;
        
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "1"; //add value
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "2"; //add value
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "3"; //add value
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "4"; //add value
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "5"; //add value
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "6"; //add value
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "7"; //add value
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "8"; //add value
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "9"; //add value
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "00"; //add value
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "0"; //add value
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txt_payment.Text += "."; //add value
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_payment.Text = "";
        }

        private void transactionFinished(object sender, EventArgs e)
        {
            decimal total = 0;
            try
            {
                total = decimal.Parse(txtTransTotal.Text.TrimStart('$')) - decimal.Parse(txt_payment.Text); //attempt to calculate payment
            }
            catch
            {
                MessageBox.Show("Error Has Occured. Please enter a valid Amount"); // display message if payment is not valid
                return;
            }
            if (total > 0)
            {
                txtTransTotal.Text = total.ToString(); // if total is not equal to 0, display remaining balance.
            }
            else
            {
                MessageBox.Show("Plese give " + String.Format("{0:c}",-total) + " back to Customer."); // displays balance to be returned to customer.
                PaymentMade(this, new PaymentMadeEventArgs() { PaymentSuccess = true }); // set payment status to true.
                this.Close();
            }
            
            
        }

        private decimal transTotal; // transaction Total

        public decimal TransTotal //set total and assign to textbox. Will dynamically update.
        {
            get { return transTotal; }
            set 
            {
                transTotal = value;
                txtTransTotal.Text = String.Format("{0:c}", transTotal);
            }
        }
    }

    public class PaymentMadeEventArgs: EventArgs
    {
        private bool paymentSuccess; // payment success status

        public bool PaymentSuccess // get payment status upon finish of transacion.
        {
          get { return paymentSuccess; }
          set { paymentSuccess = value; }
        }
    }
}
