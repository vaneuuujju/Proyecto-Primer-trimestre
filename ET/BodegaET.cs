using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BodegaET
    {
        private int idBodega;
        private string nombre;
        private int productosAlmacenados;
        private float cantidad;

        public int IdBodega { get => idBodega; set => idBodega = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int ProductosAlmacenados { get => productosAlmacenados; set => productosAlmacenados = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
    }
}
