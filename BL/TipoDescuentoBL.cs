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
    public class TipoDescuentoBL
    {
        //Metodo publico que retorna un string 
        public string GuardarTipoDescuento(int nOpcion, TipoDescuentoET tipoDescuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoDescuentoDAL datos = new TipoDescuentoDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.GuardarTipoDescuento(nOpcion, tipoDescuento);
        }

        public DataTable ListaTipoDescuento(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoDescuentoDAL datos = new TipoDescuentoDAL();
            //Retornamos un datatable con la lista de los tipos descuentos que estan registrados
            return datos.ListaTipoDescuento(cTexto);
        }

        public bool ActualizarTipoDescuento(TipoDescuentoET tipoDescuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoDescuentoDAL datos = new TipoDescuentoDAL();
            // Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en
            //la capa dal
            return datos.ActualizarTipoDescuento(tipoDescuento);
        }

        public DataTable BuscarTipoDescuento(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoDescuentoDAL datos = new TipoDescuentoDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo
            return datos.BuscarTipoDescuento(descripcion);
        }


    }
}
