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
    public partial class frmTransaction : Form
    {
        DBConnection dbConnection = new DBConnection();

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            List<string> unit = new List<string>();
            unit.Add("Piece");
            unit.Add("Box");
            combo_subproductid.DataSource = unit;
        }

        private void btn_transactionsave_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            try
            {
                combo_subproductid.Text = combo_subproductid.Text.Trim();                    
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
                    {
                        txt_quantity.Text = "Please enter quantity";
                        return;
                    }     
            }
            catch (Exception ex)
            {
                
            }
            try
            {
                if (string.IsNullOrEmpty(txt_status.Text.Trim()))
                    {
                        txt_status.Text = "Please enter status";
                        return;
                    }
            }
            catch (Exception ex)
            {
                
            }
            try
            {
                if (string.IsNullOrEmpty(txt_remark.Text.Trim()))
                {
                    txt_remark.Text = "Please enter remarks";
                    return;
                }      
            }
            catch (Exception ex)
            {
              
            }

            string Query = "INSERT INTO tbl_Transaction values('" + combo_subproductid.SelectedItem + "'," + txt_quantity.Text.Trim() + ",'" + txt_status.Text.Trim() + "','" + txt_remark.Text.Trim() + "','" + DateTime.Now + "')";
            db.RunQuery(Query);  
        }
    }
}
