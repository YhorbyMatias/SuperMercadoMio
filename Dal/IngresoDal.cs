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
    public class IngresoDal
    {
        #region Atributos
        public int getNumeroDeRegistro()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MAX(Id_Ingreso), 0) As Numero_De_Registro From Ingreso";
            sqlConnection.Open();
            int numeroDeRegistro = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return numeroDeRegistro;
        }
        public int insert(IngresoEnt ingresoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarIngreso";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", ingresoX.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Fecha", ingresoX.FECHA);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Registro", ingresoX.NUMERO_DE_REGISTRO);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Nota_De_Entrega", ingresoX.NUMERO_DE_NOTA_DE_ENTREGA);
            sqlCommand.Parameters.AddWithValue("@Monto", ingresoX.MONTO);
            if (ingresoX.OBSERVACIONES != "")
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", ingresoX.OBSERVACIONES);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Estado", ingresoX.ESTADO);
            sqlConnection.Open();
            int idIngreso = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idIngreso;
        }
        #endregion
    }
}