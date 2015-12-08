using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mercado_Mio.Compra
{
    public partial class Resultados : Form
    {
        #region Objects
        public int index = -1;
        DataTable purchases;
        #endregion
        #region Form
        public Resultados(DataTable purchases)
        {
            InitializeComponent();
            this.purchases = purchases;
        }
        private void Resultados_Load(object sender, EventArgs e)
        {
            purchasesDataGridView.DataSource = purchases;
            formatPurchasesDataGridView();
        }
        #endregion
        #region purchasesDataGridView
        private void purchasesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                this.Close();
            }
        }
        #endregion
        #region Methods
        private void formatPurchasesDataGridView()
        {
            for (int columnIndex = 0; columnIndex < purchasesDataGridView.Columns.Count; columnIndex++)
            {
                purchasesDataGridView.Columns[columnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            purchasesDataGridView.Columns["Id"].Visible = false;
            purchasesDataGridView.Columns["Observaciones"].Visible = false;
            purchasesDataGridView.Columns["Numero_De_Registro"].HeaderText = "Nº de Registro";
            purchasesDataGridView.Columns["Numero_De_Nota_De_Entrega"].HeaderText = "Nº de Nota de Entrega";
            purchasesDataGridView.Columns["Numero_De_Registro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            purchasesDataGridView.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            purchasesDataGridView.Columns["Nit"].Width = 80;
            purchasesDataGridView.Columns["Proveedor"].Width = 300;
            purchasesDataGridView.Columns["Fecha"].Width = 80;
            purchasesDataGridView.Columns["Monto"].Width = 80;
            purchasesDataGridView.Columns["Estado"].Width = 80;
            purchasesDataGridView.Columns["Monto"].Width = 100;
        }
        #endregion
    }
}