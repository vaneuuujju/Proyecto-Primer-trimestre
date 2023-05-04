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
    //Tenemos que cambiar el internal de la class a public para que las otras capas pueden acceder 
    //a los metodos que la misma contenga (obvio si la misma se ha referenciado anteriormente)
    public class TipoUsuarioBL
    {
        //Metodo el cual va a retornar un string, el mismo recibe por argumentos una variable entera
        //y tambien un objeto de tipoUsuario
        public string GuardarTipoUsu(int nOpcion, TipoUsuarioET tipoUsuario)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoUsuarioDAL datos = new TipoUsuarioDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.GuardarTipoUsu(nOpcion, tipoUsuario);
        }

        public DataTable ListaTipoUsuario(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoUsuarioDAL datos = new TipoUsuarioDAL();
            //Retornamos un datatable con la lista de los tipos descuentos que estan registrados
            return datos.ListaTipoUsuario(cTexto);
        }
        //Metodo que retorna un bool, el mismo recibe por argumentos un objeto de TipoUsuario
        public bool ActualizarTipoUsuario(TipoUsuarioET tipoUsuario)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoUsuarioDAL datos = new TipoUsuarioDAL();
            // Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en
            //la capa dal
            return datos.ActualizarTipoUsuario(tipoUsuario);
        }

        public DataTable BuscarTipoUsuario(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoUsuarioDAL datos = new TipoUsuarioDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo de la capa DAL
            return datos.BuscarTipoUsuario(descripcion);
        }

    }
}
