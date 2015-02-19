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
                        node.Text = dt.Rows[i]["RowId"].ToString();

                        //node.SubItems.Add(dt.Rows[i]["Id"].ToString());
                        node.SubItems.Add(dt.Rows[i]["InvId"].ToString());
                        node.SubItems.Add(dt.Rows[i]["PrId"].ToString());
                        node.SubItems.Add(dt.Rows[i]["PrDescription"].ToString());
                        node.SubItems.Add(dt.Rows[i]["PrQty"].ToString());
                        node.SubItems.Add(dt.Rows[i]["PrRate"].ToString());
                        node.SubItems.Add(dt.Rows[i]["PrTaxPercent"].ToString());
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
                    txt_invoicenumber.Text = txt_invoicenumber.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    combo_productid.Text = combo_productid.Text.Trim(); //txt_invoicenumber.Text = txt_invoicenumber.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    combo_description.Text = combo_description.Text.Trim(); //txt_invoicenumber.Text = txt_invoicenumber.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    txt_quantity.Text = txt_quantity.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    txt_rate.Text = txt_rate.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    txt_tax.Text = txt_tax.Text.Trim();
                }
                catch (Exception ex)
                {

                }

                string Query = "INSERT INTO tbl_InvoiceSub values(" + txt_invoicenumber.Text.Trim() + ",'" + combo_productid.SelectedItem + "','" + combo_description.Text.Trim() + "','" + txt_quantity.Text.Trim() + "','" + txt_rate.Text.Trim() + "','" + txt_tax.Text.Trim() + "')";//,'" + DateTime.Now + "')";
                db.RunQuery(Query);
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
