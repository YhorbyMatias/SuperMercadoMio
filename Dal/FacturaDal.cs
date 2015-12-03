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
    public class FacturaDal
    {
        #region Methods
        public int add(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "insertarFactura";
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", factura.ID_USUARIO);
            sqlCommand.Parameters.AddWithValue("@Id_Caja", factura.ID_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Apertura_De_Caja", factura.ID_APERTURA_DE_CAJA);
            sqlCommand.Parameters.AddWithValue("@Id_Egreso", factura.ID_EGRESO);
            sqlCommand.Parameters.AddWithValue("@Id_Cliente", factura.ID_CLIENTE);
            sqlCommand.Parameters.AddWithValue("@Id_Dosificacion", factura.ID_DOSIFICACION);
            sqlCommand.Parameters.AddWithValue("@Numero_De_Autorizacion", factura.NUMERO_DE_AUTORIZACION);
            sqlCommand.Parameters.AddWithValue("@Ci_O_Nit", factura.CI_O_NIT);
            sqlCommand.Parameters.AddWithValue("@Cliente", factura.CLIENTE);
            sqlCommand.Parameters.AddWithValue("@Fecha", factura.FECHA);
            sqlCommand.Parameters.AddWithValue("@Hora", factura.HORA);
            sqlCommand.Parameters.AddWithValue("@Monto", factura.MONTO);
            sqlCommand.Parameters.AddWithValue("@Monto_Pagado", factura.MONTO_PAGADO);
            sqlCommand.Parameters.AddWithValue("@Cambio", factura.CAMBIO);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public void cancel(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Factura Set Codigo_De_Control = '0', Ci_O_Nit = '0', Cliente = 'ANULADA', Monto = '0.00', "
                + "Monto_Pagado = '0.00', Cambio = '0.00', Estado = 'ANULADA' Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", factura.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public int getNumber(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select Numero From Factura Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", factura.ID);
            sqlConnection.Open();
            int number = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return number;
        }
        public DataTable getById(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select E.Razon_Social, E.Propietario, S.Numero As Numero_De_Sucursal, S.Direccion, S.Municipio, "
                + "E.Nit, F.Numero As Numero_De_Factura, F.Numero_De_Autorizacion, F.Fecha, F.Hora, F.Ci_O_Nit, F.Cliente, "
                + "F.Monto, F.Monto_Pagado, F.Cambio, F.Codigo_De_Control, D.Fecha_Limite_De_Emision, U.Usuario, C.Numero As Numero_De_Caja "
                + "From Usuario U, Empresa E, Sucursal S, Dosificacion D, Caja C, Factura F Where U.Id = F.Id_Usuario And E.Id = S.Id_Empresa "
                + "And E.Estado = 1 And S.Id = D.Id_Sucursal And S.Estado = 1 And D.Id = F.Id_Dosificacion And C.Id = F.Id_Caja "
                + "And F.Id = @Id_Factura";
            sqlCommand.Parameters.AddWithValue("@Id_Factura", factura.ID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Factura");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getByControlCode(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select F.Id, F.Id_Egreso, F.Numero_De_Autorizacion, F.Numero As Numero_De_Factura, F.Codigo_De_Control, "
                + "D.Fecha_Limite_De_Emision, U.Usuario, C.Numero As Numero_De_Caja, F.Ci_O_Nit, F.Cliente, F.Fecha, F.Hora, F.Monto, "
                + "F.Monto_Pagado, F.Cambio,  From Usuario U, Dosificacion D, Caja C, Factura F "
                + "Where U.Id = F.Id_Usuario And D.Id = F.Id_Dosificacion And C.Id = F.Id_Caja And F.Estado = 'VIGENTE' "
                + "And F.Id = @Id_Factura";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Control", factura.CODIGO_DE_CONTROL);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable("Factura");
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void updateControlCode(FacturaEnt factura)
        {
            SqlConnection sqlConnection = new SqlConnection(ConexionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Factura Set Codigo_De_Control = @Codigo_De_Control Where Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Codigo_De_Control", factura.CODIGO_DE_CONTROL);
            sqlCommand.Parameters.AddWithValue("@Id", factura.ID);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}