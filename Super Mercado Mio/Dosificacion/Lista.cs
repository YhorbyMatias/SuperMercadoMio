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

namespace Super_Mercado_Mio.Dosificacion
{
    public partial class Lista : Form
    {
        #region Objetos
        int option = 0;
        int records = 0;
        bool isWritable = true;
        DosificacionBss objetoDosificacion = new DosificacionBss();
        DosificacionEnt dosificacion = new DosificacionEnt();
        DataView dataViewDosificaciones = new DataView();
        #endregion
        #region Form
        public Lista(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            dosificacion.ID_SUCURSAL = 1;
            loadDataGridViewDosificaciones(objetoDosificacion.searchAll(dosificacion));
        }
        #endregion
        #region textBoxNumeroDeAutorizacion
        private void textBoxNumeroDeAutorizacion_KeyDown(object sender, KeyEventArgs e)
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
        }
        private void textBoxNumeroDeAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (ValidacionBss.isDigitOrControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                isWritable = true;
                e.Handled = true;
            }
        }
        #endregion
        #region dataGridViewDosificaciones
        private void dataGridViewDosificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Dosificacion.Modificar formModificarDosificacion =
                    new Modificar(Convert.ToInt32(dataGridViewDosificaciones["Id", e.RowIndex].Value));
                formModificarDosificacion.MdiParent = this.MdiParent;
                this.Close();
                formModificarDosificacion.Show();
            }
        }
        #endregion
        #region Methods
        private void filterDataGridViewDosificaciones()
        {
            if (records > 0)
            {
                dataViewDosificaciones.RowFilter = "Numero_De_Autorizacion Like '%" + textBoxNumeroDeAutorizacion.Text.Trim() + "%'";
            }
        }
        private void formatDataGridViewDosificaciones()
        {
            if (option == 2)
            {
                dataGridViewDosificaciones.Columns["Modificar"].Visible = true;
            }
            dataGridViewDosificaciones.Columns["Id"].Visible = false;
            dataGridViewDosificaciones.Columns["Numero"].HeaderText = "Nº";
            dataGridViewDosificaciones.Columns["Numero_De_Autorizacion"].HeaderText = "Nº de Autorización";
            dataGridViewDosificaciones.Columns["Fecha_Limite_De_Emision"].HeaderText = "Fecha Límite de Emisión";
            dataGridViewDosificaciones.Columns["Numero_De_Autorizacion"].Width = 125;
            dataGridViewDosificaciones.Columns["Fecha_Limite_De_Emision"].Width = 100;
            dataGridViewDosificaciones.Columns["Leyenda"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void loadDataGridViewDosificaciones(DataTable dataTableDosificaciones)
        {
            dataViewDosificaciones.Table = dataTableDosificaciones;
            dataGridViewDosificaciones.DataSource = dataViewDosificaciones;
            records = dataGridViewDosificaciones.Rows.Count;
            if (records > 0)
            {
                formatDataGridViewDosificaciones();
                dataGridViewDosificaciones.ColumnHeadersVisible = true;
                dataGridViewDosificaciones.Sort(dataGridViewDosificaciones.Columns["Numero"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewDosificaciones.ColumnHeadersVisible = false;
                dataGridViewDosificaciones.DataSource = null;
            }
        }
        #endregion
    }
}