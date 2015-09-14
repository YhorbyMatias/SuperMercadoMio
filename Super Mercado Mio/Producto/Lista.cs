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
        public Lista()
        {
            InitializeComponent();
        }
        private void Lista_Load(object sender, EventArgs e)
        {

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
        #region Metodos Propios
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