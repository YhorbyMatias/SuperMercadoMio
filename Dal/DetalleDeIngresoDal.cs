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
        public int add(DetalleDeIngresoEnt detalleDeIngreso)
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
        public void cancel(DetalleDeIngresoEnt detalleDeIngreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Detalle_De_Ingreso Set Estado = 'ANULADO' Where Estado = 'VIGENTE' And Id_Ingreso = @Id_Ingreso";
            sqlCommand.Parameters.AddWithValue("@Id_Ingreso", detalleDeIngreso.ID_INGRESO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void delete(DetalleDeIngresoEnt detalleDeIngreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Detalle_De_Ingreso Set Estado = 'ELIMINADO' Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", detalleDeIngreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getByIngresoId(DetalleDeIngresoEnt detalleDeIngreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select DdI.Id, DdI.Id_Producto, P.Codigo_De_Barras, P.Nombre_Generico, P.Marca, P.Presentacion, "
                + "P.Sabor_U_Olor, DdI.Cantidad, DdI.Precio_De_Compra, DdI.Monto_Total, DdI.Porcentaje_De_Utilidad, DdI.Precio_De_Venta "
                + "From Producto P, Detalle_De_Ingreso DdI "
                + "Where P.Id = DdI.Id_Producto And P.Estado = 1 And DdI.Estado != 'ELIMINADO' And DdI.Id_Ingreso = @Id_Ingreso";
            sqlCommand.Parameters.AddWithValue("@Id_Ingreso", detalleDeIngreso.ID_INGRESO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Ingreso");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(DetalleDeIngresoEnt detalleDeIngreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Detalle_De_Ingreso Set Cantidad = @Cantidad, Precio_De_Compra = @Precio_De_Compra, "
                + "Monto_Total = @Monto_Total, Porcentaje_De_Utilidad = @Porcentaje_De_Utilidad, Precio_De_Venta = @Precio_De_Venta "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Cantidad", detalleDeIngreso.CANTIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", detalleDeIngreso.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Monto_Total", detalleDeIngreso.MONTO_TOTAL);
            sqlCommand.Parameters.AddWithValue("@Porcentaje_De_Utilidad", detalleDeIngreso.PORCENTAJE_DE_UTILIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", detalleDeIngreso.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Id", detalleDeIngreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}