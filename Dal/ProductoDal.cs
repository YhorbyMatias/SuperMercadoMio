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
    public class ProductoDal
    {
        #region Metodos
        public int add(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarProducto";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", producto.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", producto.ID_GRUPO);
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", producto.TIPO_DE_CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", producto.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", producto.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", producto.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", producto.PRESENTACION);
            if (producto.SABOR_U_OLOR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", producto.SABOR_U_OLOR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Tipo", producto.TIPO);
            if (producto.CANTIDAD_MINIMA > 0)
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", producto.CANTIDAD_MINIMA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", producto.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", producto.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Alias", producto.ALIAS);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int authenticate(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Producto Where Estado = 1 And Nombre_Generico = @Nombre_Generico "
                + "And Marca = @Marca And Presentacion = @Presentacion And ISNULL(Sabor_U_Olor, '') = @Sabor_U_Olor "
                + "And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", producto.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", producto.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", producto.PRESENTACION);
            sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", producto.SABOR_U_OLOR);
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateAlias(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Producto Where Estado = 1 And Alias = @Alias And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Alias", producto.ALIAS);
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateCodigoDeBarras(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id) From Producto Where Estado = 1 And Codigo_De_Barras = @Codigo_De_Barras And Id <> @Id";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", producto.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public void delete(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Producto Set Estado = 0 Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable findAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor, Precio_De_Venta "
                + "From buscarProductos() Where Precio_De_Venta > 0 Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getByBarCode(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Alias, Tipo, Precio_De_Venta From buscarProductos() "
                + "Where Codigo_De_Barras = @Codigo_De_Barras";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", producto.CODIGO_DE_BARRAS);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Producto");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int getNumber(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id) From Producto Where Estado = 1 "
                + "And Tipo_De_Codigo_De_Barras = @Tipo_De_Codigo_De_Barras";
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", producto.TIPO_DE_CODIGO_DE_BARRAS);
            sqlConnection.Open();
            int number = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return number;
        }
        public DataTable getStock()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From Stock() Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable search(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Proveedor, Id_Grupo, Tipo_De_Codigo_De_Barras, Codigo_De_Barras, Nombre_Generico, Marca, "
                + "Presentacion, Sabor_U_Olor, Tipo, Cantidad_Minima, Precio_De_Compra, Precio_De_Venta, Alias From Producto Where Estado = 1 "
                + "And Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Producto");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarProductos() Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchAllRemovable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * From buscarProductos() Where Id Not In "
                + "(Select Distinct DdI.Id_Producto From Detalle_De_Ingreso DdI Where DdI.Estado = 'VIGENTE' Union "
                + "Select Distinct DdE.Id_Producto From Detalle_De_Egreso DdE Where DdE.Estado = 'VIGENTE')Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchMarcas()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Distinct Marca From Producto Where Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Marcas");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable select(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor, "
                + "Precio_De_Compra, Precio_De_Venta From buscarProductos() Where Codigo_De_Barras = @Codigo_De_Barras";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", producto.CODIGO_DE_BARRAS);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Producto");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable selectAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor, "
                + "Precio_De_Compra, Precio_De_Venta From buscarProductos() Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Producto Set Id_Proveedor = @Id_Proveedor, Id_Grupo = @Id_Grupo, "
                + "Tipo_De_Codigo_De_Barras = @Tipo_De_Codigo_De_Barras, Codigo_De_Barras = @Codigo_De_Barras, "
                + "Nombre_Generico = @Nombre_Generico, Marca = @Marca, Sabor_U_Olor = @Sabor_U_Olor, Tipo = @Tipo, "
                + "Cantidad_Minima = @Cantidad_Minima, Precio_De_Compra = @Precio_De_Compra, Precio_De_Venta = @Precio_De_Venta, "
                + "Alias = @Alias Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", producto.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", producto.ID_GRUPO);
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", producto.TIPO_DE_CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", producto.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", producto.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", producto.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", producto.PRESENTACION);
            if (producto.SABOR_U_OLOR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", producto.SABOR_U_OLOR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Tipo", producto.TIPO);
            if (producto.CANTIDAD_MINIMA > 0)
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", producto.CANTIDAD_MINIMA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", producto.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", producto.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Alias", producto.ALIAS);
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updatePrecios(ProductoEnt producto)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Producto Set Precio_De_Compra = @Precio_De_Compra, Precio_De_Venta = @Precio_De_Venta "
                + "Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", producto.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", producto.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Id", producto.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}