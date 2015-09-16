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
        public int insert(DetalleDeIngresoEnt detalleDeIngresoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarDetalleDeIngreso";
            sqlCommand.Parameters.AddWithValue("@Id_Ingreso", detalleDeIngresoX.ID_INGRESO);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", detalleDeIngresoX.ID_PRODUCTO);
            sqlCommand.Parameters.AddWithValue("@Cantidad", detalleDeIngresoX.CANTIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", detalleDeIngresoX.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Monto_Total", detalleDeIngresoX.MONTO_TOTAL);
            sqlCommand.Parameters.AddWithValue("@Porcentaje_De_Utilidad", detalleDeIngresoX.PORCENTAJE_DE_UTILIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", detalleDeIngresoX.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Estado", detalleDeIngresoX.ESTADO);
            sqlConnection.Open();
            int idDetalleDeIngreso = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idDetalleDeIngreso;
        }
        #endregion
    }
}