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
            this.lstvwProduct = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_viewproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvwProduct
            // 
            this.lstvwProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ProductCode,
            this.ProductName,
            this.ProductDescription,
            this.Date});
            this.lstvwProduct.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwProduct.GridLines = true;
            this.lstvwProduct.Location = new System.Drawing.Point(0, 77);
            this.lstvwProduct.Name = "lstvwProduct";
            this.lstvwProduct.Size = new System.Drawing.Size(855, 419);
            this.lstvwProduct.TabIndex = 0;
            this.lstvwProduct.UseCompatibleStateImageBehavior = false;
            this.lstvwProduct.View = System.Windows.Forms.View.Details;
            this.lstvwProduct.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Product Id";
            this.id.Width = 150;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product Code";
            this.ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductCode.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 200;
            // 
            // ProductDescription
            // 
            this.ProductDescription.Text = "Product Description";
            this.ProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductDescription.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 150;
            // 
            // btn_viewproduct
            // 
            this.btn_viewproduct.Location = new System.Drawing.Point(367, 501);
            this.btn_viewproduct.Name = "btn_viewproduct";
            this.btn_viewproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_viewproduct.TabIndex = 1;
            this.btn_viewproduct.Text = "Add";
            this.btn_viewproduct.UseVisualStyleBackColor = true;
            this.btn_viewproduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 534);
            this.Controls.Add(this.btn_viewproduct);
            this.Controls.Add(this.lstvwProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvwProduct;
        private System.Windows.Forms.Button btn_viewproduct;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductDescription;
        private System.Windows.Forms.ColumnHeader Date;

    }
}