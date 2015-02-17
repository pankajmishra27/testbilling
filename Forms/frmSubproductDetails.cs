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
    public partial class frmSubproductDetails : Form
    {

        DBConnection dbConnection = new DBConnection();

        public frmSubproductDetails()
        {
            InitializeComponent();
        }

        private void frmSubproductDetails_Load(object sender, EventArgs e)
        {
            try
            {
                string Query = "Select * from tbl_Subproduct";
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
                        node.SubItems.Add(dt.Rows[i]["ProductId"].ToString());
                        node.SubItems.Add(dt.Rows[i]["SubproductName"].ToString());
                        //node.SubItems.Add(dt.Rows[i]["Quantity"].ToString());
                        //node.SubItems.Add(dt.Rows[i]["PerItemAmount"].ToString());
                        node.SubItems.Add(dt.Rows[i]["UnitType"].ToString());
                        node.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["Date"].ToString()).ToString("dd-MMM-yyyy"));

                        lstvwsubproducts.Items.Add(node);
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

        
    }
}
