using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProducts.DbClasses
{
    public class ProductRepository
    {
        DBConnection dbConnection = new DBConnection();

        public void AddProduct(string ProductCode, string ProductName, string ProductDescription)
        {
            try
            {
                string Query = "insert into tbl_Product(ProductName,Productdescription,DateTime) values('" + ProductName + "','" + ProductDescription + "'," + DateTime.Now + ")";
                dbConnection.RunQuery(Query);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
