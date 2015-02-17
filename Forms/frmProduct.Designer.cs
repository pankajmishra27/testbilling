namespace ShopProducts.Forms
{
    partial class frmProduct
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
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.txt_subpname = new System.Windows.Forms.TextBox();
            this.btn_subproduct = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_peritemamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_unittype = new System.Windows.Forms.TextBox();
            this.combo_unittype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subproduct Name";
            // 
            // txt_pid
            // 
            this.txt_pid.Location = new System.Drawing.Point(258, 30);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(100, 20);
            this.txt_pid.TabIndex = 2;
            // 
            // txt_subpname
            // 
            this.txt_subpname.Location = new System.Drawing.Point(258, 78);
            this.txt_subpname.Name = "txt_subpname";
            this.txt_subpname.Size = new System.Drawing.Size(100, 20);
            this.txt_subpname.TabIndex = 3;
            // 
            // btn_subproduct
            // 
            this.btn_subproduct.Location = new System.Drawing.Point(189, 305);
            this.btn_subproduct.Name = "btn_subproduct";
            this.btn_subproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_subproduct.TabIndex = 4;
            this.btn_subproduct.Text = "Save";
            this.btn_subproduct.UseVisualStyleBackColor = true;
            this.btn_subproduct.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(332, 305);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(258, 124);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Per Item Amount";
            // 
            // txt_peritemamount
            // 
            this.txt_peritemamount.Location = new System.Drawing.Point(258, 168);
            this.txt_peritemamount.Name = "txt_peritemamount";
            this.txt_peritemamount.Size = new System.Drawing.Size(100, 20);
            this.txt_peritemamount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unit Type";
            // 
            // txt_unittype
            // 
            this.txt_unittype.Location = new System.Drawing.Point(12, 411);
            this.txt_unittype.Name = "txt_unittype";
            this.txt_unittype.Size = new System.Drawing.Size(100, 20);
            this.txt_unittype.TabIndex = 11;
            this.txt_unittype.Visible = false;
            // 
            // combo_unittype
            // 
            this.combo_unittype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_unittype.FormattingEnabled = true;
            this.combo_unittype.Location = new System.Drawing.Point(258, 212);
            this.combo_unittype.Name = "combo_unittype";
            this.combo_unittype.Size = new System.Drawing.Size(100, 21);
            this.combo_unittype.TabIndex = 13;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 427);
            this.Controls.Add(this.combo_unittype);
            this.Controls.Add(this.txt_unittype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_peritemamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_subproduct);
            this.Controls.Add(this.txt_subpname);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.TextBox txt_subpname;
        private System.Windows.Forms.Button btn_subproduct;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_peritemamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_unittype;
        private System.Windows.Forms.ComboBox combo_unittype;
    }
}