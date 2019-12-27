using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diablo.MvcWebApp.Helpers
{
    static class SharedHelper
    {
        public static string GetConnectionString()
        {
            return GetConnectionString("DBContext");
        }

        public static string GetConnectionString(string name)
        {
            String connectionString = null;

            if (System.Web.Configuration.WebConfigurationManager.ConnectionStrings[name] != null)
            {
                connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[name].ToString();
            }

            return connectionString;
        }
    }
}