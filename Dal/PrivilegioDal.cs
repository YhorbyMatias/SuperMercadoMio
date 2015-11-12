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
    public class PrivilegioDal
    {
        #region Metodos
        public void delete(PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Privilegio Set Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Estado", privilegio.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", privilegio.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int exists(OpcionEnt opcion, PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Opcion O, Privilegio P Where O.Id = P.Id_Opcion And O.Estado = 1 "
                + "And P.Estado = 1 And O.Nombre = @Nombre And P.Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Nombre", opcion.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegio.ID_USUARIO);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable find(PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id From Privilegio Where Estado = 1 And Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegio.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int insert(PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarPrivilegio";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegio.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Opcion", privilegio.ID_OPCION);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public DataTable search(PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Id_Opcion From Privilegio Where Estado = 1 And Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegio.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(PrivilegioEnt privilegio)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select O.Nombre From Opcion O, Privilegio P Where O.Id = P.Id_Opcion And O.Estado = 1 "
                + "And P.Estado = 1 And P.Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegio.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
    }
}