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

namespace Super_Mercado_Mio.Grupo
{
    public partial class Nuevo : Form
    {
        #region Objetos
        bool[] hasErrors = new bool[] { true };
        GrupoBss objetoGrupo = new GrupoBss();
        public GrupoEnt grupo = new GrupoEnt();
        #endregion
        #region Form
        public Nuevo()
        {
            InitializeComponent();
        }
        #endregion
        #region textBoxNombre
        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNombre();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombre, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                grupo.ID = objetoGrupo.add(grupo);
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
        #region Metodos Propios
        private int validarNombre()
        {
            if (textBoxNombre.Text.Trim() != "")
            {
                if (verificarNombre())
                {
                    return 0;
                }
                else
                {
                    return 600;
                }
            }
            else
            {
                return 1;
            }
        }
        public bool verificarNombre()
        {
            grupo.NOMBRE = textBoxNombre.Text.Trim().ToUpper();
            if (objetoGrupo.authenticate(grupo) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validaciones()
        {
            int errorPosition = hasErrors.ToList().IndexOf(true);
            if (errorPosition == -1)
            {
                return true;
            }
            else
            {
                textBoxNombre.Focus();
                return false;
            }
        }
        #endregion
    }
}