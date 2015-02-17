namespace ShopProducts.Forms
{
    partial class frmSubproductDetails
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
            this.lstvwsubproducts = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnsubproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvwsubproducts
            // 
            this.lstvwsubproducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ProductId,
            this.SubProductName,
            this.UType,
            this.DateTime});
            this.lstvwsubproducts.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwsubproducts.GridLines = true;
            this.lstvwsubproducts.Location = new System.Drawing.Point(1, 60);
            this.lstvwsubproducts.Name = "lstvwsubproducts";
            this.lstvwsubproducts.Size = new System.Drawing.Size(755, 419);
            this.lstvwsubproducts.TabIndex = 0;
            this.lstvwsubproducts.UseCompatibleStateImageBehavior = false;
            this.lstvwsubproducts.View = System.Windows.Forms.View.Details;
            this.lstvwsubproducts.SelectedIndexChanged += new System.EventHandler(this.lstvwsubproducts_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 150;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Product Id";
            this.ProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductId.Width = 150;
            // 
            // SubProductName
            // 
            this.SubProductName.Text = "Sub Product Name";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(502, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btnsubproduct
            // 
            this.btnsubproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubproduct.Location = new System.Drawing.Point(350, 486);
            this.btnsubproduct.Name = "btnsubproduct";
            this.btnsubproduct.Size = new System.Drawing.Size(75, 23);
            this.btnsubproduct.TabIndex = 5;
            this.btnsubproduct.Text = "Add";
            this.btnsubproduct.UseVisualStyleBackColor = true;
            this.btnsubproduct.Click += new System.EventHandler(this.btnsubproduct_Click);
            // 
            // frmSubproductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 495);
            this.Controls.Add(this.btnsubproduct);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvwsubproducts);
            this.Name = "frmSubproductDetails";
            this.Text = "frmSubproductDetails";
            this.Load += new System.EventHandler(this.frmSubproductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwsubproducts;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader SubProductName;
        private System.Windows.Forms.ColumnHeader UType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnsubproduct;
        private System.Windows.Forms.ColumnHeader DateTime;
    }
}