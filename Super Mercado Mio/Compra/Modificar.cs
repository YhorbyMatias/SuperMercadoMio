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
    public partial class Modificar : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[] { false, false, false };
        IngresoBss objetoIngreso = new IngresoBss();
        IngresoEnt ingreso = new IngresoEnt();
        DetalleDeIngresoBss objetoDetalleDeIngreso = new DetalleDeIngresoBss();
        DetalleDeIngresoEnt detalleDeIngreso = new DetalleDeIngresoEnt();
        ProveedorBss objetoProveedor = new ProveedorBss();
        ProveedorEnt proveedor = new ProveedorEnt();
        ProductoBss objetoProducto = new ProductoBss();
        ProductoEnt producto = new ProductoEnt();
        List<DetalleDeIngresoEnt> detalleDeIngresolist = new List<DetalleDeIngresoEnt>();
        #endregion
        #region Form
        public Modificar(int idIngreso)
        {
            InitializeComponent();
            ingreso.ID = idIngreso;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            setDataGridViewDetalleDeIngresoFormat();
            loadFormData();
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
                if (formularioListaDeProveedores.proveedor.ID > 0)
                {
                    textBoxNit.Text = formularioListaDeProveedores.proveedor.NIT;
                    searchProveedor();
                }
            }
            if (e.KeyValue == 13)
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
            int errorCode = validateProveedor();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNumeroDeNotaDeEntrega
        private void textBoxNumeroDeNotaDeEntrega_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validateNotaDeEntrega();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNumeroDeNotaDeEntrega, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                searchProduct();
            }
        }
        #endregion
        #region searchProductButton
        private void searchProductButton_Click(object sender, EventArgs e)
        {
            Producto.Busqueda formBusquedaDeProductos = new Producto.Busqueda(1);
            formBusquedaDeProductos.ShowDialog();
            if (formBusquedaDeProductos.product.ID > 0)
            {
                textBoxCodigoDeBarras.Text = formBusquedaDeProductos.product.CODIGO_DE_BARRAS;
                searchProduct();
            }
            else
            {
                textBoxCodigoDeBarras.Focus();
            }
        }
        #endregion
        #region dataGridViewDetalleDeIngreso
        private void dataGridViewDetalleDeIngreso_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int errorCode = validateCantidad(e.FormattedValue);
                dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                if (errorCode > 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    dataGridViewDetalleDeIngreso.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dataGridViewDetalleDeIngreso["Monto_Total", e.RowIndex].Value = calculateMontoTotal(e.RowIndex);
                    textBoxMonto.Text = calculateMonto();
                }
            }
            if (e.ColumnIndex == 8)
            {
                int errorCode = validatePrecioDeCompra(e.FormattedValue);
                dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                if (errorCode > 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    decimal precioDeCompra = Convert.ToDecimal(e.FormattedValue);
                    decimal precioDeVenta = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Venta", e.RowIndex].Value);
                    errorCode = validatePrecios(precioDeCompra, precioDeVenta);
                    dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                    if (errorCode > 0)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridViewDetalleDeIngreso.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", e.RowIndex].Value =
                            calculatePorcentajeDeUtilidad(e.RowIndex);
                    }
                }
            }
            if (e.ColumnIndex == 9)
            {
                int errorCode = validateMontoTotal(e.FormattedValue, e.RowIndex);
                dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                if (errorCode > 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    dataGridViewDetalleDeIngreso.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dataGridViewDetalleDeIngreso["Precio_De_Compra", e.RowIndex].Value = calculatePrecioDeCompra(e.RowIndex);
                    dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", e.RowIndex].Value =
                        calculatePorcentajeDeUtilidad(e.RowIndex);
                    textBoxMonto.Text = calculateMonto();
                }
            }
            if (e.ColumnIndex == 10)
            {
                int errorCode = validatePrecioDeVenta(e.FormattedValue);
                dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                if (errorCode > 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    decimal precioDeCompra = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Compra", e.RowIndex].Value);
                    decimal precioDeVenta = Convert.ToDecimal(e.FormattedValue);
                    errorCode = validatePrecios(precioDeCompra, precioDeVenta);
                    dataGridViewDetalleDeIngreso.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                    if (errorCode > 0)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridViewDetalleDeIngreso.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", e.RowIndex].Value =
                            calculatePorcentajeDeUtilidad(e.RowIndex);
                    }
                }
            }
        }
        private void dataGridViewDetalleDeIngreso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBoxMonto.Text = calculateMonto();
        }
        private void dataGridViewDetalleDeIngreso_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["Id"].Value.ToString() != "0")
            {
                detalleDeIngreso = new DetalleDeIngresoEnt();
                detalleDeIngreso.ID = Convert.ToInt32(e.Row.Cells["Id"].Value);
                detalleDeIngresolist.Add(detalleDeIngreso);
            }
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                ingreso.ID_PROVEEDOR = proveedor.ID;
                ingreso.NUMERO_DE_NOTA_DE_ENTREGA = textBoxNumeroDeNotaDeEntrega.Text.Trim().ToUpper();
                ingreso.MONTO = Convert.ToDecimal(calculateMonto());
                ingreso.OBSERVACIONES = textBoxObservaciones.Text.Trim().ToUpper();
                objetoIngreso.update(ingreso);
                foreach (DetalleDeIngresoEnt purchaseDetail in detalleDeIngresolist)
                {
                    objetoDetalleDeIngreso.delete(purchaseDetail);
                }
                for (int rowIndex = 0; rowIndex < dataGridViewDetalleDeIngreso.Rows.Count; rowIndex++)
                {
                    detalleDeIngreso = new DetalleDeIngresoEnt();
                    detalleDeIngreso.ID = Convert.ToInt32(dataGridViewDetalleDeIngreso["Id", rowIndex].Value);
                    detalleDeIngreso.ID_INGRESO = ingreso.ID;
                    detalleDeIngreso.ID_PRODUCTO = Convert.ToInt32(dataGridViewDetalleDeIngreso["Id_Producto", rowIndex].Value);
                    detalleDeIngreso.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", rowIndex].Value);
                    detalleDeIngreso.PRECIO_DE_COMPRA = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Compra", rowIndex].Value);
                    detalleDeIngreso.MONTO_TOTAL = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Monto_Total", rowIndex].Value);
                    detalleDeIngreso.PORCENTAJE_DE_UTILIDAD =
                        Convert.ToDecimal(dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", rowIndex].Value);
                    detalleDeIngreso.PRECIO_DE_VENTA = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Venta", rowIndex].Value);
                    if (detalleDeIngreso.ID != 0)
                    {
                        objetoDetalleDeIngreso.update(detalleDeIngreso);
                    }
                    else
                    {
                        detalleDeIngreso.ID = objetoDetalleDeIngreso.add(detalleDeIngreso);
                    }
                    producto = new ProductoEnt();
                    producto.ID = detalleDeIngreso.ID_PRODUCTO;
                    producto.PRECIO_DE_COMPRA = detalleDeIngreso.PRECIO_DE_COMPRA;
                    producto.PRECIO_DE_VENTA = detalleDeIngreso.PRECIO_DE_VENTA;
                    objetoProducto.updatePrecios(producto);
                }
                MessageBox.Show("Los datos fueron guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Metodos Propios
        private void addProducto(DataTable dataTableProducto)
        {
            int row = 0;
            bool exists = false;
            for (int rows = 0; rows < dataGridViewDetalleDeIngreso.Rows.Count; rows++)
            {
                if (dataTableProducto.Rows[0]["Id"].ToString() == dataGridViewDetalleDeIngreso["Id_Producto", rows].Value.ToString())
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
                dataGridViewDetalleDeIngreso["Id", row].Value = "0";
                dataGridViewDetalleDeIngreso["Id_Producto", row].Value = dataTableProducto.Rows[0]["Id"].ToString();
                dataGridViewDetalleDeIngreso["Codigo_De_Barras", row].Value = dataTableProducto.Rows[0]["Codigo_De_Barras"].ToString();
                dataGridViewDetalleDeIngreso["Nombre_Generico", row].Value = dataTableProducto.Rows[0]["Nombre_Generico"].ToString();
                dataGridViewDetalleDeIngreso["Marca", row].Value = dataTableProducto.Rows[0]["Marca"].ToString();
                dataGridViewDetalleDeIngreso["Presentacion", row].Value = dataTableProducto.Rows[0]["Presentacion"].ToString();
                dataGridViewDetalleDeIngreso["Sabor_U_Olor", row].Value = dataTableProducto.Rows[0]["Sabor_U_Olor"].ToString();
                dataGridViewDetalleDeIngreso["Cantidad", row].Value = 1;
                dataGridViewDetalleDeIngreso["Precio_De_Compra", row].Value =
                    Convert.ToDecimal(dataTableProducto.Rows[0]["Precio_De_Compra"]);
                dataGridViewDetalleDeIngreso["Monto_Total", row].Value = Convert.ToDecimal(dataTableProducto.Rows[0]["Precio_De_Compra"]);
                dataGridViewDetalleDeIngreso["Precio_De_Venta", row].Value = Convert.ToDecimal(dataTableProducto.Rows[0]["Precio_De_Venta"]);
                dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", row].Value = calculatePorcentajeDeUtilidad(row);
            }
            else
            {
                dataGridViewDetalleDeIngreso["Cantidad", row].Value =
                    Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", row].Value) + 1;
                dataGridViewDetalleDeIngreso["Monto_Total", row].Value = calculateMontoTotal(row);
            }
            textBoxCodigoDeBarras.ResetText();
            textBoxCodigoDeBarras.Focus();
            textBoxMonto.Text = calculateMonto();
        }
        private string calculateMonto()
        {
            decimal monto = 0;
            for (int rows = 0; rows < dataGridViewDetalleDeIngreso.Rows.Count; rows++)
            {
                monto = monto + Convert.ToDecimal(dataGridViewDetalleDeIngreso["Monto_Total", rows].Value);
            }
            return monto.ToString("0.00");
        }
        private string calculateMontoTotal(int rowIndex)
        {
            return (Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", rowIndex].Value) *
                Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Compra", rowIndex].Value)).ToString("0.00");
        }
        private string calculatePorcentajeDeUtilidad(int rowIndex)
        {
            return (((Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Venta", rowIndex].Value) * 100) /
                Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Compra", rowIndex].Value)) - 100).ToString("0.00");
        }
        private string calculatePrecioDeCompra(int rowIndex)
        {
            return (Convert.ToDecimal(dataGridViewDetalleDeIngreso["Monto_Total", rowIndex].Value) /
                Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", rowIndex].Value)).ToString("0.00");
        }
        private void loadFormData()
        {
            DataTable purchaseDataTable = objetoIngreso.getById(ingreso);
            proveedor.ID = Convert.ToInt32(purchaseDataTable.Rows[0]["Id_Proveedor"]);
            proveedor.NIT = purchaseDataTable.Rows[0]["Nit"].ToString();
            ingreso.ID_PROVEEDOR = proveedor.ID;
            textBoxNit.Text = proveedor.NIT;
            textBoxProveedor.Text = purchaseDataTable.Rows[0]["Proveedor"].ToString();
            textBoxFecha.Text = Convert.ToDateTime(purchaseDataTable.Rows[0]["Fecha"]).ToShortDateString();
            textBoxNumeroDeRegistro.Text = purchaseDataTable.Rows[0]["Numero_De_Registro"].ToString();
            textBoxNumeroDeNotaDeEntrega.Text = purchaseDataTable.Rows[0]["Numero_De_Nota_De_Entrega"].ToString();
            textBoxMonto.Text = purchaseDataTable.Rows[0]["Monto"].ToString();
            textBoxObservaciones.Text = purchaseDataTable.Rows[0]["Observaciones"].ToString();
            detalleDeIngreso.ID_INGRESO = ingreso.ID;
            DataTable purchaseLinesDataTable = objetoDetalleDeIngreso.getByIngresoId(detalleDeIngreso);
            for (int rowIndex = 0; rowIndex < purchaseLinesDataTable.Rows.Count; rowIndex++)
            {
                dataGridViewDetalleDeIngreso.Rows.Add();
                dataGridViewDetalleDeIngreso["Id", rowIndex].Value = purchaseLinesDataTable.Rows[rowIndex]["Id"].ToString();
                dataGridViewDetalleDeIngreso["Id_Producto", rowIndex].Value = purchaseLinesDataTable.Rows[rowIndex]["Id_Producto"].ToString();
                dataGridViewDetalleDeIngreso["Codigo_De_Barras", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Codigo_De_Barras"].ToString();
                dataGridViewDetalleDeIngreso["Nombre_Generico", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Nombre_Generico"].ToString();
                dataGridViewDetalleDeIngreso["Marca", rowIndex].Value = purchaseLinesDataTable.Rows[rowIndex]["Marca"].ToString();
                dataGridViewDetalleDeIngreso["Presentacion", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Presentacion"].ToString();
                dataGridViewDetalleDeIngreso["Sabor_U_Olor", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Sabor_U_Olor"].ToString();
                dataGridViewDetalleDeIngreso["Cantidad", rowIndex].Value = purchaseLinesDataTable.Rows[rowIndex]["Cantidad"].ToString();
                dataGridViewDetalleDeIngreso["Precio_De_Compra", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Precio_De_Compra"].ToString();
                dataGridViewDetalleDeIngreso["Monto_Total", rowIndex].Value = purchaseLinesDataTable.Rows[rowIndex]["Monto_Total"].ToString();
                dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Porcentaje_De_Utilidad"].ToString();
                dataGridViewDetalleDeIngreso["Precio_De_Venta", rowIndex].Value =
                    purchaseLinesDataTable.Rows[rowIndex]["Precio_De_Venta"].ToString();
            }
        }
        private void setDataGridViewDetalleDeIngresoFormat()
        {
            dataGridViewDetalleDeIngreso.Columns["Codigo_De_Barras"].Width = 100;
            dataGridViewDetalleDeIngreso.Columns["Nombre_Generico"].Width = 100;
            dataGridViewDetalleDeIngreso.Columns["Marca"].Width = 100;
            dataGridViewDetalleDeIngreso.Columns["Presentacion"].Width = 85;
            dataGridViewDetalleDeIngreso.Columns["Sabor_U_Olor"].Width = 80;
            dataGridViewDetalleDeIngreso.Columns["Cantidad"].Width = 66;
            dataGridViewDetalleDeIngreso.Columns["Precio_De_Compra"].Width = 70;
            dataGridViewDetalleDeIngreso.Columns["Monto_Total"].Width = 75;
            dataGridViewDetalleDeIngreso.Columns["Porcentaje_De_Utilidad"].Width = 60;
            dataGridViewDetalleDeIngreso.Columns["Precio_De_Venta"].Width = 75;
        }
        private void searchProduct()
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
                if (producto.ID != 0)
                {
                    dataTableProducto = objetoProducto.select(producto);
                    addProducto(dataTableProducto);
                }
            }
        }
        private void searchProveedor()
        {
            proveedor.NIT = textBoxNit.Text.Trim();
            DataTable dataTableProveedores = objetoProveedor.select(proveedor);
            if (dataTableProveedores.Rows.Count > 0)
            {
                if (dataTableProveedores.Rows.Count == 1)
                {
                    proveedor.ID = Convert.ToInt32(dataTableProveedores.Rows[0]["Id"]);
                    textBoxProveedor.Text = dataTableProveedores.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    Proveedor.Busqueda formBusquedaDeProveedores = new Proveedor.Busqueda(dataTableProveedores);
                    formBusquedaDeProveedores.ShowDialog();
                    if (formBusquedaDeProveedores.row > -1)
                    {
                        int rowIndex = formBusquedaDeProveedores.row;
                        proveedor.ID = Convert.ToInt32(dataTableProveedores.Rows[rowIndex]["Id"]);
                        textBoxProveedor.Text = dataTableProveedores.Rows[rowIndex]["Nombre"].ToString();
                    }
                }
            }
            else
            {
                Proveedor.Nuevo formularioNuevoProveedor = new Proveedor.Nuevo(2, proveedor.NIT);
                formularioNuevoProveedor.ShowDialog();
                proveedor = formularioNuevoProveedor.proveedor;
                if (proveedor.ID > 0)
                {
                    textBoxNit.Text = proveedor.NIT;
                    textBoxProveedor.Text = proveedor.NOMBRE;
                }
            }
        }
        private int validateCantidad(object formattedValue)
        {
            if (formattedValue != null)
            {
                if (ValidacionBss.esRealConTresDecimales(formattedValue.ToString()))
                {
                    if (Convert.ToDecimal(formattedValue) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
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
        private int validateMontoTotal(object formattedValue, int rowIndex)
        {
            if (formattedValue != null)
            {
                if (ValidacionBss.esRealConDosDecimales(formattedValue.ToString()))
                {
                    if (Convert.ToDecimal(formattedValue) > 0)
                    {
                        decimal cantidad = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Cantidad", rowIndex].Value);
                        decimal precioDeCompra = Convert.ToDecimal(formattedValue) / cantidad;
                        decimal precioDeVenta = Convert.ToDecimal(dataGridViewDetalleDeIngreso["Precio_De_Venta", rowIndex].Value);
                        if (precioDeCompra < precioDeVenta)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 2;
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
        private int validateNotaDeEntrega()
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
        private int validatePrecioDeCompra(object formattedValue)
        {
            if (formattedValue != null)
            {
                if (ValidacionBss.esRealConDosDecimales(formattedValue.ToString()))
                {
                    if (Convert.ToDecimal(formattedValue) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
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
        private int validatePrecioDeVenta(object FormattedValue)
        {
            if (FormattedValue != null)
            {
                if (ValidacionBss.esRealConDosDecimales(FormattedValue.ToString()))
                {
                    if (Convert.ToDecimal(FormattedValue) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
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
        private int validatePrecios(decimal precioDeCompra, decimal precioDeVenta)
        {
            if (precioDeCompra < precioDeVenta)
            {
                return 0;
            }
            else
            {
                return 802;
            }
        }
        private int validateProductos()
        {
            if (dataGridViewDetalleDeIngreso.Rows.Count > 0)
            {
                return 0;
            }
            else
            {
                return 801;
            }
        }
        private int validateProveedor()
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
                        return 800;
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
        private bool validate()
        {
            int errorCode = validateProductos();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxCodigoDeBarras, ValidacionBss.getErrorMessage(errorCode));
            int errorPosition = hasErrors.ToList().IndexOf(true);
            if (errorPosition == -1)
            {
                return true;
            }
            else
            {
                switch (errorPosition)
                {
                    case 0:
                        textBoxNit.Focus();
                        break;
                    case 1:
                        textBoxNumeroDeNotaDeEntrega.Focus();
                        break;
                    case 2:
                        textBoxCodigoDeBarras.Focus();
                        break;
                }
                return false;
            }
        }
        #endregion
    }
}