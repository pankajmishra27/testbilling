using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopProducts.DbClasses;
using System.Threading;

namespace ShopProducts.Forms
{
    public partial class frmCustomerDetails : Form
    {
        DBConnection dbConnection = new DBConnection();

        public frmCustomerDetails()
        {
            InitializeComponent();
        }



        private void GetCustomers()
        {
            try
            {
                string Query = "Select * from tbl_Customer";
                DataSet ds = dbConnection.GetData(Query);
                DataTable dt = ds.Tables[0];

                ListViewItem node;
                lst_customerdetails.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        node = new ListViewItem();
                        node.Text = dt.Rows[i]["Id"].ToString();

                        //node.SubItems.Add(dt.Rows[i]["Id"].ToString());
                        node.SubItems.Add(dt.Rows[i]["Name"].ToString());
                        node.SubItems.Add(dt.Rows[i]["Address"].ToString());
                        node.SubItems.Add(dt.Rows[i]["Contact"].ToString());
                        node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                        lst_customerdetails.Items.Add(node);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CallGetCustomer()
        {
            lst_customerdetails.Invoke(new MethodInvoker(delegate
            {
                GetCustomers();
            }));
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            //Thread thr = new Thread(CallGetCustomer);
            //thr.Start();
            GetCustomers();
        }

        private void btn_addcustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            GetCustomers();
        }

        private void btn_deletecustomerdetails_Click(object sender, EventArgs e)
        {
            try
            {
                string a = string.Empty;

                if (lst_customerdetails.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select a Row");
                    return;
                }

                DBConnection db = new DBConnection();
                string id = string.Empty;

                if (!string.IsNullOrEmpty(lst_customerdetails.FocusedItem.SubItems[0].Text))
                {
                    id = lst_customerdetails.FocusedItem.SubItems[0].Text;
                }
                else
                {
                    string msg = "Please select a row.";
                }


                string Query = "DELETE FROM tbl_Customer WHERE Id =" + int.Parse(id);
                db.RunQuery(Query);

                //frmCustomerDetails frm = new frmCustomerDetails();
                //frm.ShowDialog();
                GetCustomers();
            }
            catch (Exception)
            {

            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = string.Empty;

            if (lst_customerdetails.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Row");
                return;
            }
            if (lst_customerdetails.SelectedItems.Count>0)
            {
               a =  lst_customerdetails.SelectedItems[0].Text;
            }

            frmCustomer editcustomer = new frmCustomer(a);
            editcustomer.ShowDialog();
            GetCustomers();
        }
    }
}
