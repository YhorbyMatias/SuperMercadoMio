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
        ProductoEnt producto = new ProductoEnt();
        DataView dataViewProductos = new DataView();
        #endregion
        #region Form
        public Lista(int opcionX)
        {
            InitializeComponent();
            opcion = opcionX;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            if (opcion == 1 || opcion == 2)
            {
                loadDataGridViewProductos(objetoProducto.searchAll());
            }
            else if (opcion == 3)
            {
                loadDataGridViewProductos(objetoProducto.selectAll());
            }
            else if (opcion == 4)
            {
                loadDataGridViewProductos(objetoProducto.findAll());
            }
        }
        #endregion
        #region textBoxCodigo
        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxNombreGenerico
        private void textBoxNombreGenerico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxMarca
        private void textBoxMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxPresentacion
        private void textBoxPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxSaborUOlor
        private void textBoxSaborUOlor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxProveedor
        private void textBoxProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
            }
        }
        #endregion
        #region textBoxGrupo
        private void textBoxGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewProveedores();
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
                        new Modificar(Convert.ToInt32(dataGridViewProductos["Id_Producto", e.RowIndex].Value));
                    formularioModificarProducto.MdiParent = this.MdiParent;
                    this.Close();
                    formularioModificarProducto.Show();
                }
            }
        }
        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opcion == 3 || opcion == 4)
            {
                producto.ID_PRODUCTO = Convert.ToInt32(dataGridViewProductos["Id_Producto", e.RowIndex].Value);
                producto.CODIGO_DE_BARRAS = dataGridViewProductos["Codigo_De_Barras", e.RowIndex].Value.ToString();
                this.Close();
            }
        }
        #endregion
        #region Metodos Propios
        private void setDataGridViewProductosFormat()
        {
            dataGridViewProductos.Columns["Id_Producto"].Visible = false;
            if (opcion == 1)
            {
                dataGridViewProductos.Columns["Modificar"].Visible = false;
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
            else if (opcion == 2)
            {
                dataGridViewProductos.Columns["Modificar"].Visible = true;
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
            else if (opcion == 3)
            {
                dataGridViewProductos.Columns["Modificar"].Visible = false;
                dataGridViewProductos.Columns["Codigo_De_Barras"].HeaderText = "Código de Barras";
                dataGridViewProductos.Columns["Nombre_Generico"].HeaderText = "Nombre Genérico";
                dataGridViewProductos.Columns["Presentacion"].HeaderText = "Presentación";
                dataGridViewProductos.Columns["Sabor_U_Olor"].HeaderText = "Sabor U Olor";
                dataGridViewProductos.Columns["Precio_De_Compra"].HeaderText = "Precio de Compra";
                dataGridViewProductos.Columns["Precio_De_Venta"].HeaderText = "Precio de Venta";
                dataGridViewProductos.Columns["Codigo_De_Barras"].Width = 100;
                dataGridViewProductos.Columns["Nombre_Generico"].Width = 100;
                dataGridViewProductos.Columns["Marca"].Width = 125;
                dataGridViewProductos.Columns["Presentacion"].Width = 80;
                dataGridViewProductos.Columns["Sabor_U_Olor"].Width = 80;
                dataGridViewProductos.Columns["Precio_De_Compra"].Width = 70;
                dataGridViewProductos.Columns["Precio_De_Venta"].Width = 70;
                dataGridViewProductos.Columns["Precio_De_Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewProductos.Columns["Precio_De_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewProductos.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewProductos.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewProductos.Columns["Nombre_Generico"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewProductos.Columns["Marca"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
        private void loadDataGridViewProductos(DataTable dataTableProductosX)
        {
            dataViewProductos.Table = dataTableProductosX;
            dataGridViewProductos.DataSource = dataViewProductos;
            records = dataGridViewProductos.Rows.Count;
            if (records > 0)
            {
                setDataGridViewProductosFormat();
                dataGridViewProductos.ColumnHeadersVisible = true;
            }
            else
            {
                dataGridViewProductos.DataSource = null;
                dataGridViewProductos.ColumnHeadersVisible = false;
            }
        }
        private void filterDataGridViewProveedores()
        {
            if (records > 0)
            {
                if (textBoxCodigo.Text.Trim() != "")
                {
                    dataViewProductos.RowFilter = "Codigo = " + textBoxCodigo.Text.Trim();
                }
                else
                {
                    dataViewProductos.RowFilter = "Nombre_Generico Like '%" + textBoxNombreGenerico.Text.Trim().ToUpper() + "%'"
                        + "Or Marca Like '%" + textBoxMarca.Text.Trim().ToUpper() + "%'"
                        + "Or Presentacion Like '%" + textBoxPresentacion.Text.Trim().ToUpper() + "%'"
                        + "Or Sabor_U_Olor Like '%" + textBoxSaborUOlor.Text.Trim().ToUpper() + "%'"
                        + "Or Proveedor Like '%" + textBoxProveedor.Text.Trim().ToUpper() + "%'"
                        + "Or Grupo Like '%" + textBoxGrupo.Text.Trim().ToUpper() + "%'";
                }
            }
        }
        #endregion
    }
}