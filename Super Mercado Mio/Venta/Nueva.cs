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

namespace Super_Mercado_Mio.Venta
{
    public partial class Nueva : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, true, true };
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
                if (!SesionEnt.activeDosificacion)
                {
                    checkBoxSinFactura.Checked = true;
                    checkBoxSinFactura.Enabled = false;
                }
                textBoxNumeroVenta.Text = (objetoEgreso.getNumber() + 1).ToString();
                textBoxFecha.Text = DateTime.Now.ToShortDateString();
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
                //Buscar cliente
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
                    buttonGuardar.Focus();
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
            int errorCode = reviewAmountPaid();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxMontoPagado, ValidacionBss.getErrorMessage(errorCode));
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
        private decimal calculateTotalPrice(int rowIndex)
        {
            return (Convert.ToDecimal(dataGridViewProductos["Cantidad", rowIndex].Value)
                * Convert.ToDecimal(dataGridViewProductos["Precio_Unitario", rowIndex].Value));
        }
        private decimal calculateTotalAmount()
        {
            decimal totalAmount = 0;
            for (int filas = 0; filas < dataGridViewProductos.Rows.Count; filas++)
            {
                totalAmount = totalAmount + Convert.ToDecimal(dataGridViewProductos["Precio_Total", filas].Value);
            }
            return totalAmount;
        }
        private void formatDataGridViewDetalleDeVenta()
        {
            dataGridViewProductos.Columns["Alias"].Width = 280;
            dataGridViewProductos.Columns["Cantidad"].Width = 100;
            dataGridViewProductos.Columns["Precio_Unitario"].Width = 130;
            dataGridViewProductos.Columns["Precio_Total"].Width = 130;
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
                    if (cliente.CI_O_NIT == textBoxCiONit.Text.Trim())
                    {
                        return 0;
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
                return 1;
            }
        }
        private void searchClient()
        {
            cliente.TIPO = "NORMAL";
            DataTable Datos = objetocliente.BuscarClienteBss(cliente);
            if (Datos.Rows.Count > 0)
            {
                lblErrorCIoNIT.Visible = false;
                textBoxCliente.Text = Datos.Rows[0]["Nombre_Completo"].ToString();
                egreso.ID_CLIENTE = Convert.ToInt32(Datos.Rows[0]["Id_Cliente"]);
                textBoxCodigoDeBarras.Focus();
            }
            else
            {
                Cliente.Nuevo FormularioNuevoCliente = new Cliente.Nuevo(2, cliente.CI_O_NIT);
                FormularioNuevoCliente.ShowDialog();
                if (FormularioNuevoCliente.registrado == 1)
                {
                    Datos = objetocliente.BuscarClienteBss(cliente);
                    lblErrorCIoNIT.Visible = false;
                    textBoxCliente.Text = Datos.Rows[0]["Nombre_Completo"].ToString();
                    egreso.ID_CLIENTE = Convert.ToInt32(Datos.Rows[0]["Id_Cliente"]);
                    textBoxCodigoDeBarras.Focus();
                }
                else
                {
                    lblErrorCIoNIT.Visible = true;
                    textBoxCIoNIT.Focus();
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
                for (int i = 0; i < dataGridViewProductos.Rows.Count; i++)
                {
                    if (dataTableProducto.Rows[0]["Id"].ToString() == dataGridViewProductos["Id", i].Value.ToString())
                    {
                        rowIndex = i;
                        exist = true;
                        break;
                    }
                }
                if (exist == false)
                {
                    dataGridViewProductos.Rows.Add();
                    rowIndex = dataGridViewProductos.Rows.Count - 1;
                    dataGridViewProductos["Id", rowIndex].Value = dataTableProducto.Rows[0]["Id"].ToString();
                    dataGridViewProductos["Alias", rowIndex].Value = dataTableProducto.Rows[0]["Alias"].ToString();
                    dataGridViewProductos["Cantidad", rowIndex].Value = quantity;
                    dataGridViewProductos["Precio_Unitario", rowIndex].Value = Convert.ToDecimal(dataTableProducto.Rows[0]["Precio_De_Venta"]);
                    dataGridViewProductos["Precio_Total", rowIndex].Value = calculateTotalPrice(rowIndex).ToString("0.00");
                    if (dataTableProducto.Rows[0]["Tipo"].ToString() == "BALANZA")
                    {
                        dataGridViewProductos["Cantidad", rowIndex].ReadOnly = true;
                        dataGridViewProductos["Cantidad", rowIndex].Style.BackColor = Color.Silver;
                    }
                }
                else
                {
                    dataGridViewProductos["Cantidad", rowIndex].Value = Convert.ToDecimal(dataGridViewProductos["Cantidad", rowIndex].Value)
                        + quantity;
                    dataGridViewProductos["Precio_Total", rowIndex].Value = calculateTotalPrice(rowIndex).ToString("0.00");
                        
                }
                textBoxMontoTotal.Text = calculateTotalAmount().ToString();
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