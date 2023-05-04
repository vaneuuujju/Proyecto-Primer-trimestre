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
    public class EncabezadoFacBL
    {
        //Metodo publico que retorna un string el cual recibe por argumentos una variable entera y
        //un objeto de tipo Encabezado, el cual va guardar un nuevo encabezado de factura 

        public string GuardarEncaFac(int nOpcion, EncabezadoFacET encabezadoFac)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            EncabezadoFacDAL datos = new EncabezadoFacDAL();
            return datos.GuardarEncaFac(nOpcion, encabezadoFac);
        }


        public bool ActualizarEncabezadoFac(EncabezadoFacET encabezadpFac)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            EncabezadoFacDAL datos = new EncabezadoFacDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarEncabezadoFac(encabezadpFac);
        }

        public DataTable BuscarEncabezado(string nombreCliente)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            EncabezadoFacDAL datos = new EncabezadoFacDAL();
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            return datos.BuscarEncabezado(nombreCliente);
        }
    }
}
