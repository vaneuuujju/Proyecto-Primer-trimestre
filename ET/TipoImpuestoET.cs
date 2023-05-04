using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class TipoImpuestoET
    {
        private int idTipoImpuesto;
        private string descrpcion;

        public int IdTipoImpuesto { get => idTipoImpuesto; set => idTipoImpuesto = value; }
        public string Descrpcion { get => descrpcion; set => descrpcion = value; }
    }
}
