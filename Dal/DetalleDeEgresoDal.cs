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
    public class DetalleDeEgresoDal
    {
        #region Methods
        public int add(DetalleDeEgresoEnt detalleDeEgreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarDetalleDeEgreso";
            sqlCommand.Parameters.AddWithValue("@Id_Egreso", detalleDeEgreso.ID_EGRESO);
            sqlCommand.Parameters.AddWithValue("@Id_Producto", detalleDeEgreso.ID_PRODUCTO);
            sqlCommand.Parameters.AddWithValue("@Cantidad", detalleDeEgreso.CANTIDAD);
            sqlCommand.Parameters.AddWithValue("@Precio_Unitario", detalleDeEgreso.PRECIO_UNITARIO);
            sqlCommand.Parameters.AddWithValue("@Monto_Total", detalleDeEgreso.MONTO_TOTAL);
            sqlCommand.Parameters.AddWithValue("@Estado", detalleDeEgreso.ESTADO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public DataTable getMinorSalesDetail(EgresoEnt egreso)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select P.Id, P.Alias, DdE.Cantidad, DdE.Precio_Total "
                + "From Producto P, Egreso E, Detalle_De_Egreso DdE Where P.Id = DdE.Id_Producto And P.Estado = 1 "
                + "And E.Id = DdE.Id_Egreso And E.Id_Cliente = 1 And E.Tipo = 'VENTA MENOR' And E.Facturado = 0 And E.Cerrado = 0 "
                + "And E.Id_Apertura_De_Caja = @Id_Apertura_De_Caja";
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", egreso.ID_APERTURA_DE_CAJA);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable("Detalle de Egreso Egresos Menores");
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
    }
}