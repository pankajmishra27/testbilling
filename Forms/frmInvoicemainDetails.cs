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
    public partial class frmInvoicemainDetails : Form
    {
        DBConnection dbConnection = new DBConnection();
        public frmInvoicemainDetails()
        {
            InitializeComponent();
        }

        private void frmInvoicemainDetails_Load(object sender, EventArgs e)
        {
           
                try
                {
                    string Query = "Select * from tbl_InvoiceMain";
                    DataSet ds = dbConnection.GetData(Query);
                    DataTable dt = ds.Tables[0];

                    ListViewItem node;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        try
                        {
                            node = new ListViewItem();
                            node.Text = dt.Rows[i]["InvId"].ToString();
                            node.SubItems.Add(dt.Rows[i]["InvoiceNo"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceDate"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceCustomer"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceAddress"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceCustomerId"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceChequeNo"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvoiceBank"].ToString());
                            node.SubItems.Add(dt.Rows[i]["InvChequeDate"].ToString());
                            //node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                            lstviewinvoicemain.Items.Add(node);
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

        private void btn_subproductdetails_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string id = string.Empty;

            if (!string.IsNullOrEmpty(lstviewinvoicemain.FocusedItem.SubItems[0].Text))
            {
                id = lstviewinvoicemain.FocusedItem.SubItems[0].Text;
            }
            else
            {
                string msg = "Please select a row.";
            }


            string Query = "DELETE FROM tbl_InvoiceMain WHERE InvId =" + int.Parse(id);
            db.RunQuery(Query);

            frmInvoicemainDetails frm = new frmInvoicemainDetails();
            frm.Show();
        }

        private void btnsubproduct_Click(object sender, EventArgs e)
        {
            frmInvoicemain frm = new frmInvoicemain();
            frm.Show();
        }
    }
}
