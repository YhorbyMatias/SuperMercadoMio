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

namespace Super_Mercado_Mio.Empresa
{
    public partial class Datos : Form
    {
        #region Objetos
        EmpresaBss objetoEmpresa = new EmpresaBss();
        #endregion
        #region Formulario
        public Datos()
        {
            InitializeComponent();
        }
        private void Datos_Load(object sender, EventArgs e)
        {
            if (objetoEmpresa.exists() == 1)
            {
                cargarInformacionDeEmpresa();
            }
            else
            {
                MessageBox.Show("La empresa no fue registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Metodos Propios
        private void cargarInformacionDeEmpresa()
        {
            DataTable dataTableEmpresa = objetoEmpresa.search();
            textBoxPropietario.Text = dataTableEmpresa.Rows[0]["Propietario"].ToString();
            textBoxRazonSocial.Text = dataTableEmpresa.Rows[0]["Razon_Social"].ToString();
            textBoxNit.Text = dataTableEmpresa.Rows[0]["Nit"].ToString();
            textBoxActividadEconomica.Text = dataTableEmpresa.Rows[0]["Actividad_Economica"].ToString();
        }
        #endregion
    }
}