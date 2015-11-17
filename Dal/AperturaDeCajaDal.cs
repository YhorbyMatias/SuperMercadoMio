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
    public class AperturaDeCajaDal
    {
        #region Methods
        public int add(AperturaDeCajaEnt aperturaDeCaja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarAperturaDeCaja";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", aperturaDeCaja.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", aperturaDeCaja.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Hora", aperturaDeCaja.HORA);
            sqlCommand.Parameters.AddWithValue("@Monto", aperturaDeCaja.MONTO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int exists(AperturaDeCajaEnt aperturaDeCaja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Apertura_De_Caja Where Cerrado = 0 And Id_Usuario = @Id_Usuario "
                + "And Id_Caja = @Id_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", aperturaDeCaja.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", aperturaDeCaja.ID_CAJA);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable get(AperturaDeCajaEnt aperturaDeCaja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Monto From Apertura_De_Caja Where Cerrado = 0 And Id_Usuario = @Id_Usuario "
                + "And Id_Caja = @Id_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", aperturaDeCaja.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", aperturaDeCaja.ID_CAJA);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("AperturaDeCaja");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
    }
}