namespace CheeseWorldPOS
{
    partial class frmTransaction_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_totalDisplay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.txt_coupons = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_blank = new System.Windows.Forms.Panel();
            this.btn_tender = new System.Windows.Forms.Button();
            this.btn_DltItem = new System.Windows.Forms.Button();
            this.btn_cnclOrdr = new System.Windows.Forms.Button();
            this.btn_otrFun = new System.Windows.Forms.Button();
            this.btn_mgrFun = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_misc = new System.Windows.Forms.Button();
            this.btn_meat = new System.Windows.Forms.Button();
            this.btn_cheese = new System.Windows.Forms.Button();
            this.cheeseWorldTestEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_meat = new System.Windows.Forms.FlowLayoutPanel();
            this.cheeseWorld_TestDatabaseDataSet = new CheeseWorldPOS.CheeseWorld_TestDatabaseDataSet();
            this.gridTrans = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_cheese = new System.Windows.Forms.Panel();
            this.btn_UZ = new System.Windows.Forms.Button();
            this.btn_QT = new System.Windows.Forms.Button();
            this.btn_MP = new System.Windows.Forms.Button();
            this.btn_IL = new System.Windows.Forms.Button();
            this.btn_EH = new System.Windows.Forms.Button();
            this.btn_AD = new System.Windows.Forms.Button();
            this.pnl_cheeseType = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_MiscProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_misc = new System.Windows.Forms.Panel();
            this.btn_drinks = new System.Windows.Forms.Button();
            this.btn_bread = new System.Windows.Forms.Button();
            this.btn_cracker = new System.Windows.Forms.Button();
            this.btn_chips = new System.Windows.Forms.Button();
            this.btn_coupon = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.pnl_totalDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseWorldTestEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseWorld_TestDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).BeginInit();
            this.pnl_cheese.SuspendLayout();
            this.pnl_misc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_totalDisplay
            // 
            this.pnl_totalDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_totalDisplay.Controls.Add(this.label3);
            this.pnl_totalDisplay.Controls.Add(this.Discount);
            this.pnl_totalDisplay.Controls.Add(this.label2);
            this.pnl_totalDisplay.Controls.Add(this.label1);
            this.pnl_totalDisplay.Controls.Add(this.txt_GrandTotal);
            this.pnl_totalDisplay.Controls.Add(this.txt_coupons);
            this.pnl_totalDisplay.Controls.Add(this.txt_discount);
            this.pnl_totalDisplay.Controls.Add(this.txt_tax);
            this.pnl_totalDisplay.Controls.Add(this.total);
            this.pnl_totalDisplay.Controls.Add(this.txt_total);
            this.pnl_totalDisplay.Location = new System.Drawing.Point(519, 328);
            this.pnl_totalDisplay.Name = "pnl_totalDisplay";
            this.pnl_totalDisplay.Size = new System.Drawing.Size(253, 116);
            this.pnl_totalDisplay.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tax:";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(95, 52);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(52, 13);
            this.Discount.TabIndex = 9;
            this.Discount.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coupons:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Net Total:";
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.Location = new System.Drawing.Point(150, 92);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.ReadOnly = true;
            this.txt_GrandTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_GrandTotal.TabIndex = 6;
            // 
            // txt_coupons
            // 
            this.txt_coupons.Location = new System.Drawing.Point(150, 25);
            this.txt_coupons.Name = "txt_coupons";
            this.txt_coupons.ReadOnly = true;
            this.txt_coupons.Size = new System.Drawing.Size(100, 20);
            this.txt_coupons.TabIndex = 5;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(150, 47);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 4;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(150, 70);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.ReadOnly = true;
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 3;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(113, 99);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(34, 13);
            this.total.TabIndex = 2;
            this.total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(150, 3);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 418);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 47);
            this.btn_exit.TabIndex = 46;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_blank
            // 
            this.pnl_blank.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_blank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_blank.Location = new System.Drawing.Point(112, 44);
            this.pnl_blank.Name = "pnl_blank";
            this.pnl_blank.Size = new System.Drawing.Size(400, 400);
            this.pnl_blank.TabIndex = 45;
            // 
            // btn_tender
            // 
            this.btn_tender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tender.Location = new System.Drawing.Point(688, 471);
            this.btn_tender.Name = "btn_tender";
            this.btn_tender.Size = new System.Drawing.Size(84, 47);
            this.btn_tender.TabIndex = 44;
            this.btn_tender.Text = "Tender";
            this.btn_tender.UseVisualStyleBackColor = true;
            this.btn_tender.Click += new System.EventHandler(this.OpenTenderForm);
            // 
            // btn_DltItem
            // 
            this.btn_DltItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DltItem.Location = new System.Drawing.Point(598, 471);
            this.btn_DltItem.Name = "btn_DltItem";
            this.btn_DltItem.Size = new System.Drawing.Size(84, 47);
            this.btn_DltItem.TabIndex = 43;
            this.btn_DltItem.Text = "Delete Item";
            this.btn_DltItem.UseVisualStyleBackColor = true;
            this.btn_DltItem.Click += new System.EventHandler(this.btn_DltItem_Click);
            // 
            // btn_cnclOrdr
            // 
            this.btn_cnclOrdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnclOrdr.Location = new System.Drawing.Point(508, 471);
            this.btn_cnclOrdr.Name = "btn_cnclOrdr";
            this.btn_cnclOrdr.Size = new System.Drawing.Size(84, 47);
            this.btn_cnclOrdr.TabIndex = 42;
            this.btn_cnclOrdr.Text = "Cancel Order";
            this.btn_cnclOrdr.UseVisualStyleBackColor = true;
            this.btn_cnclOrdr.Click += new System.EventHandler(this.btn_cnclOrdr_Click);
            // 
            // btn_otrFun
            // 
            this.btn_otrFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_otrFun.Location = new System.Drawing.Point(418, 471);
            this.btn_otrFun.Name = "btn_otrFun";
            this.btn_otrFun.Size = new System.Drawing.Size(84, 47);
            this.btn_otrFun.TabIndex = 41;
            this.btn_otrFun.Text = "Other Functions";
            this.btn_otrFun.UseVisualStyleBackColor = true;
            this.btn_otrFun.Click += new System.EventHandler(this.btn_otrFun_Click);
            // 
            // btn_mgrFun
            // 
            this.btn_mgrFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mgrFun.Location = new System.Drawing.Point(112, 471);
            this.btn_mgrFun.Name = "btn_mgrFun";
            this.btn_mgrFun.Size = new System.Drawing.Size(84, 47);
            this.btn_mgrFun.TabIndex = 40;
            this.btn_mgrFun.Text = "Manager Functions";
            this.btn_mgrFun.UseVisualStyleBackColor = true;
            this.btn_mgrFun.Click += new System.EventHandler(this.btn_mgrFun_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.Location = new System.Drawing.Point(12, 471);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(84, 47);
            this.btn_logOut.TabIndex = 39;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_misc
            // 
            this.btn_misc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_misc.Location = new System.Drawing.Point(12, 186);
            this.btn_misc.Name = "btn_misc";
            this.btn_misc.Size = new System.Drawing.Size(84, 47);
            this.btn_misc.TabIndex = 38;
            this.btn_misc.Text = "Misc.";
            this.btn_misc.UseVisualStyleBackColor = true;
            this.btn_misc.Click += new System.EventHandler(this.btn_misc_Click);
            // 
            // btn_meat
            // 
            this.btn_meat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meat.Location = new System.Drawing.Point(12, 113);
            this.btn_meat.Name = "btn_meat";
            this.btn_meat.Size = new System.Drawing.Size(84, 47);
            this.btn_meat.TabIndex = 37;
            this.btn_meat.Text = "Meat";
            this.btn_meat.UseVisualStyleBackColor = true;
            this.btn_meat.Click += new System.EventHandler(this.btn_meat_Click);
            // 
            // btn_cheese
            // 
            this.btn_cheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cheese.Location = new System.Drawing.Point(12, 44);
            this.btn_cheese.Name = "btn_cheese";
            this.btn_cheese.Size = new System.Drawing.Size(84, 47);
            this.btn_cheese.TabIndex = 36;
            this.btn_cheese.Text = "Cheese";
            this.btn_cheese.UseVisualStyleBackColor = true;
            this.btn_cheese.Click += new System.EventHandler(this.btn_cheese_Click);
            // 
            // cheeseWorldTestEntitiesBindingSource
            // 
            this.cheeseWorldTestEntitiesBindingSource.DataSource = typeof(CheeseWorldPOS.CheeseWorld_DatabaseEntities);
            // 
            // pnl_meat
            // 
            this.pnl_meat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_meat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_meat.Location = new System.Drawing.Point(112, 44);
            this.pnl_meat.Name = "pnl_meat";
            this.pnl_meat.Size = new System.Drawing.Size(400, 400);
            this.pnl_meat.TabIndex = 0;
            // 
            // cheeseWorld_TestDatabaseDataSet
            // 
            this.cheeseWorld_TestDatabaseDataSet.DataSetName = "CheeseWorld_TestDatabaseDataSet";
            this.cheeseWorld_TestDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridTrans
            // 
            this.gridTrans.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantiy,
            this.Price});
            this.gridTrans.Location = new System.Drawing.Point(519, 44);
            this.gridTrans.Name = "gridTrans";
            this.gridTrans.ReadOnly = true;
            this.gridTrans.Size = new System.Drawing.Size(253, 281);
            this.gridTrans.TabIndex = 49;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantiy
            // 
            this.Quantiy.HeaderText = "Quantity";
            this.Quantiy.Name = "Quantiy";
            this.Quantiy.ReadOnly = true;
            this.Quantiy.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // pnl_cheese
            // 
            this.pnl_cheese.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_cheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_cheese.Controls.Add(this.btn_UZ);
            this.pnl_cheese.Controls.Add(this.btn_QT);
            this.pnl_cheese.Controls.Add(this.btn_MP);
            this.pnl_cheese.Controls.Add(this.btn_IL);
            this.pnl_cheese.Controls.Add(this.btn_EH);
            this.pnl_cheese.Controls.Add(this.btn_AD);
            this.pnl_cheese.Location = new System.Drawing.Point(112, 44);
            this.pnl_cheese.Name = "pnl_cheese";
            this.pnl_cheese.Size = new System.Drawing.Size(400, 400);
            this.pnl_cheese.TabIndex = 50;
            // 
            // btn_UZ
            // 
            this.btn_UZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UZ.Location = new System.Drawing.Point(277, 98);
            this.btn_UZ.Name = "btn_UZ";
            this.btn_UZ.Size = new System.Drawing.Size(84, 47);
            this.btn_UZ.TabIndex = 14;
            this.btn_UZ.Text = "U - Z";
            this.btn_UZ.UseVisualStyleBackColor = true;
            this.btn_UZ.Click += new System.EventHandler(this.btn_UZ_Click);
            // 
            // btn_QT
            // 
            this.btn_QT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QT.Location = new System.Drawing.Point(142, 98);
            this.btn_QT.Name = "btn_QT";
            this.btn_QT.Size = new System.Drawing.Size(84, 47);
            this.btn_QT.TabIndex = 13;
            this.btn_QT.Text = "Q - T";
            this.btn_QT.UseVisualStyleBackColor = true;
            this.btn_QT.Click += new System.EventHandler(this.btn_QT_Click);
            // 
            // btn_MP
            // 
            this.btn_MP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MP.Location = new System.Drawing.Point(13, 98);
            this.btn_MP.Name = "btn_MP";
            this.btn_MP.Size = new System.Drawing.Size(84, 47);
            this.btn_MP.TabIndex = 12;
            this.btn_MP.Text = "M - P";
            this.btn_MP.UseVisualStyleBackColor = true;
            this.btn_MP.Click += new System.EventHandler(this.btn_MP_Click);
            // 
            // btn_IL
            // 
            this.btn_IL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IL.Location = new System.Drawing.Point(277, 16);
            this.btn_IL.Name = "btn_IL";
            this.btn_IL.Size = new System.Drawing.Size(84, 47);
            this.btn_IL.TabIndex = 11;
            this.btn_IL.Text = "I - L";
            this.btn_IL.UseVisualStyleBackColor = true;
            this.btn_IL.Click += new System.EventHandler(this.btn_IL_Click);
            // 
            // btn_EH
            // 
            this.btn_EH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EH.Location = new System.Drawing.Point(142, 16);
            this.btn_EH.Name = "btn_EH";
            this.btn_EH.Size = new System.Drawing.Size(84, 47);
            this.btn_EH.TabIndex = 11;
            this.btn_EH.Text = "E - H";
            this.btn_EH.UseVisualStyleBackColor = true;
            this.btn_EH.Click += new System.EventHandler(this.btn_EH_Click);
            // 
            // btn_AD
            // 
            this.btn_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AD.Location = new System.Drawing.Point(13, 16);
            this.btn_AD.Name = "btn_AD";
            this.btn_AD.Size = new System.Drawing.Size(84, 47);
            this.btn_AD.TabIndex = 10;
            this.btn_AD.Text = "A - D";
            this.btn_AD.UseVisualStyleBackColor = true;
            this.btn_AD.Click += new System.EventHandler(this.btn_AD_Click);
            // 
            // pnl_cheeseType
            // 
            this.pnl_cheeseType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_cheeseType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_cheeseType.Location = new System.Drawing.Point(112, 44);
            this.pnl_cheeseType.Name = "pnl_cheeseType";
            this.pnl_cheeseType.Size = new System.Drawing.Size(400, 400);
            this.pnl_cheeseType.TabIndex = 51;
            // 
            // pnl_MiscProducts
            // 
            this.pnl_MiscProducts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_MiscProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_MiscProducts.Location = new System.Drawing.Point(112, 44);
            this.pnl_MiscProducts.Name = "pnl_MiscProducts";
            this.pnl_MiscProducts.Size = new System.Drawing.Size(400, 400);
            this.pnl_MiscProducts.TabIndex = 52;
            // 
            // pnl_misc
            // 
            this.pnl_misc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_misc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_misc.Controls.Add(this.btn_drinks);
            this.pnl_misc.Controls.Add(this.btn_bread);
            this.pnl_misc.Controls.Add(this.btn_cracker);
            this.pnl_misc.Controls.Add(this.btn_chips);
            this.pnl_misc.Location = new System.Drawing.Point(112, 44);
            this.pnl_misc.Name = "pnl_misc";
            this.pnl_misc.Size = new System.Drawing.Size(400, 400);
            this.pnl_misc.TabIndex = 53;
            // 
            // btn_drinks
            // 
            this.btn_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drinks.Location = new System.Drawing.Point(131, 18);
            this.btn_drinks.Name = "btn_drinks";
            this.btn_drinks.Size = new System.Drawing.Size(93, 47);
            this.btn_drinks.TabIndex = 57;
            this.btn_drinks.Text = "Drinks";
            this.btn_drinks.UseVisualStyleBackColor = true;
            this.btn_drinks.Click += new System.EventHandler(this.btn_drinks_Click);
            // 
            // btn_bread
            // 
            this.btn_bread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bread.Location = new System.Drawing.Point(13, 98);
            this.btn_bread.Name = "btn_bread";
            this.btn_bread.Size = new System.Drawing.Size(93, 47);
            this.btn_bread.TabIndex = 56;
            this.btn_bread.Text = "Bread";
            this.btn_bread.UseVisualStyleBackColor = true;
            this.btn_bread.Click += new System.EventHandler(this.btn_bread_Click);
            // 
            // btn_cracker
            // 
            this.btn_cracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cracker.Location = new System.Drawing.Point(251, 18);
            this.btn_cracker.Name = "btn_cracker";
            this.btn_cracker.Size = new System.Drawing.Size(93, 47);
            this.btn_cracker.TabIndex = 55;
            this.btn_cracker.Text = "Crackers";
            this.btn_cracker.UseVisualStyleBackColor = true;
            // 
            // btn_chips
            // 
            this.btn_chips.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chips.Location = new System.Drawing.Point(13, 16);
            this.btn_chips.Name = "btn_chips";
            this.btn_chips.Size = new System.Drawing.Size(93, 47);
            this.btn_chips.TabIndex = 54;
            this.btn_chips.Text = "Chips";
            this.btn_chips.UseVisualStyleBackColor = true;
            this.btn_chips.Click += new System.EventHandler(this.btn_chips_Click);
            // 
            // btn_coupon
            // 
            this.btn_coupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coupon.Location = new System.Drawing.Point(238, 471);
            this.btn_coupon.Name = "btn_coupon";
            this.btn_coupon.Size = new System.Drawing.Size(84, 47);
            this.btn_coupon.TabIndex = 54;
            this.btn_coupon.Text = "Coupons";
            this.btn_coupon.UseVisualStyleBackColor = true;
            this.btn_coupon.Click += new System.EventHandler(this.btn_coupon_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discount.Location = new System.Drawing.Point(328, 471);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(84, 47);
            this.btn_discount.TabIndex = 55;
            this.btn_discount.Text = "Discounts";
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Operator:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(594, 22);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(0, 20);
            this.lblEmpName.TabIndex = 57;
            // 
            // frmTransaction_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_discount);
            this.Controls.Add(this.btn_coupon);
            this.Controls.Add(this.pnl_misc);
            this.Controls.Add(this.pnl_cheese);
            this.Controls.Add(this.pnl_cheeseType);
            this.Controls.Add(this.gridTrans);
            this.Controls.Add(this.pnl_MiscProducts);
            this.Controls.Add(this.pnl_totalDisplay);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_meat);
            this.Controls.Add(this.pnl_blank);
            this.Controls.Add(this.btn_tender);
            this.Controls.Add(this.btn_DltItem);
            this.Controls.Add(this.btn_cnclOrdr);
            this.Controls.Add(this.btn_otrFun);
            this.Controls.Add(this.btn_mgrFun);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_misc);
            this.Controls.Add(this.btn_meat);
            this.Controls.Add(this.btn_cheese);
            this.Name = "frmTransaction_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Home Page";
            this.pnl_totalDisplay.ResumeLayout(false);
            this.pnl_totalDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseWorldTestEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseWorld_TestDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrans)).EndInit();
            this.pnl_cheese.ResumeLayout(false);
            this.pnl_misc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_totalDisplay;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_blank;
        private System.Windows.Forms.Button btn_tender;
        private System.Windows.Forms.Button btn_DltItem;
        private System.Windows.Forms.Button btn_cnclOrdr;
        private System.Windows.Forms.Button btn_otrFun;
        private System.Windows.Forms.Button btn_mgrFun;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_misc;
        private System.Windows.Forms.Button btn_meat;
        private System.Windows.Forms.Button btn_cheese;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.BindingSource cheeseWorldTestEntitiesBindingSource;
        private System.Windows.Forms.FlowLayoutPanel pnl_meat;
        private CheeseWorld_TestDatabaseDataSet cheeseWorld_TestDatabaseDataSet;
        private System.Windows.Forms.DataGridView gridTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel pnl_cheese;
        private System.Windows.Forms.Button btn_UZ;
        private System.Windows.Forms.Button btn_QT;
        private System.Windows.Forms.Button btn_MP;
        private System.Windows.Forms.Button btn_IL;
        private System.Windows.Forms.Button btn_EH;
        private System.Windows.Forms.Button btn_AD;
        private System.Windows.Forms.FlowLayoutPanel pnl_cheeseType;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.FlowLayoutPanel pnl_MiscProducts;
        private System.Windows.Forms.Panel pnl_misc;
        private System.Windows.Forms.Button btn_chips;
        private System.Windows.Forms.Button btn_drinks;
        private System.Windows.Forms.Button btn_bread;
        private System.Windows.Forms.Button btn_cracker;
        private System.Windows.Forms.Button btn_coupon;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.TextBox txt_coupons;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GrandTotal;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmpName;
    }
}