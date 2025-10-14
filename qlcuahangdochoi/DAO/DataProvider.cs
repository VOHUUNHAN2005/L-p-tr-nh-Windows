using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace qlcuahangdochoi.DAO
{
    internal class DataProvider
    {
        static private string strConn = "Data source = HUUNHAN\\SQLEXPRESS;Initial Catalog=db_ql_cuahangdochoi;Integrated Security=True;";

        protected SqlConnection conn = new SqlConnection(strConn);
    }
}
