namespace CheeseWorldPOS
{
    partial class frmDiscount
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
            this.pnl_discountType = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnl_discountType
            // 
            this.pnl_discountType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_discountType.Location = new System.Drawing.Point(12, 12);
            this.pnl_discountType.Name = "pnl_discountType";
            this.pnl_discountType.Size = new System.Drawing.Size(403, 402);
            this.pnl_discountType.TabIndex = 0;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(427, 426);
            this.Controls.Add(this.pnl_discountType);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Type of Discount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_discountType;
    }
}