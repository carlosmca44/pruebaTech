using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pruebaTech
{
    class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection cn = new SqlConnection(@"SERVER=DESKTOP-TS7SI57\SQLEXPRESS;DATABASE=PRUEBA;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
