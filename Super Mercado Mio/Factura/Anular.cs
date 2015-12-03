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

namespace Super_Mercado_Mio.Factura
{
    public partial class Anular : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true };
        AperturaDeCajaBss objetoAperturaDeCaja = new AperturaDeCajaBss();
        AperturaDeCajaEnt aperturaDeCaja = new AperturaDeCajaEnt();
        FacturaBss objetoFactura = new FacturaBss();
        FacturaEnt factura = new FacturaEnt();
        EgresoBss objetoEgreso = new EgresoBss();
        EgresoEnt egreso = new EgresoEnt();
        DetalleDeEgresoBss objetoDetalleDeEgreso = new DetalleDeEgresoBss();
        DetalleDeEgresoEnt detalleDeEgreso = new DetalleDeEgresoEnt();
        #endregion
        #region Form
        public Anular()
        {
            InitializeComponent();
        }
        private void Anular_Load(object sender, EventArgs e)
        {
            aperturaDeCaja.ID_USUARIO = SesionEnt.idUsuario;
            aperturaDeCaja.ID_CAJA = SesionEnt.idCaja;
            if (objetoAperturaDeCaja.exists(aperturaDeCaja) > 0)
            {
                aperturaDeCaja.ID = objetoAperturaDeCaja.getId(aperturaDeCaja);
            }
            else
            {
                MessageBox.Show("No realizó la apertura de caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonAnular.Enabled = false;
            }
        }
        #endregion
        #region textBoxSearchCodigoDeControl
        private void textBoxSearchCodigoDeControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.isControlCode(Clipboard.GetText()) == false)
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
        private void textBoxSearchCodigoDeControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.controlCodeDictionary.IndexOf(e.KeyChar) > -1)
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
                if (e.KeyChar != 8 && e.KeyChar != 13)
                {
                    int longitud = textBoxCodigoDeControl.TextLength + 1;
                    if ((longitud % 3) == 0)
                    {
                        textBoxCodigoDeControl.Text = textBoxCodigoDeControl.Text + "-";
                        textBoxCodigoDeControl.Select(textBoxCodigoDeControl.TextLength, 0);
                    }
                }
            }
            else
            {
                isWritable = true;
                e.Handled = true;
            }
        }
        private void textBoxSearchCodigoDeControl_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion
        #region buttonSearchFactura
        private void buttonSearchFactura_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region buttonAnular
        private void buttonAnular_Click(object sender, EventArgs e)
        {
            if (checkForErrors())
            {
                objetoFactura.cancel(factura);
                if (!checkBoxRefacturar.Checked)
                {
                    objetoEgreso.cancel(egreso);
                    detalleDeEgreso.ID_EGRESO = egreso.ID;
                    objetoDetalleDeEgreso.cancel(detalleDeEgreso);
                    if (objetoEgreso.isClosed(egreso))
                    {
                        DevolucionBss objetoDevolucion = new DevolucionBss();
                        DevolucionEnt devolucion = new DevolucionEnt();
                        devolucion.ID_USUARIO = SesionEnt.idUsuario;
                        devolucion.ID_CAJA = SesionEnt.idCaja;
                        devolucion.ID_APERTURA_DE_CAJA = aperturaDeCaja.ID;
                        devolucion.ID_EGRESO = egreso.ID;
                        devolucion.HORA = DateTime.Now.ToString("T");
                        devolucion.MONTO = 0 - egreso.MONTO;
                        objetoDevolucion.add(devolucion);
                    }
                }
                else
                {
                    Venta.Modificar formModificarVenta = new Venta.Modificar(egreso.ID);
                    formModificarVenta.MdiParent = this.MdiParent;
                    this.Close();
                    formModificarVenta.Show();
                }
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
        private bool checkForErrors()
        {
            if (factura.ID > 0)
            {
                if (textBoxCodigoDeControl.Text.Trim().ToUpper() == textBoxSearchCodigoDeControl.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private int checkControlCode()
        {
            if (ValidacionBss.isControlCode(textBoxCodigoDeControl.Text.Trim()))
            {
                if (factura.ID > 0)
                {
                    if (textBoxCodigoDeControl.Text.Trim().ToUpper() == textBoxSearchCodigoDeControl.Text)
                    {
                        return 0;
                    }
                    else
                    {
                        return 90;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }
        }
        #endregion
    }
}