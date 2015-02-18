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
            lbl_customername.Visible = false;
            lbl_customeraddress.Visible = false;
            lbl_customercontact.Visible = false;
        }

        private void btn_customerinfo_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                try
                {
                    if (!string.IsNullOrEmpty(txtcustomername.Text.Trim()))
                    {
                        string Pname = txtcustomername.Text.Trim();
                    }
                    else
                    {
                        lbl_customername.Text = "Please Enter Customer Name";
                        lbl_customername.Visible = true;
                        return;
                    }

                    //txtcustomername.Text = txtcustomername.Text.Trim();      
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (!string.IsNullOrEmpty(txtcustomeraddress.Text.Trim()))
                    {
                        string Pname = txtcustomeraddress.Text.Trim();
                    }
                    else
                    {
                        lbl_customeraddress.Text = "Please Enter Customer Address";
                        lbl_customeraddress.Visible = true;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (!string.IsNullOrEmpty(txtcustomercontact.Text.Trim()))
                    {
                        string Pname = txtcustomercontact.Text.Trim();
                    }
                    else
                    {
                        lbl_customercontact.Text = "Please Enter Customer Contact";
                        lbl_customercontact.Visible = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    
                }

                string Query = "INSERT INTO tbl_Customer values('" + txtcustomername.Text.Trim() + "','" + txtcustomeraddress.Text.Trim() + "','" + txtcustomercontact.Text.Trim() + "','" + DateTime.Now + "')";
                db.RunQuery(Query);

            }
            catch (Exception ex)
            {
              
            }
        }
    }
}
