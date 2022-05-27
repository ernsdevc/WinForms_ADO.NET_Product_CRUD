using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders25_ADO.NET_CRUD
{
    public class cls_Connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlcon = new SqlConnection("Server=MACHINEX;Database=NORTHWND;Trusted_Connection=True");
                return sqlcon;
            }
        }
    }
}
