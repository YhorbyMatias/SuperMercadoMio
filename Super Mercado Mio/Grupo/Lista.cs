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

namespace Super_Mercado_Mio.Grupo
{
    public partial class Lista : Form
    {
        #region Objetos
        int opcion = 0;
        int records = 0;
        GrupoBss objetoGrupo = new GrupoBss();
        DataView dataViewGrupos = new DataView();
        #endregion
        #region Form
        public Lista(int opcionX)
        {
            InitializeComponent();
            opcion = opcionX;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            if (opcion == 2)
            {
                dataGridViewGrupos.Columns["Modificar"].Visible = true;
            }
            loadDataGridViewGrupos(objetoGrupo.searchAll());
        }
        #endregion
        #region textBoxBuscar
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewGrupos();
            }
        }
        #endregion
        #region dataGridViewGrupos
        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Grupo.Modificar formularioModificarGrupo = new Modificar(Convert.ToInt32(dataGridViewGrupos["Id_Grupo", e.RowIndex].Value),
                            this.refreshDataGridViewGrupos);
                    formularioModificarGrupo.MdiParent = this.MdiParent;
                    this.Hide();
                    formularioModificarGrupo.Show();
                }
            }
        }
        #endregion
        #region Metodos Propios
        private void loadDataGridViewGrupos(DataTable dataTableProveedoresX)
        {
            dataViewGrupos.Table = dataTableProveedoresX;
            dataGridViewGrupos.DataSource = dataViewGrupos;
            records = dataGridViewGrupos.Rows.Count;
            if (records > 0)
            {
                dataGridViewGrupos.ColumnHeadersVisible = true;
                dataGridViewGrupos.Columns["Id_Grupo"].Visible = false;
                dataGridViewGrupos.Columns["Numero"].HeaderText = "Número";
                dataGridViewGrupos.Sort(dataGridViewGrupos.Columns["Nombre"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewGrupos.DataSource = null;
                dataGridViewGrupos.ColumnHeadersVisible = false;
            }
        }
        private void filterDataGridViewGrupos()
        {
            if (records > 0)
            {
                if (dataGridViewGrupos.SortedColumn.ValueType == typeof(int))
                {
                    if (ValidacionBss.esEntero(textBoxBuscar.Text.Trim()))
                    {
                        dataViewGrupos.RowFilter = dataGridViewGrupos.SortedColumn.Name.ToString() + " = "
                            + textBoxBuscar.Text.Trim();
                    }
                    else
                    {
                        dataViewGrupos.RowFilter = dataGridViewGrupos.SortedColumn.Name.ToString() + " = -1";
                    }
                }
                else
                {
                    dataViewGrupos.RowFilter = dataGridViewGrupos.SortedColumn.Name.ToString() +
                                                 " Like '%" + textBoxBuscar.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        private void refreshDataGridViewGrupos()
        {
            loadDataGridViewGrupos(objetoGrupo.searchAll());
            filterDataGridViewGrupos();
        }
        #endregion
    }
}