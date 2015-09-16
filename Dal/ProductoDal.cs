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
        public int authenticate(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Producto) From Producto Where Estado = 1 And Nombre_Generico = @Nombre_Generico "
                + "And Marca = @Marca And Presentacion = @Presentacion And ISNULL(Sabor_U_Olor, '') = @Sabor_U_Olor And Id_Producto <> @Id_Producto";
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", productoX.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", productoX.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", productoX.PRESENTACION);
            sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", productoX.SABOR_U_OLOR);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", productoX.ID_PRODUCTO);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public int authenticateAlias(ProductoEnt productoX)
        {
            int exists = 0;
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Producto) From Producto Where Estado = 1 And Alias = @Alias "
                + "And Id_Producto <> @Id_Producto";
            sqlCommand.Parameters.AddWithValue("@Alias", productoX.ALIAS);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", productoX.ID_PRODUCTO);
            sqlConnection.Open();
            try
            {
                exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        
            }
            catch { 
            
            }
            sqlConnection.Close();
            return exists;
        }
        public int authenticateCodigoDeBarras(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Count(Id_Producto) From Producto Where Estado = 1 And Codigo_De_Barras = @Codigo_De_Barras "
                + "And Id_Producto <> @Id_Producto";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", productoX.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", productoX.ID_PRODUCTO);
            sqlConnection.Open();
            int exists = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return exists;
        }
        public DataTable findAll()
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Producto, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor "
                + "From buscarProductos() Where Precio > 0 Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int insert(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarProducto";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", productoX.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", productoX.ID_GRUPO);
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", productoX.TIPO_DE_CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", productoX.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", productoX.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", productoX.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", productoX.PRESENTACION);
            sqlCommand.Parameters.AddWithValue("@Alias", productoX.ALIAS);
            if (productoX.SABOR_U_OLOR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", productoX.SABOR_U_OLOR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Tipo", productoX.TIPO);
            if (productoX.CANTIDAD_MINIMA > 0)
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", productoX.CANTIDAD_MINIMA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", productoX.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", productoX.PRECIO_DE_VENTA);
            sqlConnection.Open();
            int idProducto = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idProducto;
        }
        public int getNumber(ProductoEnt productoX)
        {
            int numero = 0;
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select COUNT(Id_Producto) From Producto Where Estado = 1 "
                + "And Tipo_De_Codigo_De_Barras = @Tipo_De_Codigo_De_Barras";
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", productoX.TIPO_DE_CODIGO_DE_BARRAS);
            sqlConnection.Open();
            try
            {
                numero = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch { }
            sqlConnection.Close();
            return numero;
        }
        public DataTable search(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Proveedor, Id_Grupo, Tipo_De_Codigo_De_Barras, Codigo_De_Barras, Nombre_Generico, Marca, "
                + "Presentacion, Alias, Sabor_U_Olor, Tipo, Cantidad_Minima, Precio_De_Compra, Precio_De_Venta From Producto Where Estado = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Marcas");
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
        public DataTable select(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Id_Producto, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor, "
                + "Precio_De_Compra, Precio_De_Venta From buscarProductos() Where Codigo_De_Barras = @Codigo_De_Barras";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", productoX.CODIGO_DE_BARRAS);
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
            sqlCommand.CommandText = "Select Id_Producto, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Sabor_U_Olor, "
                + "Precio_De_Compra, Precio_De_Venta From buscarProductos() Order By Codigo_De_Barras Asc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Productos");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void update(ProductoEnt productoX)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Producto Set Id_Proveedor = @Id_Proveedor, Id_Grupo = @Id_Grupo, "
                + "Tipo_De_Codigo_De_Barras = @Tipo_De_Codigo_De_Barras, Codigo_De_Barras = @Codigo_De_Barras, "
                + "Nombre_Generico = @Nombre_Generico, Marca = @Marca, Alias = @Alias, Sabor_U_Olor = @Sabor_U_Olor, Tipo = @Tipo, "
                + "Cantidad_Minima = @Cantidad_Minima, Precio_De_Compra = @Precio_De_Compra, Precio_De_Venta = @Precio_De_Venta "
                + "Where Id_Producto = @Id_Producto";
            sqlCommand.Parameters.AddWithValue("@Id_Proveedor", productoX.ID_PROVEEDOR);
            sqlCommand.Parameters.AddWithValue("@Id_Grupo", productoX.ID_GRUPO);
            sqlCommand.Parameters.AddWithValue("@Tipo_De_Codigo_De_Barras", productoX.TIPO_DE_CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", productoX.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Nombre_Generico", productoX.NOMBRE_GENERICO);
            sqlCommand.Parameters.AddWithValue("@Marca", productoX.MARCA);
            sqlCommand.Parameters.AddWithValue("@Presentacion", productoX.PRESENTACION);
            sqlCommand.Parameters.AddWithValue("@Alias", productoX.ALIAS);
            if (productoX.SABOR_U_OLOR != "")
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", productoX.SABOR_U_OLOR);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Sabor_U_Olor", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Tipo", productoX.TIPO);
            if (productoX.CANTIDAD_MINIMA > 0)
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", productoX.CANTIDAD_MINIMA);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Cantidad_Minima", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Precio_De_Compra", productoX.PRECIO_DE_COMPRA);
            sqlCommand.Parameters.AddWithValue("@Precio_De_Venta", productoX.PRECIO_DE_VENTA);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", productoX.ID_PRODUCTO);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}