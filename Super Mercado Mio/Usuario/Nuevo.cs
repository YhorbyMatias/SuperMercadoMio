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
        bool[] hasErrors = new bool[] { true, true, true, false, false, true, true, true };
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
            loadCheckedListBoxOpciones();
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
            int errorCode = reviewCi();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCi, ValidacionBss.getErrorMessage(errorCode));
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
            int errorCode = reviewNames();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNombres, ValidacionBss.getErrorMessage(errorCode));
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
            int errorCode = reviewLastName();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxApellidoPaterno, ValidacionBss.getErrorMessage(errorCode));
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
            int errorCode = reviewMotherLastName();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxApellidoMaterno, ValidacionBss.getErrorMessage(errorCode));
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
            int errorCode = reviewPhone();
            hasErrors[4] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxTelefono, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombreDeUsuario
        private void textBoxNombreDeUsuario_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = rewiewUserName();
            hasErrors[5] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNombreDeUsuario, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxClave
        private void textBoxClave_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewPassword();
            hasErrors[6] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxClave, ValidacionBss.getErrorMessage(errorCode));
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
            int errorCode = reviewOptions();
            hasErrors[7] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(checkedListBoxOpciones, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors() == true)
            {
                usuario.APELLIDO_MATERNO = textBoxApellidoMaterno.Text.Trim().ToUpper();
                usuario.TELEFONO = textBoxTelefono.Text.Trim();
                usuario.CLAVE = encryptPassword(textBoxClave.Text.Trim());
                usuario.ID = objetoUsuario.insert(usuario);
                addRecord("Usuario", usuario.ID, "Nuevo");
                for (int i = 0; i < dataTableOpciones.Rows.Count; i++)
                {
                    if (checkedListBoxOpciones.GetItemChecked(i))
                    {
                        privilegio = new PrivilegioEnt();
                        privilegio.ID_USUARIO = usuario.ID;
                        privilegio.ID_OPCION = Convert.ToInt32(dataTableOpciones.Rows[i]["Id"]);
                        privilegio.ID = objetoPrivilegio.insert(privilegio);
                        addRecord("Privilegio", privilegio.ID, "Nuevo");
                    }
                }
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
        private bool authenticateCi()
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
        private int authenticateUser()
        {
            if (!hasErrors[1] && !hasErrors[2])
            {
                usuario.NOMBRES = textBoxNombres.Text.Trim().ToUpper();
                usuario.APELLIDO_PATERNO = textBoxApellidoPaterno.Text.Trim().ToUpper();
                if (objetoUsuario.authenticate(usuario) > 0)
                {
                    return 111;
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
        private bool authenticateUserName()
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
        private bool checkForErrors()
        {
            int errorCode = authenticateUser();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNombres, ValidacionBss.getErrorMessage(errorCode));
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
        private string encryptPassword(string clave)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(clave);
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
        private void loadCheckedListBoxOpciones()
        {
            dataTableOpciones = objetoOpcion.search();
            foreach (DataRow dataRow in dataTableOpciones.Rows)
            {
                checkedListBoxOpciones.Items.Add(dataRow["Nombre"].ToString());
            }
        }
        private int reviewCi()
        {
            if (textBoxCi.Text.Trim() != "")
            {
                if (ValidacionBss.esCi(textBoxCi.Text.Trim()) == true)
                {
                    if (authenticateCi())
                    {
                        return 0;
                    }
                    else
                    {
                        return 110;
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
        private int reviewLastName()
        {
            if (textBoxApellidoPaterno.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxApellidoPaterno.Text.Trim()) == true)
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
        private int reviewMotherLastName()
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
        private int reviewNames()
        {
            if (textBoxNombres.Text.Trim() != "")
            {
                if (ValidacionBss.esCadena(textBoxNombres.Text.Trim()) == true)
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
        private int reviewPhone()
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
        private int rewiewUserName()
        {
            if (textBoxNombreDeUsuario.Text.Trim() != "")
            {
                if (authenticateUserName())
                {
                    return 0;
                }
                else
                {
                    return 112;
                }
            }
            else
            {
                return 1;
            }
        }
        private int reviewPassword()
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
        private int reviewOptions()
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
        #endregion
    }
}