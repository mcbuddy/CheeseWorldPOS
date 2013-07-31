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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_id.Text += "1"; //add 1 to the text box
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_id.Text += "2"; //add 2 to the text box
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_id.Text += "3";  //add 3 to the text box
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_id.Text += "4"; //add 4 to the text box
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_id.Text += "5"; //add 5 to the text box
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_id.Text += "6";  //add 6 to the text box
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_id.Text += "7";  //add 7 to the text box
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_id.Text += "8";  //add 8 to the text box
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_id.Text += "9";  //add 9 to the text box
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_id.Text += "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = ""; //Clear text box
        }

        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities();
        public string empFristName;
        public string empLastName;
        public string employeeRole;
        public int? employeeId;
        public int loginID;
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                loginID = int.Parse(txt_id.Text);
                var employeeList = cheeseEntity.ExecuteStoreQuery<tblEmployee>("Select * FROM tblEmployee WHERE EmployeeLogin = " + loginID, null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblEmployee emp in employeeList)
                {
                    employeeId = emp.EmployeeLogin;
                    empFristName = emp.EmployeeFirstName;
                    empLastName = emp.EmployeeLastName;
                    employeeRole = emp.EmployeeRole;
                }
            }
            catch
            {
                MessageBox.Show("Error Has Occured. Please enter a login ID."); // display message no id is entered
                txt_id.Text = "";
                return;
            }


            if (employeeId != loginID)
            {
                MessageBox.Show("Operator Cannot be Found."); // display message if login is incorrect
                txt_id.Text = "";
            }
            else
            {
                frmTransaction_Home frm = new frmTransaction_Home(empFristName, empLastName, employeeRole); //instanciate a new form
                frm.Show(); // displays the transaction home form
                this.Hide(); // hides the main form
            }
            
            
        }
    }
}
