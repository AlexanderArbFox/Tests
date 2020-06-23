using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестирование
{
    class RoleClass
    {
        public SqlConnection con;

        public RoleClass()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["RC"].ConnectionString);
        }

        public static string type;
    }
}
