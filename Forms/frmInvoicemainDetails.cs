using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopProducts.DbClasses;
using ShopProducts.Reports;

namespace ShopProducts.Forms
{
    public partial class frmInvoicemainDetails : Form
    {
        DBConnection dbConnection = new DBConnection();
        public frmInvoicemainDetails()
        {
            InitializeComponent();
        }

        private void LoadForm_Invoicedetails()
        {
            try
            {
                string Query = "Select * from tbl_InvoiceMain";
                DataSet ds = dbConnection.GetData(Query);
                DataTable dt = ds.Tables[0];

                ListViewItem node;
                lstviewinvoicemain.Items.Clear();

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

        private void frmInvoicemainDetails_Load(object sender, EventArgs e)
        {
            try
            {
                LoadForm_Invoicedetails();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btn_subproductdetails_Click(object sender, EventArgs e)
        {
            try
            {
                string a = string.Empty;

                if (lstviewinvoicemain.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select a Row");
                    return;
                }
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

                //frmInvoicemainDetails frm = new frmInvoicemainDetails();
                //frm.Show();
                LoadForm_Invoicedetails();
            }
            catch (Exception ex)
            {
              
            }     
        }

        private void btnsubproduct_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoicemain frm = new frmInvoicemain();
                frm.ShowDialog();
                LoadForm_Invoicedetails();
            }
            catch (Exception ex)
            {
              
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstviewinvoicemain.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please the invoice...");
                    return;
                }

                string InvId;
                InvId = this.lstviewinvoicemain.SelectedItems[0].SubItems[0].Text;
                DataTable dt = dbConnection.RunPrintInvoice(InvId);
                frmReportShow f = new frmReportShow();
                invoiceReport rpt = new invoiceReport();
                rpt.SetDataSource(dt);
                f.CRV.ReportSource = rpt;
                f.ShowDialog();
            }
            catch (Exception ex)
            {


            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                string query = "SELECT * FROM tbl_InvoiceMain WHERE Date Between '" + dateTimePicker1.Value.Date + "' AND '" + dateTimePicker2.Value.AddDays(1).AddSeconds(-1).Date + "'";
                //string query = "SELECT * FROM tbl_InvoiceMain WHERE InvoiceDate Between '" + dateTimePicker1.Value.Date + "' AND '" + dateTimePicker2.Value.Date + "'";
                DataSet d = db.GetData(query);

                DataTable dt = d.Tables[0];

                ListViewItem node;
                lstviewinvoicemain.Items.Clear();

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
    }
}
