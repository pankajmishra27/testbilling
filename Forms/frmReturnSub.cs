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
    public partial class frmReturnSub : Form
    {
        string totaltaxamount = string.Empty;
        string totalamount = string.Empty;
        string invoiveno = string.Empty;
        string qty = string.Empty;
        string invoiceid = string.Empty;

        public frmReturnSub()
        {
            InitializeComponent();
        }

        public frmReturnSub(string Name, string Description, string Quantity, string Rate, string TaxPercent,string TaxAmount,string Amount,string TotalTaxAmount,string TotalAmount,string InvoiceNumber,string INVid)
        {
            InitializeComponent();

            txt_name.Text = Name;
            txt_description.Text = Description;
            txt_rate.Text = Rate;
            txt_amount.Text = Amount;
            txt_taxpercent.Text = TaxPercent;
            txt_taxamount.Text = TaxAmount;
            totaltaxamount = TotalTaxAmount;
            totalamount = TotalAmount;
            invoiveno = InvoiceNumber;
            invoiceid = INVid;
            qty = Quantity;
            txt_quantity.Text = Quantity;


        }
        private void frmReturnSub_Load(object sender, EventArgs e)
        {

        }
        private void txt_quantity_TextChanged(object sender, EventArgs e)
       {
           if (!string.IsNullOrEmpty(txt_quantity.Text))
           {
               if (float.Parse(txt_quantity.Text) <= float.Parse(qty))
               {
                   double val1 = double.Parse(txt_quantity.Text);
                   double val2 = double.Parse(txt_rate.Text);
                   double val3 = val1 * val2;
                   txt_amount.Text = val3.ToString();

                   double val4 = double.Parse(txt_amount.Text);
                   double val5 = double.Parse(txt_taxpercent.Text);
                   double val6 = val4 * val5;
                   double val7 = val6 / 100;
                   txt_taxamount.Text = val7.ToString();
               }
               else
               {
                   MessageBox.Show("Quantity cannot be more than existing quantity");
               }
           }
        }

        private void btn_saveinvoicesub_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(totaltaxamount) - double.Parse(txt_taxamount.Text);
            double val2 = double.Parse(totalamount) - double.Parse(txt_amount.Text);
            try
            {
                DBConnection db = new DBConnection();

                try
                {
                    //if (int.Parse(txt_quantity.Text) <= int.Parse(qty))
                    if (float.Parse(txt_quantity.Text) <= float.Parse(qty))
                    {
                        string Query1 = " SELECT * FROM tbl_Product WHERE ProductName = '" + txt_name.Text + "'";
                        DataSet d1 = db.GetData(Query1);
                        DataTable dt1 = d1.Tables[0];

                        float tb_pr_qua = float.Parse(dt1.Rows[0]["Quantity"].ToString());
                        float AddedQty = tb_pr_qua + float.Parse(txt_quantity.Text);

                        string Query2 = " SELECT * FROM tbl_InvoiceSub WHERE PrId = " + txt_description.Text + "AND InvId = " + invoiceid;
                        DataSet d2 = db.GetData(Query2);
                        DataTable dt2 = d2.Tables[0];

                        float tb_sub_qua = float.Parse(dt2.Rows[0]["PrQty"].ToString());
                        float SubtractedQty = tb_sub_qua - float.Parse(txt_quantity.Text);

                        string query = " UPDATE tbl_Product SET Quantity = " + AddedQty + " WHERE ProductName ='" + txt_name.Text + "'";
                        db.RunQuery(query);

                        string Querys = " UPDATE tbl_InvoiceMain SET InvNetAmount = " + val2 + " , InvTaxNetAmount = " + val1 + " WHERE InvoiceNo = " + invoiveno;
                        db.RunQuery(Querys);

                        string querys = " UPDATE tbl_InvoiceSub SET PrQty = " + SubtractedQty + " WHERE PrId =" + txt_description.Text;
                        db.RunQuery(querys);

                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be more than existing quantity");
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {

            }
            this.Close();

            frmReturnMain frmReturn = new frmReturnMain(invoiveno.Trim());
            frmReturn.Show();
        }
    }
}
