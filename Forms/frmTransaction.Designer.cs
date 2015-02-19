namespace ShopProducts.Forms
{
    partial class frmTransaction
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
            this.combo_subproductid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.btn_transactionsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subproduct Id";
            // 
            // combo_subproductid
            // 
            this.combo_subproductid.FormattingEnabled = true;
            this.combo_subproductid.Location = new System.Drawing.Point(198, 65);
            this.combo_subproductid.Name = "combo_subproductid";
            this.combo_subproductid.Size = new System.Drawing.Size(230, 21);
            this.combo_subproductid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(198, 147);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(230, 20);
            this.txt_quantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(198, 227);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(230, 20);
            this.txt_status.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remark";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(198, 312);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(230, 20);
            this.txt_remark.TabIndex = 7;
            // 
            // btn_transactionsave
            // 
            this.btn_transactionsave.Location = new System.Drawing.Point(198, 393);
            this.btn_transactionsave.Name = "btn_transactionsave";
            this.btn_transactionsave.Size = new System.Drawing.Size(75, 23);
            this.btn_transactionsave.TabIndex = 8;
            this.btn_transactionsave.Text = "Save";
            this.btn_transactionsave.UseVisualStyleBackColor = true;
            this.btn_transactionsave.Click += new System.EventHandler(this.btn_transactionsave_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 489);
            this.Controls.Add(this.btn_transactionsave);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_subproductid);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_subproductid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Button btn_transactionsave;
    }
}