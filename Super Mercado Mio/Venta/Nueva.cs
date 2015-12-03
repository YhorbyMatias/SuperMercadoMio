using Bss;
using Ent;
using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio.Venta
{
    public partial class Nueva : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, false, true };
        AperturaDeCajaBss objetoAperturaDeCaja = new AperturaDeCajaBss();
        AperturaDeCajaEnt aperturaDeCaja = new AperturaDeCajaEnt();
        ProductoBss objetoProducto = new ProductoBss();
        ProductoEnt producto = new ProductoEnt();
        ClienteBss objetoCliente = new ClienteBss();
        ClienteEnt cliente = new ClienteEnt();
        EgresoBss objetoEgreso = new EgresoBss();
        EgresoEnt egreso = new EgresoEnt();
        DetalleDeEgresoBss objetoDetalleDeEgreso = new DetalleDeEgresoBss();
        DetalleDeEgresoEnt detalleDeEgreso = new DetalleDeEgresoEnt();
        DosificacionBss objetoDosificacion = new DosificacionBss();
        DosificacionEnt dosificacion = new DosificacionEnt();
        FacturaBss objetoFactura = new FacturaBss();
        FacturaEnt factura = new FacturaEnt();
        DetalleDeFacturaBss objetoDetalleDeFactura = new DetalleDeFacturaBss();
        DetalleDeFacturaEnt detalleDeFactura = new DetalleDeFacturaEnt();
        ImpresoraBss printer = new ImpresoraBss();
        #endregion
        #region Form
        public Nueva()
        {
            InitializeComponent();
        }
        private void Nueva_Load(object sender, EventArgs e)
        {
            formatDataGridViewDetalleDeVenta();
            aperturaDeCaja.ID_USUARIO = SesionEnt.idUsuario;
            aperturaDeCaja.ID_CAJA = SesionEnt.idCaja;
            if (objetoAperturaDeCaja.exists(aperturaDeCaja) > 0)
            {
                aperturaDeCaja.ID = objetoAperturaDeCaja.getId(aperturaDeCaja);
                if (!SesionEnt.activeDosificacion)
                {
                    checkBoxFacturaManual.Checked = true;
                    checkBoxFacturaManual.Enabled = false;
                }
                textBoxNumeroVenta.Text = (objetoEgreso.getNumber() + 1).ToString();
                textBoxFecha.Text = DateTime.Now.ToShortDateString();
                egreso.ID_CLIENTE = 1;
                cliente.CI_O_NIT = "0";
            }
            else
            {
                MessageBox.Show("No realizó la apertura de caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonGuardar.Enabled = false;
            }
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBoxCodigoDeBarras.Text.Trim() != "")
                {
                    searchProduct(textBoxCodigoDeBarras.Text.Trim());
                }
            }
        }
        #endregion
        #region buttonSearchProduct
        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            Producto.Busqueda formBusquedaDeProductos = new Producto.Busqueda(2);
            formBusquedaDeProductos.ShowDialog();
            if (formBusquedaDeProductos.product.ID > 0)
            {
                searchProduct(formBusquedaDeProductos.product.CODIGO_DE_BARRAS);
            }
            else
            {
                textBoxCodigoDeBarras.Focus();
            }
        }
        #endregion
        #region dataGridViewDetalleDeVenta
        private void dataGridViewDetalleDeVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                textBoxCodigoDeBarras.Focus();
            }
        }
        private void dataGridViewDetalleDeVenta_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int errorCode = reviewQuantity(e.FormattedValue);
                dataGridViewDetalleDeVenta.Rows[e.RowIndex].ErrorText = ValidacionBss.getErrorMessage(errorCode);
                if (errorCode > 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    dataGridViewDetalleDeVenta.Rows[e.RowIndex].ErrorText = null;
                    dataGridViewDetalleDeVenta.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dataGridViewDetalleDeVenta["Monto_Total", e.RowIndex].Value = calculateInvoiceLineTotalAmount(e.RowIndex);
                    textBoxMontoTotal.Text = calculateInvoiceTotalAmount().ToString();
                    textBoxCambio.Text = calculateChange().ToString();
                }
            }
        }
        private void dataGridViewDetalleDeVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBoxMontoTotal.Text = calculateInvoiceTotalAmount().ToString();
            textBoxCambio.Text = calculateChange().ToString();
            textBoxCodigoDeBarras.Focus();
        }
        #endregion
        #region textBoxCiONit
        private void textBoxCiONit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCiONit(Clipboard.GetText()) == false)
                {
                    e.Handled = true;
                    isWritable = false;
                }
                else
                {
                    isWritable = true;
                }
            }
            if (e.KeyValue == 13)
            {
                if (textBoxCiONit.Text.Trim() != "")
                {
                    searchClient(textBoxCiONit.Text.Trim());
                }
            }
        }
        private void textBoxCiONit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.isDigitOrControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                isWritable = true;
                e.Handled = true;
            }
        }
        private void textBoxCiONit_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewClient();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonSearchClient
        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            Cliente.Lista formListaDeClientes = new Cliente.Lista(3);
            formListaDeClientes.ShowDialog();
            if (formListaDeClientes.cliente.ID > 0)
            {
                egreso.ID_CLIENTE = formListaDeClientes.cliente.ID;
                cliente.CI_O_NIT = formListaDeClientes.cliente.CI_O_NIT;
                textBoxCiONit.Text = cliente.CI_O_NIT;
                textBoxCliente.Text = formListaDeClientes.cliente.NOMBRE;
            }
            textBoxMontoPagado.Focus();
        }
        #endregion
        #region textBoxMontoPagado
        private void textBoxMontoPagado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (ValidacionBss.esRealConDosDecimales(Clipboard.GetText()) == false)
                {
                    e.Handled = true;
                    isWritable = false;
                }
                else
                {
                    isWritable = true;
                }
            }
            if (e.KeyValue == 13)
            {
                textBoxCambio.Text = calculateChange().ToString();
                if (Convert.ToDecimal(textBoxCambio.Text) >= 0)
                {
                    textBoxCambio.ForeColor = Color.Black;
                    buttonGuardar.Focus();
                }
                else
                {
                    textBoxCambio.ForeColor = Color.Red;
                }
            }
        }
        private void textBoxMontoPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMontoPagado.Text.IndexOf(".") > -1)
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
        private void textBoxMontoPagado_Validating(object sender, CancelEventArgs e)
        {
            textBoxCambio.Text = calculateChange().ToString();
            int errorCode = reviewAmountPaid();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxMontoPagado, ValidacionBss.getErrorMessage(errorCode));
            if (errorCode == 902)
            {
                textBoxCambio.ForeColor = Color.Red;
            }
            else
            {
                textBoxCambio.ForeColor = Color.Black;
            }
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors())
            {
                egreso.ID_USUARIO = SesionEnt.idUsuario;
                egreso.ID_CAJA = SesionEnt.idCaja;
                egreso.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
                egreso.HORA = DateTime.Now.ToString("T");
                if (Convert.ToDecimal(textBoxMontoTotal.Text) < 5)
                {
                    egreso.TIPO = "VENTA MENOR";
                    egreso.FACTURADO = false;
                }
                else if (checkBoxFacturaManual.Checked)
                {
                    egreso.TIPO = "FACTURA MANUAL";
                    egreso.FACTURADO = true;
                }
                else
                {
                    egreso.TIPO = "FACTURA SISTEMA";
                    egreso.FACTURADO = true;
                }
                egreso.METODO_DE_PAGO = "CONTADO";
                egreso.MONTO = Convert.ToDecimal(textBoxMontoTotal.Text);
                egreso.MONTO_DE_CUPON = 0;
                egreso.MONTO_EXTRA = 0;
                egreso.MONTO_PAGADO = Convert.ToDecimal(textBoxMontoPagado.Text);
                egreso.CAMBIO = Convert.ToDecimal(textBoxCambio.Text);
                egreso.OBSERVACIONES = "";
                egreso.CERRADO = false;
                egreso.ESTADO = "VIGENTE";
                for (int rowIndex = 0; rowIndex < dataGridViewDetalleDeVenta.Rows.Count; rowIndex++)
                {
                    detalleDeEgreso = new DetalleDeEgresoEnt();
                    detalleDeEgreso.ID_PRODUCTO = Convert.ToInt32(dataGridViewDetalleDeVenta["Id_Producto", rowIndex].Value);
                    detalleDeEgreso.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value);
                    detalleDeEgreso.PRECIO_UNITARIO = Convert.ToDecimal(dataGridViewDetalleDeVenta["Precio_Unitario", rowIndex].Value);
                    detalleDeEgreso.MONTO_TOTAL = Convert.ToDecimal(dataGridViewDetalleDeVenta["Monto_Total", rowIndex].Value);
                    detalleDeEgreso.ESTADO = "VIGENTE";
                    objetoEgreso.invoiceLines.Add(detalleDeEgreso);
                }
                egreso.ID = objetoEgreso.add(egreso);
                if (egreso.ID == Convert.ToInt32(textBoxNumeroVenta.Text))
                {
                    MessageBox.Show("Los datos fueron guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos fueron guardados correctamente.\n \n" + "NÚMERO DE VENTA : " + egreso.ID.ToString(),
                        "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (egreso.TIPO == "FACTURA SISTEMA")
                {
                    dosificacion.ID_SUCURSAL = 1;
                    DataTable dataTableDosificacion = objetoDosificacion.select(dosificacion);
                    dosificacion.ID = Convert.ToInt32(dataTableDosificacion.Rows[0]["Id"]);
                    dosificacion.NUMERO_DE_AUTORIZACION = dataTableDosificacion.Rows[0]["Numero_De_Autorizacion"].ToString();
                    factura.LLAVE = @dataTableDosificacion.Rows[0]["Llave"].ToString();
                    factura.ID_USUARIO = SesionEnt.idUsuario;
                    factura.ID_CAJA = SesionEnt.idCaja;
                    factura.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
                    factura.ID_EGRESO = egreso.ID;
                    factura.ID_CLIENTE = egreso.ID_CLIENTE;
                    factura.ID_DOSIFICACION = dosificacion.ID;
                    factura.NUMERO_DE_AUTORIZACION = dosificacion.NUMERO_DE_AUTORIZACION;
                    factura.NUMERO_DE_AUTORIZACION_AUXILIAR = dosificacion.NUMERO_DE_AUTORIZACION;
                    factura.CI_O_NIT = textBoxCiONit.Text.Trim();
                    factura.CI_O_NIT_AUXILIAR = factura.CI_O_NIT;
                    factura.CLIENTE = textBoxCliente.Text.Trim().ToUpper();
                    factura.FECHA = DateTime.Today.ToShortDateString();
                    factura.FECHA_AUXILIAR = DateTime.Today.ToString("yyyyMMdd");
                    factura.HORA = DateTime.Now.ToLongTimeString();
                    factura.MONTO = egreso.MONTO;
                    factura.MONTO_AUXILIAR = decimal.Round(factura.MONTO, 0).ToString();
                    factura.MONTO_PAGADO = egreso.MONTO_PAGADO;
                    factura.CAMBIO = egreso.CAMBIO;
                    for (int rowIndex = 0; rowIndex < dataGridViewDetalleDeVenta.Rows.Count; rowIndex++)
                    {
                        detalleDeFactura = new DetalleDeFacturaEnt();
                        detalleDeFactura.ID_PRODUCTO = Convert.ToInt32(dataGridViewDetalleDeVenta["Id_Producto", rowIndex].Value);
                        detalleDeFactura.DETALLE = dataGridViewDetalleDeVenta["Alias", rowIndex].Value.ToString();
                        detalleDeFactura.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value);
                        detalleDeFactura.IMPORTE = Convert.ToDecimal(dataGridViewDetalleDeVenta["Monto_Total", rowIndex].Value);
                        objetoFactura.addDetalle(detalleDeFactura);
                    }
                    factura.ID = objetoFactura.add(factura);
                    factura.NUMERO = objetoFactura.getNumber(factura);
                    factura.NUMERO_AUXILIAR = factura.NUMERO.ToString();
                    factura.CODIGO_DE_CONTROL = objetoFactura.getControlCode(factura);
                    objetoFactura.updateControlCode(factura);
                    objetoEgreso.updateFacturadoById(egreso);
                    detalleDeFactura.ID_FACTURA = factura.ID;
                    if (SesionEnt.printerEnabled)
                    {
                        printInvoice(objetoFactura.getById(factura), objetoDetalleDeFactura.obtainById(detalleDeFactura));
                    }
                    else
                    {
                        MessageBox.Show("La impresora se halla deshabilidada. No se imprimió la factura.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                closeForm();
            }
        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private decimal calculateChange()
        {
            if (textBoxMontoPagado.Text.Trim() != "")
            {
                return (Convert.ToDecimal(textBoxMontoPagado.Text) - Convert.ToDecimal(textBoxMontoTotal.Text.Trim()));
            }
            else
            {
                return (0 - Convert.ToDecimal(textBoxMontoTotal.Text));
            }
        }
        private decimal calculateInvoiceLineTotalAmount(int rowIndex)
        {
            return (Convert.ToDecimal(dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value)
                * Convert.ToDecimal(dataGridViewDetalleDeVenta["Precio_Unitario", rowIndex].Value));
        }
        private decimal calculateInvoiceTotalAmount()
        {
            decimal totalAmount = 0;
            for (int filas = 0; filas < dataGridViewDetalleDeVenta.Rows.Count; filas++)
            {
                totalAmount = totalAmount + Convert.ToDecimal(dataGridViewDetalleDeVenta["Monto_Total", filas].Value);
            }
            return totalAmount;
        }
        private void closeForm()
        {
            Venta.Nueva formNuevaVenta = new Venta.Nueva();
            formNuevaVenta.MdiParent = this.MdiParent;
            this.Close();
            formNuevaVenta.Show();
        }
        private void formatDataGridViewDetalleDeVenta()
        {
            dataGridViewDetalleDeVenta.Columns["Alias"].Width = 280;
            dataGridViewDetalleDeVenta.Columns["Cantidad"].Width = 100;
            dataGridViewDetalleDeVenta.Columns["Precio_Unitario"].Width = 130;
            dataGridViewDetalleDeVenta.Columns["Monto_Total"].Width = 130;
        }
        private bool checkForErrors()
        {
            int errorCode = reviewLines();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCodigoDeBarras, ValidacionBss.getErrorMessage(errorCode));
            errorCode = reviewClient();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(errorCode));
            errorCode = reviewAmountPaid();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxMontoPagado, ValidacionBss.getErrorMessage(errorCode));
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
                        textBoxCodigoDeBarras.Focus();
                        break;
                    case 1:
                        textBoxCiONit.Focus();
                        break;
                    case 2:
                        textBoxMontoPagado.Focus();
                        break;
                }
                return false;
            }
        }
        private void printInvoice(DataTable invoice, DataTable invoiceLines)
        {
            Cursor.Current = Cursors.WaitCursor;
            SesionEnt.posPrinter.TransactionPrint(PrinterStation.Receipt, PrinterTransactionControl.Transaction);
            SesionEnt.posPrinter.RecLineChars = 40;
            SesionEnt.posPrinter.PrintNormal(PrinterStation.Receipt, printer.formatoDeImpresionDeFactura(invoice, invoiceLines,
                SesionEnt.posPrinter.RecLinesToPaperCut));
            SesionEnt.posPrinter.CutPaper(100);
            SesionEnt.posPrinter.TransactionPrint(PrinterStation.Receipt, PrinterTransactionControl.Normal);
        }
        private int reviewAmountPaid()
        {
            if (textBoxMontoPagado.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxMontoPagado.Text.Trim()))
                {
                    if (Convert.ToDecimal(textBoxMontoPagado.Text.Trim()) > 0)
                    {
                        if (Convert.ToDecimal(textBoxMontoTotal.Text) <= Convert.ToDecimal(textBoxMontoPagado.Text.Trim()))
                        {
                            return 0;
                        }
                        else
                        {
                            return 902;
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
        private int reviewClient()
        {
            if (textBoxCiONit.Text.Trim() != "")
            {
                if (ValidacionBss.esCiONit(textBoxCiONit.Text.Trim()))
                {
                    if (egreso.ID_CLIENTE > 0)
                    {
                        if (cliente.CI_O_NIT == textBoxCiONit.Text.Trim())
                        {
                            if (egreso.ID_CLIENTE == 1)
                            {
                                if (Convert.ToDecimal(textBoxMontoTotal.Text) >= 5)
                                {
                                    return 903;
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                            else
                            {
                                if (egreso.ID_CLIENTE == 20)
                                {
                                    if (Convert.ToDecimal(textBoxMontoTotal.Text) < 5)
                                    {
                                        return 904;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            return 901;
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
        private int reviewLines()
        {
            if (dataGridViewDetalleDeVenta.Rows.Count > 0)
            {
                return 0;
            }
            else
            {
                return 900;
            }
        }
        private int reviewQuantity(object formattedValue)
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
        private void searchClient(string ciONit)
        {
            cliente.CI_O_NIT = ciONit;
            DataTable dataTableCliente = objetoCliente.getByCiONit(cliente);
            if (dataTableCliente.Rows.Count > 0)
            {
                if (dataTableCliente.Rows.Count == 1)
                {
                    errorProvider.SetError(textBoxCiONit, null);
                    textBoxCliente.Text = dataTableCliente.Rows[0]["Nombre"].ToString();
                    egreso.ID_CLIENTE = Convert.ToInt32(dataTableCliente.Rows[0]["Id"]);
                    textBoxMontoPagado.Focus();
                }
                else
                {
                    Cliente.Busqueda formBusquedaDeClientes = new Cliente.Busqueda(dataTableCliente);
                    formBusquedaDeClientes.ShowDialog();
                    int row = formBusquedaDeClientes.row;
                    if (row > -1)
                    {
                        errorProvider.SetError(textBoxCiONit, null);
                        textBoxCliente.Text = dataTableCliente.Rows[row]["Nombre"].ToString();
                        egreso.ID_CLIENTE = Convert.ToInt32(dataTableCliente.Rows[row]["Id"]);
                        textBoxMontoPagado.Focus();
                    }
                    else
                    {
                        egreso.ID_CLIENTE = 0;
                        errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(1));
                    }
                }
            }
            else
            {
                Cliente.Nuevo formNuevoCliente = new Cliente.Nuevo(2, cliente.CI_O_NIT);
                formNuevoCliente.ShowDialog();
                if (formNuevoCliente.cliente.ID > 0)
                {
                    errorProvider.SetError(textBoxCiONit, null);
                    textBoxCliente.Text = formNuevoCliente.cliente.NOMBRE;
                    egreso.ID_CLIENTE = formNuevoCliente.cliente.ID;
                    textBoxMontoPagado.Focus();
                }
                else
                {
                    egreso.ID_CLIENTE = 0;
                    errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(1));
                }
            }
        }
        private void searchProduct(string codigoDeBarras)
        {
            bool exist = false;
            int rowIndex = 0;
            decimal quantity = 1;
            DataTable dataTableProducto = new DataTable();
            if (codigoDeBarras[0].Equals('b') || codigoDeBarras[0].Equals('B'))
            {
                producto.CODIGO_DE_BARRAS = codigoDeBarras.Substring(2, 5);
                quantity = Convert.ToDecimal(codigoDeBarras.Substring(7, 2) + "." + codigoDeBarras.Substring(9, 3));
            }
            else
            {
                producto.CODIGO_DE_BARRAS = codigoDeBarras;
            }
            dataTableProducto = objetoProducto.getByBarCode(producto);
            if (dataTableProducto.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewDetalleDeVenta.Rows.Count; i++)
                {
                    if (dataTableProducto.Rows[0]["Id"].ToString() == dataGridViewDetalleDeVenta["Id_Producto", i].Value.ToString())
                    {
                        rowIndex = i;
                        exist = true;
                        break;
                    }
                }
                if (exist == false)
                {
                    dataGridViewDetalleDeVenta.Rows.Add();
                    rowIndex = dataGridViewDetalleDeVenta.Rows.Count - 1;
                    dataGridViewDetalleDeVenta["Id_Producto", rowIndex].Value = dataTableProducto.Rows[0]["Id"].ToString();
                    dataGridViewDetalleDeVenta["Alias", rowIndex].Value = dataTableProducto.Rows[0]["Alias"].ToString();
                    dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value = quantity;
                    dataGridViewDetalleDeVenta["Precio_Unitario", rowIndex].Value = Convert.ToDecimal(dataTableProducto.Rows[0]["Precio_De_Venta"]);
                    dataGridViewDetalleDeVenta["Monto_Total", rowIndex].Value = calculateInvoiceLineTotalAmount(rowIndex).ToString("0.00");
                    if (dataTableProducto.Rows[0]["Tipo"].ToString() == "BALANZA")
                    {
                        dataGridViewDetalleDeVenta["Cantidad", rowIndex].ReadOnly = true;
                        dataGridViewDetalleDeVenta["Cantidad", rowIndex].Style.BackColor = Color.Silver;
                    }
                }
                else
                {
                    dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value = Convert.ToDecimal(dataGridViewDetalleDeVenta["Cantidad", rowIndex].Value)
                        + quantity;
                    dataGridViewDetalleDeVenta["Monto_Total", rowIndex].Value = calculateInvoiceLineTotalAmount(rowIndex).ToString("0.00");
                        
                }
                textBoxMontoTotal.Text = calculateInvoiceTotalAmount().ToString();
                textBoxCambio.Text = calculateChange().ToString();
                textBoxCodigoDeBarras.ResetText();
                textBoxCodigoDeBarras.Focus();
            }
            else
            {
                textBoxCodigoDeBarras.Focus();
            }
        }
        #endregion
    }
}