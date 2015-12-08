using Bss;
using Ent;
using Microsoft.PointOfService;
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
        DosificacionBss objetoDosificacion = new DosificacionBss();
        DosificacionEnt dosificacion = new DosificacionEnt();
        CajaBss objetoCaja = new CajaBss();
        CajaEnt caja = new CajaEnt();
        ImpresoraBss printer = new ImpresoraBss();
        #endregion
        #region Form
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    printer.closeConnection();
            //}
            //catch (PosControlException exception)
            //{
            //    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Application.Exit();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            SesionEnt.idUsuario = usuario.ID;
            SesionEnt.nombreDeUsuario = objetoUsuario.getFullName(usuario);
            SesionEnt.nombreDeEquipo = System.Environment.MachineName;
            toolStripStatusLabelUsuario.Text = "Usuario: " + SesionEnt.nombreDeUsuario;
            loadMenu();
            reviewDosificacion();
            reviewCashBox();
            //try
            //{
            //    printer.openConnection();
            //}
            //catch (PosControlException exception)
            //{
            //    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
        #region Menu Dosificacion
        private void nuevaDosificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dosificacion.Nueva formNuevaDosificacion = new Dosificacion.Nueva();
            formNuevaDosificacion.MdiParent = this;
            formNuevaDosificacion.Show();
        }
        private void modificarDosificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dosificacion.Lista formListaDeDosificacion = new Dosificacion.Lista(2);
            formListaDeDosificacion.MdiParent = this;
            formListaDeDosificacion.Show();
        }
        private void listaDeDosificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dosificacion.Lista formListaDeDosificacion = new Dosificacion.Lista(1);
            formListaDeDosificacion.MdiParent = this;
            formListaDeDosificacion.Show();
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
        #region Menu Grupo
        private void nuevoGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo.Nuevo formularioNuevoGrupo = new Grupo.Nuevo();
            formularioNuevoGrupo.MdiParent = this;
            formularioNuevoGrupo.Show();
        }
        private void modificarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo.Lista formularioListaDeProductos = new Grupo.Lista(2);
            formularioListaDeProductos.MdiParent = this;
            formularioListaDeProductos.Show();
        }
        private void eliminarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo.Eliminar formularioEliminarGrupo = new Grupo.Eliminar();
            formularioEliminarGrupo.MdiParent = this;
            formularioEliminarGrupo.Show();
        }
        private void listaDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo.Lista formularioListaDeProductos = new Grupo.Lista(1);
            formularioListaDeProductos.MdiParent = this;
            formularioListaDeProductos.Show();
        }
        #endregion
        #region Menu Caja
        private void modificarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja.Lista fromListaDeCajas = new Caja.Lista(2);
            fromListaDeCajas.MdiParent = this;
            fromListaDeCajas.Show();
        }
        private void eliminarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja.Eliminar formEliminarCaja = new Caja.Eliminar();
            formEliminarCaja.MdiParent = this;
            formEliminarCaja.Show();
        }
        private void listaDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja.Lista formCashboxList = new Caja.Lista(1);
            formCashboxList.MdiParent = this;
            formCashboxList.Show();
        }
        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja.Apertura formAperturaDeCaja = new Caja.Apertura();
            formAperturaDeCaja.MdiParent = this;
            formAperturaDeCaja.Show();
        }
        private void cierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja.Cierre formCierreDeCaja = new Caja.Cierre();
            formCierreDeCaja.MdiParent = this;
            formCierreDeCaja.Show();
        }
        #endregion
        #region Menu Venta
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta.Nueva formNuevaVenta = new Venta.Nueva();
            formNuevaVenta.MdiParent = this;
            formNuevaVenta.Show();
        }
        #endregion
        #region Menu Factura
        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura.Anular formAnularFactura = new Factura.Anular();
            formAnularFactura.MdiParent = this;
            formAnularFactura.Show();
        }
        #endregion
        #region Menu Cliente
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.Nuevo formNuevoCliente = new Cliente.Nuevo(1, null);
            formNuevoCliente.MdiParent = this;
            formNuevoCliente.Show();
        }
        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.Lista formListaDeClientes = new Cliente.Lista(2);
            formListaDeClientes.MdiParent = this;
            formListaDeClientes.Show();
        }
        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.Eliminar formEliminarCliente = new Cliente.Eliminar();
            formEliminarCliente.MdiParent = this;
            formEliminarCliente.Show();
        }
        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.Lista formListaDeClientes = new Cliente.Lista(1);
            formListaDeClientes.MdiParent = this;
            formListaDeClientes.Show();
        }
        #endregion
        #region Menu Compra
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Nueva formularioNuevaCompra = new Compra.Nueva();
            formularioNuevaCompra.MdiParent = this;
            formularioNuevaCompra.Show();
        }
        private void modificarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Busqueda formBusquedaDeCompras = new Compra.Busqueda(2);
            formBusquedaDeCompras.MdiParent = this;
            formBusquedaDeCompras.Show();
        }
        private void anularCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Busqueda formBusquedaDeCompras = new Compra.Busqueda(3);
            formBusquedaDeCompras.MdiParent = this;
            formBusquedaDeCompras.Show();
        }
        private void busquedaDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.Busqueda formBusquedaDeCompras = new Compra.Busqueda(1);
            formBusquedaDeCompras.MdiParent = this;
            formBusquedaDeCompras.Show();
        }
        #endregion
        #region Menu Producto
        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.Nuevo formularioNuevoProducto = new Producto.Nuevo(1, null);
            formularioNuevoProducto.MdiParent = this;
            formularioNuevoProducto.Show();
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.Lista formularioListaDeProductos = new Producto.Lista(2);
            formularioListaDeProductos.MdiParent = this;
            formularioListaDeProductos.Show();
        }
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.Eliminar formEliminarProducto = new Producto.Eliminar();
            formEliminarProducto.MdiParent = this;
            formEliminarProducto.Show();
        }
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.Lista formularioListaDeProductos = new Producto.Lista(1);
            formularioListaDeProductos.MdiParent = this;
            formularioListaDeProductos.Show();
        }
        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.Stock formStockDeProductos = new Producto.Stock();
            formStockDeProductos.MdiParent = this;
            formStockDeProductos.Show();
        }
        #endregion
        #region Methods
        private void loadMenu()
        {
            PrivilegioBss objetoprivilegio = new PrivilegioBss();
            PrivilegioEnt privilegio = new PrivilegioEnt();
            privilegio.ID_USUARIO = usuario.ID;
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
                    case "Modificar Sucursal":
                        modificarSucursalToolStripMenuItem.Enabled = true;
                        break;
                    case "Datos de Sucursal":
                        datosDeSucursalToolStripMenuItem.Enabled = true;
                        break;
                    case "Nueva Dosificación":
                        nuevaDosificacionToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Dosificación":
                        modificarDosificacionToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Dosificaciones":
                        listaDeDosificacionesToolStripMenuItem.Enabled = true;
                        break;
                    case "Nuevo Proveedor":
                        nuevoProveedorToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Proveedor":
                        modificarProveedorToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Proveedor":
                        eliminarProveedorToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Proveedores":
                        listaDeProveedoresToolStripMenuItem.Enabled = true;
                        break;
                    case "Nuevo Grupo":
                        nuevoGrupoToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Grupo":
                        modificarGrupoToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Grupo":
                        eliminarGrupoToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Grupos":
                        listaDeGruposToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Caja":
                        modificarCajaToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Caja":
                        eliminarCajaToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Cajas":
                        listaDeCajasToolStripMenuItem.Enabled = true;
                        break;
                    case "Apertura de Caja":
                        aperturaDeCajaToolStripMenuItem.Enabled = true;
                        break;
                    case "Cierre de Caja":
                        cierreDeCajaToolStripMenuItem.Enabled = true;
                        break;
                    case "Nueva Venta":
                        nuevaVentaToolStripMenuItem.Enabled = true;
                        break;
                    case "Nuevo Cliente":
                        nuevoClienteToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Cliente":
                        modificarClienteToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Cliente":
                        eliminarClienteToolStripMenuItem.Enabled = true;
                        break;
                    case "Lista de Clientes":
                        listaDeClientesToolStripMenuItem.Enabled = true;
                        break;
                    case "Nueva Compra":
                        nuevaCompraToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Compra":
                        modificarCompraToolStripMenuItem.Enabled = true;
                        break;
                    case "Anular Compra":
                        anularCompraToolStripMenuItem.Enabled = true;
                        break;
                    case "Busqueda de Compras":
                        busquedaDeComprasToolStripMenuItem.Enabled = true;
                        break;
                    case "Nuevo Producto":
                        nuevoProductoToolStripMenuItem.Enabled = true;
                        break;
                    case "Modificar Producto":
                        modificarProductoToolStripMenuItem.Enabled = true;
                        break;
                    case "Eliminar Producto":
                        eliminarProductoToolStripMenuItem.Enabled = true;
                        break;
                    case "Stock de Productos":
                        stockDeProductosToolStripMenuItem.Enabled = true;
                        break;
                }
            }
        }
        private void reviewDosificacion()
        {
            SesionEnt.activeDosificacion = true;
            dosificacion.ID_SUCURSAL = 1;
            dosificacion.ESTADO = "ACTIVA";
            if (objetoDosificacion.exists(dosificacion) == 1)
            {
                dosificacion.ID = objetoDosificacion.getId(dosificacion);
                int remainingDays = objetoDosificacion.getRemainingDays(dosificacion);
                if (remainingDays <= 7)
                {
                    if (remainingDays < 0)
                    {
                        dosificacion.ESTADO = "INACTIVA";
                        objetoDosificacion.updateStatus(dosificacion);
                        dosificacion = new DosificacionEnt();
                        dosificacion.ID_SUCURSAL = 1;
                        dosificacion.ESTADO = "PENDIENTE";
                        if (objetoDosificacion.exists(dosificacion) == 1)
                        {
                            dosificacion.ID = objetoDosificacion.getId(dosificacion);
                            dosificacion.ESTADO = "ACTIVA";
                            objetoDosificacion.updateStatus(dosificacion);
                        }
                        else
                        {
                            nuevaDosificacionToolStripMenuItem.Visible = true;
                            SesionEnt.activeDosificacion = false;
                            MessageBox.Show("No existe una dosificación activa. No se pueden emitir facturas.", "Advertencia", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La dosificación vencerá en " + remainingDays + " días.", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                nuevaDosificacionToolStripMenuItem.Visible = true;
                SesionEnt.activeDosificacion = false;
                MessageBox.Show("No existe una dosificación activa. No se pueden emitir facturas.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void reviewCashBox()
        {
            caja.NOMBRE_DE_EQUIPO = SesionEnt.nombreDeEquipo;
            if (objetoCaja.exists(caja) == 0)
            {
                Caja.Nueva formNuevaCaja = new Caja.Nueva();
                formNuevaCaja.ShowDialog();
            }
            SesionEnt.idCaja = objetoCaja.getId(caja);
        }
        #endregion
    }
}