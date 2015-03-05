namespace ShopProducts.Forms
{
    partial class frmCategoryDetails
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
            this.lstvwProduct = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_viewproduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editproducts = new System.Windows.Forms.Button();
            this.btn_deleteproduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvwProduct
            // 
            this.lstvwProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.CategoryName,
            this.Date});
            this.lstvwProduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwProduct.FullRowSelect = true;
            this.lstvwProduct.GridLines = true;
            this.lstvwProduct.Location = new System.Drawing.Point(6, 22);
            this.lstvwProduct.Name = "lstvwProduct";
            this.lstvwProduct.Size = new System.Drawing.Size(504, 289);
            this.lstvwProduct.TabIndex = 0;
            this.lstvwProduct.UseCompatibleStateImageBehavior = false;
            this.lstvwProduct.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Category Id";
            this.id.Width = 150;
            // 
            // CategoryName
            // 
            this.CategoryName.Text = "Category Name";
            this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoryName.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 150;
            // 
            // btn_viewproduct
            // 
            this.btn_viewproduct.BackgroundImage = global::ShopProducts.Properties.Resources._2;
            this.btn_viewproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_viewproduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewproduct.ForeColor = System.Drawing.Color.Black;
            this.btn_viewproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewproduct.Location = new System.Drawing.Point(209, 317);
            this.btn_viewproduct.Name = "btn_viewproduct";
            this.btn_viewproduct.Size = new System.Drawing.Size(91, 37);
            this.btn_viewproduct.TabIndex = 1;
            this.btn_viewproduct.Text = "Add";
            this.btn_viewproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_viewproduct.UseVisualStyleBackColor = true;
            this.btn_viewproduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_editproducts);
            this.groupBox1.Controls.Add(this.btn_deleteproduct);
            this.groupBox1.Controls.Add(this.lstvwProduct);
            this.groupBox1.Controls.Add(this.btn_viewproduct);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 360);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category List";
            // 
            // btn_editproducts
            // 
            this.btn_editproducts.BackgroundImage = global::ShopProducts.Properties.Resources._1;
            this.btn_editproducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_editproducts.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editproducts.ForeColor = System.Drawing.Color.Black;
            this.btn_editproducts.Location = new System.Drawing.Point(416, 319);
            this.btn_editproducts.Name = "btn_editproducts";
            this.btn_editproducts.Size = new System.Drawing.Size(94, 37);
            this.btn_editproducts.TabIndex = 3;
            this.btn_editproducts.Text = "Edit";
            this.btn_editproducts.UseVisualStyleBackColor = true;
            this.btn_editproducts.Click += new System.EventHandler(this.btn_editproducts_Click);
            // 
            // btn_deleteproduct
            // 
            this.btn_deleteproduct.BackgroundImage = global::ShopProducts.Properties.Resources._3;
            this.btn_deleteproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteproduct.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteproduct.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteproduct.Location = new System.Drawing.Point(306, 318);
            this.btn_deleteproduct.Name = "btn_deleteproduct";
            this.btn_deleteproduct.Size = new System.Drawing.Size(104, 36);
            this.btn_deleteproduct.TabIndex = 2;
            this.btn_deleteproduct.Text = "Delete";
            this.btn_deleteproduct.UseVisualStyleBackColor = true;
            this.btn_deleteproduct.Click += new System.EventHandler(this.btn_deleteproduct_Click);
            // 
            // frmCategoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.blue_wallpaper_plain;
            this.ClientSize = new System.Drawing.Size(543, 405);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category List";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvwProduct;
        private System.Windows.Forms.Button btn_viewproduct;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader CategoryName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_editproducts;
        private System.Windows.Forms.Button btn_deleteproduct;

    }
}