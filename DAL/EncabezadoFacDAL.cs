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
    public class EncabezadoFacDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Agregar encabezado de factura 
        public string GuardarEncaFac(int nOpcion, EncabezadoFacET encabezadoFac)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar la encabezado factura
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarFactura", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@idFactura", SqlDbType.VarChar).Value = encabezadoFac.IdFactura;
                Comando.Parameters.Add("@fechaEmision", SqlDbType.VarChar).Value = encabezadoFac.FechaEmision1;
                Comando.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = encabezadoFac.NombreCliente1;
                Comando.Parameters.Add("@idCliente", SqlDbType.Int).Value = encabezadoFac.IdCliente;
                Comando.Parameters.Add("@nombreProvedor", SqlDbType.VarChar).Value = encabezadoFac.NombreProvedor;
                Comando.Parameters.Add("@idFormapago", SqlDbType.Int).Value = encabezadoFac.IdCliente;
                Comando.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = encabezadoFac.IdImpuesto;
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

        //Modificar Encabezado factura 
        public bool ActualizarEncabezadoFac(EncabezadoFacET encabezadpFac)
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

                    comando.Parameters.Add(new SqlParameter("@procentaje", encabezadpFac.IdFactura));
                    comando.Parameters.Add(new SqlParameter("@nombreCliente", encabezadpFac.NombreCliente1));
                    comando.Parameters.Add(new SqlParameter("@idCliente", encabezadpFac.IdCliente));
                    comando.Parameters.Add(new SqlParameter("@fechaEmision", encabezadpFac.FechaEmision1));
                    comando.Parameters.Add(new SqlParameter("@formaPago", encabezadpFac.IdFormaPago));
                    comando.Parameters.Add(new SqlParameter("@nombreProvedor", encabezadpFac.NombreProvedor));
                    comando.Parameters.Add(new SqlParameter("@idImpuesto", encabezadpFac.IdImpuesto));
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

        //Buscar solo 1 encabezado
        public DataTable BuscarEncabezado(string nombreCliente)
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
                    comando.Parameters.Add(new SqlParameter("@nombreCliente", "%" + nombreCliente + "%"));
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
