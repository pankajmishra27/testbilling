namespace ShopProducts.Forms
{
    partial class frmCustomerDetails
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
            this.lst_customerdetails = new System.Windows.Forms.ListView();
            this.customer_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer_contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_customerdetails
            // 
            this.lst_customerdetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customer_id,
            this.customer_name,
            this.customer_address,
            this.customer_contact,
            this.Date});
            this.lst_customerdetails.GridLines = true;
            this.lst_customerdetails.Location = new System.Drawing.Point(-1, 0);
            this.lst_customerdetails.Name = "lst_customerdetails";
            this.lst_customerdetails.Size = new System.Drawing.Size(876, 359);
            this.lst_customerdetails.TabIndex = 0;
            this.lst_customerdetails.UseCompatibleStateImageBehavior = false;
            this.lst_customerdetails.View = System.Windows.Forms.View.Details;
            // 
            // customer_id
            // 
            this.customer_id.Text = "Customer Id";
            this.customer_id.Width = 100;
            // 
            // customer_name
            // 
            this.customer_name.Text = "Customer Name";
            this.customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customer_name.Width = 197;
            // 
            // customer_address
            // 
            this.customer_address.Text = "Customer Address";
            this.customer_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customer_address.Width = 281;
            // 
            // customer_contact
            // 
            this.customer_contact.Text = "Customer Contact";
            this.customer_contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customer_contact.Width = 171;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 122;
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Location = new System.Drawing.Point(407, 401);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_addcustomer.TabIndex = 1;
            this.btn_addcustomer.Text = "Add";
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 456);
            this.Controls.Add(this.btn_addcustomer);
            this.Controls.Add(this.lst_customerdetails);
            this.Name = "frmCustomerDetails";
            this.Text = "frmCustomerDetails";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_customerdetails;
        private System.Windows.Forms.ColumnHeader customer_id;
        private System.Windows.Forms.ColumnHeader customer_name;
        private System.Windows.Forms.ColumnHeader customer_address;
        private System.Windows.Forms.ColumnHeader customer_contact;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button btn_addcustomer;
    }
}