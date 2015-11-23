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
        public void close(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Egreso Set Cerrado = 1 Where Estado = 1 And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
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
        #endregion
    }
}