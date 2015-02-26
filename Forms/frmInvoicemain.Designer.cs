namespace ShopProducts.Forms
{
    partial class frmInvoicemain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bank = new System.Windows.Forms.TextBox();
            this.txt_chequenumber = new System.Windows.Forms.TextBox();
            this.txt_chequedate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_deletetolistview = new System.Windows.Forms.Button();
            this.btn_addtolistview = new System.Windows.Forms.Button();
            this.txt_totalamount = new System.Windows.Forms.TextBox();
            this.txt_totaltaxamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addsubproduct = new System.Windows.Forms.Button();
            this.combo_productname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_description = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lst_Invoicemain = new System.Windows.Forms.ListView();
            this.prid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxamount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.txt_taxamount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_taxpercent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_invoicecustomerName = new System.Windows.Forms.ComboBox();
            this.combo_invoicecustomerID = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_customeraddress = new System.Windows.Forms.TextBox();
            this.txt_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.txt_invoicenumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(805, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invoice No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(796, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice Date";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Location = new System.Drawing.Point(457, 15);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(162, 21);
            this.txt_customerid.TabIndex = 5;
            this.txt_customerid.Visible = false;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(457, 56);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(162, 21);
            this.txt_customername.TabIndex = 6;
            this.txt_customername.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.txt_bank);
            this.groupBox1.Controls.Add(this.txt_chequenumber);
            this.groupBox1.Controls.Add(this.txt_chequedate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(564, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // txt_bank
            // 
            this.txt_bank.Location = new System.Drawing.Point(109, 53);
            this.txt_bank.Name = "txt_bank";
            this.txt_bank.Size = new System.Drawing.Size(174, 23);
            this.txt_bank.TabIndex = 5;
            // 
            // txt_chequenumber
            // 
            this.txt_chequenumber.Location = new System.Drawing.Point(109, 21);
            this.txt_chequenumber.Name = "txt_chequenumber";
            this.txt_chequenumber.Size = new System.Drawing.Size(174, 23);
            this.txt_chequenumber.TabIndex = 4;
            // 
            // txt_chequedate
            // 
            this.txt_chequedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_chequedate.Location = new System.Drawing.Point(341, 13);
            this.txt_chequedate.Name = "txt_chequedate";
            this.txt_chequedate.Size = new System.Drawing.Size(136, 23);
            this.txt_chequedate.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(289, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(31, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cheque No.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.combo_invoicecustomerName);
            this.groupBox2.Controls.Add(this.combo_invoicecustomerID);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.txt_customeraddress);
            this.groupBox2.Controls.Add(this.txt_invoicedate);
            this.groupBox2.Controls.Add(this.txt_invoicenumber);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_customerid);
            this.groupBox2.Controls.Add(this.txt_customername);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 518);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.groupBox3.Controls.Add(this.btn_deletetolistview);
            this.groupBox3.Controls.Add(this.btn_addtolistview);
            this.groupBox3.Controls.Add(this.txt_totalamount);
            this.groupBox3.Controls.Add(this.txt_totaltaxamount);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_addsubproduct);
            this.groupBox3.Controls.Add(this.combo_productname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.combo_description);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_quantity);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.lst_Invoicemain);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_rate);
            this.groupBox3.Controls.Add(this.txt_taxamount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_taxpercent);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 307);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // btn_deletetolistview
            // 
            this.btn_deletetolistview.ForeColor = System.Drawing.Color.Black;
            this.btn_deletetolistview.Location = new System.Drawing.Point(959, 43);
            this.btn_deletetolistview.Name = "btn_deletetolistview";
            this.btn_deletetolistview.Size = new System.Drawing.Size(75, 23);
            this.btn_deletetolistview.TabIndex = 35;
            this.btn_deletetolistview.Text = "Delete";
            this.btn_deletetolistview.UseVisualStyleBackColor = true;
            this.btn_deletetolistview.Click += new System.EventHandler(this.btn_deletetolistview_Click);
            // 
            // btn_addtolistview
            // 
            this.btn_addtolistview.ForeColor = System.Drawing.Color.Black;
            this.btn_addtolistview.Location = new System.Drawing.Point(884, 43);
            this.btn_addtolistview.Name = "btn_addtolistview";
            this.btn_addtolistview.Size = new System.Drawing.Size(75, 23);
            this.btn_addtolistview.TabIndex = 34;
            this.btn_addtolistview.Text = "Add";
            this.btn_addtolistview.UseVisualStyleBackColor = true;
            this.btn_addtolistview.Click += new System.EventHandler(this.btn_addtolistview_Click);
            // 
            // txt_totalamount
            // 
            this.txt_totalamount.Location = new System.Drawing.Point(888, 253);
            this.txt_totalamount.Name = "txt_totalamount";
            this.txt_totalamount.Size = new System.Drawing.Size(136, 21);
            this.txt_totalamount.TabIndex = 33;
            // 
            // txt_totaltaxamount
            // 
            this.txt_totaltaxamount.Location = new System.Drawing.Point(732, 253);
            this.txt_totaltaxamount.Name = "txt_totaltaxamount";
            this.txt_totaltaxamount.Size = new System.Drawing.Size(140, 21);
            this.txt_totaltaxamount.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(918, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_addsubproduct
            // 
            this.btn_addsubproduct.ForeColor = System.Drawing.Color.Black;
            this.btn_addsubproduct.Location = new System.Drawing.Point(801, 280);
            this.btn_addsubproduct.Name = "btn_addsubproduct";
            this.btn_addsubproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addsubproduct.TabIndex = 30;
            this.btn_addsubproduct.Text = "Save";
            this.btn_addsubproduct.UseVisualStyleBackColor = true;
            this.btn_addsubproduct.Click += new System.EventHandler(this.btn_addsubproduct_Click);
            // 
            // combo_productname
            // 
            this.combo_productname.FormattingEnabled = true;
            this.combo_productname.Location = new System.Drawing.Point(6, 38);
            this.combo_productname.Name = "combo_productname";
            this.combo_productname.Size = new System.Drawing.Size(121, 21);
            this.combo_productname.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Product Name";
            // 
            // combo_description
            // 
            this.combo_description.FormattingEnabled = true;
            this.combo_description.Location = new System.Drawing.Point(142, 39);
            this.combo_description.Name = "combo_description";
            this.combo_description.Size = new System.Drawing.Size(121, 21);
            this.combo_description.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Product Description";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(295, 41);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(85, 21);
            this.txt_quantity.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(786, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(775, 42);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 21);
            this.txt_amount.TabIndex = 24;
            // 
            // lst_Invoicemain
            // 
            this.lst_Invoicemain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prid,
            this.name,
            this.description,
            this.quantity,
            this.rate,
            this.tax,
            this.taxamount,
            this.amount});
            this.lst_Invoicemain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Invoicemain.FullRowSelect = true;
            this.lst_Invoicemain.GridLines = true;
            this.lst_Invoicemain.Location = new System.Drawing.Point(6, 72);
            this.lst_Invoicemain.Name = "lst_Invoicemain";
            this.lst_Invoicemain.Size = new System.Drawing.Size(1025, 174);
            this.lst_Invoicemain.TabIndex = 25;
            this.lst_Invoicemain.UseCompatibleStateImageBehavior = false;
            this.lst_Invoicemain.View = System.Windows.Forms.View.Details;
            // 
            // prid
            // 
            this.prid.Text = "Pr Id";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 129;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 132;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 143;
            // 
            // rate
            // 
            this.rate.Text = "Rate";
            this.rate.Width = 152;
            // 
            // tax
            // 
            this.tax.Text = "Tax %";
            this.tax.Width = 98;
            // 
            // taxamount
            // 
            this.taxamount.Text = "Tax Amount";
            this.taxamount.Width = 153;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 154;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(305, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quantity";
            // 
            // txt_rate
            // 
            this.txt_rate.Location = new System.Drawing.Point(415, 42);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(87, 21);
            this.txt_rate.TabIndex = 21;
            // 
            // txt_taxamount
            // 
            this.txt_taxamount.Location = new System.Drawing.Point(655, 43);
            this.txt_taxamount.Name = "txt_taxamount";
            this.txt_taxamount.Size = new System.Drawing.Size(100, 21);
            this.txt_taxamount.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(666, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Tax Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(441, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Rate";
            // 
            // txt_taxpercent
            // 
            this.txt_taxpercent.Location = new System.Drawing.Point(539, 42);
            this.txt_taxpercent.Name = "txt_taxpercent";
            this.txt_taxpercent.Size = new System.Drawing.Size(85, 21);
            this.txt_taxpercent.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(564, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tax %";
            // 
            // combo_invoicecustomerName
            // 
            this.combo_invoicecustomerName.FormattingEnabled = true;
            this.combo_invoicecustomerName.Location = new System.Drawing.Point(152, 52);
            this.combo_invoicecustomerName.Name = "combo_invoicecustomerName";
            this.combo_invoicecustomerName.Size = new System.Drawing.Size(202, 21);
            this.combo_invoicecustomerName.TabIndex = 31;
            // 
            // combo_invoicecustomerID
            // 
            this.combo_invoicecustomerID.AllowDrop = true;
            this.combo_invoicecustomerID.FormattingEnabled = true;
            this.combo_invoicecustomerID.Location = new System.Drawing.Point(152, 12);
            this.combo_invoicecustomerID.Name = "combo_invoicecustomerID";
            this.combo_invoicecustomerID.Size = new System.Drawing.Size(202, 21);
            this.combo_invoicecustomerID.Sorted = true;
            this.combo_invoicecustomerID.TabIndex = 30;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(966, 182);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(859, 181);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_customeraddress
            // 
            this.txt_customeraddress.Location = new System.Drawing.Point(152, 94);
            this.txt_customeraddress.Multiline = true;
            this.txt_customeraddress.Name = "txt_customeraddress";
            this.txt_customeraddress.Size = new System.Drawing.Size(406, 83);
            this.txt_customeraddress.TabIndex = 12;
            // 
            // txt_invoicedate
            // 
            this.txt_invoicedate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_invoicedate.Location = new System.Drawing.Point(905, 58);
            this.txt_invoicedate.Name = "txt_invoicedate";
            this.txt_invoicedate.Size = new System.Drawing.Size(136, 23);
            this.txt_invoicedate.TabIndex = 11;
            // 
            // txt_invoicenumber
            // 
            this.txt_invoicenumber.Location = new System.Drawing.Point(905, 21);
            this.txt_invoicenumber.Name = "txt_invoicenumber";
            this.txt_invoicenumber.Size = new System.Drawing.Size(136, 21);
            this.txt_invoicenumber.TabIndex = 10;
            // 
            // frmInvoicemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 524);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInvoicemain";
            this.Text = "frmInvoicemain";
            this.Load += new System.EventHandler(this.frmInvoicemain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bank;
        private System.Windows.Forms.TextBox txt_chequenumber;
        private System.Windows.Forms.DateTimePicker txt_chequedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker txt_invoicedate;
        private System.Windows.Forms.TextBox txt_invoicenumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_customeraddress;
        private System.Windows.Forms.ListView lst_Invoicemain;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_taxamount;
        private System.Windows.Forms.TextBox txt_taxpercent;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ColumnHeader prid;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader rate;
        private System.Windows.Forms.ColumnHeader tax;
        private System.Windows.Forms.ColumnHeader taxamount;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ComboBox combo_description;
        private System.Windows.Forms.ComboBox combo_productname;
        private System.Windows.Forms.ComboBox combo_invoicecustomerID;
        private System.Windows.Forms.ComboBox combo_invoicecustomerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_addsubproduct;
        private System.Windows.Forms.TextBox txt_totalamount;
        private System.Windows.Forms.TextBox txt_totaltaxamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addtolistview;
        private System.Windows.Forms.Button btn_deletetolistview;
    }
}