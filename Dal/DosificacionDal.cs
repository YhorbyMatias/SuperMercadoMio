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
    public class DosificacionDal
    {
        #region Metodos
        public int add(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "InsertarDosificacion";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacion.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Llave", dosificacion.LLAVE);
            sqlCommand.Parameters.AddWithValue("@Fecha_Limite_De_Emision", dosificacion.FECHA_LIMITE_DE_EMISION);
            sqlCommand.Parameters.AddWithValue("@Leyenda", dosificacion.LEYENDA);
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int authenticate(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) From Dosificacion Where Numero_De_Autorizacion = @Numero_De_Autorizacion And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacion.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Id", dosificacion.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int exists(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) From Dosificacion Where Id_Sucursal = @Id_Sucursal And Estado = @Estado";
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable findAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Estado = 'PENDIENTE' Union Select Id_Sucursal, Numero_De_Autorizacion, Llave, "
                + "Fecha_Limite_De_Emision, Leyenda, Estado From Dosificacion Where Estado = 'VIGENTE' "
                + "And Id Not In (Select Distinct Id_Dosificacion From Factura Where Estado = 'VIGENTE') "
                + "Order By Id Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int getId(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id From Dosificacion Where Id_Sucursal = @Id_Sucursal And Estado = @Estado";
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int getRemainingDays(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(DATEDIFF(DAY, GETDATE(), Fecha_Limite_De_Emision), 0) From Dosificacion "
                + "Where Estado = 'ACTIVA' And Id_Sucursal = @Id_Sucursal And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Id", dosificacion.ID);
            sqlConnection.Open();
            int remainingDays = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return remainingDays;
        }
        public DataTable search(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select S.Numero As Numero_De_Sucursal, D.Numero_De_Autorizacion, D.Llave, D.Fecha_Limite_De_Emision, "
                + "D.Leyenda, D.Estado "
                + "From Sucursal S, Dosificacion D Where S.Id = D.Id_Sucursal And S.Estado = 1 And D.Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", dosificacion.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ROW_NUMBER() OVER (ORDER BY Id) As Numero, Id, Numero_De_Autorizacion, Llave, "
                + "Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Id_Sucursal = @Id_Sucursal Order By Id Asc";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Numero_De_Autorizacion, Llave From Dosificacion "
                + "Where Estado = 'VIGENTE' And Id_Sucursal = @Id_Sucursal";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Dosificacion Set Id_Sucursal = @Id_Sucursal, Numero_De_Autorizacion = @Numero_De_Autorizacion, "
                + "Llave = @Llave, Fecha_Limite_De_Emision = @Fecha_Limite_De_Emision, Leyenda = @Leyenda, Estado = @Estado "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacion.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Llave", dosificacion.LLAVE);
            sqlCommand.Parameters.AddWithValue("@Fecha_Limite_De_Emision", dosificacion.FECHA_LIMITE_DE_EMISION);
            sqlCommand.Parameters.AddWithValue("@Leyenda", dosificacion.LEYENDA);
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", dosificacion.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateEstado(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Dosificacion Set Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", dosificacion.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}