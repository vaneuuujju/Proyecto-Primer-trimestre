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
    public class DetalleFactBL
    {
        //Metodo publico que retorna un string el cual recibe por argumentos una variable entera y
        //un objeto de tipo DetalleFactura 
        public string NuevoDetalleFac(int nOpcion, DetalleFacET detalleFac)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DetalleFacDAL datos = new DetalleFacDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.NuevoDetalleFac(nOpcion, detalleFac);
        }
        //Metodo publico el cual retorna un objeto de tipo Datatable, recibe por argumento un string
        public DataTable ListaDetalleFac(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DetalleFacDAL datos = new DetalleFacDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListaDetalleFac(cTexto);
        }

        public bool ActualizarDescuento(DetalleFacET detalleFac)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DetalleFacDAL datos = new DetalleFacDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarDescuento(detalleFac);
        }

        public DataTable BuscarDetalleFac(int idEncabezadoFac)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DetalleFacDAL datos = new DetalleFacDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo BuscarDetalleFac de la capa DAL
            return datos.BuscarDetalleFac(idEncabezadoFac);
        }


    }
}
