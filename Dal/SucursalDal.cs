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
        public int exists()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Sucursal) From Sucursal Where Estado = 1";
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public int insert(SucursalEnt sucursalX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarSucursal";
            sqlCommand.Parameters.AddWithValue("@Id_Empresa", sucursalX.ID_EMPRESA);
            sqlCommand.Parameters.AddWithValue("@Numero", sucursalX.NUMERO);
            sqlCommand.Parameters.AddWithValue("@Direccion", sucursalX.DIRECCION);
            sqlCommand.Parameters.AddWithValue("@Telefono", sucursalX.TELEFONO);
            sqlCommand.Parameters.AddWithValue("@Municipio", sucursalX.MUNICIPIO);
            sqlConnection.Open();
            int idSucursal = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idSucursal;
        }
        public DataTable search()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select E.Razon_Social, E.Nit, S.Numero, S.Direccion, S.Telefono, S.Municipio "
                + "From Empresa E, Sucursal S Where E.Id_Empresa = S.Id_Empresa And E.Estado = 1 And S.Estado = 1 And S.Id_Sucursal = 1";
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
            sqlCommand.CommandText = "Select Id_Sucursal, Numero From Sucursal Where Estado = 1 And Id_Sucursal = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Sucursal");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(SucursalEnt sucursalX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Sucursal Set Numero = @Numero, Direccion = @Direccion, Telefono = @Telefono, "
                + "Municipio = @Municipio Where Id_Sucursal = @Id_Sucursal";
            sqlCommand.Parameters.AddWithValue("@Numero", sucursalX.NUMERO);
            sqlCommand.Parameters.AddWithValue("@Direccion", sucursalX.DIRECCION);
            sqlCommand.Parameters.AddWithValue("@Telefono", sucursalX.TELEFONO);
            sqlCommand.Parameters.AddWithValue("@Municipio", sucursalX.MUNICIPIO);
            sqlCommand.Parameters.AddWithValue("@Id_Sucursal", sucursalX.ID_SUCURSAL);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}