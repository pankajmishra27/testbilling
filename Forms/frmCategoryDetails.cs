using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopProducts.DbClasses;

namespace ShopProducts.Forms
{
    public partial class frmCategoryDetails : Form
    {

        DBConnection dbConnection = new DBConnection();

        public frmCategoryDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "Select * from tbl_ProductCategory";
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
                        node.SubItems.Add(dt.Rows[i]["ProductCode"].ToString());
                        node.SubItems.Add(dt.Rows[i]["ProductName"].ToString());
                        node.SubItems.Add(dt.Rows[i]["ProductDescription"].ToString());
                        node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                        lstvwProduct.Items.Add(node);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void lst_Invoicemain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleteproduct_Click(object sender, EventArgs e)
        {
            try
            {
                 DBConnection db = new DBConnection();
            string id = string.Empty;

            if(!string.IsNullOrEmpty(lstvwProduct.FocusedItem.SubItems[0].Text))
            {            
                 id = lstvwProduct.FocusedItem.SubItems[0].Text;
            }
            else
            {
                string msg = "Please select a row.";
            }

            string Query = "DELETE FROM tbl_ProductCategory WHERE Id =" + int.Parse(id);
            db.RunQuery(Query);

            frmCategoryDetails frm = new frmCategoryDetails();
            frm.Show();

            }
            catch (Exception ex)
            {
                
            }

        }

        private void btn_editproducts_Click(object sender, EventArgs e)
        {
            string a = string.Empty;

            if (lstvwProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Row");
                return;
            }
            if (lstvwProduct.SelectedItems.Count > 0)
            {
                a = lstvwProduct.SelectedItems[0].Text;
            }

            frmCategory editproduct = new frmCategory(a);
            editproduct.Show();
        }
    }
}
