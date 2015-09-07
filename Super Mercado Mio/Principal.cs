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

namespace Super_Mercado_Mio
{
    public partial class Principal : Form
    {
        #region Objetos
        UsuarioBss objetoUsuario = new UsuarioBss();
        public UsuarioEnt usuario = new UsuarioEnt();
        EmpresaBss objetoEmpresa = new EmpresaBss();
        SucursalBss objetoSucursal = new SucursalBss();
        #endregion
        #region Form
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            SesionEnt.idUsuario = usuario.ID_USUARIO;
            SesionEnt.nombreDeUsuario = objetoUsuario.getFullName(usuario);
            SesionEnt.nombreDeEquipo = System.Environment.MachineName;
            toolStripStatusLabelUsuario.Text = "Usuario: " + SesionEnt.nombreDeUsuario;
            loadMenu();
            if (objetoEmpresa.exists() == 0)
            {
                if (usuario.ID_USUARIO == 1)
                {
                    nuevaEmpresaToolStripMenuItem.Enabled = true;
                    nuevaEmpresaToolStripMenuItem.Visible = true;
                }
                else
                {
                    Empresa.Nueva FormularioNuevaEmpresa = new Empresa.Nueva(2, this.isCompanyRegistered);
                    FormularioNuevaEmpresa.ShowDialog();
                }
            }
            if (objetoSucursal.exists() == 0)
            {
                if (usuario.ID_USUARIO == 1)
                {
                    nuevaSucursalToolStripMenuItem.Enabled = true;
                    nuevaSucursalToolStripMenuItem.Visible = true;
                }
                else
                {
                    Sucursal.Nueva FormularioNuevaSucursal = new Sucursal.Nueva(2, this.isBranchRegistered);
                    FormularioNuevaSucursal.ShowDialog();
                }
            }
        }
        #endregion
        #region Menu Archivo
        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.CambiarClave formularioCambiarClave = new Archivo.CambiarClave(usuario);
            formularioCambiarClave.MdiParent = this;
            formularioCambiarClave.Show();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formularioLogin = new Login();
            formularioLogin.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Menu Usuario
        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.Nuevo formularioNuevoUsuario = new Usuario.Nuevo();
            formularioNuevoUsuario.MdiParent = this;
            formularioNuevoUsuario.Show();
        }
        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.Lista formularioListaDeUsuarios = new Usuario.Lista(2);
            formularioListaDeUsuarios.MdiParent = this;
            formularioListaDeUsuarios.Show();
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.Eliminar formularioEliminarUsuario = new Usuario.Eliminar();
            formularioEliminarUsuario.MdiParent = this;
            formularioEliminarUsuario.Show();
        }
        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.Lista formularioListaDeUsuarios = new Usuario.Lista(1);
            formularioListaDeUsuarios.MdiParent = this;
            formularioListaDeUsuarios.Show();
        }
        #endregion
        #region Menu Empresa
        private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.Nueva formularioNuevaEmpresa = new Empresa.Nueva(1, this.isCompanyRegistered);
            formularioNuevaEmpresa.MdiParent = this;
            formularioNuevaEmpresa.Show();
        }
        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.Modificar formularioModificarEmpresa = new Empresa.Modificar();
            formularioModificarEmpresa.MdiParent = this;
            formularioModificarEmpresa.Show();
        }
        private void datosDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.Datos formularioDatosDeEmpresa = new Empresa.Datos();
            formularioDatosDeEmpresa.MdiParent = this;
            formularioDatosDeEmpresa.Show();
        }
        #endregion
        #region Menu Sucursal
        private void nuevaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal.Nueva formularioNuevaSucursal = new Sucursal.Nueva(1, isBranchRegistered);
            formularioNuevaSucursal.MdiParent = this;
            formularioNuevaSucursal.Show();
        }
        private void modificarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal.Modificar formularioModificarSucursal = new Sucursal.Modificar();
            formularioModificarSucursal.MdiParent = this;
            formularioModificarSucursal.Show();
        }
        private void datosDeSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal.Datos formularioDatosDeSucursal = new Sucursal.Datos();
            formularioDatosDeSucursal.MdiParent = this;
            formularioDatosDeSucursal.Show();
        }
        #endregion
        #region Menu Proveedor
        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor.Nuevo formularioNuevoProveedor = new Proveedor.Nuevo(1, null);
            formularioNuevoProveedor.MdiParent = this;
            formularioNuevoProveedor.Show();
        }
        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor.Lista formularioListaDeProveedores = new Proveedor.Lista(2);
            formularioListaDeProveedores.MdiParent = this;
            formularioListaDeProveedores.Show();
        }
        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor.Eliminar formularioEliminarListaDeProveedores = new Proveedor.Eliminar();
            formularioEliminarListaDeProveedores.MdiParent = this;
            formularioEliminarListaDeProveedores.Show();
        }
        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor.Lista formularioListaDeProveedores = new Proveedor.Lista(1);
            formularioListaDeProveedores.MdiParent = this;
            formularioListaDeProveedores.Show();
        }
        #endregion
        #region Metodos Propios
        private void loadMenu()
        {
            PrivilegioBss objetoprivilegio = new PrivilegioBss();
            PrivilegioEnt privilegio = new PrivilegioEnt();
            privilegio.ID_USUARIO = usuario.ID_USUARIO;
            DataTable dataTablePrivilegios = objetoprivilegio.select(privilegio);
            int numeroderoles = dataTablePrivilegios.Rows.Count;
            for (int i = 0; i < numeroderoles; i++)
            {
                string opcion = Convert.ToString(dataTablePrivilegios.Rows[i]["Nombre"]);
                switch (opcion)
                {
                    case "Copia de Seguridad":
                        copiaDeSeguridadBaseDeDatosToolStripMenuItem.Enabled = true;
                        break;
                    case "Restaurar":
                        restaurarBaseDeDatosToolStripMenuItem.Enabled = true;
                        break;
                    case "Nuevo Usuario":
                        nuevoUsuarioToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Usuario":
                        modificarUsuarioToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Usuario":
                        eliminarUsuarioToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Usuarios":
                        listaDeUsuariosToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Empresa":
                        modificarEmpresaToolStripMenuItem.Enabled = true;
                        break;
                    case "Datos de Empresa":
                        datosDeEmpresaToolStripMenuItem.Enabled = true;
                        break;
                    case "Nueva Sucursal":
                        nuevaSucursalToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Sucursal":
                        modificarSucursalToolStripMenuItem.Enabled = true;
                        break;
                    case "Datos de Sucursal":
                        datosDeSucursalToolStripMenuItem.Enabled = true;
                        break;
                }
            }
        }
        private void isCompanyRegistered()
        {
            if (objetoEmpresa.exists() == 1)
            {
                nuevaEmpresaToolStripMenuItem.Enabled = false;
                nuevaEmpresaToolStripMenuItem.Visible = false;
            }
        }
        private void isBranchRegistered()
        {
            if (objetoSucursal.exists() == 1)
            {
                nuevaSucursalToolStripMenuItem.Enabled = false;
                nuevaSucursalToolStripMenuItem.Visible = false;
            }
        }
        #endregion
    }
}