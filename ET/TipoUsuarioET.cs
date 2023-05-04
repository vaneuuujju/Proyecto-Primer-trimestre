using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class TipoUsuarioET
    {
        private int idTipoUsuario;
        private string nombre;
        private string descripcion;
        ///fijarse en variable permisos diagrama de clases

        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


    }
}
