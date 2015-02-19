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

            lbl_subproductname.Visible = false;
            lbl_Quantity.Visible = false;
            lbl_peritemamount.Visible = false;

            List<string> unit = new List<string>();
            unit.Add("Piece");
            unit.Add("Box");
            combo_unittype.DataSource = unit;

            List<string> id = new List<string>();
            id.Add("Product Name");
            combo_productid.DataSource = id;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                try
                {
                    combo_productid.Text = combo_productid.Text.Trim();
                    //txt_pid.Text = txt_pid.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (!string.IsNullOrEmpty(txt_subpname.Text.Trim()))
                    {
                        string Pname = txt_subpname.Text.Trim();
                    }
                    else
                    {
                        lbl_subproductname.Text = "Please Enter Subproduct Name";
                        lbl_subproductname.Visible = true;
                        return;
                    }
                    //txt_subpname.Text = txt_subpname.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (!string.IsNullOrEmpty(txt_quantity.Text.Trim()))
                    {
                        string Pname = txt_quantity.Text.Trim();
                    }
                    else
                    {
                        lbl_Quantity.Text = "Please Enter Quantity";
                        lbl_Quantity.Visible = true;
                        return;
                    }
                    //txt_quantity.Text = txt_quantity.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (!string.IsNullOrEmpty(txt_peritemamount.Text.Trim()))
                    {
                        string Pname = txt_peritemamount.Text.Trim();
                    }
                    else
                    {
                        lbl_peritemamount.Text = "Please Enter Peritem Amount";
                        lbl_peritemamount.Visible = true;
                        return;
                    }
                    //txt_peritemamount.Text = txt_peritemamount.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    combo_unittype.Text = combo_unittype.Text.Trim();
                }
                catch (Exception ex)
                {

                }
                string Query = "INSERT INTO tbl_Subproduct values(" + combo_productid.SelectedItem + ",'" + txt_subpname.Text.Trim() + "','" + txt_quantity.Text.Trim() + "','" + txt_peritemamount.Text.Trim() + "','" + combo_unittype.SelectedItem + "','" + DateTime.Now + "')";
                db.RunQuery(Query);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
