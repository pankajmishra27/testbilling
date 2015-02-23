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

        string CustomerId { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
        }
     
        private void frmCustomer_Load(object sender, EventArgs e)
        {
           
        }

        public frmCustomer(string C_Id)
        {
            CustomerId = C_Id;
            InitializeComponent();
        }

        private void btn_customerinfo_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                if (string.IsNullOrEmpty(CustomerId))
                {

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
                else
                {
                    string Query = "UPDATE tbl_Customer SET Name = '" + txtcustomername.Text.Trim() + "', Address ='" + txtcustomeraddress.Text.Trim() + "', Contact = '" + txtcustomercontact.Text.Trim() + "' WHERE Id = " + int.Parse(CustomerId);
                    db.RunQuery(Query);
 
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMessage.Text = "Record Not Added.";
            }

            frmCustomerDetails frm = new frmCustomerDetails();
            frm.Show();
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
