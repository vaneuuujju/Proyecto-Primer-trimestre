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
    public class TiempoImpuestoBL
    {
        //Metodo que retorna un string y recibe por argumentos un entero y un objeto TipoImpuesto
        public string GuardarTipoImp(int nOpcion, TipoImpuestoET tipoImpuesto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoImpuestoDAL datos = new TipoImpuestoDAL();
            return datos.GuardarTipoImp(nOpcion, tipoImpuesto);
        }
        public DataTable ListaTipoImpuesto(string cTexto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoImpuestoDAL datos = new TipoImpuestoDAL();
            //Vamos a retornar un objeto de tipo Datatable
            return datos.ListaTipoImpuesto(cTexto);
        }
        public bool ActualizarTipImpuesto(TipoImpuestoET tipoImpuesto)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoImpuestoDAL datos = new TipoImpuestoDAL();
            //Retornamos un bool el cual nos llega por medio del retorno del metodo que se encuntra en la capa DAL
            return datos.ActualizarTipImpuesto(tipoImpuesto);
        }
        public DataTable BuscarTipoImpuesto(string descripcion)
        {
            //Creamos una instancia de la capa DAL, para poder obtener acceso a los metodos
            TipoImpuestoDAL datos = new TipoImpuestoDAL();
            //Retornamos el objeto Datatable que nos retorna el metodo
            return datos.BuscarTipoImpuesto(descripcion);
        }

    }
}
