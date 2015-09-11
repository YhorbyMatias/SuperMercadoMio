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
        public int authenticate(GrupoEnt grupoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Grupo) From Grupo Where Estado = 1 And Nombre = @Nombre And Id_Grupo <> @Id_Grupo";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupoX.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", grupoX.ID_GRUPO);
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public void delete(GrupoEnt grupoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Grupo Set Estado = @Estado Where Id_Grupo = @Id_Grupo";
            sqlCommand.Parameters.AddWithValue("@Estado", grupoX.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", grupoX.ID_GRUPO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int insert(GrupoEnt grupoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarGrupo";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupoX.NOMBRE);
            sqlConnection.Open();
            int idGrupo = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idGrupo;
        }
        public DataTable search(GrupoEnt grupoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Nombre From Grupo Where Estado = 1 And Id_Grupo = @Id_Grupo";
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", grupoX.ID_GRUPO);
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
            DataTable dataTable = new DataTable("Proveedores");
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
        public void update(GrupoEnt grupoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Grupo Set Nombre = @Nombre Where Id_Grupo = @Id_Grupo";
            sqlCommand.Parameters.AddWithValue("@Nombre", grupoX.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", grupoX.ID_GRUPO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}