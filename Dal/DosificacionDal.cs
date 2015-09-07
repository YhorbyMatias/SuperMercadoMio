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
        public int authenticate(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Dosificacion) From Dosificacion Where Numero_De_Autorizacion = @Numero_De_Autorizacion "
                + "And Llave = @Llave And Id_Dosificacion <> @Id_Dosificacion";
            SqlParameter sqlParameterNumeroDeAutorizacion = sqlCommand.Parameters.Add("@Numero_De_Autorizacion", SqlDbType.VarChar);
            sqlParameterNumeroDeAutorizacion.Value = dosificacionX.NUMERO_DE_AUTORIZACION;
            SqlParameter sqlParameterLlave = sqlCommand.Parameters.Add("@Llave", SqlDbType.VarChar);
            sqlParameterLlave.Value = dosificacionX.LLAVE;
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public int checkEmissionDeadline(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(DATEDIFF(DAY, GETDATE(), Fecha_Limite_De_Emision), 0) From Dosificacion "
                + "Where Estado = 'VIGENTE' And Id_Sucursal = @Id_Sucursal And Id_Dosificacion = @Id_Dosificacion";
            SqlParameter sqlParameterIdSucursal = sqlCommand.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameterIdSucursal.Value = dosificacionX.ID_SUCURSAL;
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            sqlConnection.Open();
            int diasRestantes = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return diasRestantes;
        }
        public int exists(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Dosificacion) From Dosificacion Where Estado = @Estado And Id_Sucursal = @Id_Sucursal";
            SqlParameter sqlParameterEstado = sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar);
            sqlParameterEstado.Value = dosificacionX.ESTADO;
            SqlParameter sqlParameterIdSucursal = sqlCommand.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameterIdSucursal.Value = dosificacionX.ID_SUCURSAL;
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public DataTable findAll(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Estado = 'PENDIENTE' Union Select Id_Sucursal, Numero_De_Autorizacion, Llave, "
                + "Fecha_Limite_De_Emision, Leyenda, Estado From Dosificacion Where Estado = 'VIGENTE' "
                + "And Id_Dosificacion Not In (Select Distinct Id_Dosificacion From Factura Where Estado = 'VIGENTE') "
                + "Order By Id_Dosificacion Asc";
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int insert(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "InsertarDosificacion";
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", dosificacionX.ID_SUCURSAL);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", dosificacionX.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Llave", dosificacionX.LLAVE);
            sqlCommand.Parameters.AddWithValue("@Fecha_Limite_De_Emision", dosificacionX.FECHA_LIMITE_DE_EMISION);
            sqlCommand.Parameters.AddWithValue("@Leyenda", dosificacionX.LEYENDA);
            sqlCommand.Parameters.AddWithValue("@Estado", dosificacionX.LEYENDA);
            sqlConnection.Open();
            int idDosificacion = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idDosificacion;
        }
        public DataTable search(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                +"From Dosificacion Where Id_Dosificacion = @Id_Dosificacion";
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Dosificacion, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado "
                + "From Dosificacion Where Id_Sucursal = @Id_Sucursal Order By Id_Dosificacion Asc";
            SqlParameter sqlParameterIdSucursal = sqlCommand.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameterIdSucursal.Value = dosificacionX.ID_SUCURSAL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Dosificacion, Numero_De_Autorizacion, Llave, Leyenda From Dosificacion "
                + "Where Estado = 'VIGENTE' And Id_Sucursal = @Id_Sucursal";
            SqlParameter sqlParameterIdSucursal = sqlCommand.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameterIdSucursal.Value = dosificacionX.ID_SUCURSAL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Dosificacion");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Dosificacion Set Id_Sucursal = @Id_Sucursal, Numero_De_Autorizacion = @Numero_De_Autorizacion, "
                + "Llave = @Llave, Fecha_Limite_De_Emision = @Fecha_Limite_De_Emision, Leyenda = @Leyenda, Estado = @Estado "
                + "Where Id_Dosificacion = @Id_Dosificacion";
            SqlParameter sqlParameterIdSucursal = sqlCommand.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameterIdSucursal.Value = dosificacionX.ID_SUCURSAL;
            SqlParameter sqlParameterNumeroDeAutorizacion = sqlCommand.Parameters.Add("@Numero_De_Autorizacion", SqlDbType.VarChar);
            sqlParameterNumeroDeAutorizacion.Value = dosificacionX.NUMERO_DE_AUTORIZACION;
            SqlParameter sqlParameterLlave = sqlCommand.Parameters.Add("@Llave", SqlDbType.VarChar);
            sqlParameterLlave.Value = dosificacionX.LLAVE;
            SqlParameter sqlParameterFechaLimiteDeEmision = sqlCommand.Parameters.Add("@Fecha_Limite_De_Emision", SqlDbType.Date);
            sqlParameterFechaLimiteDeEmision.Value = dosificacionX.FECHA_LIMITE_DE_EMISION;
            SqlParameter sqlParameterLeyenda = sqlCommand.Parameters.Add("@Leyenda", SqlDbType.VarChar);
            sqlParameterLeyenda.Value = dosificacionX.LEYENDA;
            SqlParameter sqlParameterEstado = sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar);
            sqlParameterEstado.Value = dosificacionX.ESTADO;
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateStatus(DosificacionEnt dosificacionX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Dosificacion Set Estado = @Estado Where Id_Dosificacion = @Id_Dosificacion";
            SqlParameter sqlParameterEstado = sqlCommand.Parameters.Add("@Estado", SqlDbType.VarChar);
            sqlParameterEstado.Value = dosificacionX.ESTADO;
            SqlParameter sqlParameterIdDosificacion = sqlCommand.Parameters.Add("@Id_Dosificacion", SqlDbType.Int);
            sqlParameterIdDosificacion.Value = dosificacionX.ID_DOSIFICACION;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}