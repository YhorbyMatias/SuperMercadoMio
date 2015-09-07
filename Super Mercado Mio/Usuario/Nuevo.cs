using Bss;
using Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio.Usuario
{
    public partial class Nuevo : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[8];
        OpcionBss objetoOpcion = new OpcionBss();
        UsuarioBss objetoUsuario = new UsuarioBss();
        UsuarioEnt usuario = new UsuarioEnt();
        PrivilegioBss objetoPrivilegio = new PrivilegioBss();
        PrivilegioEnt privilegio = new PrivilegioEnt();
        DataTable dataTableOpciones = new DataTable();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public Nuevo()
        {
            InitializeComponent();
        }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            cargarCheckedListBoxOpciones();
        }
        #endregion
        #region textBoxCi
        private void textBoxCi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCi(Clipboard.GetText()) == false)
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
        private void textBoxCi_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxCi_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarCi();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxCi, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombres
        private void textBoxNombres_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.diccionarioCadena.Contains(e.KeyChar) == true)
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
        private void textBoxNombres_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNombres();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombres, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxApellidoPaterno
        private void textBoxApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.diccionarioCadena.Contains(e.KeyChar) == true)
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
        private void textBoxApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarApellidoPaterno();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxApellidoPaterno, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxApellidoMaterno
        private void textBoxApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.diccionarioCadena.Contains(e.KeyChar) == true)
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
        private void textBoxApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarApellidoMaterno();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxApellidoMaterno, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxTelefono
        private void textBoxTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCelularOTelefono(Clipboard.GetText()) == false)
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
            hasErrors[4] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxTelefono, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombreDeUsuario
        private void textBoxNombreDeUsuario_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNombreDeUsuario();
            hasErrors[5] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombreDeUsuario, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxClave
        private void textBoxClave_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarClave();
            hasErrors[6] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxClave, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region checkBoxSeleccionarTodos
        private void checkBoxSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            for (int opciones = 0; opciones < checkedListBoxOpciones.Items.Count; opciones++)
            {
                checkedListBoxOpciones.SetItemChecked(opciones, checkBoxSeleccionarTodos.Checked);
            }
        }
        #endregion
        #region checkedListBoxOpciones
        private void checkedListBoxOpciones_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarOpciones();
            hasErrors[7] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(checkedListBoxOpciones, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones() == true)
            {
                usuario.APELLIDO_MATERNO = textBoxApellidoMaterno.Text.Trim().ToUpper();
                usuario.TELEFONO = textBoxTelefono.Text.Trim();
                usuario.CLAVE = cifrarClave(textBoxClave.Text.Trim());
                int idUsuarioNuevo = objetoUsuario.insert(usuario);
                insertarRegistro("Usuario", idUsuarioNuevo, "Nuevo");
                for (int i = 0; i < dataTableOpciones.Rows.Count; i++)
                {
                    if (checkedListBoxOpciones.GetItemChecked(i))
                    {
                        privilegio = new PrivilegioEnt();
                        privilegio.ID_USUARIO = idUsuarioNuevo;
                        privilegio.ID_OPCION = Convert.ToInt32(dataTableOpciones.Rows[i]["Id_Opcion"]);
                        privilegio.ID_PRIVILEGIO = objetoPrivilegio.insert(privilegio);
                        insertarRegistro("Privilegio", privilegio.ID_PRIVILEGIO, "Nuevo");
                    }
                }
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
        private void cargarCheckedListBoxOpciones()
        {
            dataTableOpciones = objetoOpcion.search();
            foreach (DataRow dataRow in dataTableOpciones.Rows)
            {
                checkedListBoxOpciones.Items.Add(dataRow["Nombre"].ToString());
            }
        }
        private bool verificarCi()
        {
            usuario.CI = textBoxCi.Text.Trim();
            if (objetoUsuario.authenticateCi(usuario) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool verificarUsuario(int controlToValidateX)
        {
            if (hasErrors[controlToValidateX] == false)
            {
                usuario.NOMBRES = textBoxNombres.Text.Trim().ToUpper();
                usuario.APELLIDO_PATERNO = textBoxApellidoPaterno.Text.Trim().ToUpper();
                if (objetoUsuario.authenticate(usuario) == 0)
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
        private bool verificarNombreDeUsuario()
        {
            usuario.NOMBRE_DE_USUARIO = textBoxNombreDeUsuario.Text.Trim();
            if (objetoUsuario.authenticateUserName(usuario) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int validarCi()
        {
            if (textBoxCi.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxCi.Text.Trim()) == true)
                {
                    if (verificarCi())
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
        private int validarNombres()
        {
            if (textBoxNombres.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxNombres.Text.Trim()) == true)
                {
                    if (verificarUsuario(2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
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
        private int validarApellidoPaterno()
        {
            if (textBoxApellidoPaterno.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxApellidoPaterno.Text.Trim()) == true)
                {
                    if (verificarUsuario(1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
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
        private int validarApellidoMaterno()
        {
            if (textBoxApellidoMaterno.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxApellidoMaterno.Text.Trim()) == true)
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
                if (ValidacionBss.esCelularOTelefono(textBoxTelefono.Text.Trim()) == true)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
        private int validarNombreDeUsuario()
        {
            if (textBoxNombreDeUsuario.Text.Trim() != "")
            {
                if (verificarNombreDeUsuario())
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
            else
            {
                return 1;
            }
        }
        private int validarClave()
        {
            if (textBoxClave.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarOpciones()
        {
            int errorCode = 3;
            for (int i = 0; i < dataTableOpciones.Rows.Count; i++)
            {
                if (checkedListBoxOpciones.GetItemChecked(i))
                {
                    errorCode = 0;
                    break;
                }
            }
            return errorCode;
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
                        textBoxCi.Focus();
                        break;
                    case 1:
                        textBoxNombres.Focus();
                        break;
                    case 2:
                        textBoxApellidoPaterno.Focus();
                        break;
                    case 3:
                        textBoxApellidoMaterno.Focus();
                        break;
                    case 4:
                        textBoxTelefono.Focus();
                        break;
                    case 5:
                        textBoxNombreDeUsuario.Focus();
                        break;
                    case 6:
                        textBoxClave.Focus();
                        break;
                    case 7:
                        checkedListBoxOpciones.Focus();
                        break;
                }
                return false;
            }
        }
        private string cifrarClave(string claveX)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(claveX);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString().ToUpper();
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