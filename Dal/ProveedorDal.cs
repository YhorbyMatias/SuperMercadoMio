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
        public int authenticateNit(ProveedorEnt proveedorX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Proveedor) From Proveedor Where Estado = 1 And Nit = @Nit "
                + "And Id_Proveedor <> @Id_Proveedor";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedorX.NIT);
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedorX.ID_PROVEEDOR);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(ProveedorEnt proveedorX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Proveedor Set Estado = @Estado Where Id_Proveedor = @Id_Proveedor";
            sqlCommand.Parameters.AddWithValue("@Estado", proveedorX.ESTADO);
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedorX.ID_PROVEEDOR);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int insert(ProveedorEnt proveedorX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarProveedor";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedorX.NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", proveedorX.NOMBRE);
            if (proveedorX.PERSONA_DE_CONTACTO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", proveedorX.PERSONA_DE_CONTACTO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", DBNull.Value);
            }
            if (proveedorX.DIRECCION != "")
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedorX.DIRECCION);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", DBNull.Value);
            }
            if (proveedorX.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedorX.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            if (proveedorX.CELULAR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Celular", proveedorX.CELULAR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Celular", DBNull.Value);
            }
            if (proveedorX.NUMERO_DE_CUENTA != "")
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", proveedorX.NUMERO_DE_CUENTA);
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
        public DataTable search(ProveedorEnt proveedorX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Nit, Nombre, Persona_De_Contacto, Direccion, Telefono, Celular, Numero_De_Cuenta "
                + "From Proveedor Where Estado = 1 And Id_Proveedor = @Id_Proveedor";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedorX.ID_PROVEEDOR);
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
                + "Where Id_Proveedor Not Exists (Select Id_Proveedor From Ingreso I Where Estado = 'VIGENTE')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Proveedores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(ProveedorEnt proveedorX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Proveedor Set Nit = @Nit, Nombre = @Nombre, Persona_De_Contacto = @Persona_De_Contacto, "
                + "Direccion = @Direccion, Telefono = @Telefono, Celular = @Celular, Numero_De_Cuenta = @Numero_De_Cuenta "
                + "Where Id_Proveedor = @Id_Proveedor";
            sqlCommand.Parameters.AddWithValue("@Nit", proveedorX.NIT);
            sqlCommand.Parameters.AddWithValue("@Nombre", proveedorX.NOMBRE);
            if (proveedorX.PERSONA_DE_CONTACTO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", proveedorX.PERSONA_DE_CONTACTO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Persona_De_Contacto", DBNull.Value);
            }
            if (proveedorX.DIRECCION != "")
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedorX.DIRECCION);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Direccion", DBNull.Value);
            }
            if (proveedorX.TELEFONO != "")
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedorX.TELEFONO);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
            }
            if (proveedorX.CELULAR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Celular", proveedorX.CELULAR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Celular", DBNull.Value);
            }
            if (proveedorX.NUMERO_DE_CUENTA != "")
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", proveedorX.NUMERO_DE_CUENTA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Numero_De_Cuenta", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", proveedorX.ID_PROVEEDOR);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}