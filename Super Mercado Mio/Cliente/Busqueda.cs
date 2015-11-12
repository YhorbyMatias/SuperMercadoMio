using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio.Cliente
{
    public partial class Busqueda : Form
    {
        #region Objetos
        DataTable dataTableClientes = new DataTable();
        public int row = -1;
        #endregion
        #region Form
        public Busqueda(DataTable dataTableClientes)
        {
            InitializeComponent();
            this.dataTableClientes = dataTableClientes;
        }
        private void Busqueda_Load(object sender, EventArgs e)
        {
            loadDataGridViewClientes();
            formatDataGridViewClientes();
        }
        #endregion
        #region dataGridViewClientes
        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            this.Close();
        }
        #endregion
        #region Metodos Propios
        private void formatDataGridViewClientes()
        {
            for (int columnIndex = 0; columnIndex < dataGridViewClientes.Columns.Count; columnIndex++)
            {
                dataGridViewClientes.Columns[columnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void loadDataGridViewClientes()
        {
            dataGridViewClientes.DataSource = dataTableClientes;
            dataGridViewClientes.Columns["Id"].Visible = false;
        }
        #endregion
    }
}