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
    public class BodegaDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        // Metodo para agregar bodega
        public string GuardarBodega(int nOpcion, BodegaET bodega)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar la bodega
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos 
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("SP_Guardar_bodega", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdBodega", SqlDbType.Int).Value = bodega.IdBodega;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = bodega.Nombre;
                Comando.Parameters.Add("@cantidad", SqlDbType.Float).Value = bodega.Cantidad;
                Comando.Parameters.Add("@productosAlmacenados", SqlDbType.VarChar).Value = bodega.ProductosAlmacenados;
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

        //Actualizar bodega
        public bool ActualizarBodega(BodegaET bodega)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("SpActualizarBodega", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                                          //Nuevos parametros 
                    comando.Parameters.Add(new SqlParameter("@idBodega", bodega.IdBodega));
                    comando.Parameters.Add(new SqlParameter("@nombre", bodega.Nombre));
                    comando.Parameters.Add(new SqlParameter("@cantidad", bodega.Cantidad));
                    comando.Parameters.Add(new SqlParameter("@productosAlmacenados", bodega.ProductosAlmacenados));
                    //Se lee la base de datos
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
        //almacenar nuevo producto
        public string AlmacenarProducto(int nOpcion, ProductoET producto)
        {

            //Se crea una instancia para crear un objeto de producto
            BodegaET bodega = new BodegaET();
            //Variable que indica el exito o fracaso de guardar producto
            string Rpta = "";
            try
            {
                //Se crea la conexcion con la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica el procedimiento almacenado a utilizar
                SqlCommand Comando = new SqlCommand("SP_Guardar_producto", SqlCon);
                //Se indica que el comando es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;

                //Nombre de los datos por guardar     //Tipo de los datos por guardar
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdImpuesto;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                Comando.Parameters.Add("@precio", SqlDbType.Float).Value = producto.Precio;
                Comando.Parameters.Add("@Idimpuesto", SqlDbType.Float).Value = producto.IdImpuesto;
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
                //Si la conenxio esta abierta, entonces cerrarla
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //Preguntar por este metodo
        //Buscar1 producto almacenado en la bodega
        public DataTable BuscarProducto(string descripcion)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();
            {
                try
                {
                    //Abrir conexion con la base de datos
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("Sp_ListadoProductos", SqlCon);
                    comando.Connection = SqlCon;
                    comando.Parameters.Add(new SqlParameter("@descripcion", "%" + descripcion + "%"));
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

        //Ver capacidad de la bodega
        public DataTable VerCapacidad (float cantidad)
        {
            //Instancia creada para obtener un objeto de tipo dataTable
            DataTable retVal = new DataTable();

            {
                try
                {
                    //Abrir conexion con la base de datos 
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenad utilizar
                    SqlCommand comando = new SqlCommand("SpBuscarBodega", SqlCon);
                    comando.Connection = SqlCon;
                    comando.Parameters.Add(new SqlParameter("@cantidad", "%" + cantidad + "%"));
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

        //Ver productos almacenados
        public DataTable ListaProductos(string cTexto)
        {

            try
            {
                //Se crea una conexion a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand Comando = new SqlCommand("Sp_ListadoProductos", SqlCon);
                //Se indica que el comando es para un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se indica traer todo el texto almacenado
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                //Se abre la conexion
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                //Se retorna toda la tabla
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
    }
}
