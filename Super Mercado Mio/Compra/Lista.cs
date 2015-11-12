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

namespace Super_Mercado_Mio.Compra
{
    public partial class Lista : Form
    {
        #region Objetos
        int option = 0;
        bool isWritable = true;
        bool isValidDate = true;
        IngresoBss objetoIngreso = new IngresoBss();
        IngresoEnt ingreso = new IngresoEnt();
        ProductoEnt producto = new ProductoEnt();
        #endregion
        #region Form
        public Lista(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region toolStripButtonSearch
        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            clearData();
        }
        #endregion
        #region toolStripButtonFirst
        private void toolStripButtonFirst_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region toolStripButtonPrevious
        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region toolStripButtonNext
        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region toolStripButtonLast
        private void toolStripButtonLast_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region textBoxNit
        private void textBoxNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esNit(Clipboard.GetText()) == false)
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
                if (textBoxNit.ReadOnly == false)
                {

                }
            }
        }
        private void textBoxNit_KeyPress(object sender, KeyPressEventArgs e)
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
        #region textBoxProveedor
        private void textBoxProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBoxProveedor.ReadOnly == false)
                {

                }
            }
        }
        #endregion
        #region maskedTextBoxFecha
        private void maskedTextBoxFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (maskedTextBoxFecha.ReadOnly == false)
                {

                }
            }
        }
        private void maskedTextBoxFecha_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (maskedTextBoxFecha.Text.Trim() != "/  /")
            {
                if (!e.IsValidInput)
                {
                    isValidDate = false;
                    errorProvider.SetError(maskedTextBoxFecha, "La fecha debe tener el formato dd/mm/aaaa.");
                }
                else
                {
                    isValidDate = true;
                    errorProvider.SetError(maskedTextBoxFecha, null);
                }
            }
        }
        #endregion
        #region textBoxNumeroDeRegistro
        private void textBoxNumeroDeRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esNit(Clipboard.GetText()) == false)
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
        private void textBoxNumeroDeRegistro_KeyPress(object sender, KeyPressEventArgs e)
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
        #region Methods
        private void clearData()
        {
            textBoxNit.ResetText();
            textBoxProveedor.ResetText();
            maskedTextBoxFecha.ResetText();
            textBoxNumeroDeRegistro.ResetText();
            textBoxNumeroDeNotaDeEntrega.ResetText();
            textBoxMonto.ResetText();
            textBoxObservaciones.ResetText();
            textBoxCodigoDeBarras.ResetText();
            textBoxNit.ReadOnly = false;
            textBoxProveedor.ReadOnly = false;
            maskedTextBoxFecha.ReadOnly = false;
            textBoxNumeroDeRegistro.ReadOnly = false;
            textBoxNumeroDeNotaDeEntrega.ReadOnly = false;
            textBoxNit.ContextMenuStrip = contextMenuStripEmpty;
            textBoxNumeroDeRegistro.ContextMenuStrip = contextMenuStripEmpty;
            dataGridViewDetalleDeIngreso.Rows.Clear();
        }
        #endregion
    }
}