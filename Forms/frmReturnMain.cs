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
           string Query = "SELECT  * FROM tbl_InvoiceMain WHERE InvoiceNo =" + int.Parse(txt_invoicenumber.Text.Trim());
           DataSet ds = db.GetData(Query);
           DataTable dt = ds.Tables[0];

          combo_invoicecustomerID.Text = dt.Rows[0]["InvoiceCustomerId"].ToString();
          combo_invoicecustomerName.Text = dt.Rows[0]["InvoiceCustomer"].ToString();
          txt_chequenumber.Text = dt.Rows[0]["InvoiceChequeNo"].ToString();
          txt_customeraddress.Text = dt.Rows[0]["InvoiceAddress"].ToString();
          txt_chequedate.Text = dt.Rows[0]["InvChequeDate"].ToString();
          txt_invoicedate.Text = dt.Rows[0]["InvoiceDate"].ToString();
          txt_bank.Text = dt.Rows[0]["InvoiceBank"].ToString();
       }

      private void btn_addtolistview_Click(object sender, EventArgs e)
      {

      }

      private void btn_addsubproduct_Click(object sender, EventArgs e)
      {

      }
    }
}
