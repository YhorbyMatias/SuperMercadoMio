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
    public class DevolucionDal
    {
        #region Methods
        public int add(DevolucionEnt devolucion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarDevolucion";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", devolucion.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", devolucion.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", devolucion.ID_APERTURA_DE_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Egreso", devolucion.ID_EGRESO);
            sqlCommand.Parameters.AddWithValue("@Hora", devolucion.HORA);
            sqlCommand.Parameters.AddWithValue("@Monto", devolucion.MONTO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public void close(DevolucionEnt devolucion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Devolucion Set Cerrado = 1 Where Estado = 1 And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", devolucion.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public decimal getRefundsTotalAmount(DevolucionEnt devolucion)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(SUM(Monto), 0) As Monto_De_Devoluciones From Devolucion Where Estado = 1 "
                + "And Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", devolucion.ID_APERTURA_DE_CAJA);
            sqlConnection.Open();
            decimal refundsTotalAmount = Convert.ToDecimal(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return refundsTotalAmount;
        }
        #endregion
    }
}