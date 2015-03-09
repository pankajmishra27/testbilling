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
    public partial class frmInvoicemain : Form
    {
        DBConnection dbConnection = new DBConnection();
        int count = 0;
        float taxamt = 0;
        float amt = 0;
      
        public frmInvoicemain()
        {
            InitializeComponent();
        }

        private void DisplayInvoiceNo()
        {
            DataTable dt = new DataTable();
            dt = dbConnection.GetInvoiceNumber();
            if (dt.Rows.Count == 0)
                this.txt_invoicenumber.Text = "1";
            else
                this.txt_invoicenumber.Text = dt.Rows[0]["InvoiceNo"].ToString();
        }

        private void frmInvoicemain_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            try
            {
                try
                {
                    DisplayInvoiceNo();

                    string Query = "SELECT * FROM tbl_Customer";
                    DataSet ds = db.GetData(Query);

                    combo_invoicecustomerID.DataSource = ds.Tables[0];
                    combo_invoicecustomerID.DisplayMember = "Id";

                    combo_invoicecustomerName.DataSource = ds.Tables[0];
                    combo_invoicecustomerName.DisplayMember = "Name";
                }
                catch (Exception ex)
                {

                }

                try
                {
                    string Query = "SELECT * FROM tbl_Product";
                    DataSet ds = db.GetData(Query);

                    combo_productname.DataSource = ds.Tables[0];
                    combo_productname.DisplayMember = "ProductName";

                    combo_description.DataSource = ds.Tables[0];
                    combo_description.DisplayMember = "ProductCode";

                }
                catch (Exception ex)
                {                 
                  
                }
            }
            catch (Exception ex)
            {
                
            }    
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                try
                {
                    if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                    {
                        txt_invoicenumber.Text = "Please enter invoice number";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_customeraddress.Text.Trim()))
                    {
                        txt_customeraddress.Text = "Please enter customer address";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_chequenumber.Text.Trim()))
                    {
                        txt_chequenumber.Text = "Enter Cheque No.";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_bank.Text.Trim()))
                    {
                        txt_bank.Text = " Enter Bank name";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                    {
                        txt_taxamount.Text = "Enter Tax Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                try
                {
                    if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                    {
                        txt_amount.Text = "Enter Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    
                }
                //if(string.IsNullOrEmpty(combo_invoicecustomerID.Text) || string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()) || string.IsNullOrEmpty(combo_invoicecustomerName.Text) || string.IsNullOrEmpty(txt_customeraddress.Text.Trim()) || string.IsNullOrEmpty(txt_chequenumber.Text.Trim()) || string.IsNullOrEmpty(txt_bank.Text.Trim()) || string.IsNullOrEmpty(txt_taxamount.Text.Trim()) || string.IsNullOrEmpty(txt_amount.Text.Trim()))
                //{
                //    return; 
                //}

                
                //string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + txt_customername.Text.Trim() + "','" + txt_customeraddress.Text.Trim() + "','" + txt_customerid.Text.Trim() + "','" +  txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";//,'" + DateTime.Now + "')";
                string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + combo_invoicecustomerName.Text + "','" + txt_customeraddress.Text.Trim() + "','" + combo_invoicecustomerID.Text + "','" + txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";
                db.RunQuery(Query);     
            }
            catch (Exception ex)
            {

            }
        }

        //private void btn_Saveinvoice_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        DBConnection db = new DBConnection();
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
        //            {
        //                txt_invoicenumber.Text = "Please enter invoice number";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_customeraddress.Text.Trim()))
        //            {
        //                txt_customeraddress.Text = "Please enter customer address";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_chequenumber.Text.Trim()))
        //            {
        //                txt_chequenumber.Text = "Enter Cheque No.";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_bank.Text.Trim()))
        //            {
        //                txt_bank.Text = " Enter Bank name";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
        //            {
        //                txt_taxamount.Text = "Enter Tax Amount";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        try
        //        {
        //            if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
        //            {
        //                txt_amount.Text = "Enter Amount";
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        if (string.IsNullOrEmpty(combo_invoicecustomerID.Text) || string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()) || string.IsNullOrEmpty(combo_invoicecustomerName.Text) || string.IsNullOrEmpty(txt_customeraddress.Text.Trim()) || string.IsNullOrEmpty(txt_chequenumber.Text.Trim()) || string.IsNullOrEmpty(txt_bank.Text.Trim()) || string.IsNullOrEmpty(txt_taxamount.Text.Trim()) || string.IsNullOrEmpty(txt_amount.Text.Trim()))
        //        {
        //            return;
        //        }

        //        string Query = "INSERT INTO tbl_InvoiceMain values(" + txt_invoicenumber.Text.Trim() + ",'" + txt_invoicedate.Text.Trim() + "','" + combo_invoicecustomerName.Text + "','" + txt_customeraddress.Text.Trim() + "','" + combo_invoicecustomerID.Text + "','" + txt_chequenumber.Text.Trim() + "','" + txt_bank.Text.Trim() + "','" + txt_chequedate.Text.Trim() + "','" + txt_taxamount.Text.Trim() + "','" + txt_amount.Text.Trim() + "')";
        //        db.RunQuery(Query);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //   //try
        //   // {
        //   //     DBConnection db = new DBConnection();
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
        //   //         {
        //   //             txt_invoicenumber.Text = "Enter Invoice Number";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {

        //   //     }
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
        //   //         {
        //   //             txt_quantity.Text = "Enter Quantity";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {

        //   //     }
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_rate.Text.Trim()))
        //   //         {
        //   //             txt_rate.Text = "Enter Rate";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {

        //   //     }
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_taxpercent.Text.Trim()))
        //   //         {
        //   //             txt_taxpercent.Text = "Enter Tax Percent";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {
                    
        //   //         throw;
        //   //     }
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
        //   //         {
        //   //             txt_taxamount.Text = "Enter Tax Amount";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {

        //   //     }
        //   //     try
        //   //     {
        //   //         if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
        //   //         {
        //   //             txt_amount.Text = "Enter Amount";
        //   //         }
        //   //     }
        //   //     catch (Exception ex)
        //   //     {

        //   //     }

        //   //    //If we add totaltax amount & total amount from listview
        //   //     string Querys = "INSERT INTO tbl_InvoiceSub(InvId,PrName,PrDescription,PrQty,PrRate,PrTaxPercent,PrTaxAmount,PrAmount) VALUES(" + int.Parse(txt_invoicenumber.Text.Trim()) + ",'" + combo_productname.Text + "','" + combo_description.Text + "'," + double.Parse(txt_quantity.Text.Trim()) + "," + txt_rate.Text.Trim() + "," + double.Parse(txt_taxpercent.Text.Trim()) + "," + double.Parse(txt_taxamount.Text.Trim()) + "," + double.Parse(txt_amount.Text.Trim()) + ")";
               
               
        //   //    // if we add only tax amount & MAOUNT 
        //   //    // string Querys = "INSERT INTO tbl_InvoiceSub(InvId,PrName,PrDescription,PrQty,PrRate,PrTaxPercent,PrTaxAmount,PrAmount) VALUES(" + int.Parse(txt_invoicenumber.Text.Trim()) + ",'" + combo_productname.Text + "','" + combo_description.Text + "'," + double.Parse(txt_quantity.Text.Trim()) + "," + txt_rate.Text.Trim() + "," + double.Parse(txt_taxpercent.Text.Trim()) + "," + double.Parse(txt_taxamount.Text.Trim()) + "," + double.Parse(txt_amount.Text.Trim()) + ")";
        //   //     db.RunQuery(Querys);

                
        //   // }
        //   // catch (Exception ex)
        //   // {

        //   // }
        //}

        
        private void btn_addtolistview_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    try
                    {
                        if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                        {
                            txt_invoicenumber.Text = "Enter Invoice Number";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
                        {
                            txt_quantity.Text = "Enter Quantity";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_rate.Text.Trim()))
                        {
                            txt_rate.Text = "Enter Rate";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_taxpercent.Text.Trim()))
                        {
                            txt_taxpercent.Text = "Enter Tax Percent";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                        {
                            txt_taxamount.Text = "Enter Tax Amount";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                        {
                            txt_amount.Text = "Enter Amount";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                catch (Exception ex)
                {

                }
                int remain = 0;

                ListViewItem item = lst_Invoicemain.FindItemWithText(combo_productname.Text);

                if (item == null)
                {
                    DBConnection db = new DBConnection();
                    string Query = " SELECT * FROM tbl_Product WHERE ProductName = '" + combo_productname.Text + "'";
                    DataSet d = db.GetData(Query);
                    DataTable dt = d.Tables[0];

                    int qua = int.Parse(dt.Rows[0]["Quantity"].ToString());
                    int remainQty = qua - remain;
                    remain = remain + int.Parse(txt_quantity.Text.Trim());

                    if (qua >= remain)
                    {

                        ListViewItem node = new ListViewItem();

                        count++;
                        node.Text = count.ToString();
                        node.SubItems.Add(combo_productname.Text);
                        node.SubItems.Add(combo_description.Text);
                        node.SubItems.Add(txt_quantity.Text.Trim());
                        node.SubItems.Add(txt_rate.Text.Trim());
                        node.SubItems.Add(txt_taxpercent.Text.Trim());
                        node.SubItems.Add(txt_taxamount.Text.Trim());
                        node.SubItems.Add(txt_amount.Text.Trim());

                        lst_Invoicemain.Items.Add(node);

                        taxamt += float.Parse(txt_taxamount.Text.Trim());
                        txt_totaltaxamount.Text = taxamt.ToString();

                        amt += float.Parse(txt_amount.Text.Trim());
                        txt_totalamount.Text = amt.ToString();

                    }
                    else
                    {
                        MessageBox.Show("You can take only " + remainQty.ToString() + " " + combo_productname.Text);
                    }
                }
                else
                {
                    MessageBox.Show("This " + combo_productname.Text + " already added in List.");
                }
            }
            catch (Exception ex)
            {
                
            }            
        }

        private void btn_deletetolistview_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem lvItem in lst_Invoicemain.SelectedItems)
                {
                    lst_Invoicemain.Items.Remove(lvItem);
                }
            }
            catch (Exception ex)
            {

            }
        }

        //int totalQty = 0;
        int remain = 0;
        private void btn_Saveinvoice_Click_1(object sender, EventArgs e)
        {
            lst_Invoicemain.View = View.Details;
   
            try
            {
                DBConnection db = new DBConnection();
                
                try
                {
                    if (string.IsNullOrEmpty(txt_invoicenumber.Text.Trim()))
                    {
                        txt_invoicenumber.Text = "Please enter invoice number";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_customeraddress.Text.Trim()))
                    {
                        txt_customeraddress.Text = "Please enter customer address";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_chequenumber.Text.Trim()))
                    {
                        txt_chequenumber.Text = "Enter Cheque No.";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_bank.Text.Trim()))
                    {
                        txt_bank.Text = " Enter Bank name";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_taxamount.Text.Trim()))
                    {
                        txt_taxamount.Text = "Enter Tax Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    if (string.IsNullOrEmpty(txt_amount.Text.Trim()))
                    {
                        txt_amount.Text = "Enter Amount";
                        return;
                    }
                }
                catch (Exception ex)
                {

                }

                int Rowid;
                db.InsertInvoiceMain(int.Parse(txt_invoicenumber.Text.ToUpper().Trim()),DateTime.Parse(txt_invoicedate.Text.Trim()),combo_invoicecustomerName.Text.ToUpper().Trim(),
                                    combo_invoicecustomerID.Text,txt_customeraddress.Text.ToUpper().Trim(),out Rowid,txt_chequenumber.Text.Trim(),
                                    txt_bank.Text.ToUpper().Trim(), DateTime.Parse(txt_chequedate.Text.Trim()), txt_totalamount.Text.Trim(), txt_totaltaxamount.Text.Trim());

                for (int i = 0; i < this.lst_Invoicemain.Items.Count; i++)
                {
                    try
                    {
                        
                        //string fruitcode = dt.Rows[0]["ProductCode"].ToString();

                        string PrId = this.lst_Invoicemain.Items[i].Text;
                        string PrQty = this.lst_Invoicemain.Items[i].SubItems[3].Text;
                        string PrRate = this.lst_Invoicemain.Items[i].SubItems[4].Text;
                        string PrTaxPer = this.lst_Invoicemain.Items[i].SubItems[5].Text;
                        string SubQuery = "insert into tbl_InvoiceSub(InvId,PrId,PrQty,PrRate,PrTaxPercent) values('" + Rowid + "','" + this.lst_Invoicemain.Items[i].SubItems[2].Text + "','" + PrQty + "','" + PrRate + "','" + PrTaxPer + "')";
                        db.RunQuery(SubQuery);


                        string Querys = " SELECT * FROM tbl_Product WHERE ProductName = '" + this.lst_Invoicemain.Items[i].SubItems[1].Text + "'";
                        DataSet d = db.GetData(Querys);
                        DataTable dt = d.Tables[0];
                        int qua = int.Parse(dt.Rows[0]["Quantity"].ToString());
                        int remainQty = qua - int.Parse(this.lst_Invoicemain.Items[i].SubItems[3].Text);

                        string Query = " UPDATE tbl_Product SET Quantity = " + remainQty + " WHERE ProductName ='" + this.lst_Invoicemain.Items[i].SubItems[1].Text + "'";
                        db.RunQuery(Query);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }
            this.Close();
        }

       
        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rate.Text))
            {
                double val1 = double.Parse(txt_quantity.Text);
                double val2 = double.Parse(txt_rate.Text);
                double val3 = val1 * val2;
                txt_amount.Text = val3.ToString();
            }
        }

        private void txt_taxpercent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_taxpercent.Text))
            {
                double val1 = double.Parse(txt_amount.Text);
                double val2 = double.Parse(txt_taxpercent.Text);
                double val3 = val1 * val2;
                double val4 = val3 / 100;
                txt_taxamount.Text = val4.ToString();
            }
        }
    }
}
