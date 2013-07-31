using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Data.Objects;

namespace CheeseWorldPOS
{
    public partial class frmTransaction_Home : Form
    {
        //decimal TransactionTotal;
        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities(); //instanciate new database entities



        public frmTransaction_Home(string empFirstName, string empLastName, string employeeRole) // home load
        {
            InitializeComponent();
            pnl_meat.Hide();
            pnl_cheese.Hide();
            pnl_MiscProducts.Hide();
            pnl_misc.Hide();
            lblEmpName.Text = empFirstName + " " + empLastName;
            if (employeeRole == "E")
            {
                btn_mgrFun.Hide();
            }
            else { btn_mgrFun.Show(); }
            
            
        }

        public frmTransaction_Home()
        {
            // TODO: Complete member initialization
        }

        private void btn_exit_Click(object sender, EventArgs e) // terminate app
        {
            Application.Exit(); //terminate
        }

        private void btn_cheese_Click(object sender, EventArgs e) // show cheese panel
        {
            pnl_cheese.Show(); //hide panels
            pnl_blank.Hide();//hide panels
            pnl_meat.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_misc.Hide();
        }

        private void btn_misc_Click(object sender, EventArgs e) // show misc panel
        {
            pnl_meat.Hide(); //hide panels
            pnl_blank.Hide(); //hide panels
            pnl_cheese.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Hide();
            pnl_misc.Hide();
            pnl_misc.Show();
        }

        private void btn_meat_Click(object sender, EventArgs e) // add meat to panel
        {
            pnl_meat.Show(); //hide panels
            pnl_blank.Hide(); //hide panels
            pnl_cheese.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_misc.Hide();
            pnl_meat.Controls.Clear();

            var meatlist = cheeseEntity.ExecuteStoreQuery<tblMeat>("Select * FROM tblMeat ORDER BY MeatName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblMeat tmeat in meatlist)
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
                    pnl_meat.Controls.Add(btn); // add button to panel
                }
        }

        private void btn_chips_Click(object sender, EventArgs e) // add chips to panel
        {
            pnl_meat.Hide(); //hide panels
            pnl_blank.Hide(); //hide panels
            pnl_cheese.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Show();
            pnl_misc.Hide();
            pnl_MiscProducts.Controls.Clear();

            var miscList = cheeseEntity.ExecuteStoreQuery<tblMiscProduct>("Select * FROM tblMiscProducts WHERE MiscProductDescription LIKE 'chips' ORDER BY MiscProductName ASC;", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblMiscProduct tMisc in miscList)
                {
                    Button btn = new Button();// instanciate new button
                    btn.Name = tMisc.MiscProductName; // assign a name
                    btn.Text = tMisc.MiscProductName; //assing an id
                    btn.BackColor = Control.DefaultBackColor; // background color
                    btn.ForeColor = Control.DefaultForeColor; // foregruong color
                    btn.Height = 47; //button height
                    btn.Width = 84; // button width
                    btn.Tag = tMisc; // store info from sql query
                    btn.Click += new EventHandler(AddMiscQuantity); // add click event
                    pnl_MiscProducts.Controls.Add(btn); // add button to panel
                }
        }

        private void btn_drinks_Click(object sender, EventArgs e) // add drinks to panel
        {
            pnl_meat.Hide(); //hide panels
            pnl_blank.Hide(); //hide panels
            pnl_cheese.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Show();
            pnl_misc.Hide();
            pnl_MiscProducts.Controls.Clear();

            var miscList = cheeseEntity.ExecuteStoreQuery<tblMiscProduct>("Select * FROM tblMiscProducts WHERE MiscProductDescription LIKE 'drinks' ORDER BY MiscProductName ASC;", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblMiscProduct tMisc in miscList)
                {
                    Button btn = new Button();// instanciate new button
                    btn.Name = tMisc.MiscProductName; // assign a name
                    btn.Text = tMisc.MiscProductName; //assing an id
                    btn.BackColor = Control.DefaultBackColor; // background color
                    btn.ForeColor = Control.DefaultForeColor; // foregruong color
                    btn.Height = 47; //button height
                    btn.Width = 84; // button width
                    btn.Tag = tMisc; // store info from sql query
                    btn.Click += new EventHandler(AddMiscQuantity); // add click event
                    pnl_MiscProducts.Controls.Add(btn); // add button to panel
                }


        }

        private void btn_bread_Click(object sender, EventArgs e) // add bread to panel
        {
            pnl_meat.Hide(); //hide panels
            pnl_blank.Hide(); //hide panels
            pnl_cheese.Hide(); //hide panels
            pnl_cheeseType.Hide(); //hide panels
            pnl_MiscProducts.Show();
            pnl_misc.Hide();
            pnl_MiscProducts.Controls.Clear();

            var miscList = cheeseEntity.ExecuteStoreQuery<tblMiscProduct>("Select * FROM tblMiscProducts WHERE MiscProductDescription LIKE 'bread' ORDER BY MiscProductName ASC;", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblMiscProduct tMisc in miscList)
            {
                Button btn = new Button();// instanciate new button
                btn.Name = tMisc.MiscProductName; // assign a name
                btn.Text = tMisc.MiscProductName; //assing an id
                btn.BackColor = Control.DefaultBackColor; // background color
                btn.ForeColor = Control.DefaultForeColor; // foregruong color
                btn.Height = 47; //button height
                btn.Width = 84; // button width
                btn.Tag = tMisc; // store info from sql query
                btn.Click += new EventHandler(AddMiscQuantity); // add click event
                pnl_MiscProducts.Controls.Add(btn); // add button to panel
            }
        }

        private void btn_AD_Click(object sender, EventArgs e) // add cheese from A-D to panel
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 1 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

                foreach (tblCheese tprod in cheeselist)
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

        private void btn_EH_Click(object sender, EventArgs e) // add cheese from E-H to panel
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 2 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblCheese tprod in cheeselist)
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

        private void btn_IL_Click(object sender, EventArgs e) // add cheese from I-L to panel
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 3 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblCheese tprod in cheeselist)
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

        private void btn_MP_Click(object sender, EventArgs e) // add cheese from M-P to panel
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 4 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblCheese tprod in cheeselist)
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

        private void btn_QT_Click(object sender, EventArgs e) // cheese from Q-T to panel 
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 5 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblCheese tprod in cheeselist)
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

        private void btn_UZ_Click(object sender, EventArgs e) // add cheese from U-Z to panel
        {
            pnl_cheese.Hide(); // hide the cheese aplhabet panel
            pnl_cheeseType.Show();// display the cheese type panel
            pnl_meat.Hide();//hide the meat panel
            pnl_blank.Hide(); //hide panels
            pnl_MiscProducts.Hide(); // hide panels
            pnl_cheeseType.Controls.Clear();
            var cheeselist = cheeseEntity.ExecuteStoreQuery<tblCheese>("Select * FROM tblCheese WHERE cheeseGroup = 6 ORDER BY CheeseName ASC", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblCheese tprod in cheeselist)
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

        public decimal quantity; // variable for quantity
        public decimal ProdPrice; // variable for product price

        protected void AddCheeseQuantity(object sender, EventArgs e) // add cheese to grid
        {
            Button btn = (Button)sender; // instanciate button
            tblCheese c = (tblCheese)btn.Tag; // asign c value of tag
            frmQty frm = new frmQty(quantity);
            frm.ShowDialog();
            quantity = frm.Quantity;
            ProdPrice = quantity * (decimal)c.CheeseRetailPrice;
            gridTrans.Rows.Add(c.CheeseName, quantity, String.Format("{0:c}", ProdPrice)); // popualate the datagridview
            int CurRow = gridTrans.Rows.Count - 2; // value of current row
            gridTrans.CurrentCell = this.gridTrans[2, CurRow]; //sets selected value of gridiew to last added.
            TransactionTotal += ProdPrice; //add value to total
        }

        protected void AddMeatQuantity(object sender, EventArgs e) //add meat to grid
        {
            Button btn = (Button)sender; // instanciate button
            tblMeat m = (tblMeat)btn.Tag; // asign c value of tag
            frmQty frm = new frmQty(quantity);
            frm.ShowDialog();
            quantity = frm.Quantity;
            ProdPrice = quantity * (decimal)m.MeatRetailPrice;
            gridTrans.Rows.Add(m.MeatName,quantity,String.Format("{0:c}",ProdPrice)); // popualate the datagridview
            int CurRow = gridTrans.Rows.Count - 2; // value of current row
            gridTrans.CurrentCell = this.gridTrans[2,CurRow]; //sets selected value of gridiew to last added.
            TransactionTotal += ProdPrice; //add value to total
        }

        protected void AddMiscQuantity(object sender, EventArgs e) // add misc to grid
        {
            Button btn = (Button)sender; // instanciate button
            tblMiscProduct m = (tblMiscProduct)btn.Tag; // asign c value of tag
            frmQty frm = new frmQty(quantity);
            frm.ShowDialog();
            quantity = frm.Quantity;
            ProdPrice = quantity * (decimal)m.MiscProductRetailPrice;
            gridTrans.Rows.Add(m.MiscProductName, quantity, String.Format("{0:c}", ProdPrice)); // popualate the datagridview
            int CurRow = gridTrans.Rows.Count - 2; // value of current row
            gridTrans.CurrentCell = this.gridTrans[2, CurRow]; //sets selected value of gridiew to last added.
            TransactionTotal += ProdPrice; //add value to total
        }

        private void btn_DltItem_Click(object sender, EventArgs e) // delete item button
        {
            try
            {
                string deletedPrice = gridTrans.SelectedCells[0].Value.ToString(); // get the value of current selected price
                gridTrans.Rows.RemoveAt(gridTrans.CurrentRow.Index); // remove current selected row.
                TransactionTotal = TransactionTotal - decimal.Parse(deletedPrice.TrimStart('$')); // subtract price of selcted item from total
            }
            catch // catch exception
            {
                MessageBox.Show("There is no item to delete."); // display message if there is no item to delete is not valid
                return;
            }
        }

        private void OpenTenderForm(object sender, EventArgs e) // open form to tender amount when Tender button is pressed
        {
            if (TransactionTotal == 0)
            {
                MessageBox.Show("There is no item to perfrom transaction."); // display message if there is no item to tender
            }
            else
            {
                frmPayment payment = new frmPayment();
                payment.Show();
                payment.PaymentMade += new frmPayment.PaymentMadeEvent(payment_PaymentMade); // event for validation of payment status
                payment.TransTotal = GrandTotal;
            }
        }

        void payment_PaymentMade(object sender, PaymentMadeEventArgs e) // invoke methods if payment status is true
        {
            tblTransaction transaction = new tblTransaction(); // instanciate new table to insert to databae
            transaction.TransactionDate = DateTime.Now; // add data time to database
            if (e.PaymentSuccess == true)
            {
                transaction.NetTotal = TransactionTotal; // add net total to database
                transaction.Total = GrandTotal; // add grand total to database
                if (txt_coupons.Text != "")
                { transaction.Coupons = decimal.Parse(txt_coupons.Text.TrimStart('$')); }
                if (txt_discount.Text !="")
                {transaction.Discount = decimal.Parse(txt_discount.Text.TrimStart('$'));}
                for (int i = 0; i < gridTrans.Rows.Count - 1; i++) // loop gets value of the produts in transaction box, formats and adds to the print document
                {
                    transaction.transactionItem += gridTrans[0, i].Value.ToString() + " "; // add all products that are bought
                }
                
                cheeseEntity.tblTransactions.AddObject(transaction); // insert all the data to database
                cheeseEntity.SaveChanges(); // save changes
                this.printReceipt(); //initiate print receipt method
                gridTrans.Rows.Clear(); // clear the grid
                TransactionTotal = 0; // reset transaction total
                txt_coupons.Text = "";
                txt_discount.Text = "";
            }
            
        }

        private void printReceipt() // Send to printer
        {
            PrintDialog printDialog = new PrintDialog(); // allows user to select a printer to print document.
            PrintDocument printDocument = new PrintDocument(); //defines an object to be sent to the printer
            printDialog.Document = printDocument; // gets the value of the document to be printed
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage); // event to add the elements to the document.
            DialogResult result = printDialog.ShowDialog(); // displays print dialog

            if (result == DialogResult.OK)
            {
                printDocument.Print(); // prints document if OK is pressed
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e) // Print Reciept Specifications
        {
            Graphics graphic = e.Graphics; // instanciate a graphics class
            Font font = new Font("Courier New",12); // define font definition
            float fontHeight = font.GetHeight(); // get font height
            int StartX = 10; // starting X coordinate
            int StartY = 10; // starting Y coordinate
            int offset = 40; // offset value

            graphic.DrawString("Welcome to Cheese of the World", new Font("Courier New", 18), new SolidBrush(Color.Black), StartX, StartY); // draw the welcome line

            for (int i = 0; i < gridTrans.Rows.Count - 1; i++) // loop gets value of the produts in transaction box, formats and adds to the print document
            {
                string productSName = gridTrans[0, i].Value.ToString().PadRight(30);
                string productQuantity = gridTrans[1, i].Value.ToString().PadRight(10);
                string productPrice = String.Format("{0:C}", gridTrans[2, i].Value);
                string productLine = productSName + productQuantity + productPrice;
                
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black),StartX, StartY + offset);
                offset += 15;

            }

            offset = offset + 20;
            graphic.DrawString("Net Total".PadRight(30) + String.Format("{0:C}", TransactionTotal), font, new SolidBrush(Color.Black), StartX, StartY + offset); // adds net total
            offset = offset + 20;
            graphic.DrawString("Coupon".PadRight(30) + String.Format("{0:C}", txt_coupons.Text), font, new SolidBrush(Color.Black), StartX, StartY + offset); // adds coupons
            offset = offset + 20;
            graphic.DrawString("Discount".PadRight(30) + String.Format("{0:C}", txt_discount.Text), font, new SolidBrush(Color.Black), StartX, StartY + offset); // adds discounts
            offset = offset + 20;
            graphic.DrawString("Total".PadRight(30) + String.Format("{0:C}", GrandTotal), font, new SolidBrush(Color.Black), StartX, StartY + offset); // adds grand total

        }

        private void btn_cnclOrdr_Click(object sender, EventArgs e) // clear entire order at once
        {
            gridTrans.Rows.Clear();
            TransactionTotal = 0;
        }

        private void btn_logOut_Click(object sender, EventArgs e) // log out
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void btn_otrFun_Click(object sender, EventArgs e)
        {
        }

        private void btn_coupon_Click(object sender, EventArgs e) // Use Coupon
        {
            frmCoupon coupon = new frmCoupon();
            coupon.ShowDialog();
            if (coupon.couponValue == null) // in case no coupon is selected prevents app from crashing
            {
                txt_coupons.Text = "";
            }
            else
            {
                txt_coupons.Text = String.Format("{0:c}", coupon.couponValue);
                GrandTotal = GrandTotal - decimal.Parse(txt_coupons.Text.TrimStart('$'));
            }
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            frmDiscount disct = new frmDiscount();
            disct.ShowDialog();
            if (disct.discountValue == null) // in case no discount is selected prevents app from crashing
            { 
                txt_discount.Text = "";
            }
            else
            {
                decimal? discountAmount = GrandTotal * disct.discountValue;
                txt_discount.Text = String.Format("{0:c}", discountAmount);
                GrandTotal = GrandTotal - decimal.Parse(txt_discount.Text.TrimStart('$'));
            }
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
                GrandTotal = transactionTotal;
                txt_total.Text = String.Format("{0:c}", transactionTotal);
            }
        }

        private decimal grandTotal;

        public decimal GrandTotal
        {
            get { return grandTotal; }
            set 
            { 
                grandTotal = value;
                txt_GrandTotal.Text = String.Format("{0:C}", grandTotal);
            }
        }

        private void btn_mgrFun_Click(object sender, EventArgs e)
        {
            frmManagerFuntions frm = new frmManagerFuntions();
            frm.ShowDialog();
        }

        

        
    }
}
