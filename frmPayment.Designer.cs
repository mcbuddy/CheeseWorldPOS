namespace CheeseWorldPOS
{
    partial class frmPayment
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
            this.pnl_qty = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.pnl_qty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_qty
            // 
            this.pnl_qty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_qty.Controls.Add(this.label2);
            this.pnl_qty.Controls.Add(this.txtTransTotal);
            this.pnl_qty.Controls.Add(this.label1);
            this.pnl_qty.Controls.Add(this.btn_00);
            this.pnl_qty.Controls.Add(this.btn_enter);
            this.pnl_qty.Controls.Add(this.btn_0);
            this.pnl_qty.Controls.Add(this.btn_point);
            this.pnl_qty.Controls.Add(this.btn_clear);
            this.pnl_qty.Controls.Add(this.btn_3);
            this.pnl_qty.Controls.Add(this.txt_payment);
            this.pnl_qty.Controls.Add(this.btn_2);
            this.pnl_qty.Controls.Add(this.btn_7);
            this.pnl_qty.Controls.Add(this.btn_1);
            this.pnl_qty.Controls.Add(this.btn_8);
            this.pnl_qty.Controls.Add(this.btn_6);
            this.pnl_qty.Controls.Add(this.btn_9);
            this.pnl_qty.Controls.Add(this.btn_5);
            this.pnl_qty.Controls.Add(this.btn_4);
            this.pnl_qty.Location = new System.Drawing.Point(13, 13);
            this.pnl_qty.Name = "pnl_qty";
            this.pnl_qty.Size = new System.Drawing.Size(409, 400);
            this.pnl_qty.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Total Amount:";
            // 
            // txtTransTotal
            // 
            this.txtTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransTotal.Location = new System.Drawing.Point(191, 24);
            this.txtTransTotal.Name = "txtTransTotal";
            this.txtTransTotal.ReadOnly = true;
            this.txtTransTotal.Size = new System.Drawing.Size(192, 47);
            this.txtTransTotal.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tender Amount:";
            // 
            // btn_00
            // 
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.Location = new System.Drawing.Point(49, 307);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(60, 50);
            this.btn_00.TabIndex = 47;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.btn_00_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(258, 139);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(96, 47);
            this.btn_enter.TabIndex = 46;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.transactionFinished);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(115, 307);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 50);
            this.btn_0.TabIndex = 45;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(181, 307);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(60, 50);
            this.btn_point.TabIndex = 44;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(258, 195);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 47);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(181, 251);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 50);
            this.btn_3.TabIndex = 42;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(191, 77);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(192, 47);
            this.txt_payment.TabIndex = 33;
            this.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(115, 251);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 50);
            this.btn_2.TabIndex = 41;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(49, 139);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 50);
            this.btn_7.TabIndex = 34;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(49, 251);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 50);
            this.btn_1.TabIndex = 40;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(115, 139);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 50);
            this.btn_8.TabIndex = 35;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(181, 195);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 50);
            this.btn_6.TabIndex = 39;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(181, 139);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 50);
            this.btn_9.TabIndex = 36;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(115, 195);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 50);
            this.btn_5.TabIndex = 38;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(49, 195);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 50);
            this.btn_4.TabIndex = 37;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(437, 426);
            this.Controls.Add(this.pnl_qty);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Amount to Pay";
            this.pnl_qty.ResumeLayout(false);
            this.pnl_qty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_qty;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransTotal;
    }
}