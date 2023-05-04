using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ProductoET
    {
        private int _idProducto;
        private string descripcion;
        private float precio;
        private int idImpuesto;
        private int cantidad;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int IdImpuesto { get => idImpuesto; set => idImpuesto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }

}
