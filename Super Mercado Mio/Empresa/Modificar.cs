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

namespace Super_Mercado_Mio.Empresa
{
    public partial class Modificar : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[4];
        EmpresaBss objetoEmpresa = new EmpresaBss();
        EmpresaEnt empresa = new EmpresaEnt();
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
            if (objetoEmpresa.exists() == 1)
            {
                cargarInformacionDeEmpresa();
            }
            else
            {
                MessageBox.Show("La empresa no fue registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonGuardar.Enabled = false;
            }
        }
        #endregion
        #region textBoxPropietario
        private void textBoxPropietario_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPropietario();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPropietario, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxRazonSocial
        private void textBoxRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarRazonSocial();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxRazonSocial, ValidacionBss.getErrorMessage(errorCode));
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
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxActividadEconomica
        private void textBoxActividadEconomica_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxActividadEconomica_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxActividadEconomica_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarActividadEconomica();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxActividadEconomica, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones() == true)
            {
                empresa.ID_EMPRESA = 1;
                empresa.PROPIETARIO = textBoxPropietario.Text.Trim().ToUpper();
                empresa.RAZON_SOCIAL = textBoxRazonSocial.Text.Trim().ToUpper();
                empresa.NIT = textBoxNit.Text.Trim();
                empresa.ACTIVIDAD_ECONOMICA = textBoxActividadEconomica.Text.Trim().ToUpper();
                objetoEmpresa.update(empresa);
                insertarRegistro("Empresa", empresa.ID_EMPRESA, "Modificar");
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
        private void cargarInformacionDeEmpresa()
        {
            DataTable dataTableEmpresa = objetoEmpresa.search();
            textBoxPropietario.Text = dataTableEmpresa.Rows[0]["Propietario"].ToString();
            textBoxRazonSocial.Text = dataTableEmpresa.Rows[0]["Razon_Social"].ToString();
            textBoxNit.Text = dataTableEmpresa.Rows[0]["Nit"].ToString();
            textBoxActividadEconomica.Text = dataTableEmpresa.Rows[0]["Actividad_Economica"].ToString();
        }
        private int validarPropietario()
        {
            if (textBoxPropietario.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarRazonSocial()
        {
            if (textBoxRazonSocial.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarNit()
        {
            if (textBoxNit.Text.Trim() != "")
            {
                if (ValidacionBss.esNit(textBoxNit.Text.Trim()) == true)
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
        private int validarActividadEconomica()
        {
            if (textBoxActividadEconomica.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxActividadEconomica.Text.Trim()) == true)
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
        private bool validaciones()
        {
            int errorCode = hasErrors.ToList().IndexOf(true);
            if (errorCode == -1)
            {
                return true;
            }
            else
            {
                switch(errorCode)
                {
                    case 0:
                        textBoxPropietario.Focus();
                        break;
                    case 1:
                        textBoxRazonSocial.Focus();
                        break;
                    case 2:
                        textBoxNit.Focus();
                        break;
                    case 3:
                        textBoxActividadEconomica.Focus();
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