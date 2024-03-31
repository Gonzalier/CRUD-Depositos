using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Depositos
{
    internal class VDatos
    {

        public static List<DepoFact> presetarLista()
        {
            List<DepoFact> lista = new List<DepoFact>();
            using (SqlConnection conexion = DBConnection.ObtenerConexcion())
            {
                String query = "SELECT * FROM Facturas";
                SqlCommand comando = new SqlCommand(query,conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DepoFact deposito = new DepoFact();
                    deposito.Nombre = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                    {
                        deposito.NumeroReserva = reader.GetInt32(1);
                    }
                    deposito.CheckOut = reader.GetString(2);
                    deposito.Monto = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                    {
                        deposito.Agencia = reader.GetString(4);
                    }

                    deposito.NumeroTramite = reader.GetInt32(5);
                    deposito.Motivo = reader.GetString(6);
                    deposito.NFactura =reader.GetInt32(7);
                    deposito.Fecha = reader.GetString(8);
                    lista.Add(deposito);


                }
                conexion.Close();
                return lista;
            }
        }
    }
}
