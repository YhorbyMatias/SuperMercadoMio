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

namespace Super_Mercado_Mio.Proveedor
{
    public partial class Eliminar : Form
    {
        #region Objetos
        int records = 0;
        ProveedorBss objetoProveedor = new ProveedorBss();
        ProveedorEnt proveedor = new ProveedorEnt();
        DataView dataViewProveedores = new DataView();
        #endregion
        #region Form
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            loadDataGridViewProveedores(objetoProveedor.searchRemovable());
        }
        #endregion
        #region textBoxBuscar
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region buttonEliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el proveedor?", "Eliminar Proveedor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    proveedor.ID = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["Id"].Value);
                    proveedor.ESTADO = false;
                    objetoProveedor.delete(proveedor);
                    MessageBox.Show("El proveedor fue eliminado.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void setDataGridViewProveedoresFormat()
        {
            dataGridViewProveedores.Columns["Id"].Visible = false;
            dataGridViewProveedores.Columns["Numero"].HeaderText = "Número";
            dataGridViewProveedores.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridViewProveedores.Columns["Numero"].Width = 70;
            dataGridViewProveedores.Columns["Nit"].Width = 150;
            dataGridViewProveedores.Columns["Nombre"].Width = 380;
            dataGridViewProveedores.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProveedores.Columns["Nombre"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void loadDataGridViewProveedores(DataTable dataTableProveedoresX)
        {
            dataViewProveedores.Table = dataTableProveedoresX;
            dataGridViewProveedores.DataSource = dataViewProveedores;
            records = dataGridViewProveedores.Rows.Count;
            if (records > 0)
            {
                setDataGridViewProveedoresFormat();
                dataGridViewProveedores.ColumnHeadersVisible = true;
                dataGridViewProveedores.Sort(dataGridViewProveedores.Columns["Nombre"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewProveedores.DataSource = null;
                dataGridViewProveedores.ColumnHeadersVisible = false;
            }
        }
        private void filterDataGridViewProveedores()
        {
            if (records > 0)
            {
                if (dataGridViewProveedores.SortedColumn.ValueType == typeof(int))
                {
                    if (ValidacionBss.esEntero(textBoxBuscar.Text.Trim()))
                    {
                        dataViewProveedores.RowFilter = dataGridViewProveedores.SortedColumn.Name.ToString() + " = "
                            + textBoxBuscar.Text.Trim();
                    }
                    else
                    {
                        dataViewProveedores.RowFilter = dataGridViewProveedores.SortedColumn.Name.ToString() + " = -1";
                    }
                }
                else
                {
                    dataViewProveedores.RowFilter = dataGridViewProveedores.SortedColumn.Name.ToString() +
                                                 " Like '%" + textBoxBuscar.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        #endregion
    }
}