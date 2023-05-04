using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class TipoFacturaET
    {
        private int idTipoFactura;
        private string descripcion;

        public int IdTipoFactura { get => idTipoFactura; set => idTipoFactura = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
