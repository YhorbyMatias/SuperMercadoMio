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
    public class ClienteDal
    {
        #region Methods
        public int add(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarCliente";
            sqlCommand.Parameters.AddWithValue("@Ci_O_Nit", cliente.CI_O_NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", cliente.NOMBRE);
            //sqlCommand.Parameters.AddWithValue("@Estado", cliente.ESTADO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int authenticateCiONit(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Cliente Where Ci_O_Nit = @Ci_O_Nit And Estado = @Estado And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Ci_O_Nit", cliente.CI_O_NIT);
            sqlCommand.Parameters.AddWithValue("@Estado", cliente.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", cliente.ID);
            sqlConnection.Open();
            int exists = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return exists;
        }
        public int authenticateName(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Cliente Where Nombre = @Nombre And Estado = @Estado And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre", cliente.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Estado", cliente.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", cliente.ID);
            sqlConnection.Open();
            int exists = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return exists;
        }
        public void delete(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Cliente Set Estado = 0 Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", cliente.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Ci_O_Nit, Nombre From Cliente Where Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Cliente");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getById(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Ci_O_Nit, Nombre From Cliente Where Estado = 1 And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", cliente.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Cliente");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getRemovable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Ci_O_Nit, Nombre From Cliente Where Estado = 1 "
                + "And Id Not In (Select Distinct Id_Cliente From Egreso Where Estado = 'VIGENTE')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Cliente");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(ClienteEnt cliente)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Cliente Set Ci_O_Nit = @Ci_O_Nit, Nombre = @Nombre Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Ci_O_Nit", cliente.CI_O_NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", cliente.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id", cliente.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}