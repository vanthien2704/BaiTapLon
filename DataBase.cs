using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaiTapLon
{
    class DataBase
    {
        public static SqlConnection SqlConnection = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLBANHANG;Persist Security Info=True;User ID=admin;Password=admin");
    }
}
