using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using ET;
using System.Threading.Tasks;

namespace DAL
{
    public class DescuentoDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //Intancia para crear un objeto con respecto a la conexion de la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Agregar un descuento
        public string NuevoDescuento(int nOpcion, DescuentoET descuento)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar la descuento
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarDescuento", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdDescuento", SqlDbType.Int).Value = descuento.IdDescuento;
                Comando.Parameters.Add("@porcentaje", SqlDbType.Float).Value = descuento.Procentaje;
                Comando.Parameters.Add("@idTipoDesciento", SqlDbType.Int).Value = descuento.IdTipoDescuento;
                Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logró guardar correctamente";
                //Abro la conexion a la base
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //Si la conexcion esta abierta, entonces que cierre la conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //Buscar todos los descuentos
        public DataTable ListaDescuento(string cTexto)
        {
            ///Donde se va guardar los datos tablas
            DataTable tabla = new DataTable();
            try
            {
                //Se crea una conexion a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand Comando = new SqlCommand("Sp_ListadoDescuento", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Se indica traer todo el texto almacenad
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                //Se abre la conexion
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //Se indica que si la conexión esta abierta, que se cierre 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //Eliminar descuento
        public string EliminarDescuento(int idDescuento)
        {
            //Variable que indica si se elimino correctamente o no
            string rpta = "";

            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar 
                SqlCommand comando = new SqlCommand("SP_EliminarDescuento", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //Se indica cual es el impuesto eliminado
                comando.Parameters.Add("@idDescuento", SqlDbType.Int).Value = idDescuento;
                //Se abrio la conencion con la BD
                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logro eliminar correctamente";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                //Se indica que si la conexión esta abierta, que se cierre 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Modificar descuento 
        public bool ActualizarDescuento(DescuentoET descuento)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarDescuento", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 

                    comando.Parameters.Add(new SqlParameter("@procentaje", descuento.Procentaje));
                    comando.Parameters.Add(new SqlParameter("@idDescuento", descuento.IdDescuento));
                    comando.Parameters.Add(new SqlParameter("@idTipoDescuento", descuento.IdTipoDescuento));
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Close();
                    retVal = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retVal = false;
                }
            }
            return retVal;
        }

        //Buscar solo 1 descuento
        public DataTable BuscarDescuento(float porcentaje)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("Sp_ListadoDescuentos", SqlCon);
                    comando.Connection = SqlCon;
                    comando.Parameters.Add(new SqlParameter("@porcentaje", "%" + porcentaje  + "%"));
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = comando;
                    da.Fill(retVal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
    }
}
