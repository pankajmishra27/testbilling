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
    public partial class frmInvoicemain : Form
    {
        DBConnection dbConnection = new DBConnection();

        public frmInvoicemain()
        {
            InitializeComponent();
        }

        private void frmInvoicemain_Load(object sender, EventArgs e)
        {


            //lbl_customerid.Visible = false;
            //lbl_customername.Visible = false;

            List<string> PrID = new List<string>();
            PrID.Add("01");
            PrID.Add("02");
            combo_productid.DataSource = PrID;

            List<string> PrDescription = new List<string>();
            PrDescription.Add("Cherry");
            PrDescription.Add("Pineapple");
            combo_description.DataSource = PrDescription;

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

                        //node.SubItems.Add(dt.Rows[i]["Id"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceNo"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceDate"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceCustomer"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceAddress"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceCustomerId"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceChequeNo"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceBank"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceChequeDate"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceNetAmount"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvoiceTaxNetAmount"].ToString());
                        //node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                        lst_Invoicemain.Items.Add(node);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                try
                {
                    if (string.IsNullOrEmpty(txt_customerid.Text.Trim()))
                    {
                        txt_customerid.Text = "Please enter customer id";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                    {
                        txt_invoicenumber.Text = "Please enter invoice number";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_customername.Text.Trim()))
                    {
                        txt_customername.Text = "Please enter customer name";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_customeraddress.Text.Trim()))
                    {
                        txt_customeraddress.Text = "Please enter customer address";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_chequenumber.Text.Trim()))
                    {
                        txt_chequenumber.Text = "Cheque No.";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_bank.Text.Trim()))
                    {
                        txt_bank.Text = "Bank name";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                    {
                        txt_taxamount.Text = "Tax Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                    {
                        txt_amount.Text = "Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + txt_customername.Text.Trim() + "','" + txt_customeraddress.Text.Trim() + "','" + txt_customerid.Text.Trim() + "','" +  txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";//,'" + DateTime.Now + "')";
                db.RunQuery(Query);     
            }
            catch (Exception ex)
            {

            }
        }
        
    }
}
