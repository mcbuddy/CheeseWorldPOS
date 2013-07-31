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
    public partial class frmDiscount : Form
    {
        private CheeseWorld_DatabaseEntities cheeseEntity = new CheeseWorld_DatabaseEntities();
        public frmDiscount()
        {
            InitializeComponent();
            var discountList = cheeseEntity.ExecuteStoreQuery<tblDiscount>("Select * FROM tblDiscount", null).ToList(); // databaseVariable.ExecuteStoreQuery allows traditional sql queries work

            foreach (tblDiscount d in discountList)
            {
                Button btn = new Button(); // instanciate new button
                btn.Name = d.DiscountType; // assign a name
                btn.Text = d.DiscountType; //assing an id
                btn.BackColor = Control.DefaultBackColor; // background color
                btn.ForeColor = Control.DefaultForeColor; // foregruong color
                btn.Height = 95; //button height
                btn.Width = 400; // button width
                btn.Font = new Font(btn.Font.FontFamily, 30);
                btn.Tag = d; // store info from sql query
                btn.Click += new EventHandler(AddDiscountValue); // add click event
                pnl_discountType.Controls.Add(btn); // add button to panel
                
            }
        }

        public decimal? discountValue;

        protected void AddDiscountValue(object sender, EventArgs e) // add cheese to grid
        {
            Button btn = (Button)sender; // instanciate button
            tblDiscount d = (tblDiscount)btn.Tag; // asign c value of tag
            discountValue = d.DiscountValue;
            this.Close();

        }
    }
}
