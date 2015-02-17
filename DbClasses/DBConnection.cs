using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

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
    }
}
