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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            try
            {
                List<string> unit = new List<string>();
                unit.Add("Piece");
                unit.Add("Box");
                cmbUnitType.DataSource = unit;

                List<string> id = new List<string>();
                id.Add("Product Name");
                cmbCategory.DataSource = id;
            }
            catch (Exception ex)
            {
                
            }
           
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
                {
                    lblErrorMessage.Text = "Please Enter Product Name";
                    return;
                }

                if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
                {
                    lblErrorMessage.Text = "Please Enter Quantity Name";
                    return;
                }

                string Query = "INSERT INTO tbl_Subproduct values(" + cmbCategory.SelectedItem + ",'0','" + txtQuantity.Text.Trim() + "','" + txt_peritemamount.Text.Trim() + "','" + cmbUnitType.SelectedItem + "','" + DateTime.Now + "')";
                db.RunQuery(Query);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
