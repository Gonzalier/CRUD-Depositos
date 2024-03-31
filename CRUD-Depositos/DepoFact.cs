using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Depositos
{
    internal class DepoFact
    {
        public String Nombre { get; set; }
        public int NumeroReserva { get; set; }
        public String CheckOut { get; set; }
        public String Monto { get; set; }
        public String Agencia { get; set; }
        public int NumeroTramite { get; set; }
        public String Motivo { get; set; }
        public int NFactura { get; set; }
        public String Fecha { get; set; }
        public DepoFact() { }
        public DepoFact(string nombre, int numeroReserva, string checkOut, string monto, string agencia, int numeroTramite, string motivo, int nFactura, string fecha)
        {
            Nombre = nombre;
            NumeroReserva = numeroReserva;
            CheckOut = checkOut;
            Monto = monto;
            Agencia = agencia;
            NumeroTramite = numeroTramite;
            Motivo = motivo;
            NFactura = nFactura;
            Fecha = fecha;
        }
    }
}
