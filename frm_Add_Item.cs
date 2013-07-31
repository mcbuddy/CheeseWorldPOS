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
    public partial class frm_Add_Item : Form
    {
        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities(); //instanciate new database entities

        public frm_Add_Item()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemName.Text))

                if (!string.IsNullOrEmpty(txtType.Text))

                    if (!string.IsNullOrEmpty(txtProductProvider.Text))
                    {
                        switch (cbxCategory.Text)
                        {
                            case "Cheese":
                                int temp = addcheese();
                                if (temp == 1)
                                {
                                    this.Close();
                                }
                                break;
                            case "Meat":
                                int temp1 = addMeat();
                                if (temp1 == 1)
                                {
                                    this.Close();
                                }
                                break;
                            case "Misc":
                                int temp3 = addMisc();
                                if (temp3 == 1)
                                {
                                    this.Close();
                                }
                                break;
                            default:
                                MessageBox.Show("The Category can not be null Please choose a Category.");
                                ClearTextBoxes();
                                break;
                        }
                    }
                    else
                        MessageBox.Show("The Product Provider is null Please type a Product Provider.");
                else
                    MessageBox.Show("The Product type is null Please type a Product type.");
            else
                MessageBox.Show("The Item name is null Please type a Item Name.");
        }
        public int addcheese()
        {
            //convertion of value to be supported by the database type

            decimal item = ConvertStringDecimal(txtItemQuantity.Text);
            decimal rprice = ConvertStringDecimal(txtRetailPrice.Text);
            decimal cprice = ConvertStringDecimal(txtPrice.Text);

            if (item <= 0 || rprice <= 0 || cprice <= 0)
            {
                MessageBox.Show("The one of the fallowing field is invalid. Item quantity, retail price or price plese double check");
                return 0;
            }
            else
            {
                DateTime dt = Convert.ToDateTime(txtDateOfPurchase.Text);
                //initiated the new cheese table
                tblCheese newcheese = new tblCheese();

                //assigned values to the table cheese
                newcheese.CheeseName = txtItemName.Text;
                newcheese.CheeseType = txtType.Text;
                newcheese.CheeseQuantity = item; ;
                newcheese.CheeseProvider = txtProductProvider.Text;
                newcheese.CheesePurchaseDate = dt;
                newcheese.CheeseRetailPrice = rprice;
                newcheese.CheeseCostPrice = cprice;
                newcheese.CheeseDescription = rtbFullDesc.Text;

                //select the cheese group

                switch (cbxgroup.Text)
                {
                    case "A-D":
                        newcheese.CheeseGroup = 1;
                        break;
                    case "E-H":
                        newcheese.CheeseGroup = 2;
                        break;
                    case "I-L":
                        newcheese.CheeseGroup = 3;
                        break;
                    case "M-P":
                        newcheese.CheeseGroup = 4;
                        break;
                    case "Q-T":
                        newcheese.CheeseGroup = 5;
                        break;
                    case "U-Z":
                        newcheese.CheeseGroup = 6;
                        break;
                }
                //add and save the changes to the cheese table
                cheeseEntity.tblCheese.AddObject(newcheese);
                cheeseEntity.SaveChanges();
                MessageBox.Show("The new Item was Add it to the Cheese table.");
                return 1;
            }
        }
        public int addMeat()
        {
            //convertion of value to be supported by the database type

            decimal item = ConvertStringDecimal(txtItemQuantity.Text);
            decimal rprice = ConvertStringDecimal(txtRetailPrice.Text);
            decimal cprice = ConvertStringDecimal(txtPrice.Text);

            if (item <= 0 || rprice <= 0 || cprice <= 0)
            {
                MessageBox.Show("The one of the fallowing field is invalid. Item quantity, retail price or price plese double check");
                return 0;
            }
            else
            {
                DateTime dt = Convert.ToDateTime(txtDateOfPurchase.Text);
                //initiated the new cheese table
                tblMeat newMeat = new tblMeat();

                //assigned values to the table cheese
                newMeat.MeatName = txtItemName.Text;
                newMeat.MeatType = txtType.Text;
                newMeat.MeatQuantity = item; ;
                newMeat.MeatProvider = txtProductProvider.Text;
                newMeat.MeatPurchaseDate = dt;
                newMeat.MeatRetailPrice = rprice;
                newMeat.MeatCostPrice = cprice;
                newMeat.MeatDescription = rtbFullDesc.Text;

                //add and save the changes to the cheese table
                cheeseEntity.tblMeats.AddObject(newMeat);
                cheeseEntity.SaveChanges();
                MessageBox.Show("The new Item was Add it to the Meat table.");
                return 1;
            }
        }
        public int addMisc()
        {
            //convertion of value to be supported by the database type

            decimal item = ConvertStringDecimal(txtItemQuantity.Text);
            decimal rprice = ConvertStringDecimal(txtRetailPrice.Text);
            decimal cprice = ConvertStringDecimal(txtPrice.Text);

            if (item <= 0 || rprice <= 0 || cprice <= 0)
            {
                MessageBox.Show("The one of the fallowing field is invalid. Item quantity, retail price or price plese double check");
                return 0;
            }
            else
            {
                DateTime dt = Convert.ToDateTime(txtDateOfPurchase.Text);
                //initiated the new cheese table
                tblMiscProduct newMisc = new tblMiscProduct();

                //assigned values to the table cheese
                newMisc.MiscProductName = txtItemName.Text;
                newMisc.MiscProductType = txtType.Text;
                newMisc.MiscProductQuantity = item; ;
                newMisc.MiscProductProvider = txtProductProvider.Text;
                newMisc.MiscProductPurchaseDate = dt;
                newMisc.MiscProductRetailPrice = rprice;
                newMisc.MiscProductCostPrice = cprice;
                newMisc.MiscProductDescription = rtbFullDesc.Text;

                //add and save the changes to the cheese table
                cheeseEntity.tblMiscProducts.AddObject(newMisc);
                cheeseEntity.SaveChanges();
                MessageBox.Show("The new Item was Add it to the Misc table.");
                return 1;
            }
        }
        public decimal ConvertStringDecimal(string stringVal)
        {
            decimal decimalVal = 0;

            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);
            }
            catch (System.OverflowException)
            {
                return (-2);
            }
            catch (System.FormatException)
            {
                return (-1);
            }
            catch (System.ArgumentNullException)
            {
                return (0);
            }
            return (decimalVal);
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            rtbFullDesc.Text = " ";
            func(Controls);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Add_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
