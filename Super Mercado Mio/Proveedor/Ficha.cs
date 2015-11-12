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

namespace Super_Mercado_Mio.Proveedor
{
    public partial class Ficha : Form
    {
        #region Objetos
        ProveedorBss objetoProveedor = new ProveedorBss();
        ProveedorEnt proveedor = new ProveedorEnt();
        #endregion
        #region Form
        public Ficha(int idProveedor)
        {
            InitializeComponent();
            proveedor.ID = idProveedor;
        }
        private void Ficha_Load(object sender, EventArgs e)
        {
            cargarInformacionDeProveedor();
        }
        #endregion
        #region Metodos Propios
        private void cargarInformacionDeProveedor()
        {
            DataTable dataTableProveedor = objetoProveedor.search(proveedor);
            textBoxNit.Text = dataTableProveedor.Rows[0]["Nit"].ToString();
            textBoxNombre.Text = dataTableProveedor.Rows[0]["Nombre"].ToString();
            textBoxPersonaDeContacto.Text = dataTableProveedor.Rows[0]["Persona_De_Contacto"].ToString();
            textBoxDireccion.Text = dataTableProveedor.Rows[0]["Direccion"].ToString();
            textBoxTelefono.Text = dataTableProveedor.Rows[0]["Telefono"].ToString();
            textBoxCelular.Text = dataTableProveedor.Rows[0]["Celular"].ToString();
            textBoxNumeroDeCuenta.Text = dataTableProveedor.Rows[0]["Numero_De_Cuenta"].ToString();
        }
        #endregion
    }
}