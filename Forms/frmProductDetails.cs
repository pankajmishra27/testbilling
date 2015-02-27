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
    public partial class frmProductDetails : Form
    {

        DBConnection dbConnection = new DBConnection();

        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmSubproductDetails_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "Select * from tbl_Product";
                DataSet ds = dbConnection.GetData(Query);
                DataTable dt = ds.Tables[0];

                ListViewItem node;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        node = new ListViewItem();
                        node.Text = dt.Rows[i]["Id"].ToString();

                        //node.SubItems.Add(dt.Rows[i]["Id"].ToString());
                        //node.SubItems.Add(dt.Rows[i]["Id"].ToString());
                        node.SubItems.Add(dt.Rows[i]["CategoryId"].ToString());
                        node.SubItems.Add(dt.Rows[i]["ProductName"].ToString());
                        node.SubItems.Add(dt.Rows[i]["Quantity"].ToString());
                        //node.SubItems.Add(dt.Rows[i]["PerItemAmount"].ToString());
                        //node.SubItems.Add(dt.Rows[i]["UnitType"].ToString());
                        node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                        lstvwproducts.Items.Add(node);
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

        private void btnsubproduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void lstvwsubproducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_subproductdetails_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string id = string.Empty;

            if (!string.IsNullOrEmpty(lstvwproducts.FocusedItem.SubItems[0].Text))
            {
                id = lstvwproducts.FocusedItem.SubItems[0].Text;
            }
            else
            {
                string msg = "Please select a row.";
            }


            string Query = "DELETE FROM tbl_Product WHERE Id =" + int.Parse(id);
            db.RunQuery(Query);

            frmProductDetails frm = new frmProductDetails();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = string.Empty;

            if (lstvwproducts.SelectedItems.Count > 0)
            {
                a = lstvwproducts.SelectedItems[0].Text;
            }

            frmProduct editproduct = new frmProduct(a);
            editproduct.Show();
        }
    }
}
