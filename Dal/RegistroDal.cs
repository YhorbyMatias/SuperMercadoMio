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
        public void insert(RegistroEnt registroX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarRegistro";
            sqlCommand.Parameters.AddWithValue("@Usuario", registroX.USUARIO);
            sqlCommand.Parameters.AddWithValue("@Equipo", registroX.EQUIPO);
            sqlCommand.Parameters.AddWithValue("@Hora", registroX.HORA);
            sqlCommand.Parameters.AddWithValue("@Tabla", registroX.TABLA);
            sqlCommand.Parameters.AddWithValue("@Id_Tabla", registroX.ID_TABLA);
            sqlCommand.Parameters.AddWithValue("@Tipo", registroX.TIPO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}