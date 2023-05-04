using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class TipoClienteET
    {
        private int idTipoCliente;
        private string nombreTipoCliente;
        private string descripcion;

        public int IdTipoCliente { get => idTipoCliente; set => idTipoCliente = value; }
        public string NombreTipoCliente { get => nombreTipoCliente; set => nombreTipoCliente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
