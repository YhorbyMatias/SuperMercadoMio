﻿using Bss;
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

namespace Super_Mercado_Mio.Archivo
{
    public partial class CambiarClave : Form
    {
        #region Objetos
        int idUsuario = 0;
        UsuarioBss objetoUsuario = new UsuarioBss();
        UsuarioEnt usuario = new UsuarioEnt();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public CambiarClave(UsuarioEnt usuarioX)
        {
            InitializeComponent();
            idUsuario = usuarioX.ID;
            usuario = usuarioX;
        }
        #endregion
        #region textBoxClaveActual
        private void textBoxClaveActual_Validating(object sender, CancelEventArgs e)
        {
            if (validarClaveActual())
            {
                errorProviderFormulario.SetError(textBoxClaveActual, null);
            }
            else
            {
                errorProviderFormulario.SetError(textBoxClaveActual, "La clave actual es obligatoria.");
            }
        }
        #endregion
        #region textBoxNuevaClave
        private void textBoxNuevaClave_Validating(object sender, CancelEventArgs e)
        {
            switch (validarNuevaClave())
            {
                case 0:
                    errorProviderFormulario.SetError(textBoxNuevaClave, null);
                    break;
                case 1:
                    errorProviderFormulario.SetError(textBoxNuevaClave, "Este campo es obligatorio.");
                    break;
                case 2:
                    errorProviderFormulario.SetError(textBoxNuevaClave, "Las claves no coinciden.");
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region textBoxConfirmarNuevaClave
        private void textBoxConfirmarNuevaClave_Validating(object sender, CancelEventArgs e)
        {
            switch (validarConfirmarNuevaClave())
            {
                case 0:
                    errorProviderFormulario.SetError(textBoxNuevaClave, null);
                    errorProviderFormulario.SetError(textBoxConfirmarNuevaClave, null);
                    break;
                case 1:
                    errorProviderFormulario.SetError(textBoxConfirmarNuevaClave, "Este campo es obligatorio.");
                    break;
                case 2:
                    errorProviderFormulario.SetError(textBoxConfirmarNuevaClave, "Las claves no coinciden.");
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                usuario.CLAVE = generarClave(textBoxNuevaClave.Text.Trim());
                objetoUsuario.updatePassword(usuario);
                string nombreDeUsuario = objetoUsuario.getFullName(usuario);
                insertarRegistro(nombreDeUsuario, "Usuario", usuario.ID, "Update Password");
                MessageBox.Show("La clave se cambió correctamente.", "Operación Exitosa", MessageBoxButtons.OK,
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
        private bool validarClaveActual()
        {
            if (textBoxClaveActual.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int validarNuevaClave()
        {
            if (textBoxNuevaClave.Text.Trim() != "")
            {
                if (textBoxNuevaClave.Text.Trim() == textBoxConfirmarNuevaClave.Text.Trim())
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
        private int validarConfirmarNuevaClave()
        {
            if (textBoxConfirmarNuevaClave.Text.Trim() != "")
            {
                if (textBoxNuevaClave.Text.Trim() == textBoxConfirmarNuevaClave.Text.Trim())
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
        private bool verificarClave()
        {
            usuario.CLAVE = generarClave(textBoxClaveActual.Text.Trim());
            if (objetoUsuario.authenticatePassword(usuario) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validaciones()
        {
            bool estado = false;
            if (validarClaveActual())
            {
                if (validarNuevaClave() == 0)
                {
                    if (validarConfirmarNuevaClave() == 0)
                    {
                        if (verificarClave())
                        {
                            estado = true;
                        }
                        else
                        {
                            errorProviderFormulario.SetError(textBoxClaveActual, "La clave no es correcta.");
                            textBoxClaveActual.ResetText();
                            textBoxNuevaClave.ResetText();
                            textBoxConfirmarNuevaClave.ResetText();
                            textBoxClaveActual.Focus();
                        }
                    }
                    else
                    {
                        textBoxConfirmarNuevaClave.Focus();
                    }
                }
                else
                {
                    textBoxNuevaClave.Focus();
                }
            }
            else
            {
                textBoxClaveActual.Focus();
            }
            return estado;
        }
        private string generarClave(string claveX)
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
        private void insertarRegistro(string usuarioX, string tablaX, int idTablaX, string tipoX)
        {
            registro = new RegistroEnt();
            registro.USUARIO = usuarioX;
            registro.HORA = DateTime.Now.ToString("T");
            registro.TABLA = tablaX;
            registro.ID_TABLA = idTablaX;
            registro.TIPO = tipoX;
            objetoRegistro.insert(registro);
        }
        #endregion
    }
}