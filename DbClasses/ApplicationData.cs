using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProducts.DbClasses
{
    public class ApplicationData
    {

        public static string StartPath = string.Empty;
        public static string FolderLocalApplicationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ProductDetails";
    }
}
