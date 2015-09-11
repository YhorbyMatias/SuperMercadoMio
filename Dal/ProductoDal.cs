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
                + "And Id_Producto <> @Id_Producto";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Barras", productoX.CODIGO_DE_BARRAS);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", productoX.ID_PRODUCTO);
            sqlConnection.Open();
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
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
            int existe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return existe;
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
            sqlCommand.Parameters.AddWithValue("@Precio", productoX.PRECIO);
            sqlConnection.Open();
            int idProducto = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return idProducto;
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
        #endregion
    }
}