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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categorycode = new System.Windows.Forms.TextBox();
            this.txt_categoryname = new System.Windows.Forms.TextBox();
            this.txt_categorydescription = new System.Windows.Forms.TextBox();
            this.btn_Savecategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Description";
            // 
            // txt_categorycode
            // 
            this.txt_categorycode.Location = new System.Drawing.Point(257, 32);
            this.txt_categorycode.Name = "txt_categorycode";
            this.txt_categorycode.Size = new System.Drawing.Size(208, 20);
            this.txt_categorycode.TabIndex = 3;
            // 
            // txt_categoryname
            // 
            this.txt_categoryname.Location = new System.Drawing.Point(257, 98);
            this.txt_categoryname.Name = "txt_categoryname";
            this.txt_categoryname.Size = new System.Drawing.Size(208, 20);
            this.txt_categoryname.TabIndex = 4;
            // 
            // txt_categorydescription
            // 
            this.txt_categorydescription.Location = new System.Drawing.Point(257, 165);
            this.txt_categorydescription.Name = "txt_categorydescription";
            this.txt_categorydescription.Size = new System.Drawing.Size(208, 20);
            this.txt_categorydescription.TabIndex = 5;
            // 
            // btn_Savecategory
            // 
            this.btn_Savecategory.ForeColor = System.Drawing.Color.Black;
            this.btn_Savecategory.Location = new System.Drawing.Point(257, 231);
            this.btn_Savecategory.Name = "btn_Savecategory";
            this.btn_Savecategory.Size = new System.Drawing.Size(75, 23);
            this.btn_Savecategory.TabIndex = 6;
            this.btn_Savecategory.Text = "Save";
            this.btn_Savecategory.UseVisualStyleBackColor = true;
            this.btn_Savecategory.Click += new System.EventHandler(this.btn_Savecategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ShopProducts.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.txt_categorycode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Savecategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_categoryname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_categorydescription);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 327);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(600, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_categorycode;
        private System.Windows.Forms.TextBox txt_categoryname;
        private System.Windows.Forms.TextBox txt_categorydescription;
        private System.Windows.Forms.Button btn_Savecategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}