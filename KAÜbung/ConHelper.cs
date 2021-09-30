using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAÜbung
{
    public static class ConHelper
    {
        public static string ConVal(String name)
        {
            string con = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return con;
        }
    }
}
