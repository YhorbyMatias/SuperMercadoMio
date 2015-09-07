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

namespace Super_Mercado_Mio.Usuario
{
    public partial class Eliminar : Form
    {
        #region Objetos
        int records = 0;
        UsuarioBss objetoUsuario = new UsuarioBss();
        UsuarioEnt usuario = new UsuarioEnt();
        PrivilegioBss objetoPrivilegio = new PrivilegioBss();
        PrivilegioEnt privilegio = new PrivilegioEnt();
        DataTable dataTablePrivilegios = new DataTable();
        DataView dataViewUsuarios = new DataView();
        RegistroBss objetoRegistro = new RegistroBss();
        RegistroEnt registro = new RegistroEnt();
        #endregion
        #region Formulario
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            cargarDataGridViewUsuarios(objetoUsuario.searchAll());
        }
        #endregion
        #region textBoxBuscar
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewUsuarios();
            }
        }
        #endregion
        #region buttonEliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    usuario.ID_USUARIO = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id_Usuario"].Value);
                    if (usuario.ID_USUARIO != SesionEnt.idUsuario)
                    {
                        objetoUsuario.delete(usuario);
                        insertarRegistro("Usuario", usuario.ID_USUARIO, "Eliminar");
                        privilegio.ID_USUARIO = usuario.ID_USUARIO;
                        dataTablePrivilegios = objetoPrivilegio.find(privilegio);
                        for (int filas = 0; filas < dataTablePrivilegios.Rows.Count; filas++)
                        {
                            privilegio = new PrivilegioEnt();
                            privilegio.ID_PRIVILEGIO = Convert.ToInt32(dataTablePrivilegios.Rows[filas]["Id_Privilegio"]);
                            privilegio.ESTADO = false;
                            objetoPrivilegio.delete(privilegio);
                            insertarRegistro("Privilegio", privilegio.ID_PRIVILEGIO, "Eliminar");
                        }
                        MessageBox.Show("El usuario fue eliminado.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El usuario está en uso y no puede ser eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
        private void cargarDataGridViewUsuarios(DataTable dataTableUsuariosX)
        {
            dataViewUsuarios.Table = dataTableUsuariosX;
            dataGridViewUsuarios.DataSource = dataViewUsuarios;
            records = dataGridViewUsuarios.Rows.Count;
            if (records > 0)
            {
                dataGridViewUsuarios.Columns["Id_Usuario"].Visible = false;
                dataGridViewUsuarios.Sort(dataGridViewUsuarios.Columns["Usuario"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewUsuarios.DataSource = null;
                dataGridViewUsuarios.ColumnHeadersVisible = false;
            }
        }
        private void filterDataGridViewUsuarios()
        {
            if (records > 0)
            {
                if (dataGridViewUsuarios.SortedColumn.ValueType == typeof(int))
                {
                    if (ValidacionBss.esEntero(textBoxBuscar.Text.Trim()))
                    {
                        dataViewUsuarios.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() + " = " + textBoxBuscar.Text.Trim();
                    }
                    else
                    {
                        dataViewUsuarios.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() + " = -1";
                    }
                }
                else
                {
                    dataViewUsuarios.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() +
                                                 " Like '%" + textBoxBuscar.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        private void insertarRegistro(string tablaX, int claveX, string tipoX)
        {
            registro = new RegistroEnt();
            registro.USUARIO = SesionEnt.nombreDeUsuario;
            registro.EQUIPO = SesionEnt.nombreDeEquipo;
            registro.HORA = DateTime.Now.ToString("T");
            registro.TABLA = tablaX;
            registro.ID_TABLA = claveX;
            registro.TIPO = tipoX;
            objetoRegistro.insert(registro);
        }
        #endregion
    }
}