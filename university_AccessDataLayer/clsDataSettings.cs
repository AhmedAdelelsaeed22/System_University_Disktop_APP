using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace university_AccessDataLayer
{
    internal class clsDataSettings
    {
        public static string conectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public static string SourceName = ConfigurationManager.AppSettings["SourceName"]; // Event logging
    }
}
