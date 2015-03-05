namespace ShopProducts.Forms
{
    partial class frmCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categoryname = new System.Windows.Forms.TextBox();
            this.btn_Savecategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name :";
            // 
            // txt_categoryname
            // 
            this.txt_categoryname.Location = new System.Drawing.Point(257, 42);
            this.txt_categoryname.Name = "txt_categoryname";
            this.txt_categoryname.Size = new System.Drawing.Size(208, 20);
            this.txt_categoryname.TabIndex = 4;
            // 
            // btn_Savecategory
            // 
            this.btn_Savecategory.BackgroundImage = global::ShopProducts.Properties.Resources._2;
            this.btn_Savecategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Savecategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Savecategory.ForeColor = System.Drawing.Color.Black;
            this.btn_Savecategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Savecategory.Location = new System.Drawing.Point(257, 83);
            this.btn_Savecategory.Name = "btn_Savecategory";
            this.btn_Savecategory.Size = new System.Drawing.Size(82, 38);
            this.btn_Savecategory.TabIndex = 6;
            this.btn_Savecategory.Text = "Save";
            this.btn_Savecategory.UseVisualStyleBackColor = true;
            this.btn_Savecategory.Click += new System.EventHandler(this.btn_Savecategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.btn_Savecategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_categoryname);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(600, 239);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categoryname;
        private System.Windows.Forms.Button btn_Savecategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}