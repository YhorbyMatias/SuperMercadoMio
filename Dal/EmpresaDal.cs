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
    public class EmpresaDal
    {
        #region Metodos
        public int add(EmpresaEnt empresa)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarEmpresa";
            sqlCommand.Parameters.AddWithValue("@Propietario", empresa.PROPIETARIO);
            sqlCommand.Parameters.AddWithValue("@Razon_Social", empresa.RAZON_SOCIAL);
            sqlCommand.Parameters.AddWithValue("@Nit", empresa.NIT);
            sqlCommand.Parameters.AddWithValue("@Actividad_Economica", empresa.ACTIVIDAD_ECONOMICA);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int exists()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) From Empresa Where Estado = 1";
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable search()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Propietario, Razon_Social, Nit, Actividad_Economica From Empresa Where Id = 1 And Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Empresa");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Razon_Social, Nit From Empresa Where Id = 1 And Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Empresa");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(EmpresaEnt empresa)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Empresa Set Propietario = @Propietario, Razon_Social = @Razon_Social, Nit = @Nit, "
                + "Actividad_Economica = @Actividad_Economica Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Propietario", empresa.PROPIETARIO);
            sqlCommand.Parameters.AddWithValue("@Razon_Social", empresa.RAZON_SOCIAL);
            sqlCommand.Parameters.AddWithValue("@Nit", empresa.NIT);
            sqlCommand.Parameters.AddWithValue("@Actividad_Economica", empresa.ACTIVIDAD_ECONOMICA);
            sqlCommand.Parameters.AddWithValue("@Id", empresa.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}