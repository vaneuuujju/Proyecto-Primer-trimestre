using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciamos a las capas que vamos a utilizar
using DAL;
using ET;
namespace BL
{

    //Tenemos que cambiar el internal de la class a public para que las otras capas pueden acceder 
    //a los metodos que la misma contenga (obvio si la misma se ha referenciado anteriormente)
    public class TipoClienteBL
    {
        public string GuardarTipoCli(int nOpcion, TipoClienteET tipoCliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoClienteDAL datos = new TipoClienteDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.GuardarTipoCli(nOpcion, tipoCliente);
        }

        //Metodo publico que nos retorna un bool
        public bool ActualizarTipoCliente(TipoClienteET tipoCliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoClienteDAL datos = new TipoClienteDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarTipoCliente(tipoCliente);
        }
        //Metodo para buscar los diferentes tipos de clientes que estan registrados 
        public DataTable BuscarTipoCliente(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoClienteDAL datos = new TipoClienteDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo
            return datos.BuscarTipoCliente(descripcion); 
        }
    }
}
