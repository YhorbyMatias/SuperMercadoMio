﻿using Bss;
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
    public partial class Modificar : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { false };
        CajaBss cashboxObject = new CajaBss();
        CajaEnt cashbox = new CajaEnt();
        #endregion
        #region Form
        public Modificar(int cashBoxId)
        {
            InitializeComponent();
            cashbox.ID = cashBoxId;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            loadFormData();
        }
        #endregion
        #region textBoxNumero
        private void textBoxNumero_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewNumber();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNumero, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors())
            {
                cashbox.NUMERO = textBoxNumero.Text.Trim();
                cashboxObject.update(cashbox);
                MessageBox.Show("Los datos fueron guardados correctamente.", "Operación Exitosa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
        private int authenticateNumber()
        {
            cashbox.NUMERO = textBoxNumero.Text.Trim();
            if (cashboxObject.authenticateNumber(cashbox) == 0)
            {
                return 0;
            }
            else
            {
                return 300;
            }
        }
        private bool checkForErrors()
        {
            int errorCode = authenticateNumber();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNumero, ValidacionBss.getErrorMessage(errorCode));
            int errorPosition = hasErrors.ToList().IndexOf(true);
            if (errorPosition == -1)
            {
                return true;
            }
            else
            {
                switch (errorPosition)
                {
                    case 0:
                        textBoxNumero.Focus();
                        break;
                }
                return false;
            }
        }
        private void loadFormData()
        {
            DataTable cashboxDataTable = cashboxObject.getById(cashbox);
            textBoxNumero.Text = cashboxDataTable.Rows[0]["Numero"].ToString();
        }
        private int reviewNumber()
        {
            if (textBoxNumero.Text.Trim() != "")
            {
                if (ValidacionBss.esEntero(textBoxNumero.Text.Trim()) == true)
                {
                    return authenticateNumber();
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }
        #endregion
    }
}