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
    public partial class Eliminar : Form
    {
        #region Objects
        int records = 0;
        ClienteBss objetoCliente = new ClienteBss();
        ClienteEnt cliente = new ClienteEnt();
        DataView dataViewClientes = new DataView();
        #endregion
        #region Form
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
        {
            loadDataGridViewClientes(objetoCliente.getRemovable());
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
        #region buttonEliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cliente.ID = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);
                objetoCliente.delete(cliente);
                MessageBox.Show("El cliente fue eliminado.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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