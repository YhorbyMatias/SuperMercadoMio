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
    public class ProveedorDal
    {
        #region Metodos
        public int add(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarProveedor";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedor.NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", proveedor.NOMBRE);
            if (proveedor.PERSONA_DE_CONTACTO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", proveedor.PERSONA_DE_CONTACTO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", DBNull.Value);
            }
            if (proveedor.DIRECCION != "")
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.DIRECCION);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", DBNull.Value);
            }
            if (proveedor.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedor.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            if (proveedor.CELULAR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Celular", proveedor.CELULAR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Celular", DBNull.Value);
            }
            if (proveedor.NUMERO_DE_CUENTA != "")
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", proveedor.NUMERO_DE_CUENTA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", DBNull.Value);
            }
            sqlConnection.Open();
            int idProveedor = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idProveedor;
        }
        public int authenticateNit(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Proveedor Where Estado = 1 And Nit = @Nit And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedor.NIT);
            sqlCommand.Parameters.AddWithValue("@Id", proveedor.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateName(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Proveedor Where Estado = 1 And Nombre = @Nombre And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre", proveedor.NOMBRE);
            sqlCommand.Parameters.AddWithValue("@Id", proveedor.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Proveedor Set Estado = @Estado Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Estado", proveedor.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id", proveedor.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable search(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Nit, Nombre, Persona_De_Contacto, Direccion, Telefono, Celular, Numero_De_Cuenta "
                + "From Proveedor Where Estado = 1 And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedor.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedor");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarProveedores()";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchRemovable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarProveedores() "
                + "Where Not Exists (Select I.Id_Proveedor From Ingreso I Where Estado = 'VIGENTE' And Id = I.Id_Proveedor)";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Nombre From Proveedor Where Estado = 1 And Nit = @Nit";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedor.NIT);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedor");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable selectAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Nombre From buscarProveedores()";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(ProveedorEnt proveedor)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Proveedor Set Nit = @Nit, Nombre = @Nombre, Persona_De_Contacto = @Persona_De_Contacto, "
                + "Direccion = @Direccion, Telefono = @Telefono, Celular = @Celular, Numero_De_Cuenta = @Numero_De_Cuenta "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedor.NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", proveedor.NOMBRE);
            if (proveedor.PERSONA_DE_CONTACTO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", proveedor.PERSONA_DE_CONTACTO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", DBNull.Value);
            }
            if (proveedor.DIRECCION != "")
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.DIRECCION);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", DBNull.Value);
            }
            if (proveedor.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedor.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            if (proveedor.CELULAR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Celular", proveedor.CELULAR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Celular", DBNull.Value);
            }
            if (proveedor.NUMERO_DE_CUENTA != "")
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", proveedor.NUMERO_DE_CUENTA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedor.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}