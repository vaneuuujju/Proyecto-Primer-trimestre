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
    public class ImpuestoBL
    {
        //Metodo publico que retorna un string el cual recibe por argumentos una variable entera y
        //un objeto de tipo DetalleFactura 
        public string NuevoImpuesto(int nOpcion, ImpuestoET impuesto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ImpuestoDAL datos = new ImpuestoDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.NuevoImpuesto(nOpcion, impuesto);
        }
        public DataTable ListadoImpuesto(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ImpuestoDAL datos = new ImpuestoDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListadoImpuesto(cTexto);
        }

        public string EliminarImpuesto(int idImpuesto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ImpuestoDAL datos = new ImpuestoDAL();
            //Metodo el cual nos va a retornar un string por medio del metodo EliminarImpuesto
            return datos.EliminarImpuesto(idImpuesto);
        }

        public bool ActualizarImpuesto(ImpuestoET impuesto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos 
            ImpuestoDAL datos = new ImpuestoDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarImpuesto(impuesto); 
        }

    }
}
