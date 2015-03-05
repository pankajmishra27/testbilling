namespace ShopProducts.Forms
{
    partial class frmInvoicemainDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btn_subproductdetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstviewinvoicemain = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoiceno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicedate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicecustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoiceaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicecustomerid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicechequeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicecbank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsubproduct = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btn_subproductdetails);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstviewinvoicemain);
            this.groupBox1.Controls.Add(this.btnsubproduct);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 465);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = global::ShopProducts.Properties.Resources._2;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(811, 421);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 38);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btn_subproductdetails
            // 
            this.btn_subproductdetails.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subproductdetails.ForeColor = System.Drawing.Color.Black;
            this.btn_subproductdetails.Image = global::ShopProducts.Properties.Resources._3;
            this.btn_subproductdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_subproductdetails.Location = new System.Drawing.Point(1009, 419);
            this.btn_subproductdetails.Name = "btn_subproductdetails";
            this.btn_subproductdetails.Size = new System.Drawing.Size(88, 37);
            this.btn_subproductdetails.TabIndex = 8;
            this.btn_subproductdetails.Text = "Delete";
            this.btn_subproductdetails.UseVisualStyleBackColor = true;
            this.btn_subproductdetails.Click += new System.EventHandler(this.btn_subproductdetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // lstviewinvoicemain
            // 
            this.lstviewinvoicemain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.invoiceno,
            this.invoicedate,
            this.invoicecustomer,
            this.invoiceaddress,
            this.invoicecustomerid,
            this.invoicechequeno,
            this.invoicecbank,
            this.date});
            this.lstviewinvoicemain.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstviewinvoicemain.FullRowSelect = true;
            this.lstviewinvoicemain.GridLines = true;
            this.lstviewinvoicemain.Location = new System.Drawing.Point(15, 51);
            this.lstviewinvoicemain.Name = "lstviewinvoicemain";
            this.lstviewinvoicemain.Size = new System.Drawing.Size(1079, 354);
            this.lstviewinvoicemain.TabIndex = 0;
            this.lstviewinvoicemain.UseCompatibleStateImageBehavior = false;
            this.lstviewinvoicemain.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Inv Id";
            this.Id.Width = 84;
            // 
            // invoiceno
            // 
            this.invoiceno.Text = "Invoice No";
            this.invoiceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.invoiceno.Width = 111;
            // 
            // invoicedate
            // 
            this.invoicedate.Text = "Invoice Date";
            this.invoicedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.invoicedate.Width = 142;
            // 
            // invoicecustomer
            // 
            this.invoicecustomer.Text = "Invoice Customer";
            this.invoicecustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.invoicecustomer.Width = 150;
            // 
            // invoiceaddress
            // 
            this.invoiceaddress.Text = "Invoice Address";
            this.invoiceaddress.Width = 129;
            // 
            // invoicecustomerid
            // 
            this.invoicecustomerid.Text = "Invoice Customer Id";
            this.invoicecustomerid.Width = 132;
            // 
            // invoicechequeno
            // 
            this.invoicechequeno.Text = "Invoice Cheque No";
            this.invoicechequeno.Width = 124;
            // 
            // invoicecbank
            // 
            this.invoicecbank.Text = "Invoice Bank";
            this.invoicecbank.Width = 98;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 104;
            // 
            // btnsubproduct
            // 
            this.btnsubproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubproduct.ForeColor = System.Drawing.Color.Black;
            this.btnsubproduct.Image = global::ShopProducts.Properties.Resources._2;
            this.btnsubproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubproduct.Location = new System.Drawing.Point(909, 419);
            this.btnsubproduct.Name = "btnsubproduct";
            this.btnsubproduct.Size = new System.Drawing.Size(92, 38);
            this.btnsubproduct.TabIndex = 5;
            this.btnsubproduct.Text = "Add";
            this.btnsubproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubproduct.UseVisualStyleBackColor = true;
            this.btnsubproduct.Click += new System.EventHandler(this.btnsubproduct_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(432, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // frmInvoicemainDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1114, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInvoicemainDetails";
            this.Text = "frmInvoicemainDetails";
            this.Load += new System.EventHandler(this.frmInvoicemainDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_subproductdetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstviewinvoicemain;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader invoiceno;
        private System.Windows.Forms.ColumnHeader invoicedate;
        private System.Windows.Forms.ColumnHeader invoicecustomer;
        private System.Windows.Forms.ColumnHeader invoiceaddress;
        private System.Windows.Forms.ColumnHeader invoicecustomerid;
        private System.Windows.Forms.ColumnHeader invoicechequeno;
        private System.Windows.Forms.ColumnHeader invoicecbank;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button btnsubproduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrint;

    }
}