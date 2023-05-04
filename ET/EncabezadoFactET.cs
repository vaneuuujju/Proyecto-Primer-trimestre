using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class EncabezadoFacET
    {
        private int idFactura;
        //preguntar tipo de dato fecha
        private string FechaEmision;
        private string NombreCliente;
        private int idCliente;
        private string nombreProvedor;
        private int idFormaPago;
        private int idImpuesto;

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string FechaEmision1 { get => FechaEmision; set => FechaEmision = value; }
        public string NombreCliente1 { get => NombreCliente; set => NombreCliente = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreProvedor { get => nombreProvedor; set => nombreProvedor = value; }
        public int IdFormaPago { get => idFormaPago; set => idFormaPago = value; }
        public int IdImpuesto { get => idImpuesto; set => idImpuesto = value; }
    }
}
