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

namespace Super_Mercado_Mio.Producto
{
    public partial class Lista : Form
    {
        #region Objetos
        int opcion = 0;
        int records = 0;
        ProductoBss objetoProducto = new ProductoBss();
        DataView dataViewProductos = new DataView();
        #endregion
        #region Form
        public Lista(int opcion)
        {
            InitializeComponent();
            this.opcion = opcion;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            loadDataGridViewProductos(objetoProducto.searchAll());
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxNombreGenerico
        private void textBoxNombreGenerico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxMarca
        private void textBoxMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxPresentacion
        private void textBoxPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxSaborUOlor
        private void textBoxSaborUOlor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxProveedor
        private void textBoxProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region textBoxGrupo
        private void textBoxGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region dataGridViewProductos
        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Producto.Modificar formularioModificarProducto =
                        new Modificar(Convert.ToInt32(dataGridViewProductos["Id", e.RowIndex].Value));
                    formularioModificarProducto.MdiParent = this.MdiParent;
                    this.Close();
                    formularioModificarProducto.Show();
                }
            }
        }
        #endregion
        #region Metodos Propios
        private void formatDataGridViewProductos()
        {
            if (opcion == 2)
            {
                dataGridViewProductos.Columns["Modificar"].Visible = true;
            }
            dataGridViewProductos.Columns["Id"].Visible = false;
            dataGridViewProductos.Columns["Tipo_De_Codigo_De_Barras"].Visible = false;
            dataGridViewProductos.Columns["Tipo"].Visible = false;
            dataGridViewProductos.Columns["Alias"].Visible = false;
            dataGridViewProductos.Columns["Codigo_De_Barras"].HeaderText = "Código de Barras";
            dataGridViewProductos.Columns["Nombre_Generico"].HeaderText = "Nombre Genérico";
            dataGridViewProductos.Columns["Presentacion"].HeaderText = "Presentación";
            dataGridViewProductos.Columns["Sabor_U_Olor"].HeaderText = "Sabor U Olor";
            dataGridViewProductos.Columns["Cantidad_Minima"].HeaderText = "Cantidad Mínima";
            dataGridViewProductos.Columns["Precio_De_Compra"].HeaderText = "Precio de Compra";
            dataGridViewProductos.Columns["Precio_De_Venta"].HeaderText = "Precio de Venta";
            dataGridViewProductos.Columns["Proveedor"].Width = 100;
            dataGridViewProductos.Columns["Grupo"].Width = 100;
            dataGridViewProductos.Columns["Codigo_De_Barras"].Width = 100;
            dataGridViewProductos.Columns["Nombre_Generico"].Width = 100;
            dataGridViewProductos.Columns["Marca"].Width = 125;
            dataGridViewProductos.Columns["Presentacion"].Width = 80;
            dataGridViewProductos.Columns["Sabor_U_Olor"].Width = 80;
            dataGridViewProductos.Columns["Cantidad_Minima"].Width = 70;
            dataGridViewProductos.Columns["Precio_De_Compra"].Width = 70;
            dataGridViewProductos.Columns["Precio_De_Venta"].Width = 70;
            dataGridViewProductos.Columns["Cantidad_Minima"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProductos.Columns["Precio_De_Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProductos.Columns["Precio_De_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProductos.Columns["Proveedor"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.Columns["Grupo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void loadDataGridViewProductos(DataTable dataTableProductosX)
        {
            dataViewProductos.Table = dataTableProductosX;
            dataGridViewProductos.DataSource = dataViewProductos;
            records = dataGridViewProductos.Rows.Count;
            if (records > 0)
            {
                formatDataGridViewProductos();
                dataGridViewProductos.ColumnHeadersVisible = true;
            }
            else
            {
                dataGridViewProductos.DataSource = null;
                dataGridViewProductos.ColumnHeadersVisible = false;
            }
        }
        private void filterDataGridViewProductos()
        {
            if (records > 0)
            {
                if (textBoxCodigoDeBarras.Text.Trim() != "")
                {
                    dataViewProductos.RowFilter = "Codigo_De_Barras = '" + textBoxCodigoDeBarras.Text.Trim() + "'";
                }
                else
                {
                    dataViewProductos.RowFilter = "Nombre_Generico Like '%" + textBoxNombreGenerico.Text.Trim().ToUpper() + "%'"
                        + "And Marca Like '%" + textBoxMarca.Text.Trim().ToUpper() + "%'"
                        + "And Presentacion Like '%" + textBoxPresentacion.Text.Trim().ToUpper() + "%'"
                        + "And Sabor_U_Olor Like '%" + textBoxSaborUOlor.Text.Trim().ToUpper() + "%'"
                        + "And Proveedor Like '%" + textBoxProveedor.Text.Trim().ToUpper() + "%'"
                        + "And Grupo Like '%" + textBoxGrupo.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        #endregion
    }
}