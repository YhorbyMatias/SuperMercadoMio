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
    public partial class Cierre : Form
    {
        #region Objects
        bool isWritable = true;
        bool[] hasErrors = new bool[] { true, true };
        AperturaDeCajaBss objetoAperturaDeCaja = new AperturaDeCajaBss();
        AperturaDeCajaEnt aperturaDeCaja = new AperturaDeCajaEnt();
        CajaBss objetoCaja = new CajaBss();
        CajaEnt caja = new CajaEnt();
        #endregion
        #region Form
        public Cierre()
        {
            InitializeComponent();
        }
        private void Cierre_Load(object sender, EventArgs e)
        {
            aperturaDeCaja.ID_USUARIO = SesionEnt.idUsuario;
            aperturaDeCaja.ID_CAJA = SesionEnt.idCaja;
            if (objetoAperturaDeCaja.exists(aperturaDeCaja) > 0)
            {
                loadFormData();
                timerHora.Start();
            }
        }
        #endregion
        #region textBoxMontoDeVentaDeTarjetas
        private void textBoxMontoDeVentaDeTarjetas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (ValidacionBss.esRealConDosDecimales(Clipboard.GetText()) == false)
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
        private void textBoxMontoDeVentaDeTarjetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMontoDeVentaDeTarjetas.Text.IndexOf(".") > -1)
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
        private void textBoxMontoDeVentaDeTarjetas_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion
        #region textBoxMontoDePagos
        private void textBoxMontoDePagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (ValidacionBss.esRealConDosDecimales(Clipboard.GetText()) == false)
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
        private void textBoxMontoDePagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxMontoDePagos.Text.IndexOf(".") > -1)
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
        private void textBoxMontoDePagos_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region buttonCerrar
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void loadFormData()
        {
            caja.NOMBRE_DE_EQUIPO = System.Environment.MachineName;
            textBoxNumeroDeCaja.Text = objetoCaja.getNumber(caja).ToString();
            textBoxUsuario.Text = SesionEnt.nombreDeUsuario;
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
            textBoxHora.Text = DateTime.Now.ToString("T");
            DataTable dataTableAperturaDeCaja = objetoAperturaDeCaja.get(aperturaDeCaja);
            aperturaDeCaja.ID = Convert.ToInt32(dataTableAperturaDeCaja.Rows[0]["Id"]);
            textBoxMontoDeAperturaDeCaja.Text = Convert.ToDecimal(dataTableAperturaDeCaja.Rows[0]["Monto"]).ToString();
        }
        #endregion
    }
}