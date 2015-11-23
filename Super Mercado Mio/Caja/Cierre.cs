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

namespace Super_Mercado_Mio.Caja
{
    public partial class Cierre : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, true };
        AperturaDeCajaBss objetoAperturaDeCaja = new AperturaDeCajaBss();
        AperturaDeCajaEnt aperturaDeCaja = new AperturaDeCajaEnt();
        CajaBss objetoCaja = new CajaBss();
        CajaEnt caja = new CajaEnt();
        EgresoBss objetoEgreso = new EgresoBss();
        EgresoEnt egreso = new EgresoEnt();
        DetalleDeEgresoBss objetoDetalleDeEgreso = new DetalleDeEgresoBss();
        DosificacionBss objetoDosificacion = new DosificacionBss();
        DosificacionEnt dosificacion = new DosificacionEnt();
        FacturaBss objetoFactura = new FacturaBss();
        FacturaEnt factura = new FacturaEnt();
        DetalleDeFacturaBss objetoDetalleDeFactura = new DetalleDeFacturaBss();
        DetalleDeFacturaEnt detalleDeFactura = new DetalleDeFacturaEnt();
        DevolucionBss objetoDevolucion = new DevolucionBss();
        DevolucionEnt devolucion = new DevolucionEnt();
        CierreDeCajaBss objetoCierreDeCaja = new CierreDeCajaBss();
        CierreDeCajaEnt cierreDeCaja = new CierreDeCajaEnt();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        ImpresoraBss printer = new ImpresoraBss();
        #endregion
        #region Form
        public Cierre()
        {
            InitializeComponent();
        }
        private void Cierre_Load(object sender, EventArgs e)
        {
            aperturaDeCaja.ID_USUARIO = SesionEnt.idUsuario;
            aperturaDeCaja.ID_CAJA = SesionEnt.idCaja;
            if (objetoAperturaDeCaja.exists(aperturaDeCaja) > 0)
            {
                if (MessageBox.Show("Se cerrarán las ventanas Nueva Venta, Modificar Venta, Anular Factura. ¿Desea continuar? ",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(Venta.Nueva))
                        {
                            form.Close();
                        }
                    }
                    egreso.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
                    if (objetoEgreso.existsMinorSales(egreso) == 0)
                    {
                        loadFormData();
                        timerHora.Start();
                    }
                    else
                    {
                        if (MessageBox.Show("Existen ventas menores, ¿Desea imprimir la factura?", "Ventas Menores", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            DataTable dataTableEgresos = objetoEgreso.getMinorSales(egreso);
                            DataTable dataTableDetalleDeEgresos = objetoDetalleDeEgreso.getMinorSalesDetail(egreso);
                            DataTable dataTableDosificacion = objetoDosificacion.select(dosificacion);
                            dosificacion.ID = Convert.ToInt32(dataTableDosificacion.Rows[0]["Id"]);
                            dosificacion.NUMERO_DE_AUTORIZACION = dataTableDosificacion.Rows[0]["Numero_De_Autorizacion"].ToString();
                            factura.LLAVE = @dataTableDosificacion.Rows[0]["Llave"].ToString();
                            factura.ID_USUARIO = egreso.ID_USUARIO;
                            factura.ID_CAJA = egreso.ID_CAJA;
                            factura.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
                            factura.ID_EGRESO = 0;
                            factura.ID_CLIENTE = 1;
                            factura.ID_DOSIFICACION = dosificacion.ID;
                            factura.NUMERO_DE_AUTORIZACION = dosificacion.NUMERO_DE_AUTORIZACION;
                            factura.NUMERO_DE_AUTORIZACION_AUXILIAR = dosificacion.NUMERO_DE_AUTORIZACION;
                            factura.CI_O_NIT = "0";
                            factura.CI_O_NIT_AUXILIAR = factura.CI_O_NIT;
                            factura.CLIENTE = "VENTAS MENORES DEL DIA";
                            factura.FECHA = DateTime.Today.ToShortDateString();
                            factura.FECHA_AUXILIAR = DateTime.Today.ToString("yyyyMMdd");
                            factura.HORA = DateTime.Now.ToLongTimeString();
                            factura.MONTO = Convert.ToDecimal(dataTableEgresos.Rows[0]["Monto"]);
                            factura.MONTO_AUXILIAR = decimal.Round(factura.MONTO, 0).ToString();
                            factura.MONTO_PAGADO = Convert.ToDecimal(dataTableEgresos.Rows[0]["Monto_Pagado"]);
                            factura.CAMBIO = Convert.ToDecimal(dataTableEgresos.Rows[0]["Cambio"]); ;
                            for (int filas = 0; filas < dataTableDetalleDeEgresos.Rows.Count; filas++)
                            {
                                detalleDeFactura = new DetalleDeFacturaEnt();
                                detalleDeFactura.ID_PRODUCTO = Convert.ToInt32(dataTableDetalleDeEgresos.Rows[filas]["Id"]);
                                detalleDeFactura.DETALLE = dataTableDetalleDeEgresos.Rows[filas]["Alias"].ToString();
                                detalleDeFactura.CANTIDAD = Convert.ToDecimal(dataTableDetalleDeEgresos.Rows[filas]["Cantidad"]);
                                detalleDeFactura.IMPORTE = Convert.ToDecimal(dataTableDetalleDeEgresos.Rows[filas]["Precio_Total"]);
                                objetoFactura.addDetalle(detalleDeFactura);
                            }
                            factura.ID = objetoFactura.add(factura);
                            factura.NUMERO = objetoFactura.getNumber(factura);
                            factura.NUMERO_AUXILIAR = factura.NUMERO.ToString();
                            factura.CODIGO_DE_CONTROL = objetoFactura.getControlCode(factura);
                            objetoFactura.updateControlCode(factura);
                            objetoEgreso.updateFacturado(egreso);
                            detalleDeFactura.ID_FACTURA = factura.ID;
                            if (SesionEnt.printerEnabled)
                            {
                                printInvoice(objetoFactura.obtainById(factura), objetoDetalleDeFactura.obtainById(detalleDeFactura));
                            }
                            else
                            {
                                MessageBox.Show("La impresora se halla deshabilidada. No se imprimió la factura.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            loadFormData();
                            timerHora.Start();
                        }
                        else
                        {
                            buttonGuardar.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No realizó la apertura de caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonGuardar.Enabled = false;
            }
        }
        #endregion
        #region timerHora
        private void timerHora_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToString("T");
        }
        #endregion
        #region textBoxMontoDeVentaDeTarjetas
        private void textBoxMontoDeVentaDeTarjetas_KeyDown(object sender, KeyEventArgs e)
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
        }
        private void textBoxMontoDeVentaDeTarjetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMontoDeVentaDeTarjetas.Text.IndexOf(".") > -1)
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
        private void textBoxMontoDeVentaDeTarjetas_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewMontoDeVentaDeTarjetas();
            errorProvider.SetError(textBoxMontoDeVentaDeTarjetas, ValidacionBss.getErrorMessage(errorCode));
            if (errorCode > 0)
            {
                e.Cancel = true;
                if (errorCode == 301)
                {
                    textBoxMontoTotal.ForeColor = Color.Red;
                    textBoxMontoTotal.Text = calculateTotalAmount().ToString();
                }
            }
            else
            {
                textBoxMontoTotal.ForeColor = Color.Black;
                textBoxMontoTotal.Text = calculateTotalAmount().ToString();
            }
        }
        #endregion
        #region textBoxMontoDePagos
        private void textBoxMontoDePagos_KeyDown(object sender, KeyEventArgs e)
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
        }
        private void textBoxMontoDePagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMontoDePagos.Text.IndexOf(".") > -1)
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
        private void textBoxMontoDePagos_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewMontoDePagos();
            errorProvider.SetError(textBoxMontoDePagos, ValidacionBss.getErrorMessage(errorCode));
            if (errorCode > 0)
            {
                e.Cancel = true;
                if (errorCode == 301)
                {
                    textBoxMontoTotal.ForeColor = Color.Red;
                    textBoxMontoTotal.Text = calculateTotalAmount().ToString();
                }
            }
            else
            {
                textBoxMontoTotal.ForeColor = Color.Black;
                textBoxMontoTotal.Text = calculateTotalAmount().ToString();
            }
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            cierreDeCaja.ID_USUARIO = SesionEnt.idUsuario;
            cierreDeCaja.ID_CAJA = SesionEnt.idCaja;
            cierreDeCaja.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
            cierreDeCaja.HORA = DateTime.Now.ToString("T");
            cierreDeCaja.MONTO_DE_APERTURA_DE_CAJA = Convert.ToDecimal(textBoxMontoDeAperturaDeCaja.Text);
            cierreDeCaja.MONTO_DE_VENTAS = Convert.ToDecimal(textBoxMontoDeVentas.Text);
            cierreDeCaja.MONTO_DE_DEVOLUCIONES = Convert.ToDecimal(textBoxMontoDeDevoluciones.Text);
            cierreDeCaja.MONTO_DE_VENTA_DE_TARJETAS = Convert.ToDecimal(textBoxMontoDeVentaDeTarjetas.Text);
            cierreDeCaja.MONTO_DE_PAGOS = Convert.ToDecimal(textBoxMontoDePagos.Text);
            cierreDeCaja.MONTO_TOTAL = Convert.ToDecimal(textBoxMontoTotal.Text);
            cierreDeCaja.ID = objetoCierreDeCaja.add(cierreDeCaja);
            addRecord("Cierre_De_Caja", cierreDeCaja.ID, "Nuevo");
            devolucion.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
            objetoDevolucion.close(devolucion);
            egreso.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
            objetoEgreso.close(egreso);
            objetoAperturaDeCaja.close(aperturaDeCaja);
            MessageBox.Show("Los datos fueron guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void addRecord(string tabla, int idTabla, string tipo)
        {
            registro = new RegistroEnt();
            registro.USUARIO = SesionEnt.nombreDeUsuario;
            registro.EQUIPO = SesionEnt.nombreDeEquipo;
            registro.HORA = DateTime.Now.ToString("T");
            registro.TABLA = tabla;
            registro.ID_TABLA = idTabla;
            registro.TIPO = tipo;
            objetoRegistro.insert(registro);
        }
        private decimal calculateTotalAmount()
        {
            return Convert.ToDecimal(textBoxMontoDeAperturaDeCaja.Text) + Convert.ToDecimal(textBoxMontoDeVentas.Text)
                + Convert.ToDecimal(textBoxMontoDeDevoluciones.Text) + Convert.ToDecimal(textBoxMontoDeVentaDeTarjetas.Text)
                - Convert.ToDecimal(textBoxMontoDePagos.Text);
        }
        private void loadFormData()
        {
            caja.NOMBRE_DE_EQUIPO = System.Environment.MachineName;
            textBoxNumeroDeCaja.Text = objetoCaja.getNumber(caja).ToString();
            textBoxUsuario.Text = SesionEnt.nombreDeUsuario;
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
            textBoxHora.Text = DateTime.Now.ToString("T");
            DataTable dataTableAperturaDeCaja = objetoAperturaDeCaja.get(aperturaDeCaja);
            aperturaDeCaja.ID = Convert.ToInt32(dataTableAperturaDeCaja.Rows[0]["Id"]);
            textBoxMontoDeAperturaDeCaja.Text = Convert.ToDecimal(dataTableAperturaDeCaja.Rows[0]["Monto"]).ToString();
            egreso.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
            textBoxMontoDeVentas.Text = objetoEgreso.getSalesTotalAmount(egreso).ToString();
            devolucion.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
            textBoxMontoDeDevoluciones.Text = objetoDevolucion.getRefundsTotalAmount(devolucion).ToString();
            if (Convert.ToDecimal(textBoxMontoDeDevoluciones.Text) < 0)
            {
                textBoxMontoDeDevoluciones.ForeColor = Color.Red;
            }
            textBoxMontoTotal.Text = (calculateTotalAmount()).ToString();

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
        private int reviewMontoDePagos()
        {
            if (textBoxMontoDePagos.Text != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxMontoDePagos.Text))
                {
                    if (Convert.ToDecimal(textBoxMontoDePagos.Text) >= 0)
                    {
                        if (calculateTotalAmount() >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 301;
                        }
                    }
                    else
                    {
                        return 4;
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
        private int reviewMontoDeVentaDeTarjetas()
        {
            if (textBoxMontoDeVentaDeTarjetas.Text != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxMontoDeVentaDeTarjetas.Text))
                {
                    if (Convert.ToDecimal(textBoxMontoDeVentaDeTarjetas.Text) >= 0)
                    {
                        if (calculateTotalAmount() >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 301;
                        }
                    }
                    else
                    {
                        return 4;
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