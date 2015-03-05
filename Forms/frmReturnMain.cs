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
    public partial class frmReturnMain : Form
    {
        public frmReturnMain()
        {
            InitializeComponent();
        }

       private void frmReturnMain_Load(object sender, EventArgs e)
        {
           
        }

      private void btn_searchinvoice_Click(object sender, EventArgs e)
       {
           DBConnection db = new DBConnection();
           string Query = "SELECT  * FROM tbl_InvoiceMain INNER JOIN tbl_InvoiceSub ON tbl_InvoiceMain.InvId = tbl_InvoiceSub.InvId INNER JOIN tbl_Product ON tbl_Product.ProductCode = tbl_InvoiceSub.PrId WHERE InvoiceNo =" + int.Parse(txt_invoicenumber.Text.Trim());
           DataSet ds = db.GetData(Query);
           DataTable dt = ds.Tables[0];

           ListViewItem node;
           lst_Invoicemain.Items.Clear();

           for (int i = 0; i < dt.Rows.Count; i++)
           {
               try
               {
                   node = new ListViewItem();
                   node.Text = dt.Rows[i]["PrId"].ToString();
                   node.SubItems.Add(dt.Rows[i]["ProductName"].ToString());
                   node.SubItems.Add(dt.Rows[i]["ProductCode"].ToString());
                   node.SubItems.Add(dt.Rows[i]["PrQty"].ToString());
                   node.SubItems.Add(dt.Rows[i]["PrRate"].ToString());
                   node.SubItems.Add(dt.Rows[i]["PrTaxPercent"].ToString());
                   node.SubItems.Add(dt.Rows[i]["InvTaxNetAmount"].ToString());
                   node.SubItems.Add(dt.Rows[i]["InvNetAmount"].ToString());


                   combo_invoicecustomerID.Text = dt.Rows[0]["InvoiceCustomerId"].ToString();
                   combo_invoicecustomerName.Text = dt.Rows[0]["InvoiceCustomer"].ToString();
                   txt_chequenumber.Text = dt.Rows[0]["InvoiceChequeNo"].ToString();
                   txt_customeraddress.Text = dt.Rows[0]["InvoiceAddress"].ToString();
                   txt_chequedate.Text = dt.Rows[0]["InvChequeDate"].ToString();
                   txt_invoicedate.Text = dt.Rows[0]["InvoiceDate"].ToString();
                   txt_bank.Text = dt.Rows[0]["InvoiceBank"].ToString();
                   txt_totaltaxamount.Text = dt.Rows[0]["InvTaxNetAmount"].ToString();
                   txt_totalamount.Text = dt.Rows[0]["InvNetAmount"].ToString();

                   

                   lst_Invoicemain.Items.Add(node);
               }
               catch (Exception ex)
               {

               }
           }

           

          //string querys = "SELECT  * FROM tbl_Product";
          //DataSet fr = db.GetData(querys);
          //DataTable fruit = fr.Tables[0];


          string Querys = "SELECT  * FROM tbl_InvoiceSub WHERE InvId =" + dt.Rows[0]["InvId"].ToString();
          DataSet d = db.GetData(Querys);
          DataTable df = d.Tables[0];

          

          //lst_Invoicemain.Show();

       }

      private void btn_editReturn_Click(object sender, EventArgs e)
      {
          string a = string.Empty;

          if (lst_Invoicemain.SelectedItems.Count == 0)
          {
              MessageBox.Show("Please Select a Row");
              return;
          }
          if (lst_Invoicemain.SelectedItems.Count > 0)
          {
              a = lst_Invoicemain.SelectedItems[0].Text;
          }

          combo_productname.Text = lst_Invoicemain.SelectedItems[0].SubItems[1].ToString();
          //combo_description.Text = dt.Rows[i]["ProductCode"].ToString();
          //txt_quantity.Text = dt.Rows[i]["PrQty"].ToString();
          //txt_rate.Text = dt.Rows[i]["PrRate"].ToString();
          //txt_taxpercent.Text = dt.Rows[i]["PrTaxPercent"].ToString();
          //txt_taxamount.Text = dt.Rows[i]["InvTaxNetAmount"].ToString();
          //txt_amount.Text = dt.Rows[i]["InvNetAmount"].ToString();
      }
    }
}
