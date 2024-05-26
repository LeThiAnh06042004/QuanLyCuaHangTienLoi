using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-V4DA6JL;Initial Catalog=LTA_CuaHangTienLoi;Integrated Security=True");
    }
}
