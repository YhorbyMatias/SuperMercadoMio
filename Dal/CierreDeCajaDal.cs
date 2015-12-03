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
    public class CierreDeCajaDal
    {
        #region Methods
        public int add(CierreDeCajaEnt cierreDeCaja)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarCierreDeCaja";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", cierreDeCaja.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", cierreDeCaja.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", cierreDeCaja.ID_APERTURA_DE_CAJA);
            sqlCommand.Parameters.AddWithValue("@Hora", cierreDeCaja.HORA);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Apertura_De_Caja", cierreDeCaja.MONTO_DE_APERTURA_DE_CAJA);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Ventas", cierreDeCaja.MONTO_DE_VENTAS);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Cupones", cierreDeCaja.MONTO_DE_CUPONES);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Devoluciones", cierreDeCaja.MONTO_DE_DEVOLUCIONES);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Ventas_De_Tarjetas", cierreDeCaja.MONTO_DE_VENTA_DE_TARJETAS);
            sqlCommand.Parameters.AddWithValue("@Monto_De_Pagos", cierreDeCaja.MONTO_DE_PAGOS);
            sqlCommand.Parameters.AddWithValue("@Monto_Total", cierreDeCaja.MONTO_TOTAL);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        #endregion
    }
}