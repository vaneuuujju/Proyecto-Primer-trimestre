using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;
namespace BL
{
    public class UsuarioBL
    {

        public string GuardarUsuario(int nOpcion, UsuarioET usuario)
        {
            UsuarioDAL datos = new UsuarioDAL();
            return datos.GuardarUsuario(nOpcion, usuario);
        }
        public DataTable ListaUsuario(string cTexto)
        {
            UsuarioDAL datos = new UsuarioDAL();
            return datos.ListaUsuario(cTexto);
        }

        public string EliminarUsuario(int idUsuario)
        {
            UsuarioDAL datos = new UsuarioDAL();
            return datos.EliminarUsuario(idUsuario);
        }

        public bool ActualizarUsuario(UsuarioET usuario)
        {
            UsuarioDAL datos = new UsuarioDAL();
            return datos.ActualizarUsuario(usuario);
        }
        public DataTable BuscarUsuario(string nombre)
        {
            UsuarioDAL datos = new UsuarioDAL();
            return datos.BuscarUsuario(nombre);
        }
    }
}
