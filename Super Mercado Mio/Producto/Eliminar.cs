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
    public partial class Eliminar : Form
    {
        #region Objects
        int records = 0;
        ProductoBss productObject = new ProductoBss();
        public ProductoEnt product = new ProductoEnt();
        DataView productDataView = new DataView();
        #endregion
        #region Form
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            loadDataGridViewProductos(productObject.searchAllRemovable());
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
        #region buttonEliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    product.ID = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["Id"].Value);
                    productObject.delete(product);
                    MessageBox.Show("El producto fue eliminado.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #region Methods
        private void filterDataGridViewProductos()
        {
            if (records > 0)
            {
                if (textBoxCodigoDeBarras.Text.Trim() != "")
                {
                    productDataView.RowFilter = "Codigo_De_Barras = '" + textBoxCodigoDeBarras.Text.Trim() + "'";
                }
                else
                {
                    productDataView.RowFilter = "Nombre_Generico Like '%" + textBoxNombreGenerico.Text.Trim().ToUpper() + "%'"
                        + "And Marca Like '%" + textBoxMarca.Text.Trim().ToUpper() + "%'"
                        + "And Presentacion Like '%" + textBoxPresentacion.Text.Trim().ToUpper() + "%'"
                        + "And Sabor_U_Olor Like '%" + textBoxSaborUOlor.Text.Trim().ToUpper() + "%'"
                        + "And Proveedor Like '%" + textBoxProveedor.Text.Trim().ToUpper() + "%'"
                        + "And Grupo Like '%" + textBoxGrupo.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        private void formatDataGridViewProductos()
        {

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
        private void loadDataGridViewProductos(DataTable dataTableProductos)
        {
            productDataView.Table = dataTableProductos;
            dataGridViewProductos.DataSource = productDataView;
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
        #endregion
    }
}