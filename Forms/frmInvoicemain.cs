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
            DBConnection db = new DBConnection();
            try
            {
                try
                {
                    string Query = "SELECT * FROM tbl_Customer";
                    DataSet ds = db.GetData(Query);

                    combo_invoicecustomerID.DataSource = ds.Tables[0];
                    combo_invoicecustomerID.DisplayMember = "Id";

                    combo_invoicecustomerName.DataSource = ds.Tables[0];
                    combo_invoicecustomerName.DisplayMember = "Name";
                }
                catch (Exception ex)
                {

                }

                try
                {
                    string Query = "SELECT * FROM tbl_ProductCategory";
                    DataSet ds = db.GetData(Query);

                    combo_productname.DataSource = ds.Tables[0];
                    combo_productname.DisplayMember = "ProductName";

                    combo_description.DataSource = ds.Tables[0];
                    combo_description.DisplayMember = "ProductDescription";
                }
                catch (Exception ex)
                {                 
                  
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
                    if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                    {
                        txt_invoicenumber.Text = "Please enter invoice number";                       
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
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_chequenumber.Text.Trim()))
                    {
                        txt_chequenumber.Text = "Enter Cheque No.";                        
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_bank.Text.Trim()))
                    {
                        txt_bank.Text = " Enter Bank name";
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                    {
                        txt_taxamount.Text = "Enter Tax Amount";
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                    {
                        txt_amount.Text = "Enter Amount";
                    }
                }
                catch (Exception ex)
                {
                    
                }
                if(string.IsNullOrEmpty(combo_invoicecustomerID.Text) || string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()) || string.IsNullOrEmpty(combo_invoicecustomerName.Text) || string.IsNullOrEmpty(txt_customeraddress.Text.Trim()) || string.IsNullOrEmpty(txt_chequenumber.Text.Trim()) || string.IsNullOrEmpty(txt_bank.Text.Trim()) || string.IsNullOrEmpty(txt_taxamount.Text.Trim()) || string.IsNullOrEmpty(txt_amount.Text.Trim()))
                {
                    return; 
                }

                
                //string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + txt_customername.Text.Trim() + "','" + txt_customeraddress.Text.Trim() + "','" + txt_customerid.Text.Trim() + "','" +  txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";//,'" + DateTime.Now + "')";
                string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + combo_invoicecustomerName.Text + "','" + txt_customeraddress.Text.Trim() + "','" + combo_invoicecustomerID.Text + "','" + txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";
                db.RunQuery(Query);     
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DBConnection db = new DBConnection();
            //string id = string.Empty;

            //if (!string.IsNullOrEmpty(lst_Invoicemain.FocusedItem.SubItems[0].Text))
            //{
            //    id = lst_Invoicemain.FocusedItem.SubItems[0].Text;
            //}
            //else
            //{
            //    string msg = "Please select a row.";
            //}


            //string Query = "DELETE FROM tbl_InvoiceSub WHERE Id =" + int.Parse(id);
            //db.RunQuery(Query);

            //frmCustomerDetails frm = new frmCustomerDetails();
            //frm.Show();
            
        }

       private void btn_addsubproduct_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                try
                {
                    if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                    {
                        txt_invoicenumber.Text = "Enter Invoice Number";
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
                    {
                        txt_quantity.Text = "Enter Quantity";
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_rate.Text.Trim()))
                    {
                        txt_rate.Text = "Enter Rate";
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxpercent.Text.Trim()))
                    {
                        txt_taxpercent.Text = "Enter Tax Percent";
                    }
                }
                catch (Exception ex)
                {
                    
                    throw;
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                    {
                        txt_taxamount.Text = "Enter Tax Amount";
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                    {
                        txt_amount.Text = "Enter Amount";
                    }
                }
                catch (Exception ex)
                {

                }
                string Querys = "INSERT INTO tbl_InvoiceSub(InvId,PrName,PrDescription,PrQty,PrRate,PrTaxPercent,PrTaxAmount,PrAmount) VALUES(" + int.Parse(txt_invoicenumber.Text.Trim()) + ",'" + combo_productname.Text + "','" + combo_description.Text + "'," + double.Parse(txt_quantity.Text.Trim()) + "," + txt_rate.Text.Trim() + "," + double.Parse(txt_taxpercent.Text.Trim()) + "," + double.Parse(txt_taxamount.Text.Trim()) + "," + double.Parse(txt_amount.Text.Trim()) + ")";

                //string Querys = "INSERT INTO tbl_InvoiceSub(InvId,PrId,PrDescription,PrQty,PrRate,PrTaxPercent,PrTaxAmount,PrAmount) VALUES(" + int.Parse(txt_invoicenumber.Text.Trim()) + "," + int.Parse(combo_productid.Text) + ",'" + combo_description.Text + "'," + double.Parse(txt_quantity.Text.Trim()) + "," + double.Parse(txt_rate.Text.Trim()) + "," + double.Parse(txt_taxpercent.Text.Trim()) +"," + double.Parse(txt_taxamount.Text.Trim()) + ","+ double.Parse(txt_amount.Text.Trim()) + ")";
                //string Querys = "INSERT INTO tbl_InvoiceSub(InvId,PrId,PrDescription,PrQty,PrRate,PrTaxPercent,PrNetAmount) VALUES(" + int.Parse(txt_invoicenumber.Text.Trim()) + "," + int.Parse(combo_productid.Text) + ",'" + combo_description.Text + "'," + double.Parse(txt_quantity.Text.Trim()) + "," + double.Parse(txt_rate.Text.Trim()) + "," + double.Parse(txt_taxamount.Text.Trim()) + "," + double.Parse(txt_amount.Text.Trim()) + ")";
                db.RunQuery(Querys);

                //frmInvoicemain frm = new frmInvoicemain();
                //frm.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_addtolistview_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem node = new ListViewItem();
                        node.Text = "1";
                        node.SubItems.Add(combo_productname.Text);
                        node.SubItems.Add(combo_description.Text);
                        node.SubItems.Add(txt_quantity.Text.Trim());
                        node.SubItems.Add(txt_rate.Text.Trim());
                        node.SubItems.Add(txt_taxpercent.Text.Trim());
                        node.SubItems.Add(txt_taxamount.Text.Trim());
                        node.SubItems.Add(txt_amount.Text.Trim());
                
                lst_Invoicemain.Items.Add(node);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btn_deletetolistview_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem lvItem in lst_Invoicemain.SelectedItems)
                {
                    lst_Invoicemain.Items.Remove(lvItem);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
