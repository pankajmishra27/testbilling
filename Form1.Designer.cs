namespace ShopProducts
{
    partial class Form1
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
            this.txt_productcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productdescription = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_productcode
            // 
            this.txt_productcode.Location = new System.Drawing.Point(250, 52);
            this.txt_productcode.Name = "txt_productcode";
            this.txt_productcode.Size = new System.Drawing.Size(192, 20);
            this.txt_productcode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description";
            // 
            // txt_productdescription
            // 
            this.txt_productdescription.Location = new System.Drawing.Point(250, 132);
            this.txt_productdescription.Name = "txt_productdescription";
            this.txt_productdescription.Size = new System.Drawing.Size(192, 20);
            this.txt_productdescription.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(250, 206);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(367, 206);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Name";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(250, 91);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(192, 20);
            this.txt_productname.TabIndex = 10;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Red;
            this.lbl_code.Location = new System.Drawing.Point(478, 59);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(50, 13);
            this.lbl_code.TabIndex = 11;
            this.lbl_code.Text = "L_Code";
            this.lbl_code.Click += new System.EventHandler(this.lbl_code_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(478, 98);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 13);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "L_Name";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Red;
            this.lbl_description.Location = new System.Drawing.Point(478, 139);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(57, 13);
            this.lbl_description.TabIndex = 13;
            this.lbl_description.Text = "L_Descp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProducts.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(681, 458);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_productdescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_productcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_productcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productdescription;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_description;

    }
}

