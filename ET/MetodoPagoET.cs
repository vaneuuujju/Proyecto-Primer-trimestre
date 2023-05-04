using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class MetoPagoET
    {
        private int idTipoPago;
        private string descripcion;

        public int IdTipoPago { get => idTipoPago; set => idTipoPago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
