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
    public partial class Busqueda : Form
    {
        #region Objetos
        DataTable dataTableProveedores = new DataTable();
        public int row = -1;
        #endregion
        #region Form
        public Busqueda(DataTable dataTableProveedores)
        {
            InitializeComponent();
            this.dataTableProveedores = dataTableProveedores;
        }
        private void Busqueda_Load(object sender, EventArgs e)
        {
            loadDataGridViewProveedores();
            formatDataGridViewProveedores();
        }
        #endregion
        #region dataGridViewProveedores
        private void dataGridViewProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            this.Close();
        }
        #endregion
        #region Metodos Propios
        private void formatDataGridViewProveedores()
        {
            for (int columnIndex = 0; columnIndex < dataGridViewProveedores.Columns.Count; columnIndex++)
            {
                dataGridViewProveedores.Columns[columnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void loadDataGridViewProveedores()
        {
            dataGridViewProveedores.DataSource = dataTableProveedores;
            dataGridViewProveedores.Columns["Id"].Visible = false;
        }
        #endregion
    }
}