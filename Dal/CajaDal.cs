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
    public class CajaDal
    {
        #region Methods
        public int add(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarCaja";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Equipo", caja.NOMBRE_DE_EQUIPO);
            sqlCommand.Parameters.AddWithValue("@Numero", caja.NUMERO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int authenticateNumber(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Caja Where Estado = 'ACTIVA' And Numero = @Numero And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Numero", caja.NUMERO);
            sqlCommand.Parameters.AddWithValue("@Id", caja.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Caja Set Estado = 'INACTIVA' From Caja Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", caja.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int exists(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Caja Where Estado = 'ACTIVA' And Nombre_De_Equipo = @Nombre_De_Equipo";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Equipo", caja.NOMBRE_DE_EQUIPO);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable getAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Nombre_De_Equipo, Numero Where Estado = 'ACTIVA'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Cajas");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getAllRemovable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Nombre_De_Equipo, Numero Where Estado = 'ACTIVA' "
                + "And Id Not In (Select Distinct Id_Caja From Apertura_De_Caja)";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Cajas");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getById(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Numero From Caja Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", caja.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Caja");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int getId(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id From Caja Where Estado = 'ACTIVA' And Nombre_De_Equipo = @Nombre_De_Equipo";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Equipo", caja.NOMBRE_DE_EQUIPO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int getNumber(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Numero From Caja Where Estado = 'ACTIVA' And Nombre_De_Equipo = @Nombre_De_Equipo";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Equipo", caja.NOMBRE_DE_EQUIPO);
            sqlConnection.Open();
            int number = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return number;
        }
        public void update(CajaEnt caja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Caja Set Numero = @Numero From Caja Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Numero", caja.NOMBRE_DE_EQUIPO);
            sqlCommand.Parameters.AddWithValue("@Id", caja.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}