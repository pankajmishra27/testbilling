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
        string InvoiceId = string.Empty;
        public frmReturnMain()
        {
            InitializeComponent();
        }

        public frmReturnMain(string InvoiceNo)
        {
            InitializeComponent();
            LoadListView(InvoiceNo);
        }

       private void frmReturnMain_Load(object sender, EventArgs e)
        {
           
        }

      private void btn_searchinvoice_Click(object sender, EventArgs e)
       {
           if (!string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
           {
               LoadListView(txt_invoicenumber.Text.Trim());
           }
           else
           {
               MessageBox.Show("Please insert Invoice No.");
           }
           //DBConnection db = new DBConnection();
           //string Query = "SELECT  * FROM tbl_InvoiceMain INNER JOIN tbl_InvoiceSub ON tbl_InvoiceMain.InvId = tbl_InvoiceSub.InvId INNER JOIN tbl_Product ON tbl_Product.ProductCode = tbl_InvoiceSub.PrId WHERE InvoiceNo =" + int.Parse(txt_invoicenumber.Text.Trim());
           //DataSet ds = db.GetData(Query);
           //DataTable dt = ds.Tables[0];

           //ListViewItem node;
           //lst_Invoicemain.Items.Clear();
           //float taxamt = 0;
           //float amt = 0;
           //InvoiceId = dt.Rows[0]["InvId"].ToString();

           //for (int i = 0; i < dt.Rows.Count; i++)
           //{
           //    try
           //    {
           //        node = new ListViewItem();
           //        node.Text = dt.Rows[i]["PrId"].ToString();
           //        node.SubItems.Add(dt.Rows[i]["ProductName"].ToString());
           //        node.SubItems.Add(dt.Rows[i]["ProductCode"].ToString());
           //        node.SubItems.Add(dt.Rows[i]["PrQty"].ToString());
           //        node.SubItems.Add(dt.Rows[i]["PrRate"].ToString());
           //        node.SubItems.Add(dt.Rows[i]["PrTaxPercent"].ToString());

           //        double val1 = double.Parse(dt.Rows[i]["PrQty"].ToString());
           //        double val2 = double.Parse(dt.Rows[i]["PrRate"].ToString());
           //        double val3 = val1 * val2;
           //        double val4 = val3 / double.Parse(dt.Rows[i]["PrTaxPercent"].ToString());

           //        node.SubItems.Add(val4.ToString());
           //        node.SubItems.Add(val3.ToString());

           //        taxamt += float.Parse(val4.ToString());
           //        amt += float.Parse(val3.ToString());
                   
           //        combo_invoicecustomerID.Text = dt.Rows[0]["InvoiceCustomerId"].ToString();
           //        combo_invoicecustomerName.Text = dt.Rows[0]["InvoiceCustomer"].ToString();
           //        txt_chequenumber.Text = dt.Rows[0]["InvoiceChequeNo"].ToString();
           //        txt_customeraddress.Text = dt.Rows[0]["InvoiceAddress"].ToString();
           //        txt_chequedate.Text = dt.Rows[0]["InvChequeDate"].ToString();
           //        txt_invoicedate.Text = dt.Rows[0]["InvoiceDate"].ToString();
           //        txt_bank.Text = dt.Rows[0]["InvoiceBank"].ToString();
           //        txt_totaltaxamount.Text = dt.Rows[0]["InvTaxNetAmount"].ToString();
           //        txt_totalamount.Text = dt.Rows[0]["InvNetAmount"].ToString();

           //        lst_Invoicemain.Items.Add(node);
           //    }
           //    catch (Exception ex)
           //    {

           //    }
           //}

           //txt_totaltaxamount.Text = taxamt.ToString();
           //txt_totalamount.Text = amt.ToString();
       }

      private void LoadListView(string InvoiceNo)
      {
          DBConnection db = new DBConnection();
          string Query = "SELECT  * FROM tbl_InvoiceMain INNER JOIN tbl_InvoiceSub ON tbl_InvoiceMain.InvId = tbl_InvoiceSub.InvId INNER JOIN tbl_Product ON tbl_Product.ProductCode = tbl_InvoiceSub.PrId WHERE InvoiceNo =" + InvoiceNo;
          DataSet ds = db.GetData(Query);
          DataTable dt = ds.Tables[0];

          ListViewItem node;
          lst_Invoicemain.Items.Clear();
          float taxamt = 0;
          float amt = 0;
          InvoiceId = dt.Rows[0]["InvId"].ToString();

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

                  double val1 = double.Parse(dt.Rows[i]["PrQty"].ToString());
                  double val2 = double.Parse(dt.Rows[i]["PrRate"].ToString());
                  double val3 = val1 * val2;
                  double val4 = val3 / double.Parse(dt.Rows[i]["PrTaxPercent"].ToString());

                  node.SubItems.Add(val4.ToString());
                  node.SubItems.Add(val3.ToString());

                  taxamt += float.Parse(val4.ToString());
                  amt += float.Parse(val3.ToString());

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

          txt_totaltaxamount.Text = taxamt.ToString();
          txt_totalamount.Text = amt.ToString();
      }

      private void btn_editReturn_Click(object sender, EventArgs e)
      {
          try
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


              frmReturnSub frm = new frmReturnSub(lst_Invoicemain.SelectedItems[0].SubItems[1].Text, lst_Invoicemain.SelectedItems[0].SubItems[2].Text, lst_Invoicemain.SelectedItems[0].SubItems[3].Text, lst_Invoicemain.SelectedItems[0].SubItems[4].Text,
             lst_Invoicemain.SelectedItems[0].SubItems[5].Text, lst_Invoicemain.SelectedItems[0].SubItems[6].Text, lst_Invoicemain.SelectedItems[0].SubItems[7].Text, txt_totaltaxamount.Text, txt_totalamount.Text, txt_invoicenumber.Text, InvoiceId);
              frm.Show();

              this.Close();
               
          }
          catch (Exception ex)
          {
           
          }

          
         
          //string a = string.Empty;

          //if (lst_Invoicemain.SelectedItems.Count == 0)
          //{
          //    MessageBox.Show("Please Select a Row");
          //    return;
          //}
          //if (lst_Invoicemain.SelectedItems.Count > 0)
          //{
          //    a = lst_Invoicemain.SelectedItems[0].Text;
          //}

          //combo_productname.Text = lst_Invoicemain.SelectedItems[0].SubItems[1].Text;
          //combo_description.Text = lst_Invoicemain.SelectedItems[0].SubItems[2].Text;
          //txt_quantity.Text = lst_Invoicemain.SelectedItems[0].SubItems[3].Text;
          //txt_rate.Text = lst_Invoicemain.SelectedItems[0].SubItems[4].Text;
          //txt_taxpercent.Text = lst_Invoicemain.SelectedItems[0].SubItems[5].Text;
          //txt_taxamount.Text = lst_Invoicemain.SelectedItems[0].SubItems[6].Text;
          //txt_amount.Text = lst_Invoicemain.SelectedItems[0].SubItems[7].Text;
      }

      private void btn_addtolistview_Click(object sender, EventArgs e)
      {
          
          //lst_Invoicemain.SelectedItems[0].SubItems[1].Text = combo_productname.Text;
          //lst_Invoicemain.SelectedItems[0].SubItems[2].Text = combo_description.Text;
          if (int.Parse(txt_quantity.Text) <= Double.Parse(lst_Invoicemain.SelectedItems[0].SubItems[3].Text))
          {
              lst_Invoicemain.SelectedItems[0].SubItems[3].Text = txt_quantity.Text;
          }
          else
          {
              MessageBox.Show("You can return only less or equal Quantity.");
          }
          //lst_Invoicemain.SelectedItems[0].SubItems[3].Text = txt_quantity.Text;
          //lst_Invoicemain.SelectedItems[0].SubItems[4].Text = txt_rate.Text;
          //lst_Invoicemain.SelectedItems[0].SubItems[5].Text = txt_taxpercent.Text;
          //lst_Invoicemain.SelectedItems[0].SubItems[6].Text = txt_taxamount.Text;
          //lst_Invoicemain.SelectedItems[0].SubItems[7].Text = txt_amount.Text;
      }

      private void btn_addsubproduct_Click(object sender, EventArgs e)
      {
          lst_Invoicemain.View = View.Details;

          try
          {
              DBConnection db = new DBConnection();

            

              for (int i = 0; i < this.lst_Invoicemain.Items.Count; i++)
              {
                  try
                  {

                     
                      string Query1 = " SELECT * FROM tbl_Product WHERE ProductName = '" + this.lst_Invoicemain.Items[i].SubItems[1].Text + "'";
                      DataSet d1 = db.GetData(Query1);
                      DataTable dt1 = d1.Tables[0];

                      int tb_pr_qua = int.Parse(dt1.Rows[0]["Quantity"].ToString());
                      int AddedQty = tb_pr_qua + int.Parse(this.lst_Invoicemain.Items[i].SubItems[3].Text);

                      string Query2 = " SELECT * FROM tbl_InvoiceSub WHERE PrId = '" + this.lst_Invoicemain.Items[i].SubItems[2].Text + "'";
                      DataSet d2 = db.GetData(Query2);
                      DataTable dt2 = d2.Tables[0];

                      int tb_sub_qua = int.Parse(dt2.Rows[0]["Quantity"].ToString());
                      int SubtractedQty = tb_sub_qua - int.Parse(this.lst_Invoicemain.Items[i].SubItems[3].Text);

                      string query = " UPDATE tbl_Product SET Quantity = " + AddedQty + " WHERE ProductName ='" + this.lst_Invoicemain.Items[i].SubItems[1].Text + "'";
                      db.RunQuery(query);

                      string querys = " UPDATE tbl_InvoiceSub SET PrQty = " + SubtractedQty + " WHERE PrId =" + this.lst_Invoicemain.Items[i].SubItems[2].Text;
                      db.RunQuery(querys);

                     
                  }
                  catch (Exception ex)
                  {

                  }
              }
          }
          catch (Exception ex)
          {

          }
          this.Close();
      }
    }
}
