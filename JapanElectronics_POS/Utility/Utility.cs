using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapanElectronics_POS.Utility
{
    public class Utility
    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["JapanElectornicsPOS"].ToString();
        }
    }
    public static class AppSettings
    {
        public static int AdminId { get; set; }
        public static string AdminName { get; set; }
    }
}
