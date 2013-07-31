using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Objects;
namespace CheeseWorldPOS
{
    
    
    public partial class frmCheese_home : Form
    {
        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities(); //instanciate new database entities

        public int selectedDS;
    

        public frmCheese_home()
        {
            InitializeComponent();
            pnl_cheeseType.Hide(); // hide cheese type pannel
            pnl_meatType.Hide();
            lstProd.DataSource = cheese;
        }
        
        private decimal transactionTotal; //total for transaction

        public decimal TransactionTotal // set total and assign to textbox. Will dynamically update.
        {
            get 
            { 
                return transactionTotal;
            }
            set 
            { 
                transactionTotal = value;
                txt_total.Text = String.Format("{0:c}",transactionTotal);
            }
        }

       

        private void btn_cheese_Click(object sender, EventArgs e)
        {
            pnl_meatType.Hide();
            pnl_cheese.Show(); // show cheese panel
            pnl_cheeseType.Hide();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //terminate
        }

        private void btn_AD_Click(object sender, EventArgs e)
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meatType.Hide();//hide the meat panel
            

            //ObjectQuery<tblProduct> cheeselist = new ObjectQuery<tblProduct>("SELECT VALUE p FROM tblProducts AS p", cheeseEntity);
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work
           
            foreach(tblCheese tprod in cheeselist)
            {
                Button btn = new Button(); // instanciate new button
                btn.Name = tprod.CheeseName; // assign a name
                btn.Text = tprod.CheeseName; //assing an id
                btn.BackColor = Control.DefaultBackColor; // background color
                btn.ForeColor = Control.DefaultForeColor; // foregruong color
                btn.Height = 47; //button height
                btn.Width = 84; // button width
                btn.Tag = tprod; // store info from sql query
                btn.Click += new EventHandler(AddCheeseQuantity); // add click event
                pnl_cheeseType.Controls.Add(btn); // add button to panel
            }

        }

        public decimal quantity;
        public decimal cheesePrice;

        protected void AddCheeseQuantity(object sender, EventArgs e) //event for buttons in cheese list to add data to transacation list.
        {
            Button btn = (Button)sender; // instanciate button
            tblCheese p = (tblCheese)btn.Tag; // assign value of Tag to variable p
            /*
            frmQty frm2 = new frmQty();
            frm2.ShowDialog();
            quantity = frm2.Quantity;
            cheesePrice = quantity * (decimal)p.Price;*/
            cheese.Add(p); // add value of p to datalist
            TransactionTotal += (decimal)p.Price; //add value to total
            lstProd.SelectedIndex = lstProd.Items.Count - 1; //select the last added item
        }

        private void deleteItem(object sender, EventArgs e)
        {
            tblCheese selectedItem = (tblCheese)lstProd.SelectedItem; //declare the selected item
            cheese.Remove(selectedItem); // delete selected item
            TransactionTotal = TransactionTotal - (decimal)selectedItem.Price; // subtract price from total
            
            
        }

        private void formatListItem(object sender, ListControlConvertEventArgs e)
        {
            // format the list view to show cheese name and quantity
            string currentCheese = ((tblCheese)e.ListItem).CheeseName;
            string currentPrice = String.Format("{0:c}",((tblCheese)e.ListItem).Price);
            string descriptionPadded = currentCheese.PadRight(15);
            e.Value = descriptionPadded + currentPrice;
        }

        private void btn_meat_Click(object sender, EventArgs e)
        {
            /*frmMeat_home frm = new frmMeat_home(TransactionTotal,);
            frm.Show();
            this.Hide();*/
            pnl_cheeseType.Hide();// hide the cheese type panel
            pnl_meatType.Show();//display the meat panel
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblMeat>("Select * FROM tblMeat", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work
           
            foreach(tblMeat tmeat in cheeselist)
            {
                Button btn = new Button(); // instanciate new button
                btn.Name = tmeat.MeatName; // assign a name
                btn.Text = tmeat.MeatName; //assing an id
                btn.BackColor = Control.DefaultBackColor; // background color
                btn.ForeColor = Control.DefaultForeColor; // foregruong color
                btn.Height = 47; //button height
                btn.Width = 84; // button width
                btn.Tag = tmeat; // store info from sql query
                btn.Click += new EventHandler(AddMeatQuantity); // add click event
                pnl_meatType.Controls.Add(btn); // add button to panel
            }
            
        }

        protected void AddMeatQuantity(object sender, EventArgs e) //event for buttons created by loop
        {
            Button btn = (Button)sender; // instanciate button
            tblMeat p = (tblMeat)btn.Tag; // assign value of Tag to variable p
            meat.Add(p); // add value of p to datalist
            TransactionTotal += (decimal)p.Price; //add value to total
            lstProd.SelectedIndex = lstProd.Items.Count - 1; //select the last added item

            /*frmQty frm2 = new frmQty();
            frm2.Show();
            this.Close();*/
        }

        private void formatlistItem2(object sender, ListControlConvertEventArgs e)
        {

        }
    }


}