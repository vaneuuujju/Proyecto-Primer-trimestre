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
    public class TipoFacturaBL
    {
        //Metodo el cual va a retornar un string, el mismo recibe por argumentos una variable entera
        //y tambien un objeto de tipoFactura
        public string GuardarTipoFactura(int nOpcion, TipoFacturaET tipoFactura)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoFacturaDAL datos = new TipoFacturaDAL();
                //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
                //hicimos de la capa DAL
            return datos.GuardarTipoFactura(nOpcion, tipoFactura);
        }
        public DataTable ListaTipoFactura(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoFacturaDAL datos = new TipoFacturaDAL();
            //Retornamos un datatable con la lista de los tipos descuentos que estan registrados
            return datos.ListaTipoFactura(cTexto);
        }
        public bool ActualizarTipoFactura(TipoFacturaET tipoFactura)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoFacturaDAL datos = new TipoFacturaDAL();
            // Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en
            //la capa dal
            return datos.ActualizarTipoFactura(tipoFactura);
        }

        public DataTable BuscarTipoFactura(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoFacturaDAL datos = new TipoFacturaDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo de la capa DAL
            return datos.BuscarTipoFactura(descripcion);
        }

    }
}
