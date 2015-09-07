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
        public int exists()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Empresa) From Empresa Where Estado = 1";
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
        }
        public int insert(EmpresaEnt empresaX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarEmpresa";
            sqlCommand.Parameters.AddWithValue("@Propietario", empresaX.PROPIETARIO);
            sqlCommand.Parameters.AddWithValue("@Razon_Social", empresaX.RAZON_SOCIAL);
            sqlCommand.Parameters.AddWithValue("@Nit", empresaX.NIT);
            sqlCommand.Parameters.AddWithValue("@Actividad_Economica", empresaX.ACTIVIDAD_ECONOMICA);
            sqlConnection.Open();
            int idEmpresa = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idEmpresa;
        }
        public DataTable search()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Propietario, Razon_Social, Nit, Actividad_Economica From Empresa Where Estado = 1 "
                + "And Id_Empresa = 1";
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
            sqlCommand.CommandText = "Select Razon_Social, Nit From Empresa Where Estado = 1 And Id_Empresa = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Empresa");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(EmpresaEnt empresaX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Empresa Set Propietario = @Propietario, Razon_Social = @Razon_Social, Nit = @Nit, "
                + "Actividad_Economica = @Actividad_Economica Where Id_Empresa = @Id_Empresa";
            sqlCommand.Parameters.AddWithValue("@Propietario", empresaX.PROPIETARIO);
            sqlCommand.Parameters.AddWithValue("@Razon_Social", empresaX.RAZON_SOCIAL);
            sqlCommand.Parameters.AddWithValue("@Nit", empresaX.NIT);
            sqlCommand.Parameters.AddWithValue("@Actividad_Economica", empresaX.ACTIVIDAD_ECONOMICA);
            sqlCommand.Parameters.AddWithValue("@Id_Empresa", empresaX.ID_EMPRESA);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}