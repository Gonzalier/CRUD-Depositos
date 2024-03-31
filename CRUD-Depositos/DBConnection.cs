using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Depositos
{
    internal class DBConnection
    {
        public static SqlConnection ObtenerConexcion()
        {
            SqlConnection conexion = new SqlConnection("Password=mara123;Persist Security Info=True;User ID=GonzaPC;Initial Catalog=Depositos;Data Source=192.168.0.107\r\n");
            conexion.Open();
            return conexion;
        }
    }
}
