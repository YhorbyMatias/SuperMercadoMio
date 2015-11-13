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
    public class GrupoDal
    {
        #region Metodos
        public int authenticate(GrupoEnt grupo)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Grupo Where Estado = 1 And Nombre = @Nombre And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupo.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id", grupo.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(GrupoEnt grupo)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Grupo Set Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Estado", grupo.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", grupo.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int insert(GrupoEnt grupo)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarGrupo";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupo.NOMBRE);
            sqlConnection.Open();
            int idGrupo = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idGrupo;
        }
        public DataTable search(GrupoEnt grupo)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Nombre From Grupo Where Estado = 1 And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", grupo.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Grupo");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarGrupos()";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Grupos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchRemovable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarGrupos() "
                + "Where Not Exists (Select Id_Grupo From Producto P Where Estado = 1 And Id_Grupo = P.Id_Grupo)";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Grupos");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable selectAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Grupo, Nombre From buscarGrupos()";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Grupos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(GrupoEnt grupo)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Grupo Set Nombre = @Nombre Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupo.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id", grupo.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}