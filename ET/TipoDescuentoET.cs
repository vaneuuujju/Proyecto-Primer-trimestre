using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class TipoDescuento
    {
        private int idTipoDescuento;
        private string descripcion;

        public int IdTipoDescuento { get => idTipoDescuento; set => idTipoDescuento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
