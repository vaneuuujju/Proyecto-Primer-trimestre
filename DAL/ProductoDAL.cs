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
    public  class ProductoDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        ///Agregar producto
        public string GuardarPr(int nOpcion, ProductoET pr)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar el producto 
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarProducto", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@idProducto", SqlDbType.VarChar).Value = pr.IdProducto;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pr.Descripcion;
                Comando.Parameters.Add("@precio", SqlDbType.Float).Value = pr.Precio;
                Comando.Parameters.Add("@IdImpuesto", SqlDbType.Int).Value = pr.IdImpuesto;
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

        //Buscando todos los productos 
        public DataTable ListaProducto(string cTexto)
        {
            try
            {
                //Se crea una conexion a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand Comando = new SqlCommand("USP_Listado_producto", SqlCon);
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

        //Modificar producto 
        public bool ActualizarProducto(ProductoET producto)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarProducto", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 

                    comando.Parameters.Add(new SqlParameter("@descripcion", producto.Descripcion));
                    comando.Parameters.Add(new SqlParameter("@idImpuesto", producto.IdImpuesto));
                    comando.Parameters.Add(new SqlParameter("@idProducto", producto.IdProducto));
                    comando.Parameters.Add(new SqlParameter("@precio", producto.Precio));
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

        //Buscar solo 1 produco
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
                    //Parametros por ver
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
    }
}
