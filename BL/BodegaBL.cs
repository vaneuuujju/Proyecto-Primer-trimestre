using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referenciamos o uitlizamos las capas que vamos a necesitar
using DAL;
using ET;

namespace BL
{
    public class BodegaBL
    {

        //Metodo publico, que retornar un string y recibe por argumentos un entero y un objeto Bodega
        public static  string GuardarBodega(int nOpcion, BodegaET bodega)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            BodegaDAL datos = new BodegaDAL();
            //  Retornamos los que el metodo GuardarBodega nos retorne, en este caso un string
            return datos.GuardarBodega(nOpcion, bodega); 
        }


        //Metodo publico , que nos retorna un string, el cual recibe por argumentos una variable de tipo
        //entero y un objeto de tipo Producto
        public static string AlmacenarProducto(int nOpcion, ProductoET producto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            BodegaDAL datos = new BodegaDAL();
            //Retornamos los datos que nos llegan por medio de argumentos, cuando accedemos por medio
            //del objeto que instanciamos al metodo AlmecenarProducto que esta en la capa DAL
            return datos.AlmacenarProducto(nOpcion, producto); 
        }

        //Metodo publico de tipo Datable el cual nos va a ayudar a buscar los productos almacenados en bodega
        //Metodo que recibe un argumento de una variable tipo string y el cual retornar un objeto Datatable
        public static DataTable BuscarProducto(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            BodegaDAL datos = new BodegaDAL();
            //Retornamos lo que el metodo BuscarProducto,el cual que invocamos por
            //medio del objeto instanciamos y pudimos acceder al mismo
            return datos.BuscarProducto(descripcion); 
        }

        //Metodo publico de tipo Datable el cual nos va a ayudar a ver la capacidad en bodega
        //Metodo que recibe un argumento de una variable tipo float y el cual retornar un objeto Datatable
        public static DataTable VerCapacidad(float cantidad)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            BodegaDAL datos = new BodegaDAL();
            //Vamos a retornar lo que el metodo que se encuntra en la capa Dal nos retorne
            return datos.VerCapacidad(cantidad); 
        }

        //Metodo que nos va a ayudar a ver el listado de los productos que se encuentran en la tabla bodega

        public static DataTable ListaProductos(string cTexto)
        {
            //Hacmos una instancia de la clase bodega de la capa DAL
            BodegaDAL datos = new BodegaDAL();
            //Retornamos el datatable que nos retorno el metodo ListadoProductos de la capa Dal
            return datos.ListaProductos(cTexto);  
        }
    }
}
