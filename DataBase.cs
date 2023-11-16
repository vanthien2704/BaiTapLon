using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BaiTapLon
{
    class DataBase
    {
        public static SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BaiTapLon.Properties.Settings.QLBANHANGConnectionString"].ConnectionString);
    }
}
