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
    public class DetalleDeFacturaDal
    {
        #region Methods
        public int add(DetalleDeFacturaEnt detalleDeFactura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarDetalleDeFactura";
            sqlCommand.Parameters.AddWithValue("@Id_Factura", detalleDeFactura.ID_FACTURA);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", detalleDeFactura.ID_PRODUCTO);
            sqlCommand.Parameters.AddWithValue("@Detalle", detalleDeFactura.DETALLE);
            sqlCommand.Parameters.AddWithValue("@Cantidad", detalleDeFactura.CANTIDAD);
            sqlCommand.Parameters.AddWithValue("@Importe", detalleDeFactura.IMPORTE);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public DataTable getById(DetalleDeFacturaEnt detalleDeFactura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select DdF.Id, DdF.Detalle, DdF.Cantidad, Df.Importe "
                + "From Detalle_De_Factura DdF Where DdF.Id_Factura = @Id_Factura";
            sqlCommand.Parameters.AddWithValue("@Id_Factura", detalleDeFactura.ID_FACTURA);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("DetalleFactura");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable obtainById(DetalleDeFacturaEnt detalleDeFactura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select DdF.Detalle, DdF.Cantidad, Df.Importe "
                + "From Detalle_De_Factura DdF Where DdF.Id_Factura = @Id_Factura";
            sqlCommand.Parameters.AddWithValue("@Id_Factura", detalleDeFactura.ID_FACTURA);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("DetalleFactura");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
    }
}