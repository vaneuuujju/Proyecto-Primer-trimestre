using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using System.Data;

namespace BL
{
    //Tenemos que cambiar el internal de la class a public para que las otras capas pueden acceder 
    //a los metodos que la misma contenga (obvio si la misma se ha referenciado anteriormente)
    public class ProductoBL
    {
        //Un metodo publico el cual nos va a retornar un string, recibe por argumentos un entero y
        //un objeto de tipo Producto
        public static string GuardarPr(int nOpcion, ProductoET pr)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ProductoDAL datos = new ProductoDAL();
            //Vamos a retornar el string que el metodo que se encuntra en la capa dal nos retorno
            return datos.GuardarPr(nOpcion, pr);
        }
        public DataTable ListaProducto(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ProductoDAL datos = new ProductoDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListaProducto(cTexto); 
        }

        public bool ActualizarProducto(ProductoET producto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ProductoDAL datos = new ProductoDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarProducto(producto); 
        }
        public DataTable BuscarProducto(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ProductoDAL datos = new ProductoDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo BuscarProducto de la capa DAL
            return datos.BuscarProducto(descripcion); 
        }




    }
}
