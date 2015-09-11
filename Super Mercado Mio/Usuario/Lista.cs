using Bss;
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
    public partial class Lista : Form
    {
        #region Objetos
        int opcion = 0;
        int records = 0;
        UsuarioBss objetoUsuario = new UsuarioBss();
        DataView dataViewUsuarios = new DataView();
        #endregion
        #region Form
        public Lista(int opcionX)
        {
            InitializeComponent();
            opcion = opcionX;
        }
        private void Lista_Load(object sender, EventArgs e)
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
        #region dataGridViewUsuarios
        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Usuario.Modificar formularioModificarUsuario =
                        new Modificar(Convert.ToInt32(dataGridViewUsuarios["Id_Usuario", e.RowIndex].Value),
                            this.actualizarDataGridViewUsuarios);
                    formularioModificarUsuario.MdiParent = this.MdiParent;
                    this.Hide();
                    formularioModificarUsuario.Show();
                }
            }
        }
        #endregion
        #region Metodos Propios
        private void setDataGridViewUsuariosFormat()
        {
            if (opcion == 2)
            {
                dataGridViewUsuarios.Columns["Modificar"].Visible = true;
            }
            dataGridViewUsuarios.Columns["Id_Usuario"].Visible = false;
            dataGridViewUsuarios.Columns["Numero"].HeaderText = "Número";
            dataGridViewUsuarios.Columns["Modificar"].Width = 60;
            dataGridViewUsuarios.Columns["Numero"].Width = 70;
            dataGridViewUsuarios.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void cargarDataGridViewUsuarios(DataTable dataTableUsuariosX)
        {
            dataViewUsuarios.Table = dataTableUsuariosX;
            dataGridViewUsuarios.DataSource = dataViewUsuarios;
            records = dataGridViewUsuarios.Rows.Count;
            if (records > 0)
            {
                setDataGridViewUsuariosFormat();
                dataGridViewUsuarios.ColumnHeadersVisible = true;
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
        private void actualizarDataGridViewUsuarios()
        {
            cargarDataGridViewUsuarios(objetoUsuario.searchAll());
            filterDataGridViewUsuarios();
        }
        #endregion
    }
}