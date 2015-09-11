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

namespace Super_Mercado_Mio.Producto
{
    public partial class Nuevo : Form
    {
        #region Objetos
        int opcion = 0;
        string codigoDeBarras = "";
        bool isWritable = true;
        bool[] hasErrors = new bool[9];
        ProveedorBss objetoProveedor = new ProveedorBss();
        GrupoBss objetoGrupo = new GrupoBss();
        ProductoBss objetoProducto = new ProductoBss();
        #endregion
        #region Form
        public Nuevo(int opcionX, string codigoDeBarrasX)
        {
            InitializeComponent();
            opcion = opcionX;
            codigoDeBarras = codigoDeBarrasX;
        }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            loadProveedores();
            loadGrupos();
            loadMarcas();
            if (opcion == 2)
            {
                textBoxCodigoDeBarras.Text = codigoDeBarras;
            }
        }
        #endregion
        #region comboBoxProveedor
        private void comboBoxProveedor_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarProveedor();
            hasErrors[0] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(comboBoxProveedor, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region comboBoxGrupo
        private void comboBoxGrupo_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarGrupo();
            hasErrors[1] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(comboBoxGrupo, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region radioButtonTipoDeCodigoDeBarrasManual
        private void radioButtonTipoDeCodigoDeBarrasManual_CheckedChanged(object sender, EventArgs e)
        {
            evaluarCodigoDeBarras();
        }
        #endregion
        #region radioButtonTipoDeCodigoBarrasSistema
        private void radioButtonTipoDeCodigoBarrasSistema_CheckedChanged(object sender, EventArgs e)
        {
            evaluarCodigoDeBarras();
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarCodigoDeBarras();
            hasErrors[2] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxCodigoDeBarras, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxNombreGenerico
        private void textBoxNombreGenerico_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarNombreGenerico();
            hasErrors[3] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxNombreGenerico, ValidacionBss.getErrorMessage(errorCode));
            generarAlias();
        }
        #endregion
        #region textBoxMarca
        private void textBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarMarca();
            hasErrors[4] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxMarca, ValidacionBss.getErrorMessage(errorCode));
            generarAlias();
        }
        #endregion
        #region textBoxPresentacion
        private void textBoxPresentacion_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPresentacion();
            hasErrors[5] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPresentacion, ValidacionBss.getErrorMessage(errorCode));
            generarAlias();
        }
        #endregion
        #region textBoxAlias
        private void textBoxAlias_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarAlias();
            hasErrors[6] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxAlias, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxCantidadMinima
        private void textBoxCantidadMinima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (ValidacionBss.esRealConTresDecimales(Clipboard.GetText()) == false)
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
        private void textBoxCantidadMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxCantidadMinima.Text.IndexOf(".") > -1)
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
        private void textBoxCantidadMinima_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarCantidadMinima();
            hasErrors[7] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxCantidadMinima, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxPrecio
        private void textBoxPrecio_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxPrecio.Text.IndexOf(".") > -1)
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
        private void textBoxPrecio_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPrecio();
            hasErrors[8] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPrecio, ValidacionBss.getErrorMessage(errorCode));
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
        #region Metodos Propios
        private void loadProveedores()
        {
            string[] values = new string[2];
            values[0] = "0";
            values[1] = "NINGUNO";
            DataTable dataTableProveedores = objetoProveedor.selectAll();
            dataTableProveedores.Rows.Add(values);
            comboBoxProveedor.ValueMember = "Id_Proveedor";
            comboBoxProveedor.DisplayMember = "Nombre";
            comboBoxProveedor.DataSource = dataTableProveedores;
            comboBoxProveedor.SelectedValue = 0;
        }
        private void loadGrupos()
        {
            string[] values = new string[2];
            values[0] = "0";
            values[1] = "NINGUNO";
            DataTable dataTableGrupos = objetoGrupo.selectAll();
            dataTableGrupos.Rows.Add(values);
            comboBoxGrupo.ValueMember = "Id_Grupo";
            comboBoxGrupo.DisplayMember = "Nombre";
            comboBoxGrupo.DataSource = dataTableGrupos;
            comboBoxGrupo.SelectedValue = 0;
        }
        private void loadMarcas()
        {
            var marcas = new AutoCompleteStringCollection();
            DataTable dataTableMarcas = objetoProducto.searchMarcas();
            for (int filas = 0; filas < dataTableMarcas.Rows.Count; filas++)
            {
                marcas.Add(dataTableMarcas.Rows[filas][0].ToString());
            }
            textBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxMarca.AutoCompleteCustomSource = marcas;
        }
        private int validarProveedor()
        {
            if (comboBoxProveedor.SelectedValue != null)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        private int validarGrupo()
        {
            if (comboBoxGrupo.SelectedValue != null)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        private void evaluarCodigoDeBarras()
        {
            if (radioButtonTipoDeCodigoBarrasSistema.Checked == true)
            {
                textBoxCodigoDeBarras.ReadOnly = true;
            }
            else
            {
                textBoxCodigoDeBarras.ReadOnly = false;
                textBoxCodigoDeBarras.ResetText();
            }
        }
        private int validarCodigoDeBarras()
        {
            if (textBoxCodigoDeBarras.Text.Trim()!= "")
            {
                if (radioButtonTipoDeCodigoDeBarrasManual.Checked)
                {
                    if (textBoxCodigoDeBarras.Text[0].Equals('M') || textBoxCodigoDeBarras.Text[0].Equals('m'))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 1;
            }
        }
        private int validarNombreGenerico()
        {
            if (textBoxNombreGenerico.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarMarca()
        {
            if (textBoxMarca.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarPresentacion()
        {
            if (textBoxPresentacion.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private string generarAlias()
        {
            string alias = "";
            if (!hasErrors[3] && !hasErrors[4] && !hasErrors[5])
            {
                if (textBoxNombreGenerico.Text.Trim().Length > 3)
                {
                    alias = textBoxNombreGenerico.Text.Substring(0, 3).ToUpper();
                }
                else
                {
                    alias = textBoxNombreGenerico.Text.Trim().ToUpper();
                }
                if (textBoxMarca.Text.Trim().Length > 14)
                {
                    alias = alias + " " + textBoxMarca.Text.Substring(0, 14).ToUpper();
                }
                else
                {
                    alias = alias + " " + textBoxMarca.Text.Trim().ToUpper();
                }
                if (textBoxPresentacion.Text.Trim().Length > 5)
                {
                    alias = alias + " " + textBoxPresentacion.Text.Substring(0, 5).ToUpper();
                }
                else
                {
                    alias = alias + " " + textBoxPresentacion.Text.Trim().ToUpper();
                }
            }
            return alias;
        }
        private int validarAlias()
        {
            if (textBoxAlias.Text.Trim() != "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int validarCantidadMinima()
        {
            if (textBoxCantidadMinima.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConTresDecimales(textBoxCantidadMinima.Text.Trim()))
                {
                    if (Convert.ToDecimal(textBoxCantidadMinima.Text) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }
        private int validarPrecio()
        {
            if (textBoxPrecio.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxPrecio.Text.Trim()))
                {
                    if (Convert.ToDecimal(textBoxPrecio.Text) > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}