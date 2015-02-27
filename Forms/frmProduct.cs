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
        string ProductId { get; set; }

        public frmProduct()
        {
            InitializeComponent();
        }

        public frmProduct(string P_Id)
        {
            ProductId = P_Id;
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            try
            {
                List<string> unit = new List<string>();
                unit.Add("Piece");
                unit.Add("Box");
                cmbUnitType.DataSource = unit;

                string Query = "SELECT * FROM tbl_ProductCategory";
                DataSet ds = db.GetData(Query);

                cmbCategory.DataSource = ds.Tables[0];
                cmbCategory.DisplayMember = "ProductName";
                cmbCategory.ValueMember = "Id";
                
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

                if (string.IsNullOrEmpty(ProductId))
                {

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

                    string Query = "INSERT INTO tbl_Product(CategoryId,ProductName,Quantity,UnitType,Date) values('" + cmbCategory.SelectedValue + "','" + txtProductName.Text.Trim() + "','" + txtQuantity.Text.Trim() + "','" + cmbUnitType.SelectedItem + "','" + DateTime.Now + "')";
                    db.RunQuery(Query);

                    string Querys = "INSERT INTO tbl_Transaction(TransStatus,Date) VALUES('" + "Product Added" + "','" + DateTime.Now + "')";
                    db.RunQuery(Querys);
                }

                else
                {
                    string Query = "UPDATE tbl_Product SET CategoryId = '" + cmbCategory.SelectedValue + "', ProductName ='" + txtProductName.Text.Trim() + "', Quantity = '" + txtQuantity.Text.Trim() + "', UnitType = '" + cmbUnitType.SelectedItem + "', Date = '" + DateTime.Now + "' WHERE Id = " + int.Parse(ProductId);
                    db.RunQuery(Query);

                    string Querys = "INSERT INTO tbl_Transaction(TransStatus,Date) VALUES('" + "Product Added" + "','" + DateTime.Now + "')";
                    db.RunQuery(Querys);
                }

                frmProductDetails frm = new frmProductDetails();
                frm.Show();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
