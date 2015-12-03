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
    public class SucursalDal
    {
        #region Metodos
        public string getNumber(SucursalEnt sucursal)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Numero From Sucursal Where Estado = 1 And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", sucursal.ID);
            sqlConnection.Open();
            string number = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return number;
        }
        public DataTable search()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select E.Razon_Social, E.Nit, S.Numero, S.Direccion, S.Telefono, S.Municipio "
                + "From Empresa E, Sucursal S Where E.Id = S.Id_Empresa And E.Estado = 1 And S.Estado = 1 And S.Id = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Sucursal");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Numero From Sucursal Where Id = 1 And Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Sucursal");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(SucursalEnt sucursal)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Sucursal Set Numero = @Numero, Direccion = @Direccion, Telefono = @Telefono, "
                + "Municipio = @Municipio Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Numero", sucursal.NUMERO);
            sqlCommand.Parameters.AddWithValue("@Direccion", sucursal.DIRECCION);
            if (sucursal.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", sucursal.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Municipio", sucursal.MUNICIPIO);
            sqlCommand.Parameters.AddWithValue("@Id", sucursal.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}