using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleFacDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Agregar detalle factura 
        public string NuevoDetalleFac(int nOpcion, DetalleFacET detalleFac)
        {

            //Respuesta que se devolvera con el exito o fracaso al guradar la detalle factura
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("USP_Guardar_detaF", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalleFac.Cantidad;
                Comando.Parameters.Add("@idEncabezadoFac", SqlDbType.Int).Value = detalleFac.IdEncabezadoFac;
                Comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = detalleFac.IdProducto;
                Comando.Parameters.Add("@precioUnitario", SqlDbType.Int).Value = detalleFac.PrecioUnitario;
                Comando.Parameters.Add("@total", SqlDbType.Int).Value = detalleFac.Total;
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
        //Modificar actualizar DetalleFactura
        public bool ActualizarDescuento(DetalleFacET detalleFac)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarFactura", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 

                    comando.Parameters.Add(new SqlParameter("@idproducto", detalleFac.IdProducto));
                    comando.Parameters.Add(new SqlParameter("@idDescuento", detalleFac.Cantidad));
                    comando.Parameters.Add(new SqlParameter("@precioUnitario", detalleFac.PrecioUnitario));
                    comando.Parameters.Add(new SqlParameter("@idTipoDescuento", detalleFac.IdEncabezadoFac));
                    comando.Parameters.Add(new SqlParameter("@idproducto", detalleFac.Total));
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

        //Buscar solo 1 detalles de 1 factura
        public DataTable BuscarDetalleFac(int idEncabezadoFac)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();

            {
                try
                {
                    //Abrir conexion con la base de datos
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("Sp_ListadoFactura", SqlCon);
                    comando.Connection = SqlCon;
                    comando.Parameters.Add(new SqlParameter("@idEncabezadoFac", "%" + idEncabezadoFac + "%"));
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
