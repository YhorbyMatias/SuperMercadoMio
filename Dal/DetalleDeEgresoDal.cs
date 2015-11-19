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