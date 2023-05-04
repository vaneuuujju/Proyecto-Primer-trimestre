using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    //Preguntar sobre conexión de encabezado/detalle
    public class DetalleFacET
    {
        private int cantidad;
        private int idProducto;
        private int precioUnitario;
        private int total;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Total { get => total; set => total = value; }
    }
}
