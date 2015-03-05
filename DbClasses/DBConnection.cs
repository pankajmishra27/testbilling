using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace ShopProducts.DbClasses
{
    public class DBConnection
    {
        public static string strConnection = string.Empty;
        SqlConnection con = null;
        
        private void OpenConnection()
        
        {
            //string localAppDataDB = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails\\DB_Products.mdf";
            //public static string CONstr = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\InstagramSetup2\\DB_InstaSocial.db";
            string DB_Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ProductDetails\\DB_Products.mdf";
            strConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+DB_Path+";Integrated Security=True;User Instance=True";
           
            //strConnection = ConfigurationManager.ConnectionStrings["ShopProducts.Properties.Settings"].ConnectionString;
            con = new SqlConnection(strConnection);
            con.Open();
        }

        //Insert Delete Update
        public void RunQuery(string Query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }

        //Select
        public DataSet GetData(string Query)
        {
            DataSet ds = new DataSet();

            OpenConnection();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public DataTable RunPrintInvoice(string InvId)
        {
            DataTable table = new DataTable();
            OpenConnection();
            SqlCommand cmd = new SqlCommand("PrintInvoice", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DbParameter param = cmd.CreateParameter();
            param.ParameterName = "@InvId";
            param.Value = InvId;
            cmd.Parameters.Add(param);

            //cmd.Connection.Open();
            DbDataReader reader = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            return table;
        }

        public DataTable GetInvoiceNumber()
        {
            DataTable table = new DataTable();
            OpenConnection();
            SqlCommand cmd = new SqlCommand("getInvoiceNo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Connection.Open();
            DbDataReader reader = cmd.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            return table;
        }

        public bool InsertInvoiceMain(int InvoiceNo, DateTime InvoiceDate, string CustomerName, string CustomerId, string CustomerAddress, out int Rowid,
            string ChequeNo, string BankName, DateTime ChequeDate, string InvNetAmount, string InvTaxAmount)
        {

            Rowid = 0;
            
            OpenConnection();
            SqlCommand comm = new SqlCommand("InsertInvoiceMain", con);
            comm.CommandType = CommandType.StoredProcedure;

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "InvoiceNo";
            param.Value = InvoiceNo;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "InvoiceDate";
            param.Value = InvoiceDate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "InvoiceCustomer";
            param.Value = CustomerName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "InvoiceAddress";
            param.Value = CustomerAddress;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "InvoiceCustomerId";
            param.Value = CustomerId;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@InvoiceChequeNo";
            param.Value = ChequeNo;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@InvoiceBank";
            param.Value = BankName;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@InvChequeDate";
            param.Value = ChequeDate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            //@InvNetAmount numeric(18,2),
            //@InvTaxNetAmount

            param = comm.CreateParameter();
            param.ParameterName = "@InvNetAmount";
            param.Value = InvNetAmount;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@InvTaxNetAmount";
            param.Value = InvTaxAmount;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@RowId";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            int result = -1;
            try
            {
                result = comm.ExecuteNonQuery();
                Rowid = Int32.Parse(comm.Parameters["@RowId"].Value.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return (result != -1);

        }
    }
}
