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

namespace Super_Mercado_Mio.Producto
{
    public partial class Nuevo : Form
    {
        #region Objetos
        ProductoBss objetoProducto = new ProductoBss();
        #endregion
        #region Form
        public Nuevo()
        {
            InitializeComponent();
        }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            loadMarcas();
        }
        #endregion
        #region Metodos Propios
        private void loadMarcas()
        {
            var marcas = new AutoCompleteStringCollection();
            DataTable dataTableMarcas = objetoProducto.searchMarcas();
            for (int filas = 0; filas < dataTableMarcas.Rows.Count; filas++)
            {
                marcas.Add(dataTableMarcas.Rows[filas][0].ToString());
            }
            textBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxMarca.AutoCompleteCustomSource = marcas;
        }
        #endregion
    }
}