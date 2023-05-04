using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Impuesto
    {
        private int idImpestos;
        private float porcentaje;

        public int IdImpestos { get => idImpestos; set => idImpestos = value; }
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
