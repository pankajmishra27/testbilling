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
            
            InitializeComponent();
            CustomerId = C_Id;
            DBConnection db = new DBConnection();
            CustomerId = C_Id;
            string Query = "SELECT * FROM tbl_Customer WHERE Id =" + CustomerId;
            DataSet ds = db.GetData(Query);
            DataTable dt = ds.Tables[0];

            txtcustomername.Text = dt.Rows[0]["Name"].ToString();
            txtcustomeraddress.Text = dt.Rows[0]["Address"].ToString();
            txtcustomercontact.Text = dt.Rows[0]["Contact"].ToString();
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

                    string Query = "INSERT INTO tbl_Customer values('" + txtcustomername.Text.ToUpper().Trim() + "','" + txtcustomeraddress.Text.ToUpper().Trim() + "','" + txtcustomercontact.Text.ToUpper().Trim() + "','" + DateTime.Now + "')";
                    db.RunQuery(Query);

                    lblErrorMessage.Text = "Record Added Successfully.";
                    ClearAllTextboxes(this.groupBox1);
                }
                else
                {
                    string Query = "UPDATE tbl_Customer SET Name = '" + txtcustomername.Text.ToUpper().Trim() + "', Address ='" + txtcustomeraddress.Text.ToUpper().Trim() + "', Contact = '" + txtcustomercontact.Text.ToUpper().Trim() + "' WHERE Id = " + int.Parse(CustomerId);
                    db.RunQuery(Query);
 
                }

                this.Close();
            }
            catch (Exception ex)
            {
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
