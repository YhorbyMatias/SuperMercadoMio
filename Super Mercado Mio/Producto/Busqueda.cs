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
    public partial class Busqueda : Form
    {
        #region Objects
        int option = 0;
        int records = 0;
        ProductoBss productObject = new ProductoBss();
        public ProductoEnt product = new ProductoEnt();
        DataView productDataView = new DataView();
        #endregion
        #region Form
        public Busqueda(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Busqueda_Load(object sender, EventArgs e)
        {
            if (option == 1)
            {
                loadProductsDataGridView(productObject.selectAll());
            }
            else
            {
                loadProductsDataGridView(productObject.findAll());
            }
        }
        #endregion
        #region barcodeTextBox
        private void barcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region genericNameTextBox
        private void genericNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region brandTextBox
        private void brandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region presentationTextBox
        private void presentationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region tasteOrOrdorTextBox
        private void tasteOrOrdorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region providerTextBox
        private void providerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region groupTextBox
        private void groupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProductos();
            }
        }
        #endregion
        #region productsDataGridView
        private void productsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                product.ID = Convert.ToInt32(productsDataGridView["Id", e.RowIndex].Value);
                product.CODIGO_DE_BARRAS = productsDataGridView["Codigo_De_Barras", e.RowIndex].Value.ToString();
                this.Close();
            }
        }
        #endregion
        #region Methods
        private void filterDataGridViewProductos()
        {
            if (records > 0)
            {
                if (barcodeTextBox.Text.Trim() != "")
                {
                    productDataView.RowFilter = "Codigo_De_Barras = '" + barcodeTextBox.Text.Trim() + "'";
                }
                else
                {
                    productDataView.RowFilter = "Nombre_Generico Like '%" + genericNameTextBox.Text.Trim().ToUpper() + "%'"
                        + "And Marca Like '%" + brandTextBox.Text.Trim().ToUpper() + "%'"
                        + "And Presentacion Like '%" + presentationTextBox.Text.Trim().ToUpper() + "%'"
                        + "And Sabor_U_Olor Like '%" + tasteOrOrdorLabel.Text.Trim().ToUpper() + "%'"
                        + "And Proveedor Like '%" + providerTextBox.Text.Trim().ToUpper() + "%'"
                        + "And Grupo Like '%" + groupTextBox.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        private void formatProductsDataGridView()
        {
            if (option == 1)
            {
                productsDataGridView.Columns["Precio_De_Compra"].Width = 70;
                productsDataGridView.Columns["Precio_De_Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            productsDataGridView.Columns["Id"].Visible = false;
            productsDataGridView.Columns["Codigo_De_Barras"].HeaderText = "Código de Barras";
            productsDataGridView.Columns["Nombre_Generico"].HeaderText = "Nombre Genérico";
            productsDataGridView.Columns["Presentacion"].HeaderText = "Presentación";
            productsDataGridView.Columns["Sabor_U_Olor"].HeaderText = "Sabor U Olor";
            productsDataGridView.Columns["Precio_De_Compra"].HeaderText = "Precio de Compra";
            productsDataGridView.Columns["Precio_De_Venta"].HeaderText = "Precio de Venta";
            productsDataGridView.Columns["Codigo_De_Barras"].Width = 100;
            productsDataGridView.Columns["Nombre_Generico"].Width = 100;
            productsDataGridView.Columns["Marca"].Width = 125;
            productsDataGridView.Columns["Presentacion"].Width = 80;
            productsDataGridView.Columns["Sabor_U_Olor"].Width = 80;
            productsDataGridView.Columns["Precio_De_Venta"].Width = 70;
            productsDataGridView.Columns["Precio_De_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productsDataGridView.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsDataGridView.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsDataGridView.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsDataGridView.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void loadProductsDataGridView(DataTable productDataTable)
        {
            productDataView.Table = productDataTable;
            productsDataGridView.DataSource = productDataView;
            records = productsDataGridView.Rows.Count;
            if (records > 0)
            {
                formatProductsDataGridView();
                productsDataGridView.ColumnHeadersVisible = true;
            }
            else
            {
                productsDataGridView.DataSource = null;
                productsDataGridView.ColumnHeadersVisible = false;
            }
        }
        #endregion
    }
}