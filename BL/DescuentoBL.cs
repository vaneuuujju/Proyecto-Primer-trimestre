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
    public class DescuentoBL
    {
        //Metodo publico que retorna un string el cual recibe por argumentos una variable entera y
        //un objeto de tipo descuento 
        public string NuevoDescuento(int nOpcion, DescuentoET descuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DescuentoDAL datos = new DescuentoDAL();
            //Retornamos lo que el metodo que llamamos por medio de la intancia del objeto que
            //hicimos de la capa DAL
            return datos.NuevoDescuento(nOpcion, descuento); 
        }

        //Metodo publico el cual retorna un objeto de tipo Datatable, recibe por argumento un string
        public DataTable ListaDescuento(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DescuentoDAL datos = new DescuentoDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListaDescuento(cTexto); 
        }

        public string EliminarDescuento(int idDescuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DescuentoDAL datos = new DescuentoDAL();
            return datos.EliminarDescuento(idDescuento); 
        }

        public bool ActualizarDescuento(DescuentoET descuento)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DescuentoDAL datos = new DescuentoDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarDescuento(descuento); 
        }

        public DataTable BuscarDescuento(float porcentaje)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            DescuentoDAL datos = new DescuentoDAL();
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            return datos.BuscarDescuento(porcentaje);
        }


    }
}
