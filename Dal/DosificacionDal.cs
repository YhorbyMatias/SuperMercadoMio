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
        public int authenticate(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Dosificacion) From Dosificacion Where Numero_De_Autorizacion = @Numero_De_Autorizacion "
                + "And Llave = @Llave And Id_Dosificacion <> @Id_Dosificacion";
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacion.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Llave", dosificacion.LLAVE);
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", dosificacion.ID_DOSIFICACION);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int checkEmissionDeadline(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(DATEDIFF(DAY, GETDATE(), Fecha_Limite_De_Emision), 0) From Dosificacion "
                + "Where Estado = 'VIGENTE' And Id_Sucursal = @Id_Sucursal And Id_Dosificacion = @Id_Dosificacion";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", dosificacion.ID_DOSIFICACION);
            sqlConnection.Open();
            int remainingDays = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return remainingDays;
        }
        public int exists(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Dosificacion) From Dosificacion Where Estado = @Estado And Id_Sucursal = @Id_Sucursal";
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
                + "And Id_Dosificacion Not In (Select Distinct Id_Dosificacion From Factura Where Estado = 'VIGENTE') "
                + "Order By Id_Dosificacion Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int insert(DosificacionEnt dosificacion)
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
            int idDosificacion = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idDosificacion;
        }
        public DataTable search(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Id_Dosificacion = @Id_Dosificacion";
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", dosificacion.ID_DOSIFICACION);
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
            sqlCommand.CommandText = "Select Id_Dosificacion, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Id_Sucursal = @Id_Sucursal Order By Id_Dosificacion Asc";
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
            sqlCommand.CommandText = "Select Id_Dosificacion, Numero_De_Autorizacion, Llave, Leyenda From Dosificacion "
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
                + "Where Id_Dosificacion = @Id_Dosificacion";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacion.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacion.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Llave", dosificacion.LLAVE);
            sqlCommand.Parameters.AddWithValue("@Fecha_Limite_De_Emision", dosificacion.FECHA_LIMITE_DE_EMISION);
            sqlCommand.Parameters.AddWithValue("@Leyenda", dosificacion.LEYENDA);
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", dosificacion.ID_DOSIFICACION);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateEstado(DosificacionEnt dosificacion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Dosificacion Set Estado = @Estado Where Id_Dosificacion = @Id_Dosificacion";
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacion.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", dosificacion.ID_DOSIFICACION);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}