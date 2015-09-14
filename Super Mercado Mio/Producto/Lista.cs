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
        ProductoBss objetoProducto = new ProductoBss();
        ProductoEnt producto = new ProductoEnt();
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
    }
}