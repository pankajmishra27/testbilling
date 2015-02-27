namespace ShopProducts.Forms
{
    partial class frmProductDetails
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
            this.lstvwproducts = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnsubproduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_subproductdetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvwproducts
            // 
            this.lstvwproducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ProductId,
            this.SubProductName,
            this.UType,
            this.DateTime});
            this.lstvwproducts.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwproducts.FullRowSelect = true;
            this.lstvwproducts.GridLines = true;
            this.lstvwproducts.Location = new System.Drawing.Point(15, 51);
            this.lstvwproducts.Name = "lstvwproducts";
            this.lstvwproducts.Size = new System.Drawing.Size(757, 354);
            this.lstvwproducts.TabIndex = 0;
            this.lstvwproducts.UseCompatibleStateImageBehavior = false;
            this.lstvwproducts.View = System.Windows.Forms.View.Details;
            this.lstvwproducts.SelectedIndexChanged += new System.EventHandler(this.lstvwsubproducts_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 150;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Category";
            this.ProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductId.Width = 150;
            // 
            // SubProductName
            // 
            this.SubProductName.Text = "Product Name";
            this.SubProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubProductName.Width = 150;
            // 
            // UType
            // 
            this.UType.Text = "Unit Type";
            this.UType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UType.Width = 150;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Date";
            this.DateTime.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(432, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btnsubproduct
            // 
            this.btnsubproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubproduct.ForeColor = System.Drawing.Color.Black;
            this.btnsubproduct.Image = global::ShopProducts.Properties.Resources._2;
            this.btnsubproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubproduct.Location = new System.Drawing.Point(224, 411);
            this.btnsubproduct.Name = "btnsubproduct";
            this.btnsubproduct.Size = new System.Drawing.Size(87, 38);
            this.btnsubproduct.TabIndex = 5;
            this.btnsubproduct.Text = "Add";
            this.btnsubproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubproduct.UseVisualStyleBackColor = true;
            this.btnsubproduct.Click += new System.EventHandler(this.btnsubproduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_subproductdetails);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstvwproducts);
            this.groupBox1.Controls.Add(this.btnsubproduct);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 455);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ShopProducts.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(496, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_subproductdetails
            // 
            this.btn_subproductdetails.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subproductdetails.ForeColor = System.Drawing.Color.Black;
            this.btn_subproductdetails.Image = global::ShopProducts.Properties.Resources._3;
            this.btn_subproductdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_subproductdetails.Location = new System.Drawing.Point(347, 412);
            this.btn_subproductdetails.Name = "btn_subproductdetails";
            this.btn_subproductdetails.Size = new System.Drawing.Size(96, 37);
            this.btn_subproductdetails.TabIndex = 8;
            this.btn_subproductdetails.Text = "Delete";
            this.btn_subproductdetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_subproductdetails.UseVisualStyleBackColor = true;
            this.btn_subproductdetails.Click += new System.EventHandler(this.btn_subproductdetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // frmSubproductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.blue_wallpaper_plain;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSubproductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.frmSubproductDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvwproducts;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader SubProductName;
        private System.Windows.Forms.ColumnHeader UType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnsubproduct;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_subproductdetails;
    }
}