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

namespace Super_Mercado_Mio.Sucursal
{
    public partial class Datos : Form
    {
        #region Objetos
        SucursalBss objetoSucursal = new SucursalBss();
        #endregion
        #region Formulario
        public Datos()
        {
            InitializeComponent();
        }
        private void Datos_Load(object sender, EventArgs e)
        {
            if (objetoSucursal.exists() == 1)
            {
                cargarInformacionDeSucursal();
            }
            else
            {
                MessageBox.Show("La sucursal no fue registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Metodos Propios
        private void cargarInformacionDeSucursal()
        {
            DataTable dataTableSucursal = objetoSucursal.search();
            textBoxEmpresa.Text = dataTableSucursal.Rows[0]["Razon_Social"].ToString();
            textBoxNit.Text = dataTableSucursal.Rows[0]["Nit"].ToString();
            textBoxNumero.Text = dataTableSucursal.Rows[0]["Numero"].ToString();
            textBoxDireccion.Text = dataTableSucursal.Rows[0]["Direccion"].ToString();
            textBoxTelefono.Text = dataTableSucursal.Rows[0]["Telefono"].ToString();
            textBoxMunicipio.Text = dataTableSucursal.Rows[0]["Municipio"].ToString();
        }
        #endregion
    }
}