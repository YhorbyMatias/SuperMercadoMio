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
    public class EgresoDal
    {
        #region Methods
        public int add(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarEgreso";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", egreso.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", egreso.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Cliente", egreso.ID_CLIENTE);
            sqlCommand.Parameters.AddWithValue("@Hora", egreso.HORA);
            sqlCommand.Parameters.AddWithValue("@Tipo", egreso.TIPO);
            sqlCommand.Parameters.AddWithValue("@Metodo_De_Pago", egreso.METODO_DE_PAGO);
            sqlCommand.Parameters.AddWithValue("@Monto", egreso.MONTO);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Cupon", egreso.MONTO_DE_CUPON);
            sqlCommand.Parameters.AddWithValue("@Monto_Extra", egreso.MONTO_EXTRA);
            sqlCommand.Parameters.AddWithValue("@Monto_Pagado", egreso.MONTO_PAGADO);
            sqlCommand.Parameters.AddWithValue("@Cambio", egreso.CAMBIO);
            sqlCommand.Parameters.AddWithValue("@Observaciones", egreso.OBSERVACIONES);
            sqlCommand.Parameters.AddWithValue("@Facturado", egreso.FACTURADO);
            sqlCommand.Parameters.AddWithValue("@Cerrado", egreso.CERRADO);
            sqlCommand.Parameters.AddWithValue("@Estado", egreso.ESTADO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public void cancel(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Estado = 'ANULADO' Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", egreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void close(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Cerrado = 1 Where Estado = 'VIGENTE' And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int existsMinorSales(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) As 'Exists' From Egreso "
                + "Where Id_Cliente = 1 And Tipo = 'VENTA MENOR' And Facturado = 0 And Cerrado = 0 And Estado = 'VIGENTE' "
                + "And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable getMinorSales(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(SUM(Monto), 0) As Monto, ISNULL(SUM(Monto_Pagado), 0) As Monto_Pagado, "
                + "ISNULL(SUM(Cambio), 0) As Cambio From Egreso Where Id_Cliente = 1 And Tipo = 'VENTA MENOR' And Facturado = 0 "
                + "And Cerrado = 0 And Estado = 'VIGENTE' And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("EgresosMenores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int getNumber()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MAX(Id), 0) As Number From Egreso";
            sqlConnection.Open();
            int number = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return number;
        }
        public decimal getCouponsTotalAmount(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(SUM(Monto_De_Cupon), 0) As Monto_De_Cupones From Egreso Where Tipo = 'CANJE DE CUPON' "
                + " And Estado = 'VIGENTE' And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            decimal couponsTotalAmount = Convert.ToDecimal(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return couponsTotalAmount;
        }
        public decimal getExtraTotalAmount(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(SUM(Monto_Extra), 0) As Monto_Extra From Egreso Where Tipo = 'CANJE DE CUPON' "
                + " And Estado = 'VIGENTE' And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            decimal extraTotalAmount = Convert.ToDecimal(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return extraTotalAmount;
        }
        public decimal getSalesTotalAmount(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(SUM(Monto), 0) As Monto_De_Ventas From Egreso Where Estado = 'VIGENTE' "
                + "And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            decimal salesTotalAmount = Convert.ToDecimal(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return salesTotalAmount;
        }
        public bool isClosed(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Cerrado From Egreso Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", egreso.ID);
            sqlConnection.Open();
            bool cerrado = Convert.ToBoolean(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return cerrado;
        }
        public void update(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Id_Cliente = @Id_Cliente, Tipo = @Tipo, Metodo_De_Pago = @Metodo_De_Pago, "
                + "Monto = @Monto, Monto_Pagado = @Monto_Pagado, Cambio = @Cambio, Observaciones = @Observaciones, Facturado = @Facturado, "
                + "Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Cliente", egreso.ID_CLIENTE);
            sqlCommand.Parameters.AddWithValue("@Tipo", egreso.TIPO);
            sqlCommand.Parameters.AddWithValue("@Metodo_De_Pago", egreso.METODO_DE_PAGO);
            sqlCommand.Parameters.AddWithValue("@Monto", egreso.MONTO);
            sqlCommand.Parameters.AddWithValue("@Monto_Pagado", egreso.MONTO_PAGADO);
            sqlCommand.Parameters.AddWithValue("@Cambio", egreso.CAMBIO);
            sqlCommand.Parameters.AddWithValue("@Observaciones", egreso.OBSERVACIONES);
            sqlCommand.Parameters.AddWithValue("@Facturado", egreso.FACTURADO);
            sqlCommand.Parameters.AddWithValue("@Estado", egreso.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", egreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateFacturado(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Facturado = 1 Where Id_Cliente = 1 And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateFacturadoById(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Facturado = 1 Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", egreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}