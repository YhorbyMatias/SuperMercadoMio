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

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxNombreGenerico_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxMarca_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxPresentacion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSaborUOlor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxProveedor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxGrupo_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #region Metodos Propios
        private void filterDataGridViewProveedores()
        {
            if (records > 0)
            {
                if (textBoxCodigo.Text.Trim() != "")
                {
                    if (!textBoxCodigo.Text.Trim()[0].Equals('M') || !textBoxCodigo.Text.Trim()[0].Equals('m'))
                    {
                        dataViewProductos.RowFilter = dataGridViewProductos.SortedColumn.Name.ToString() + " = "
                            + textBoxCodigo.Text.Trim();
                    }
                }
                else
                {
                    dataViewProductos.RowFilter = dataGridViewProductos.SortedColumn.Name.ToString() + " = -1";
                }
            }
        }
        #endregion
    }
}