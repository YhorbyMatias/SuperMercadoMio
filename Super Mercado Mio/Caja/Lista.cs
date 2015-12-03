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

namespace Super_Mercado_Mio.Caja
{
    public partial class Lista : Form
    {
        #region Objects
        int option = 0;
        bool isWritable = true;
        CajaBss cashboxObject = new CajaBss();
        DataView cashboxDataView = new DataView();
        #endregion
        #region Form
        public Lista(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            loadCashboxDataGridView();
        }
        #endregion
        #region numberTextBox
        private void numberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esEntero(Clipboard.GetText()) == false)
                {
                    e.Handled = true;
                    isWritable = false;
                }
                else
                {
                    isWritable = true;
                }
            }
            if (e.KeyValue == 13)
            {
                cashboxDataView.RowFilter = "Numero = " + numberTextBox.Text.Trim();
            }
        }
        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (char.IsDigit(e.KeyChar) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                isWritable = true;
                e.Handled = true;
            }
        }
        #endregion
        #region cashboxDataGridView
        private void cashboxDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Caja.Modificar formUpdateCashbox = new Modificar(Convert.ToInt32(cashboxDataGridView["Id", e.RowIndex].Value));
                    formUpdateCashbox.MdiParent = this.MdiParent;
                    this.Close();
                    formUpdateCashbox.Show();
                }
            }
        }
        #endregion
        #region Methods
        private void formatCashBoxDataGridView()
        {
            cashboxDataGridView.Columns["Numero"].Width = 100;
        }
        private void loadCashboxDataGridView()
        {
            cashboxDataView.Table = cashboxObject.getAll();
            if (cashboxDataView.Count > 0)
            {
                cashboxDataGridView.DataSource = cashboxDataView;
                if (option == 2)
                {
                    cashboxDataGridView.Columns["Modificar"].Visible = true;
                }
                cashboxDataGridView.Columns["Id"].Visible = false;
                cashboxDataGridView.Columns["Nombre_De_Equipo"].HeaderText = "Nombre del Equipo";
                cashboxDataGridView.Columns["Numero"].HeaderText = "Número de Caja";
                formatCashBoxDataGridView();
            }
            else
            {
                cashboxDataGridView.ColumnHeadersVisible = false;
            }
        }
        #endregion
    }
}
