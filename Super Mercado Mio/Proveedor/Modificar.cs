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

namespace Super_Mercado_Mio.Proveedor
{
    public partial class Modificar : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[] { false, false, false, false, false };
        ProveedorBss objetoProveedor = new ProveedorBss();
        ProveedorEnt proveedor = new ProveedorEnt();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public Modificar(int idProveedor)
        {
            InitializeComponent();
            proveedor.ID = idProveedor;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            cargarInformacionDeProveedor();
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
            int errorCode = validarNit();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombre
        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNombre();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombre, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxPersonaDeContacto
        private void textBoxPersonaDeContacto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCadena(Clipboard.GetText()) == true)
                {
                    isWritable = true;
                }
                else
                {
                    e.Handled = true;
                    isWritable = false;
                }
            }
        }
        private void textBoxPersonaDeContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.diccionarioCadena.IndexOf(e.KeyChar) > -1)
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
                e.Handled = true;
            }
        }
        private void textBoxPersonaDeContacto_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPersonaDeContacto();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPersonaDeContacto, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxTelefono
        private void textBoxTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esTelefono(Clipboard.GetText()) == false)
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
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarTelefono();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxTelefono, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxCelular
        private void textBoxCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCelular(Clipboard.GetText()) == false)
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
        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxCelular_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarCelular();
            hasErrors[4] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxCelular, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                proveedor.NOMBRE = textBoxNombre.Text.Trim().ToUpper();
                proveedor.PERSONA_DE_CONTACTO = textBoxPersonaDeContacto.Text.Trim().ToUpper();
                proveedor.DIRECCION = textBoxDireccion.Text.Trim().ToUpper();
                proveedor.TELEFONO = textBoxTelefono.Text.Trim();
                proveedor.CELULAR = textBoxCelular.Text.Trim();
                proveedor.NUMERO_DE_CUENTA = textBoxNumeroDeCuenta.Text.Trim().ToUpper();
                objetoProveedor.update(proveedor);
                insertarRegistro("Proveedor", proveedor.ID, "Modificar");
                MessageBox.Show("Los datos fueron guardados correctamente.", "Operación Exitosa", MessageBoxButtons.OK,
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
        private bool authenticateName()
        {
            if (textBoxNit.Text.Trim() == "0")
            {
                proveedor.NOMBRE = textBoxNombre.Text.Trim().ToUpper();
                if (objetoProveedor.authenticateName(proveedor) == 0)
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
                return true;
            }
        }
        private void cargarInformacionDeProveedor()
        {
            DataTable dataTableProveedor = objetoProveedor.search(proveedor);
            textBoxNit.Text = dataTableProveedor.Rows[0]["Nit"].ToString();
            textBoxNombre.Text = dataTableProveedor.Rows[0]["Nombre"].ToString();
            textBoxPersonaDeContacto.Text = dataTableProveedor.Rows[0]["Persona_De_Contacto"].ToString();
            textBoxDireccion.Text = dataTableProveedor.Rows[0]["Direccion"].ToString();
            textBoxTelefono.Text = dataTableProveedor.Rows[0]["Telefono"].ToString();
            textBoxCelular.Text = dataTableProveedor.Rows[0]["Celular"].ToString();
            textBoxNumeroDeCuenta.Text = dataTableProveedor.Rows[0]["Numero_De_Cuenta"].ToString();
        }
        private bool verificarNit()
        {
            proveedor.NIT = textBoxNit.Text.Trim();
            if (proveedor.NIT != "0")
            {
                if (objetoProveedor.authenticateNit(proveedor) == 0)
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
                return true;
            }
        }
        private int validarNit()
        {
            if (textBoxNit.Text.Trim() != "")
            {
                if (ValidacionBss.esNit(textBoxNit.Text.Trim()) == true)
                {
                    if (verificarNit())
                    {
                        return 0;
                    }
                    else
                    {
                        return 400;
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
        private int validarNombre()
        {
            if (textBoxNombre.Text.Trim() != "")
            {
                if (authenticateName())
                {
                    return 0;
                }
                else
                {
                    return 401;
                }
            }
            else
            {
                return 1;
            }
        }
        private int validarPersonaDeContacto()
        {
            if (textBoxPersonaDeContacto.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxPersonaDeContacto.Text.Trim()) == true)
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
                return 0;
            }
        }
        private int validarTelefono()
        {
            if (textBoxTelefono.Text.Trim() != "")
            {
                if (ValidacionBss.esTelefono(textBoxTelefono.Text.Trim()) == true)
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
                return 0;
            }
        }
        private int validarCelular()
        {
            if (textBoxCelular.Text.Trim() != "")
            {
                if (ValidacionBss.esCelular(textBoxCelular.Text.Trim()) == true)
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
                return 0;
            }
        }
        private bool validaciones()
        {
            int errorCode = validarNit();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNit, ValidacionBss.getErrorMessage(errorCode));
            errorCode = validarNombre();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombre, ValidacionBss.getErrorMessage(errorCode));
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
                        textBoxNombre.Focus();
                        break;
                    case 2:
                        textBoxPersonaDeContacto.Focus();
                        break;
                    case 3:
                        textBoxTelefono.Focus();
                        break;
                    case 4:
                        textBoxCelular.Focus();
                        break;
                }
                return false;
            }
        }
        private void insertarRegistro(string tablaX, int idTablaX, string tipoX)
        {
            registro = new RegistroEnt();
            registro.USUARIO = SesionEnt.nombreDeUsuario;
            registro.EQUIPO = SesionEnt.nombreDeEquipo;
            registro.HORA = DateTime.Now.ToString("T");
            registro.TABLA = tablaX;
            registro.ID_TABLA = idTablaX;
            registro.TIPO = tipoX;
            objetoRegistro.insert(registro);
        }
        #endregion
    }
}