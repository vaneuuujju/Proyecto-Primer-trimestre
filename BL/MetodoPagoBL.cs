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
    public class MetodoPagoBL
    {
        //Metodo publico que retorna un string
        public string GuardarMetodoPago(int nOpcion, MetoPagoET metodoPago)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            MetodoPagoDal datos = new MetodoPagoDal();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.GuardarMetodoPago(nOpcion, metodoPago);
        }

        public DataTable ListaMetodoPago(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            MetodoPagoDal datos = new MetodoPagoDal();
            //Vamos a retornar un objeto de tipo Datatable, elcual contiene todo los metodos de pago registrados
            return datos.ListaMetodoPago(cTexto); 
        }
        public string EliminarMetodoPago(int idDescuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            MetodoPagoDal datos = new MetodoPagoDal();
            //Metodo el cual nos va a retornar un string por medio del metodo EliminarMetodoPago
            return datos.EliminarMetodoPago(idDescuento );
        }

        public bool ActualizarMetodoPago(MetoPagoET metodoPago)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            MetodoPagoDal datos = new MetodoPagoDal();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarMetodoPago(metodoPago); 
        }

        public DataTable BuscarMetodoPago(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            MetodoPagoDal datos = new MetodoPagoDal();
            return datos.BuscarMetodoPago(descripcion);
        }
    }
}
