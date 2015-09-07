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

namespace Super_Mercado_Mio.Sucursal
{
    public partial class Modificar : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[4];
        EmpresaBss objetoEmpresa = new EmpresaBss();
        SucursalBss objetoSucursal = new SucursalBss();
        SucursalEnt sucursal = new SucursalEnt();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public Modificar()
        {
            InitializeComponent();
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            if (objetoSucursal.exists() == 1)
            {
                cargarInformacionDeSucursal();
            }
            else
            {
                MessageBox.Show("La sucursal no fue registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonGuardar.Enabled = false;
            }
        }
        #endregion
        #region textBoxNumero
        private void textBoxNumero_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNumero();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNumero, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxDireccion
        private void textBoxDireccion_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarDireccion();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxDireccion, ValidacionBss.getErrorMessage(errorCode));
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
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxTelefono, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxMunicipio
        private void textBoxMunicipio_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarMunicipio();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxMunicipio, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                sucursal.ID_SUCURSAL = 1;
                sucursal.NUMERO = textBoxNumero.Text.Trim();
                sucursal.DIRECCION = textBoxDireccion.Text.Trim().ToUpper();
                sucursal.TELEFONO = textBoxTelefono.Text.Trim();
                sucursal.MUNICIPIO = textBoxMunicipio.Text.Trim().ToUpper();
                objetoSucursal.update(sucursal);
                insertarRegistro("Sucursal", sucursal.ID_SUCURSAL, "Modificar");
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
        #region Metodos Propios
        private void cargarInformacionDeSucursal()
        {
            DataTable dataTableSucursal = objetoSucursal.search();
            textBoxEmpresa.Text = dataTableSucursal.Rows[0]["Razon_Social"].ToString();
            textBoxNit.Text = dataTableSucursal.Rows[0]["Nit"].ToString();
            textBoxNumero.Text = dataTableSucursal.Rows[0]["Numero"].ToString();
            textBoxDireccion.Text = dataTableSucursal.Rows[0]["Direccion"].ToString();
            textBoxTelefono.Text = dataTableSucursal.Rows[0]["Telefono"].ToString();
            textBoxMunicipio.Text = dataTableSucursal.Rows[0]["Municipio"].ToString();
        }
        private int validarNumero()
        {
            if (textBoxNumero.Text.Trim() != "")
            {
                if (ValidacionBss.esEntero(textBoxNumero.Text.Trim()) == true)
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
        private int validarDireccion()
        {
            if (textBoxDireccion.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
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
                return 1;
            }
        }
        private int validarMunicipio()
        {
            if (textBoxMunicipio.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private bool validaciones()
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
                        textBoxNumero.Focus();
                        break;
                    case 1:
                        textBoxDireccion.Focus();
                        break;
                    case 2:
                        textBoxTelefono.Focus();
                        break;
                    case 3:
                        textBoxMunicipio.Focus();
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