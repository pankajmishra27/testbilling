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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_deletecustomerdetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.lst_customerdetails.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_customerdetails.FullRowSelect = true;
            this.lst_customerdetails.GridLines = true;
            this.lst_customerdetails.Location = new System.Drawing.Point(7, 26);
            this.lst_customerdetails.Margin = new System.Windows.Forms.Padding(4);
            this.lst_customerdetails.Name = "lst_customerdetails";
            this.lst_customerdetails.Size = new System.Drawing.Size(893, 396);
            this.lst_customerdetails.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            this.Date.Width = 140;
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_addcustomer.Image = global::ShopProducts.Properties.Resources._2;
            this.btn_addcustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addcustomer.Location = new System.Drawing.Point(592, 430);
            this.btn_addcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(98, 39);
            this.btn_addcustomer.TabIndex = 1;
            this.btn_addcustomer.Text = "Add";
            this.btn_addcustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addcustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_deletecustomerdetails);
            this.groupBox1.Controls.Add(this.lst_customerdetails);
            this.groupBox1.Controls.Add(this.btn_addcustomer);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer List";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ShopProducts.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(808, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deletecustomerdetails
            // 
            this.btn_deletecustomerdetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletecustomerdetails.ForeColor = System.Drawing.Color.Black;
            this.btn_deletecustomerdetails.Image = global::ShopProducts.Properties.Resources._3;
            this.btn_deletecustomerdetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_deletecustomerdetails.Location = new System.Drawing.Point(697, 429);
            this.btn_deletecustomerdetails.Name = "btn_deletecustomerdetails";
            this.btn_deletecustomerdetails.Size = new System.Drawing.Size(105, 38);
            this.btn_deletecustomerdetails.TabIndex = 2;
            this.btn_deletecustomerdetails.Text = "Delete";
            this.btn_deletecustomerdetails.UseVisualStyleBackColor = true;
            this.btn_deletecustomerdetails.Click += new System.EventHandler(this.btn_deletecustomerdetails_Click);
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.blue_wallpaper_plain;
            this.ClientSize = new System.Drawing.Size(919, 487);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerDetails";
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_deletecustomerdetails;
    }
}