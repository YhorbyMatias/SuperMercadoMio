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
    public class RegistroDal
    {
        #region Metodos
        public void insert(RegistroEnt registro)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarRegistro";
            sqlCommand.Parameters.AddWithValue("@Usuario", registro.USUARIO);
            sqlCommand.Parameters.AddWithValue("@Equipo", registro.EQUIPO);
            sqlCommand.Parameters.AddWithValue("@Hora", registro.HORA);
            sqlCommand.Parameters.AddWithValue("@Tabla", registro.TABLA);
            sqlCommand.Parameters.AddWithValue("@Id_Tabla", registro.ID_TABLA);
            sqlCommand.Parameters.AddWithValue("@Tipo", registro.TIPO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}