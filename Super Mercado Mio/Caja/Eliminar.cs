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

namespace Super_Mercado_Mio.Caja
{
    public partial class Eliminar : Form
    {
        #region Objects
        bool isWritable = true;
        CajaBss cashboxObject = new CajaBss();
        CajaEnt cashbox = new CajaEnt();
        DataView cashboxDataView = new DataView();
        #endregion
        #region Form
        public Eliminar()
        {
            InitializeComponent();
        }
        private void Eliminar_Load(object sender, EventArgs e)
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
        #region deleteButton
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (cashboxDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar esta caja?", "Eliminar Caja", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cashbox.ID = Convert.ToInt32(cashboxDataGridView.SelectedRows[0].Cells["Id"].Value);
                    cashboxObject.delete(cashbox);
                    MessageBox.Show("La caja fue eliminada.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        #endregion
        #region closeButton
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void formatCashBoxDataGridView()
        {
            cashboxDataGridView.Columns["Numero"].Width = 100;
        }
        private void loadCashboxDataGridView()
        {
            cashboxDataView.Table = cashboxObject.getAllRemovable();
            if (cashboxDataView.Count > 0)
            {
                cashboxDataGridView.DataSource = cashboxDataView;
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