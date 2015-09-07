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
        public void delete(PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Privilegio Set Estado = @Estado Where Id_Privilegio = @Id_Privilegio";
            sqlCommand.Parameters.AddWithValue("@Estado", privilegioX.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Privilegio", privilegioX.ID_PRIVILEGIO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int exists(OpcionEnt opcionX, PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Privilegio) From Opcion O, Privilegio P Where O.Id_Opcion = P.Id_Opcion "
                + "And O.Estado = 1 And P.Estado = 1 And O.Nombre = @Nombre And P.Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Nombre", opcionX.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegioX.ID_USUARIO);
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public DataTable find(PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Privilegio From Privilegio Where Estado = 1 And Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegioX.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int insert(PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarPrivilegio";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegioX.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Opcion", privilegioX.ID_OPCION);
            sqlConnection.Open();
            int idPrivilegio = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idPrivilegio;
        }
        public DataTable search(PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Privilegio, Id_Opcion From Privilegio Where Estado = 1 And Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegioX.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(PrivilegioEnt privilegioX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select O.Nombre From Opcion O, Privilegio P Where O.Id_Opcion = P.Id_Opcion And O.Estado = 1 "
                + "And P.Estado = 1 And P.Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", privilegioX.ID_USUARIO);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Privilegios");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
    }
}