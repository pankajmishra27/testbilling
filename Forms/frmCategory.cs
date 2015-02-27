using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopProducts.DbClasses;
using System.IO;

namespace ShopProducts.Forms
{
    public partial class frmCategory : Form
    {

        string ProductId { get; set; }

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            try
            {
               
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

        public frmCategory(string P_Id)
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

        private void btn_Savecategory_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                if(string.IsNullOrEmpty(ProductId))
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txt_categorycode.Text.Trim())) 
                        {
                            txt_categorycode.Text = "Enter Code";
                        }
                       
                    }
                    catch (Exception ex)
                    {

                    }

                    try
                    {
                        if (string.IsNullOrEmpty(txt_categoryname.Text.Trim())) 
                        {
                            txt_categoryname.Text = "Enter Name";
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_categorydescription.Text.Trim())) 
                        {
                            txt_categorydescription.Text = "Enter Description";
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                    if (string.IsNullOrEmpty(txt_categorycode.Text.Trim()) || string.IsNullOrEmpty(txt_categoryname.Text.Trim()) || string.IsNullOrEmpty(txt_categorydescription.Text.Trim()))
                    {
                        return;
                    }
              
                    string Query = "INSERT INTO tbl_ProductCategory values(" + txt_categorycode.Text.Trim() + ",'" + txt_categoryname.Text.Trim() + "','" + txt_categorydescription.Text.Trim() + "','" + DateTime.Now + "')";
                    db.RunQuery(Query);

                    string Querys = "INSERT INTO tbl_Transaction(TransStatus,Date) VALUES('" + "Product Category Added" + "','" + DateTime.Now + "')";
                    db.RunQuery(Querys);
                }
                else
                {
                    string Query = "UPDATE tbl_ProductCategory SET ProductCode = '" + txt_categorycode.Text.Trim() + "', ProductName ='" + txt_categoryname.Text.Trim() + "', ProductDescription = '" + txt_categorydescription.Text.Trim() + "' WHERE Id = " + int.Parse(ProductId);
                    db.RunQuery(Query);

                    string Querys = "INSERT INTO tbl_Transaction(TransStatus,Date) VALUES('" + "Product Category Added" + "','" + DateTime.Now + "')";
                    db.RunQuery(Querys);
                }


               
                    
                

                frmCategoryDetails frm = new frmCategoryDetails();
                frm.Show();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
