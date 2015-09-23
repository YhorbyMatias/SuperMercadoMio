using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DetalleDeIngresoDal
    {
        #region Metodos
        public int insert(DetalleDeIngresoEnt detalleDeIngreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarDetalleDeIngreso";
            sqlCommand.Parameters.AddWithValue("@Id_Ingreso", detalleDeIngreso.ID_INGRESO);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", detalleDeIngreso.ID_PRODUCTO);
            sqlCommand.Parameters.AddWithValue("@Cantidad", detalleDeIngreso.CANTIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", detalleDeIngreso.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Monto_Total", detalleDeIngreso.MONTO_TOTAL);
            sqlCommand.Parameters.AddWithValue("@Porcentaje_De_Utilidad", detalleDeIngreso.PORCENTAJE_DE_UTILIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", detalleDeIngreso.PRECIO_DE_VENTA);
            sqlConnection.Open();
            int idDetalleDeIngreso = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idDetalleDeIngreso;
        }
        #endregion
    }
}