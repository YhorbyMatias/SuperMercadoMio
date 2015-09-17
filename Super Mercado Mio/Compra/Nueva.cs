using Bss;
using Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio.Compra
{
    public partial class Nueva : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, true, true };
        IngresoBss objetoIngreso = new IngresoBss();
        IngresoEnt ingreso = new IngresoEnt();
        ProveedorBss objetoProveedor = new ProveedorBss();
        ProveedorEnt proveedor = new ProveedorEnt();
        ProductoBss objetoProducto = new ProductoBss();
        ProductoEnt producto = new ProductoEnt();
        #endregion
        #region Form
        public Nueva()
        {
            InitializeComponent();
        }
        private void Nueva_Load(object sender, EventArgs e)
        {
            textBoxNumeroDeRegistro.Text = (objetoIngreso.getNumeroDeRegistro() + 1).ToString();
        }
        #endregion
        #region textBoxNit
        private void textBoxNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esNit(Clipboard.GetText()) == false)
                {
                    e.Handled = true;
                    isWritable = false;
                }
                else
                {
                    isWritable = true;
                }
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                Proveedor.Lista formularioListaDeProveedores = new Proveedor.Lista(3);
                formularioListaDeProveedores.ShowDialog();
                if (formularioListaDeProveedores.proveedor.ID_PROVEEDOR > 0)
                {
                    textBoxNit.Text = formularioListaDeProveedores.proveedor.NIT;
                    searchProveedor();
                }
            }
            else if (e.KeyValue == 13)
            {
                searchProveedor();
            }
        }
        private void textBoxNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                isWritable = true;
                e.Handled = true;
            }
        }
        private void textBoxNit_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarProveedor();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNumeroDeNotaDeEntrega
        private void textBoxNumeroDeNotaDeEntrega_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNotaDeEntrega();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNumeroDeNotaDeEntrega, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

            }
        }
        #endregion
        #region dataGridViewDetalleDeIngreso
        private void dataGridViewDetalleDeIngreso_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
        private void dataGridViewDetalleDeIngreso_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void dataGridViewDetalleDeIngreso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Metodos Propios
        private void addProducto(DataTable dataTableProductoX)
        {
            int row = 0;
            bool exists = false;
            for (int rows = 0; rows < dataGridViewDetalleDeIngreso.Rows.Count; rows++)
            {
                if (dataTableProductoX.Rows[0]["Id_Producto"].ToString() == dataGridViewDetalleDeIngreso["Id_Producto", rows].Value.ToString())
                {
                    row = rows;
                    exists = true;
                    break;
                }
            }
            if (exists == false)
            {
                dataGridViewDetalleDeIngreso.Rows.Add();
                row = dataGridViewDetalleDeIngreso.Rows.Count - 1;
                dataGridViewDetalleDeIngreso["Id_Producto", row].Value = dataTableProductoX.Rows[0]["Id_Producto"].ToString();
                dataGridViewDetalleDeIngreso["Codigo_De_Barras", row].Value = dataTableProductoX.Rows[0]["Codigo_De_Barras"].ToString();
                dataGridViewDetalleDeIngreso["Nombre_Generico", row].Value = dataTableProductoX.Rows[0]["Nombre_Generico"].ToString();
                dataGridViewDetalleDeIngreso["Marca", row].Value = dataTableProductoX.Rows[0]["Marca"].ToString();
                dataGridViewDetalleDeIngreso["Presentacion", row].Value = dataTableProductoX.Rows[0]["Presentacion"].ToString();
                dataGridViewDetalleDeIngreso["Sabor_U_Olor", row].Value = dataTableProductoX.Rows[0]["Sabor_U_Olor"].ToString();
                dataGridViewDetalleDeIngreso["Cantidad", row].Value = 1;
                dataGridViewDetalleDeIngreso["Precio_De_Compra", row].Value = Convert.ToDecimal(dataTableProductoX.Rows[0]["Precio_De_Compra"]);
                dataGridViewDetalleDeIngreso["Monto_Total", row].Value = Convert.ToDecimal(dataTableProductoX.Rows[0]["Precio_De_Compra"]);
                dataGridViewDetalleDeIngreso["Precio_De_Venta", row].Value = Convert.ToDecimal(dataTableProductoX.Rows[0]["Precio_De_Venta"]);
            }
            else
            {
                dataGridViewDetalleDeIngreso["Cantidad", row].Value = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", row].Value) + 1;
                dataGridViewDetalleDeIngreso["Precio_Total", row].Value = (Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", row].Value) *
                    Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_Unitario", row].Value)).ToString("0.00");
            }
        }
        private void searchProducto()
        {
            producto.CODIGO_DE_BARRAS = textBoxCodigoDeBarras.Text.Trim().ToUpper();
            DataTable dataTableProducto = objetoProducto.select(producto);
            if (dataTableProducto.Rows.Count > 0)
            {
                addProducto(dataTableProducto);
            }
            else
            {
                Producto.Nuevo formularioNuevoProducto = new Producto.Nuevo(2, producto.CODIGO_DE_BARRAS);
                formularioNuevoProducto.ShowDialog();
                producto = formularioNuevoProducto.producto;
                if (producto.ID_PRODUCTO != 0)
                {
                    dataTableProducto = objetoProducto.select(producto);
                    addProducto(dataTableProducto);
                }
            }
        }
        private void searchProveedor()
        {
            proveedor.NIT = textBoxNit.Text.Trim();
            DataTable dataTableProveedor = objetoProveedor.select(proveedor);
            if (dataTableProveedor.Rows.Count > 0)
            {
                proveedor.ID_PROVEEDOR = Convert.ToInt32(dataTableProveedor.Rows[0]["Id_Proveedor"]);
                textBoxProveedor.Text = dataTableProveedor.Rows[0]["Nombre"].ToString();
            }
            else
            {
                Proveedor.Nuevo formularioNuevoProveedor = new Proveedor.Nuevo(2, proveedor.NIT);
                formularioNuevoProveedor.ShowDialog();
                proveedor = formularioNuevoProveedor.proveedor;
                if (proveedor.ID_PROVEEDOR > 0)
                {
                    textBoxNit.Text = proveedor.NIT;
                    textBoxProveedor.Text = proveedor.NOMBRE;
                }
            }
        }
        private int validarNotaDeEntrega()
        {
            if (textBoxNumeroDeNotaDeEntrega.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarProveedor()
        {
            if (textBoxNit.Text.Trim() != "")
            {
                if (ValidacionBss.esNit(textBoxNit.Text.Trim()))
                {
                    if (proveedor.NIT == textBoxNit.Text.Trim())
                    {
                        return 0;
                    }
                    else
                    {
                        return 13;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }
        #endregion
    }
}