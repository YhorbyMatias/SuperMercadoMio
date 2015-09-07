using Bss;
using Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio
{
    public partial class Login : Form
    {
        #region Objetos
        UsuarioBss objetoUsuario = new UsuarioBss();
        UsuarioEnt usuario = new UsuarioEnt();
        #endregion
        #region Formulario
        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                //Configuracion.ConfigurarServidorYBaseDeDatos FormularioConfigurarServidorYBaseDeDatos = new Configuracion.ConfigurarServidorYBaseDeDatos();
                //FormularioConfigurarServidorYBaseDeDatos.ShowDialog();
                //this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
        #endregion
        #region buttonIngresar
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBss.test();
                usuario.NOMBRE_DE_USUARIO = textBoxUsuario.Text.Trim();
                usuario.CLAVE = cifrarClave(textBoxClave.Text.Trim());
                usuario.ID_USUARIO = objetoUsuario.login(usuario);
                if (usuario.ID_USUARIO != 0)
                {
                    MessageBox.Show("Bienvenido: " + textBoxUsuario.Text, "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal FormularioPrincipal = new Principal();
                    FormularioPrincipal.usuario.ID_USUARIO = usuario.ID_USUARIO;
                    this.Hide();
                    FormularioPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxClave.ResetText();
                }
            }
            catch (SqlException sqlExceptionX)
            {
                MessageBox.Show("Hubo un problema al conectarse al servidor. " + sqlExceptionX.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
        private string cifrarClave(string ClaveX)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(ClaveX);
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
        #endregion
    }
}