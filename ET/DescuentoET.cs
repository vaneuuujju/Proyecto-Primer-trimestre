using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class DescuentoET
    {
        private int idDescuento;
        private float procentaje;

        public int IdDescuento { get => idDescuento; set => idDescuento = value; }
        public float Procentaje { get => procentaje; set => procentaje = value; }
    }
}
