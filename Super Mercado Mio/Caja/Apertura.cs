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

namespace Super_Mercado_Mio.Caja
{
    public partial class Apertura : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true };
        CajaBss objetoCaja = new CajaBss();
        CajaEnt caja = new CajaEnt();
        AperturaDeCajaBss objetoAperturaDeCaja = new AperturaDeCajaBss();
        AperturaDeCajaEnt aperturaDeCaja = new AperturaDeCajaEnt();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Form
        public Apertura()
        {
            InitializeComponent();
        }
        private void Apertura_Load(object sender, EventArgs e)
        {
            caja.NOMBRE_DE_EQUIPO = System.Environment.MachineName;
            textBoxNumeroDeCaja.Text = objetoCaja.getNumber(caja).ToString();
            textBoxUsuario.Text = SesionEnt.nombreDeUsuario;
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
            textBoxHora.Text = DateTime.Now.ToString("T");
            timerHora.Start();
        }
        #endregion
        #region timerHora
        private void timerHora_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToString("T");
        }
        #endregion
        #region textBoxMonto
        private void textBoxMonto_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMonto.Text.IndexOf(".") > -1)
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
        private void textBoxMonto_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewAmount();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxMonto, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors())
            {
                aperturaDeCaja.ID_USUARIO = SesionEnt.idUsuario;
                aperturaDeCaja.ID_CAJA = SesionEnt.idCaja;
                aperturaDeCaja.HORA = DateTime.Now.ToString("T");
                aperturaDeCaja.MONTO = Convert.ToDecimal(textBoxMonto.Text.Trim());
                aperturaDeCaja.ID = objetoAperturaDeCaja.add(aperturaDeCaja);
                addRecord("Apertura_De_Caja", aperturaDeCaja.ID, "Nuevo");
                MessageBox.Show("Los datos fueron guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            timerHora.Stop();
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
        private bool checkForErrors()
        {
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
                        textBoxMonto.Focus();
                        break;
                }
                return false;
            }
        }
        private int reviewAmount()
        {
            if (textBoxMonto.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxMonto.Text.Trim()) == true)
                {
                    if (Convert.ToDecimal(textBoxMonto.Text) >= 0)
                    {
                        return 0;
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