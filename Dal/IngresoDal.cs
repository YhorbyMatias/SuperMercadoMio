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
        #region Methods
        public int add(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarIngreso";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", ingreso.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Hora", ingreso.HORA);
            sqlCommand.Parameters.AddWithValue("@Tipo", ingreso.TIPO);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Registro", ingreso.NUMERO_DE_REGISTRO);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Nota_De_Entrega", ingreso.NUMERO_DE_NOTA_DE_ENTREGA);
            sqlCommand.Parameters.AddWithValue("@Monto", ingreso.MONTO);
            if (ingreso.OBSERVACIONES != "")
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", ingreso.OBSERVACIONES);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", DBNull.Value);
            }
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public void cancel(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Ingreso Set Estado = 'ANULADA' Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", ingreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getById(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select I.Id, I.Id_Proveedor, P.Nit, P.Nombre As Proveedor, I.Fecha, I.Numero_De_Registro, "
                + "I.Numero_De_Nota_De_Entrega, I.Monto, I.Observaciones, I.Estado From Proveedor P, Ingreso I "
                + "Where P.Id = I.Id_Proveedor And P.Estado = 1 And I.Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", ingreso.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Ingreso");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int existsId(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) As Id From Ingreso Where Tipo = @Tipo And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Tipo", ingreso.TIPO);
            sqlCommand.Parameters.AddWithValue("@Id", ingreso.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int getMaxId(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MAX(Id), 0) As Id From Ingreso Where Tipo = @Tipo";
            sqlCommand.Parameters.AddWithValue("@Tipo", ingreso.TIPO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int getMinId(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MIN(Id), 0) As Id From Ingreso Where Tipo = @Tipo";
            sqlCommand.Parameters.AddWithValue("@Tipo", ingreso.TIPO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int getNumeroDeRegistro(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) As Numero_De_Registro From Ingreso Where Tipo = @Tipo";
            sqlCommand.Parameters.AddWithValue("@Tipo", ingreso.TIPO);
            sqlConnection.Open();
            int numeroDeRegistro = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return numeroDeRegistro;
        }
        public DataTable search(ProveedorEnt proveedor, IngresoEnt ingreso, ProductoEnt producto)
        {
            string where = "";
            if (proveedor.NIT != "")
            {
                where = where + " And P.Nit Like '%" + proveedor.NIT + "%'";
            }
            if (proveedor.NOMBRE != "")
            {
                where = where + " And P.Nombre Like '%" + proveedor.NOMBRE + "%'";
            }
            if (ingreso.FECHA != "")
            {
                where = where + " And I.Fecha = '" + ingreso.FECHA + "'";
            }
            if (ingreso.NUMERO_DE_REGISTRO != 0)
            {
                where = where + " And I.Numero_De_Registro = '" + ingreso.NUMERO_DE_REGISTRO + "'";
            }
            if (ingreso.NUMERO_DE_NOTA_DE_ENTREGA != "")
            {
                where = where + " And I.Numero_De_Nota_De_Entrega Like '%" + ingreso.NUMERO_DE_NOTA_DE_ENTREGA + "%'";
            }
            if (ingreso.ESTADO != "")
            {
                where = where + " And I.Estado Like '%" + ingreso.ESTADO + "%'";
            }
            if (producto.CODIGO_DE_BARRAS != "")
            {
                where = where + " And Pr.Codigo_De_Barras = '" + producto.CODIGO_DE_BARRAS + "'";
            }
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select I.Id, P.Nit, P.Nombre As Proveedor, I.Fecha, I.Numero_De_Registro, I.Numero_De_Nota_De_Entrega, "
                + "I.Monto, I.Observaciones, I.Estado "
                + "From Proveedor P, Ingreso I, Producto Pr, Detalle_De_Ingreso DdI "
                + "Where P.Id = I.Id_Proveedor And P.Estado = 1 And I.Id = DdI.Id_Ingreso And I.Tipo = 'COMPRA' And Pr.Id = DdI.Id_Producto "
                + "And Pr.Estado = 1 And DdI.Estado in ('VIGENTE', 'ANULADO')" + where;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Ingreso");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(IngresoEnt ingreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Ingreso Set Id_Proveedor = @Id_Proveedor, "
                + "Numero_De_Nota_De_Entrega = @Numero_De_Nota_De_Entrega, Monto = @Monto, Observaciones = @Observaciones Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", ingreso.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Nota_De_Entrega", ingreso.NUMERO_DE_NOTA_DE_ENTREGA);
            sqlCommand.Parameters.AddWithValue("@Monto", ingreso.MONTO);
            if (ingreso.OBSERVACIONES != "")
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", ingreso.OBSERVACIONES);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Observaciones", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Id", ingreso.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}