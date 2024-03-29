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

namespace Super_Mercado_Mio.Cliente
{
    public partial class Modificar : Form
    {
        #region Objetos
        bool isWritable = true;
        bool[] hasErrors = new bool[] { false, false };
        ClienteBss objetoCliente = new ClienteBss();
        ClienteEnt cliente = new ClienteEnt();
        #endregion
        #region Form
        public Modificar(int idCliente)
        {
            InitializeComponent();
            cliente.ID = idCliente;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            loadFormData();
        }
        #endregion
        #region textBoxCiONit
        private void textBoxCiONit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Clipboard.SetText(Clipboard.GetText().Trim());
                if (ValidacionBss.esCiONit(Clipboard.GetText()) == false)
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
        private void textBoxCiONit_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBoxCiONit_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewCiONit();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombre
        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = reviewName();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNombre, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (checkForErrors())
            {
                cliente.CI_O_NIT = textBoxCiONit.Text.Trim();
                cliente.NOMBRE = textBoxNombre.Text.ToUpper().Trim();
                cliente.ESTADO = true;
                objetoCliente.update(cliente);
                MessageBox.Show("Los datos fueron guardados correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool authenticateCiONit()
        {
            if (textBoxCiONit.Text.Trim() != "0" && textBoxCiONit.Text.Trim() != "00")
            {
                cliente.CI_O_NIT = textBoxCiONit.Text.Trim();
                cliente.ESTADO = true;
                if (objetoCliente.authenticateCiONit(cliente) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        private bool authenticateName()
        {
            if (textBoxCiONit.Text.Trim() != "0" && textBoxCiONit.Text.Trim() != "00")
            {
                cliente.NOMBRE = textBoxNombre.Text.ToUpper().Trim();
                cliente.ESTADO = true;
                if (objetoCliente.authenticateName(cliente) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        private bool checkForErrors()
        {
            int errorCode = reviewCiONit();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxCiONit, ValidacionBss.getErrorMessage(errorCode));
            errorCode = reviewName();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProvider.SetError(textBoxNombre, ValidacionBss.getErrorMessage(errorCode));
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
                        textBoxCiONit.Focus();
                        break;
                    case 1:
                        textBoxNombre.Focus();
                        break;
                }
                return false;
            }
        }
        private void loadFormData()
        {
            DataTable dataTable = objetoCliente.getById(cliente);
            textBoxCiONit.Text = dataTable.Rows[0]["Ci_O_Nit"].ToString();
            textBoxNombre.Text = dataTable.Rows[0]["Nombre"].ToString();
        }
        private int reviewCiONit()
        {
            if (textBoxCiONit.Text.Trim() != "")
            {
                if (ValidacionBss.esCiONit(textBoxCiONit.Text.Trim()) == true)
                {
                    if (authenticateCiONit())
                    {
                        return 0;
                    }
                    else
                    {
                        return 500;
                    }
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
        private int reviewName()
        {
            if (textBoxNombre.Text.Trim() != "")
            {
                if (authenticateName())
                {
                    return 0;
                }
                else
                {
                    return 501;
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