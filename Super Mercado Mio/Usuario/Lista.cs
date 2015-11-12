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
        int option = 0;
        int records = 0;
        UsuarioBss objetoUsuario = new UsuarioBss();
        DataView dataViewUsers = new DataView();
        #endregion
        #region Form
        public Lista(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            loadDataGridViewUsers(objetoUsuario.searchAll());
        }
        #endregion
        #region textBoxBuscar
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewUsers();
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
                    Usuario.Modificar formModificarUsuario = new Modificar(Convert.ToInt32(dataGridViewUsuarios["Id", e.RowIndex].Value));
                    formModificarUsuario.MdiParent = this.MdiParent;
                    this.Hide();
                    formModificarUsuario.Show();
                }
            }
        }
        #endregion
        #region Metodos Propios
        private void filterDataGridViewUsers()
        {
            if (records > 0)
            {
                if (dataGridViewUsuarios.SortedColumn.ValueType == typeof(int))
                {
                    if (ValidacionBss.esEntero(textBoxBuscar.Text.Trim()))
                    {
                        dataViewUsers.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() + " = " + textBoxBuscar.Text.Trim();
                    }
                    else
                    {
                        dataViewUsers.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() + " = -1";
                    }
                }
                else
                {
                    dataViewUsers.RowFilter = dataGridViewUsuarios.SortedColumn.Name.ToString() +
                                                 " Like '%" + textBoxBuscar.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        private void formatDataGridViewUsers()
        {
            if (option == 2)
            {
                dataGridViewUsuarios.Columns["Modificar"].Visible = true;
            }
            dataGridViewUsuarios.Columns["Id"].Visible = false;
            dataGridViewUsuarios.Columns["Numero"].HeaderText = "Nº";
            dataGridViewUsuarios.Columns["Modificar"].Width = 60;
            dataGridViewUsuarios.Columns["Numero"].Width = 70;
            dataGridViewUsuarios.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void loadDataGridViewUsers(DataTable dataTableUsers)
        {
            dataViewUsers.Table = dataTableUsers;
            dataGridViewUsuarios.DataSource = dataViewUsers;
            records = dataGridViewUsuarios.Rows.Count;
            if (records > 0)
            {
                formatDataGridViewUsers();
                dataGridViewUsuarios.ColumnHeadersVisible = true;
                dataGridViewUsuarios.Sort(dataGridViewUsuarios.Columns["Usuario"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewUsuarios.DataSource = null;
                dataGridViewUsuarios.ColumnHeadersVisible = false;
            }
        }
        #endregion
    }
}