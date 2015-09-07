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
    public partial class Modificar : Form
    {
        #region Objetos
        private readonly Action actualizarDataGridViewUsuarios;
        bool isWritable = true;
        bool updated = false;
        bool[] hasErrors = new bool[7];
        OpcionBss objetoOpcion = new OpcionBss();
        UsuarioBss objetoUsuario = new UsuarioBss();
        UsuarioEnt usuario = new UsuarioEnt();
        PrivilegioBss objetoPrivilegio = new PrivilegioBss();
        PrivilegioEnt privilegio = new PrivilegioEnt();
        DataTable dataTableOpciones = new DataTable();
        DataTable dataTablePrivilegios = new DataTable();
        List<PrivilegioEnt> listPrivilegiosFinales = new List<PrivilegioEnt>();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public Modificar(int idUsuarioX, Action actualizarDataGridViewUsuariosX)
        {
            InitializeComponent();
            usuario.ID_USUARIO = idUsuarioX;
            actualizarDataGridViewUsuarios = actualizarDataGridViewUsuariosX;
        }
        private void Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formularioListaDeUsuarios = this.MdiParent.MdiChildren.FirstOrDefault(x => x is Usuario.Lista);
            if (updated == false)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (formularioListaDeUsuarios != null)
                    {
                        formularioListaDeUsuarios.Show();
                    }
                }
            }
            else
            {
                if (formularioListaDeUsuarios != null)
                {
                    actualizarDataGridViewUsuarios();
                    formularioListaDeUsuarios.Show();
                }
            }
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            cargarCheckedListBoxOpciones();
            cargarInformacionDeUsuario();
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
            hasErrors[6] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(checkedListBoxOpciones, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones() == true)
            {
                cargarListPrivilegiosFinales();
                usuario.APELLIDO_MATERNO = textBoxApellidoMaterno.Text.Trim().ToUpper();
                usuario.TELEFONO = textBoxTelefono.Text.Trim();
                if (textBoxClave.Text.Trim() != "")
                {
                    usuario.CLAVE = cifrarClave(textBoxClave.Text.Trim());
                }
                objetoUsuario.update(usuario);
                insertarRegistro("Usuario", usuario.ID_USUARIO, "Modificar");
                foreach (PrivilegioEnt privilegioAuxiliar in listPrivilegiosFinales)
                {
                    bool estado = false;
                    for (int filas = 0; filas < dataTablePrivilegios.Rows.Count; filas++)
                    {
                        if (privilegioAuxiliar.ID_OPCION.ToString() == dataTablePrivilegios.Rows[filas]["Id_Opcion"].ToString())
                        {
                            estado = true;
                            break;
                        }
                    }
                    if (estado == false)
                    {
                        int idPrivilegio = objetoPrivilegio.insert(privilegioAuxiliar);
                        insertarRegistro("Privilegio", idPrivilegio, "Nuevo");
                    }
                }
                for (int filas = 0; filas < dataTablePrivilegios.Rows.Count; filas++)
                {
                    bool estado = false;
                    foreach (PrivilegioEnt Privilegio in listPrivilegiosFinales)
                    {
                        if (dataTablePrivilegios.Rows[filas]["Id_Opcion"].ToString() == Privilegio.ID_OPCION.ToString())
                        {
                            estado = true;
                            break;
                        }
                    }
                    if (estado == false)
                    {
                        privilegio = new PrivilegioEnt();
                        privilegio.ID_PRIVILEGIO = Convert.ToInt32(dataTablePrivilegios.Rows[filas]["Id_Privilegio"]);
                        privilegio.ESTADO = false;
                        objetoPrivilegio.delete(privilegio);
                        insertarRegistro("Privilegio", privilegio.ID_PRIVILEGIO, "Eliminar");
                    }
                }
                updated = true;
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
            foreach (DataRow dataRowFila in dataTableOpciones.Rows)
            {
                checkedListBoxOpciones.Items.Add(dataRowFila["Nombre"].ToString());
            }
        }
        private void obtenerPrivilegios(int idUsuarioX)
        {
            for (int items = 0; items < checkedListBoxOpciones.Items.Count; items++)
            {
                checkedListBoxOpciones.SetItemChecked(items, false);
            }
            privilegio.ID_USUARIO = idUsuarioX;
            dataTablePrivilegios = objetoPrivilegio.search(privilegio);
            foreach (DataRow dataRow in dataTablePrivilegios.Rows)
            {
                for (int fila = 0; fila < dataTableOpciones.Rows.Count; fila++)
                {
                    if (dataRow["Id_Opcion"].ToString() == dataTableOpciones.Rows[fila]["Id_Opcion"].ToString())
                    {
                        checkedListBoxOpciones.SetItemChecked(fila, true);
                    }
                }
            }
        }
        private void cargarInformacionDeUsuario()
        {
            DataTable dataTableUsuario = objetoUsuario.search(usuario);
            textBoxCi.Text = dataTableUsuario.Rows[0]["Ci"].ToString();
            textBoxNombres.Text = dataTableUsuario.Rows[0]["Nombres"].ToString();
            textBoxApellidoPaterno.Text = dataTableUsuario.Rows[0]["Apellido_Paterno"].ToString();
            textBoxApellidoMaterno.Text = dataTableUsuario.Rows[0]["Apellido_Materno"].ToString();
            textBoxTelefono.Text = dataTableUsuario.Rows[0]["Telefono"].ToString();
            textBoxNombreDeUsuario.Text = dataTableUsuario.Rows[0]["Nombre_De_Usuario"].ToString();
            usuario.CLAVE = dataTableUsuario.Rows[0]["Clave"].ToString();
            obtenerPrivilegios(usuario.ID_USUARIO);
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
                        checkedListBoxOpciones.Focus();
                        break;
                }
                return false;
            }
        }
        private void cargarListPrivilegiosFinales()
        {
            for (int i = 0; i < dataTableOpciones.Rows.Count; i++)
            {
                if (checkedListBoxOpciones.GetItemChecked(i))
                {
                    PrivilegioEnt privilegio = new PrivilegioEnt();
                    privilegio.ID_USUARIO = usuario.ID_USUARIO;
                    privilegio.ID_OPCION = Convert.ToInt32(dataTableOpciones.Rows[i]["Id_Opcion"]);
                    listPrivilegiosFinales.Add(privilegio);
                }
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