using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class ImpuestoDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Adregar nuevo impuesto
        public string NuevoImpuesto(int nOpcion, ImpuestoET impuesto)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar el impuesto
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarImpuesto", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = impuesto.IdImpuestos;
                Comando.Parameters.Add("@porcentaje", SqlDbType.Float).Value = impuesto.Porcentaje;
                Comando.Parameters.Add("@idTipoImpuesto", SqlDbType.Float).Value = impuesto.IdTipoImpuesto;
                Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logró registrar correctamente";
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
        //Buscar todos los impuestos
        public DataTable ListadoImpuesto(string cTexto)
        {
            try
            {
                //Se crea una conexion a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand Comando = new SqlCommand("Sp_ListadoImpuesto", SqlCon);
                //Se indica que el comando es para un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se indica traer todo el texto almacenado
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                //Se abre la conexion
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                //Se retorna la toda la tabla
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

        //Eliminar impuesto
        public string EliminarImpuesto(int idImpuesto)
        {
            //Variable que indica si se elimino correctamente o no
            string rpta = "";

            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar 
                SqlCommand comando = new SqlCommand("SP_EliminarImpuesto", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //Se indica cual es el impuesto eliminado
                comando.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = idImpuesto;
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

                //Si la conexion esta abierta se cierra 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Modificar impuesto
        public bool ActualizarImpuesto(ImpuestoET impuesto)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarImpuesto", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 

                    comando.Parameters.Add(new SqlParameter("@idImpuesto", impuesto.IdImpuestos));
                    comando.Parameters.Add(new SqlParameter("@procentaje", impuesto.Porcentaje));
                    comando.Parameters.Add(new SqlParameter("@idTipoImpuesto", impuesto.IdTipoImpuesto));
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

        //Buscar solo 1 impuesto
        public DataTable BuscarImpuesto(float porcentaje)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();

            SqlConnection SqlCon = new SqlConnection();
            {
                try
                {
                    //Abrir conexion con la base de datos
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("Sp_ListadoImpuesto", SqlCon);
                    comando.Connection = SqlCon;
                    //Parametros por ver
                    comando.Parameters.Add(new SqlParameter("@porcentaje", "%" + porcentaje + "%"));
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
