using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopProducts.DbClasses;

namespace ShopProducts.Forms
{
    public partial class frmCustomer : Form
    {

        

        public frmCustomer()
        {
            InitializeComponent();
        }
     
        private void frmCustomer_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_customerinfo_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                if (string.IsNullOrEmpty(txtcustomername.Text.Trim()))
                {
                    //MessageBox.Show("Please Enter Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblErrorMessage.Text = "Please Enter Customer Name";
                    return;
                }

                string Query = "INSERT INTO tbl_Customer values('" + txtcustomername.Text.Trim() + "','" + txtcustomeraddress.Text.Trim() + "','" + txtcustomercontact.Text.Trim() + "','" + DateTime.Now + "')";
                db.RunQuery(Query);

                lblErrorMessage.Text = "Record Added Successfully.";
                ClearAllTextboxes(this.groupBox1);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMessage.Text = "Record Not Added.";
            }
        }

        private void ClearAllTextboxes(Control CC)
        {
            foreach (Control X in CC.Controls)
            {
                if (X is TextBox)
                    X.Text = "";
            }
        }

    }
}
