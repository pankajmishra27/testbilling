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
    public partial class frmProductDetails : Form
    {

        DBConnection dbConnection = new DBConnection();

        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
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
            Form1 frm = new Form1();
            frm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
