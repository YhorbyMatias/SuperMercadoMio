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

namespace Super_Mercado_Mio.Grupo
{
    public partial class Eliminar : Form
    {
        #region Objetos
        int records = 0;
        GrupoBss objetoGrupo = new GrupoBss();
        GrupoEnt grupo = new GrupoEnt();
        DataView dataViewGrupos = new DataView();
        #endregion
        #region Form
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            loadDataGridViewGrupos(objetoGrupo.searchRemovable());
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
        #region buttonEliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrupos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el grupo?", "Eliminar Grupo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    grupo.ID = Convert.ToInt32(dataGridViewGrupos.SelectedRows[0].Cells["Id"].Value);
                    grupo.ESTADO = false;
                    objetoGrupo.delete(grupo);
                    MessageBox.Show("El grupo fue eliminado.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        private void setDataGridViewGruposFormat()
        {
            dataGridViewGrupos.Columns["Id"].Visible = false;
            dataGridViewGrupos.Columns["Numero"].HeaderText = "Número";
            dataGridViewGrupos.Columns["Numero"].Width = 70;
            dataGridViewGrupos.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void loadDataGridViewGrupos(DataTable dataTableProveedoresX)
        {
            dataViewGrupos.Table = dataTableProveedoresX;
            dataGridViewGrupos.DataSource = dataViewGrupos;
            records = dataGridViewGrupos.Rows.Count;
            if (records > 0)
            {
                setDataGridViewGruposFormat();
                dataGridViewGrupos.ColumnHeadersVisible = true;
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
        #endregion
    }
}