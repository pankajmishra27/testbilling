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
            List<string> unit = new List<string>();
            unit.Add("Piece");
            unit.Add("Box");

            combo_unittype.DataSource = unit;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            try
            {
                txt_pid.Text = txt_pid.Text.Trim();
            }
            catch (Exception ex)
            {

            }
            try
            {
                txt_subpname.Text = txt_subpname.Text.Trim();
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
                txt_peritemamount.Text = txt_peritemamount.Text.Trim();
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
            //try
            //{
            //    txt_unittype.Text = txt_unittype.Text.Trim();
            //}
            //catch (Exception ex)
            //{

            //}
            //string Query = "INSERT INTO tbl_Subproduct values(" + txt_pid.Text + ",'" + txt_subpname.Text + "','" + txt_quantity.Text + "','" + txt_peritemamount.Text +"','" + txt_unittype.Text +"','"+ DateTime.Now + "')";
            string Query = "INSERT INTO tbl_Subproduct values(" + txt_pid.Text.Trim() + ",'" + txt_subpname.Text.Trim() + "','" + txt_quantity.Text.Trim() + "','" + txt_peritemamount.Text.Trim() + "','" + combo_unittype.SelectedItem  + "','" + DateTime.Now + "')";
            db.RunQuery(Query);
        }
    }
}
