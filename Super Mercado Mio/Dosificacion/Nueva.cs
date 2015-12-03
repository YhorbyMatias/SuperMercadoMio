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

namespace Super_Mercado_Mio.Dosificacion
{
    public partial class Nueva : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, true, true, true };
        SucursalBss objetoSucursal = new SucursalBss();
        SucursalEnt sucursal = new SucursalEnt();
        DosificacionBss objetoDosificacion = new DosificacionBss();
        DosificacionEnt dosificacion = new DosificacionEnt();
        #endregion
        #region Form
        public Nueva()
        {
            InitializeComponent();
        }
        private void Nueva_Load(object sender, EventArgs e)
        {
            loadSucursalInfo();
            dateTimePickerFechaLimiteDeEmision.Value = DateTime.Today.AddDays(180);
            textBoxEstado.Text = getEstado();
        }
        #endregion
        #region textBoxNumeroDeAutorizacion
        private void textBoxNumeroDeAutorizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esEntero(Clipboard.GetText()) == false)
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
        private void textBoxNumeroDeAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxNumeroDeAutorizacion_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewAuthorizationNumber();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNumeroDeAutorizacion, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxLlave
        private void textBoxLlave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esLlaveDeDosificacion(Clipboard.GetText()) == false)
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
        private void textBoxLlave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.diccionarioLlave.IndexOf(e.KeyChar) > -1)
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
        private void textBoxLlave_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewKey();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxLlave, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region dateTimePickerFechaLimiteDeEmision
        private void dateTimePickerFechaLimiteDeEmision_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewEmissionDeadline();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(dateTimePickerFechaLimiteDeEmision, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxLlave
        private void textBoxLeyenda_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewLegend();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxLeyenda, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors() == true)
            {
                dosificacion.ID_SUCURSAL = 1;
                dosificacion.NUMERO_DE_AUTORIZACION = textBoxNumeroDeAutorizacion.Text.Trim().ToUpper();
                dosificacion.LLAVE = @textBoxLlave.Text.Trim();
                dosificacion.FECHA_LIMITE_DE_EMISION = dateTimePickerFechaLimiteDeEmision.Value.ToShortDateString();
                dosificacion.LEYENDA = textBoxLeyenda.Text.Trim().ToUpper();
                dosificacion.ESTADO = textBoxEstado.Text;
                dosificacion.ID = objetoDosificacion.add(dosificacion);
                MessageBox.Show("Los datos fueron guardados correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #region Methods
        private bool authenticateAuthorizationNumber()
        {
            dosificacion.NUMERO_DE_AUTORIZACION = textBoxNumeroDeAutorizacion.Text.Trim();
            if (objetoDosificacion.authenticate(dosificacion) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                        textBoxNumeroDeAutorizacion.Focus();
                        break;
                    case 1:
                        textBoxLlave.Focus();
                        break;
                    case 2:
                        dateTimePickerFechaLimiteDeEmision.Focus();
                        break;
                    case 3:
                        textBoxLeyenda.Focus();
                        break;
                }
                return false;
            }
        }
        private void loadSucursalInfo()
        {
            sucursal.ID = 1;
            textBoxNumeroDeSucursal.Text = objetoSucursal.getNumber(sucursal);
        }
        private string getEstado()
        {
            dosificacion.ID_SUCURSAL = 1;
            dosificacion.ESTADO = "ACTIVA";
            if (objetoDosificacion.exists(dosificacion) == 1)
            {
                return "PENDIENTE";
            }
            else
            {
                return "ACTIVA";
            }
        }
        private int reviewAuthorizationNumber()
        {
            if (textBoxNumeroDeAutorizacion.Text.Trim() != "")
            {
                if (ValidacionBss.esEntero(textBoxNumeroDeAutorizacion.Text.Trim()))
                {
                    if (authenticateAuthorizationNumber())
                    {
                        return 0;
                    }
                    else
                    {
                        return 200;
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
        private int reviewEmissionDeadline()
        {
            if (DateTime.Compare(DateTime.Today, dateTimePickerFechaLimiteDeEmision.Value) < 0)
            {
                if (dateTimePickerFechaLimiteDeEmision.Value.ToShortDateString() != DateTime.Today.ToShortDateString())
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
        private int reviewKey()
        {
            if (textBoxLlave.Text.Trim() != "")
            {
                if (ValidacionBss.esLlaveDeDosificacion(textBoxLlave.Text.Trim()) == true)
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
                return 1;
            }
        }
        private int reviewLegend()
        {
            if (textBoxLeyenda.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        #endregion
    }
}