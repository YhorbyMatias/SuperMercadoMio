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

namespace Super_Mercado_Mio.Proveedor
{
    public partial class Lista : Form
    {
        #region Objetos
        int opcion = 0;
        int records = 0;
        ProveedorBss objetoProveedor = new ProveedorBss();
        DataView dataViewProveedores = new DataView();
        #endregion
        #region Form
        public Lista(int opcionX)
        {
            InitializeComponent();
            opcion = opcionX;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            loadDataGridViewProveedores(objetoProveedor.searchAll());
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
        #region dataGridViewProveedores
        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Proveedor.Ficha formularioFichaDeProveedor =
                        new Ficha(Convert.ToInt32(dataGridViewProveedores["Id_Proveedor", e.RowIndex].Value));
                    formularioFichaDeProveedor.ShowDialog();
                }
                if (e.ColumnIndex == 1)
                {
                    Proveedor.Modificar formularioModificarProveedor =
                        new Modificar(Convert.ToInt32(dataGridViewProveedores["Id_Proveedor", e.RowIndex].Value),
                            this.refreshDataGridViewProveedores);
                    formularioModificarProveedor.MdiParent = this.MdiParent;
                    this.Hide();
                    formularioModificarProveedor.Show();
                }
            }
        }
        #endregion
        #region Metodos Propios
        private void setDataGridViewProveedoresFormat()
        {
            if (opcion == 1)
            {
                dataGridViewProveedores.Columns["Ficha"].Visible = true;
            }
            if (opcion == 2)
            {
                dataGridViewProveedores.Columns["Modificar"].Visible = true;
            }
            dataGridViewProveedores.Columns["Id_Proveedor"].Visible = false;
            dataGridViewProveedores.Columns["Numero"].HeaderText = "Número";
            dataGridViewProveedores.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridViewProveedores.Columns["Ficha"].Width = 60;
            dataGridViewProveedores.Columns["Modificar"].Width = 60;
            dataGridViewProveedores.Columns["Numero"].Width = 70;
            dataGridViewProveedores.Columns["Nit"].Width = 100;
            dataGridViewProveedores.Columns["Nombre"].Width = 350;
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
        private void refreshDataGridViewProveedores()
        {
            loadDataGridViewProveedores(objetoProveedor.searchAll());
            filterDataGridViewProveedores();
        }
        #endregion
    }
}