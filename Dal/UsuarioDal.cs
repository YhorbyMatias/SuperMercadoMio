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
    public class UsuarioDal
    {
        #region Metodos
        public int authenticate(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Usuario Where Estado = 1 And Nombres = @Nombres "
                + "And Apellido_Paterno = @Apellido_Paterno And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombres", usuario.NOMBRES);
            sqlCommand.Parameters.AddWithValue("@Apellido_Paterno", usuario.APELLIDO_PATERNO);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateCi(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Usuario Where Estado = 1 And Ci = @Ci And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Ci", usuario.CI);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticatePassword(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) As Existe From Usuario Where Estado = 1 And Id = @Id And Clave = @Clave";
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlCommand.Parameters.AddWithValue("@Clave", usuario.CLAVE);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateUserName(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Usuario Where Estado = 1 And Nombre_De_Usuario = @Nombre_De_Usuario And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Usuario", usuario.NOMBRE_DE_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Usuario Set Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Estado", usuario.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public string getFullName(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select (Nombres + ' ' + Apellido_Paterno + ' ' + ISNULL(Apellido_Materno, '')) As Usuario From Usuario "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            string userFullName = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return userFullName;
        }
        public int insert(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarUsuario";
            sqlCommand.Parameters.AddWithValue("@Ci", usuario.CI);
            sqlCommand.Parameters.AddWithValue("@Nombres", usuario.NOMBRES);
            sqlCommand.Parameters.AddWithValue("@Apellido_Paterno", usuario.APELLIDO_PATERNO);
            if (usuario.APELLIDO_MATERNO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Apellido_Materno", usuario.APELLIDO_MATERNO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Apellido_Materno", DBNull.Value);
            }
            if (usuario.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", usuario.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Usuario", usuario.NOMBRE_DE_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Clave", usuario.CLAVE);
            sqlConnection.Open();
            int idUsuario = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idUsuario;
        }
        public int login(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MAX(Id), 0) As Id From Usuario Where Estado = 1 "
                + "And Nombre_De_Usuario = @Nombre_De_Usuario And Clave = @Clave";
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Usuario", usuario.NOMBRE_DE_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Clave", usuario.CLAVE);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public DataTable search(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Ci, Nombres, Apellido_Paterno, Apellido_Materno, Telefono, Nombre_De_Usuario, Clave From Usuario "
                + "Where Estado = 1 And Id_Usuario = @Id_Usuario";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", usuario.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Usuario");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarUsuarios()";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Usuarios");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Usuario Set Ci = @Ci, Nombres = @Nombres, Apellido_Paterno = @Apellido_Paterno, "
                + "Apellido_Materno = @Apellido_Materno, Telefono = @Telefono, Nombre_De_Usuario = @Nombre_De_Usuario, Clave = @Clave "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Ci", usuario.CI);
            sqlCommand.Parameters.AddWithValue("@Nombres", usuario.NOMBRES);
            sqlCommand.Parameters.AddWithValue("@Apellido_Paterno", usuario.APELLIDO_PATERNO);
            if (usuario.APELLIDO_MATERNO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Apellido_Materno", usuario.APELLIDO_MATERNO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Apellido_Materno", DBNull.Value);
            }
            if (usuario.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", usuario.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Nombre_De_Usuario", usuario.NOMBRE_DE_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Clave", usuario.CLAVE);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updatePassword(UsuarioEnt usuario)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Usuario Set Clave = @Clave Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Clave", usuario.CLAVE);
            sqlCommand.Parameters.AddWithValue("@Id", usuario.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}