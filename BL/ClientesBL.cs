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
    public class ClientesBL
    {
        //Metodo publico que retorna un string el cual recibe por argumentos una variable entera y
        //un objeto de tipo Cliente
        public string AgregarCliiente(int nOpcion, ClienteET cliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ClienteDAL datos = new ClienteDAL();
            //Hacemos un retorno del metodo que llamamos por medio del objeto qye instanciamos de la
            //capa dal 
            return datos.AgregarCliiente(nOpcion, cliente); 
        }


        public DataTable ListaCliente(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ClienteDAL datos = new ClienteDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListaCliente(cTexto); 
        }

        public string EliminarCliente(int idCliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ClienteDAL datos = new ClienteDAL();
            //Retornamos el string que el metodo de la capa dal nos retorno
            return datos.EliminarCliente(idCliente);
           
        }

        public bool ActualizarCliente(ClienteET cliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            ClienteDAL datos = new ClienteDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarCliente(cliente); 
        }

        public DataTable BuscarCliente(string nombre)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos 
            ClienteDAL datos = new ClienteDAL();
            //Retornamos el objeto Datatable que nos retorno el metodo BuscarCliente |  de la capa DAL
            return datos.BuscarCliente(nombre);  
        }
    }
}
