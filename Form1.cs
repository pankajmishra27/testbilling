﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopProducts.DbClasses;
using System.IO;
using ShopProducts.Forms;

namespace ShopProducts
{
    public partial class Form1 : Form
    {
        string ProductId { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                    //lbl_code.Visible = false;
                    //lbl_name.Visible = false;
                    //lbl_description.Visible = false;

                    string LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails";
                    
                    if (!Directory.Exists(ApplicationData.FolderLocalApplicationPath))
                    {
                        Directory.CreateDirectory(ApplicationData.FolderLocalApplicationPath);
                    }

                   // ApplicationData.StartPath = ApplicationData.FolderLocalApplicationPath;

                    if (!Directory.Exists(LocalPath))
                    {
                        Directory.CreateDirectory(LocalPath);
                    }


                   CopyDatabase();
                   //DBConnection db = new DBConnection();
                   ////DatabaseHandler.InsertQuery("('" +"qwert" + "zxcvb" + DateTime.Now.ToString() + "')", "tbl_Product");
                   //try
                   //{
                   //    // Query = "INSERT INTO tbl_Product values(" + 1 + ",'" + "Grapes" + "','" + "Sweet" + "','" + DateTime.Now + "')";
                   //    string Query = "INSERT INTO tbl_Product values(" + txt_productcode.Text + ",'" + txt_productname.Text + "','" + txt_productdescription.Text + "','" + DateTime.Now + "')";
                   //    db.RunQuery(Query);
                   //}
                   //catch (Exception ex)
                   //{

                   //}
                    
            }
            catch (Exception ex)
            {
                
            }
        }

        public Form1(string P_Id)
        {
            ProductId = P_Id;
            InitializeComponent();
        }

        private void CopyDatabase()
        {

            string startUpDB = Application.StartupPath + "\\DB_Products.mdf";
            string localAppDataDB = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails\\DB_Products.mdf";

            string startUpDB64 = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\DB_Products.mdf";

            if (!File.Exists(localAppDataDB))
            {
                ///Modified [19-10] to work with 64 Bit as well

                if (File.Exists(startUpDB))
                {
                    try
                    {
                        File.Copy(startUpDB, localAppDataDB);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Could not find a part of the path"))
                        {
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails");
                            File.Copy(startUpDB, localAppDataDB);
                        }
                    }
                }
                else if (File.Exists(startUpDB64))   //for 64 Bit
                {
                    try
                    {
                        File.Copy(startUpDB64, localAppDataDB);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Could not find a part of the path"))
                        {
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails");
                            File.Copy(startUpDB64, localAppDataDB);
                        }
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DBConnection db = new DBConnection();
            //    if (string.IsNullOrEmpty(ProductId))
            //    {
            //        try
            //        {
            //            if (!string.IsNullOrEmpty(txt_productcode.Text.Trim()))
            //            {
            //                string Pcode = txt_productcode.Text.Trim();
            //            }
            //            else
            //            {
            //                lbl_code.Text = "Please Enter Product Code";
            //                lbl_code.Visible = true;
            //                return;
            //            }
            //            //txt_productcode.Text = txt_productcode.Text.Trim();
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //        try
            //        {
            //            if (!string.IsNullOrEmpty(txt_productname.Text.Trim()))
            //            {
            //                string Pname = txt_productname.Text.Trim();
            //            }
            //            else
            //            {
            //                lbl_name.Text = "Please Enter Product Name";
            //                lbl_name.Visible = true;
            //                return;
            //            }
            //            //txt_productname.Text = txt_productname.Text.Trim();
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //        try
            //        {
            //            if (!string.IsNullOrEmpty(txt_productdescription.Text.Trim()))
            //            {
            //                string Pdescription = txt_productdescription.Text.Trim();
            //            }
            //            else
            //            {
            //                lbl_description.Text = "Please Enter Product Description";
            //                lbl_description.Visible = true;
            //                return;
            //            }
            //            //txt_productdescription.Text = txt_productdescription.Text.Trim();
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //        string Query = "INSERT INTO tbl_ProductCategory values(" + txt_productcode.Text.Trim() + ",'" + txt_productname.Text.Trim() + "','" + txt_productdescription.Text.Trim() + "','" + DateTime.Now + "')";
            //        db.RunQuery(Query);
            //    }
            //    else
            //    {
            //        string Query = "UPDATE tbl_ProductCategory SET ProductCode = '" + txt_productcode.Text.Trim() + "', ProductName ='" + txt_productname.Text.Trim() + "', ProductDescription = '" + txt_productdescription.Text.Trim() + "' WHERE Id = " + int.Parse(ProductId);
            //        db.RunQuery(Query);
            //    }


                frmCategoryDetails frm = new frmCategoryDetails();
                frm.Show();

            //    frmProductDetails frm = new frmProductDetails();
            //    frm.Show();

             
            //}
            //catch (Exception ex)
            //{
                
            //}      
        }

        private void lbl_code_Click(object sender, EventArgs e)
        {

        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCategoryDetails frm = new frmCategoryDetails();
            frm.Show();

            //frmProductDetails frm = new frmProductDetails();
            //frm.Show();

        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCustomerDetails frm = new frmCustomerDetails();
            //frm.Show();
        }

        private void viewInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmInvoicemain frm = new frmInvoicemain();
            //frm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductDetails frmPro = new frmProductDetails();
                frmPro.Show();
            }
            catch (Exception ex)
            {
              
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProduct frmPro = new frmProduct();
                frmPro.Show();
            }
            catch (Exception ex)
            {
            
            }  
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCategory frmPro = new frmCategory();
                frmPro.Show();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCategoryDetails frmpro = new frmCategoryDetails();
                frmpro.Show();
            }
            catch (Exception ex)
            {
              
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoicemain frmPro = new frmInvoicemain();
                frmPro.Show();
            }
            catch (Exception ex)
            {
              
            }  
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoicemainDetails frmpro = new frmInvoicemainDetails();
                frmpro.Show();
            }
            catch (Exception ex)
            {
             
            }    
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomer frmPro = new frmCustomer();
                frmPro.Show();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerDetails frmPro = new frmCustomerDetails();
                frmPro.Show();
            }
            catch (Exception ex)
            {
                
            } 
        }

        private void searchInvoiceDeatailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnMain frm = new frmReturnMain();
            frm.Show();
        }
    }
}
