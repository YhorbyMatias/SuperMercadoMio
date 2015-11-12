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

namespace Super_Mercado_Mio.Cliente
{
    public partial class Lista : Form
    {
        #region Objetos
        int option = 0;
        int records = 0;
        ClienteBss objetoCliente = new ClienteBss();
        public ClienteEnt cliente = new ClienteEnt();
        DataView dataViewClientes = new DataView();
        #endregion
        #region Form
        public Lista(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            loadDataGridViewClientes(objetoCliente.getAll());
        }
        #endregion
        #region textBoxBuscar
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                filterDataGridViewClientes();
            }
        }
        #endregion
        #region dataGridViewClientes
        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Cliente.Modificar formModificarCliente = new Modificar(Convert.ToInt32(dataGridViewClientes["Id", e.RowIndex].Value));
                    formModificarCliente.MdiParent = this.MdiParent;
                    this.Close();
                    formModificarCliente.Show();
                }
            }
        }
        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (option == 3)
                {
                    cliente.ID = Convert.ToInt32(dataGridViewClientes["Id", e.RowIndex].Value);
                    cliente.CI_O_NIT = dataGridViewClientes["Ci_O_Nit", e.RowIndex].Value.ToString();
                    cliente.NOMBRE = dataGridViewClientes["Nombre", e.RowIndex].Value.ToString();
                    this.Close();
                }
            }
        }
        #endregion
        #region Methods
        private void filterDataGridViewClientes()
        {
            if (records > 0)
            {
                dataViewClientes.RowFilter = "Nombre Like '%" + textBoxBuscar.Text + "%' Or Ci_O_Nit Like '%" + textBoxBuscar.Text + "%'";
            }
        }
        private void formatDataGridViewClientes()
        {
            if (records > 0)
            {
                dataGridViewClientes.ColumnHeadersVisible = true;
                if (option == 2)
                {
                    dataGridViewClientes.Columns["Modificar"].Visible = true;
                }
                dataGridViewClientes.Columns["Id"].Visible = false;
                dataGridViewClientes.Columns["Ci_O_Nit"].HeaderText = "CI ó NIT";
                dataGridViewClientes.Columns["Nombre"].Width = 350;
                dataGridViewClientes.Columns["Nombre"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
        private void loadDataGridViewClientes(DataTable dataTableClientes)
        {
            dataViewClientes.Table = dataTableClientes;
            dataGridViewClientes.DataSource = dataViewClientes;
            records = dataGridViewClientes.Rows.Count;
            formatDataGridViewClientes();
        }
        #endregion
    }
}