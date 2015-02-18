namespace ShopProducts.Forms
{
    partial class frmCustomer
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
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtcustomeraddress = new System.Windows.Forms.TextBox();
            this.txtcustomercontact = new System.Windows.Forms.TextBox();
            this.btn_customerinfo = new System.Windows.Forms.Button();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_customeraddress = new System.Windows.Forms.Label();
            this.lbl_customercontact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(287, 58);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(100, 20);
            this.txtcustomername.TabIndex = 3;
            // 
            // txtcustomeraddress
            // 
            this.txtcustomeraddress.Location = new System.Drawing.Point(287, 105);
            this.txtcustomeraddress.Name = "txtcustomeraddress";
            this.txtcustomeraddress.Size = new System.Drawing.Size(100, 20);
            this.txtcustomeraddress.TabIndex = 4;
            // 
            // txtcustomercontact
            // 
            this.txtcustomercontact.Location = new System.Drawing.Point(287, 157);
            this.txtcustomercontact.Name = "txtcustomercontact";
            this.txtcustomercontact.Size = new System.Drawing.Size(100, 20);
            this.txtcustomercontact.TabIndex = 5;
            // 
            // btn_customerinfo
            // 
            this.btn_customerinfo.Location = new System.Drawing.Point(287, 301);
            this.btn_customerinfo.Name = "btn_customerinfo";
            this.btn_customerinfo.Size = new System.Drawing.Size(75, 23);
            this.btn_customerinfo.TabIndex = 6;
            this.btn_customerinfo.Text = "Save";
            this.btn_customerinfo.UseVisualStyleBackColor = true;
            this.btn_customerinfo.Click += new System.EventHandler(this.btn_customerinfo_Click);
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Location = new System.Drawing.Point(413, 61);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(65, 13);
            this.lbl_customername.TabIndex = 7;
            this.lbl_customername.Text = "L_CusName";
            // 
            // lbl_customeraddress
            // 
            this.lbl_customeraddress.AutoSize = true;
            this.lbl_customeraddress.Location = new System.Drawing.Point(413, 112);
            this.lbl_customeraddress.Name = "lbl_customeraddress";
            this.lbl_customeraddress.Size = new System.Drawing.Size(56, 13);
            this.lbl_customeraddress.TabIndex = 8;
            this.lbl_customeraddress.Text = "L_CusAdd";
            // 
            // lbl_customercontact
            // 
            this.lbl_customercontact.AutoSize = true;
            this.lbl_customercontact.Location = new System.Drawing.Point(413, 164);
            this.lbl_customercontact.Name = "lbl_customercontact";
            this.lbl_customercontact.Size = new System.Drawing.Size(74, 13);
            this.lbl_customercontact.TabIndex = 9;
            this.lbl_customercontact.Text = "L_CusContact";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 476);
            this.Controls.Add(this.lbl_customercontact);
            this.Controls.Add(this.lbl_customeraddress);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.btn_customerinfo);
            this.Controls.Add(this.txtcustomercontact);
            this.Controls.Add(this.txtcustomeraddress);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtcustomeraddress;
        private System.Windows.Forms.TextBox txtcustomercontact;
        private System.Windows.Forms.Button btn_customerinfo;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_customeraddress;
        private System.Windows.Forms.Label lbl_customercontact;
    }
}