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
            sqlCommand.CommandText = "insertarCaja";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", aperturaDeCaja.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", aperturaDeCaja.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Hora", aperturaDeCaja.HORA);
            sqlCommand.Parameters.AddWithValue("@Monto", aperturaDeCaja.MONTO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        #endregion
    }
}