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
        #endregion
    }
}