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

namespace Super_Mercado_Mio.Producto
{
    public partial class Nuevo : Form
    {
        #region Objetos
        int opcion = 0;
        string codigoDeBarras = "";
        bool isWritable = true;
        bool[] hasErrors = new bool[] { false, false, true, false, false, false, true, false, false, true, true };
        ProveedorBss objetoProveedor = new ProveedorBss();
        GrupoBss objetoGrupo = new GrupoBss();
        ProductoBss objetoProducto = new ProductoBss();
        public ProductoEnt producto = new ProductoEnt();
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
            this.ActiveControl = textBoxCodigoDeBarras;
            if (opcion == 2)
            {
                textBoxCodigoDeBarras.Text = codigoDeBarras;
                this.ActiveControl = textBoxNombreGenerico;
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
        #region buttonAddProvider
        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            Proveedor.Nuevo formNuevoProveedor = new Proveedor.Nuevo(1, null);
            formNuevoProveedor.ShowDialog();
            if (formNuevoProveedor.proveedor.ID > 0)
            {
                loadProveedores();
                comboBoxProveedor.SelectedValue = formNuevoProveedor.proveedor.ID;
            }
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
        #region buttonAddGroup
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            Grupo.Nuevo formNuevoGrupo = new Grupo.Nuevo();
            formNuevoGrupo.ShowDialog();
            if (formNuevoGrupo.grupo.ID > 0)
            {
                loadGrupos();
                comboBoxGrupo.SelectedValue = formNuevoGrupo.grupo.ID;
            }
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
            textBoxAlias.Text = generarAlias();
        }
        #endregion
        #region textBoxMarca
        private void textBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarMarca();
            hasErrors[4] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxMarca, ValidacionBss.getErrorMessage(errorCode));
            textBoxAlias.Text = generarAlias();
        }
        #endregion
        #region textBoxPresentacion
        private void textBoxPresentacion_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPresentacion();
            hasErrors[5] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPresentacion, ValidacionBss.getErrorMessage(errorCode));
            textBoxAlias.Text = generarAlias();
        }
        #endregion
        #region textBoxSaborYOlor
        private void textBoxSaborUOlor_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarSaborUOlor();
            hasErrors[6] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxSaborUOlor, ValidacionBss.getErrorMessage(errorCode));
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
        #region textBoxPrecioDeCompra
        private void textBoxPrecioDeCompra_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxPrecioDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxPrecioDeCompra.Text.IndexOf(".") > -1)
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
        private void textBoxPrecioDeCompra_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPrecioDeCompra();
            hasErrors[8] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPrecioDeCompra, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxPrecioDeVenta
        private void textBoxPrecioDeVenta_KeyDown(object sender, KeyEventArgs e)
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
        private void textBoxPrecioDeVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isWritable == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 46)
                {
                    if (textBoxPrecioDeVenta.Text.IndexOf(".") > -1)
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
        private void textBoxPrecioDeVenta_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarPrecioDeVenta();
            hasErrors[9] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxPrecioDeVenta, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region textBoxAlias
        private void textBoxAlias_Validating(object sender, CancelEventArgs e)
        {
            int errorCode = validarAlias();
            hasErrors[10] = Convert.ToBoolean(errorCode);
            errorProviderFormulario.SetError(textBoxAlias, ValidacionBss.getErrorMessage(errorCode));
        }
        #endregion
        #region buttonGuardar
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                producto.ID_PROVEEDOR = Convert.ToInt32(comboBoxProveedor.SelectedValue);
                producto.ID_GRUPO = Convert.ToInt32(comboBoxGrupo.SelectedValue);
                if (radioButtonTipoDeCodigoDeBarrasManual.Checked)
                {
                    producto.TIPO_DE_CODIGO_DE_BARRAS = "MANUAL";
                    producto.CODIGO_DE_BARRAS = textBoxCodigoDeBarras.Text.Trim();
                }
                else
                {
                    producto.TIPO_DE_CODIGO_DE_BARRAS = "SISTEMA";
                    producto.CODIGO_DE_BARRAS = "M" + (objetoProducto.getNumber(producto) + 1).ToString("D5");
                }
                producto.NOMBRE_GENERICO = textBoxNombreGenerico.Text.Trim().ToUpper();
                producto.MARCA = textBoxMarca.Text.Trim().ToUpper();
                producto.PRESENTACION = textBoxPresentacion.Text.Trim().ToUpper();
                producto.SABOR_U_OLOR = textBoxSaborUOlor.Text.Trim().ToUpper();
                if (radioButtonTipoDeProductoInventario.Checked)
                {
                    producto.TIPO = "INVENTARIO";
                }
                else
                {
                    producto.TIPO = "BALANZA";
                }
                if (textBoxCantidadMinima.Text != "")
                {
                    producto.CANTIDAD_MINIMA = Convert.ToDecimal(textBoxCantidadMinima.Text);
                }
                else
                {
                    producto.CANTIDAD_MINIMA = 0;
                }
                producto.PRECIO_DE_COMPRA = Convert.ToDecimal(textBoxPrecioDeCompra.Text.Trim());
                producto.PRECIO_DE_VENTA = Convert.ToDecimal(textBoxPrecioDeVenta.Text.Trim());
                producto.ALIAS = textBoxAlias.Text.Trim().ToUpper();
                producto.ID = objetoProducto.insert(producto);
                if (producto.CODIGO_DE_BARRAS == textBoxCodigoDeBarras.Text.Trim())
                {
                    MessageBox.Show("Los datos fueron guardados correctamente.", "Operación Exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos fueron guardados correctamente.\n \n" + "Código de Barras: " + producto.CODIGO_DE_BARRAS,
                        "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
        private void loadProveedores()
        {
            string[] values = new string[2];
            values[0] = "0";
            values[1] = "NINGUNO";
            DataTable dataTableProveedores = objetoProveedor.selectAll();
            dataTableProveedores.Rows.Add(values);
            comboBoxProveedor.ValueMember = "Id";
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
            comboBoxGrupo.ValueMember = "Id";
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
        private void evaluarCodigoDeBarras()
        {
            if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
            {
                textBoxCodigoDeBarras.ReadOnly = true;
                producto.TIPO_DE_CODIGO_DE_BARRAS = "SISTEMA";
                textBoxCodigoDeBarras.Text = "M" + (objetoProducto.getNumber(producto) + 1).ToString("D5");
                errorProviderFormulario.SetError(textBoxCodigoDeBarras, null);
            }
            else
            {
                textBoxCodigoDeBarras.ReadOnly = false;
                textBoxCodigoDeBarras.ResetText();
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
        private bool verificarCodigoDeBarras()
        {
            producto.CODIGO_DE_BARRAS = textBoxCodigoDeBarras.Text.Trim();
            if (objetoProducto.authenticateCodigoDeBarras(producto) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool verificarAlias()
        {
            producto.ALIAS = textBoxAlias.Text.Trim().ToUpper();
            if (objetoProducto.authenticateAlias(producto) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool verificarProducto(int opcionX)
        {
            bool result = false;
            if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
            {
                switch (opcionX)
                {
                    case 1:
                        if (hasErrors[4] && hasErrors[5])
                        {
                            producto.NOMBRE_GENERICO = textBoxNombreGenerico.Text.Trim().ToUpper();
                            producto.MARCA = textBoxMarca.Text.Trim().ToUpper();
                            producto.PRESENTACION = textBoxPresentacion.Text.Trim().ToUpper();
                            producto.SABOR_U_OLOR = textBoxSaborUOlor.Text.Trim().ToUpper();
                            if (objetoProducto.authenticate(producto) == 0)
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        break;
                    case 2:
                        if (!hasErrors[3] && hasErrors[5])
                        {
                            producto.NOMBRE_GENERICO = textBoxNombreGenerico.Text.Trim().ToUpper();
                            producto.MARCA = textBoxMarca.Text.Trim().ToUpper();
                            producto.PRESENTACION = textBoxPresentacion.Text.Trim().ToUpper();
                            producto.SABOR_U_OLOR = textBoxSaborUOlor.Text.Trim().ToUpper();
                            if (objetoProducto.authenticate(producto) == 0)
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        break;
                    case 3:
                        if (!hasErrors[3] && hasErrors[4])
                        {
                            producto.NOMBRE_GENERICO = textBoxNombreGenerico.Text.Trim().ToUpper();
                            producto.MARCA = textBoxMarca.Text.Trim().ToUpper();
                            producto.PRESENTACION = textBoxPresentacion.Text.Trim().ToUpper();
                            producto.SABOR_U_OLOR = textBoxSaborUOlor.Text.Trim().ToUpper();
                            if (objetoProducto.authenticate(producto) == 0)
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        break;
                    case 4:
                        if (!hasErrors[3] && !hasErrors[4] && !hasErrors[5])
                        {
                            producto.NOMBRE_GENERICO = textBoxNombreGenerico.Text.Trim().ToUpper();
                            producto.MARCA = textBoxMarca.Text.Trim().ToUpper();
                            producto.PRESENTACION = textBoxPresentacion.Text.Trim().ToUpper();
                            producto.SABOR_U_OLOR = textBoxSaborUOlor.Text.Trim().ToUpper();
                            if (objetoProducto.authenticate(producto) == 0)
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        break;
                }
            }
            else
            {
                result = true;
            }
            return result;
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
                        if (verificarCodigoDeBarras())
                        {
                            return 0;
                        }
                        else
                        {
                            return 700;
                        }
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
                if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
                {
                    if (verificarProducto(1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 701;
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
        private int validarMarca()
        {
            if (textBoxMarca.Text.Trim() != "")
            {
                if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
                {
                    if (verificarProducto(2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 701;
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
        private int validarPresentacion()
        {
            if (textBoxPresentacion.Text.Trim() != "")
            {
                if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
                {
                    if (verificarProducto(3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 701;
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
        private int validarSaborUOlor()
        {
            if (radioButtonTipoDeCodigoDeBarrasSistema.Checked == true)
            {
                if (verificarProducto(4))
                {
                    return 0;
                }
                else
                {
                    return 701;
                }
            }
            else
            {
                return 0;
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
        private int validarPrecioDeCompra()
        {
            if (textBoxPrecioDeCompra.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxPrecioDeCompra.Text.Trim()))
                {
                    if (Convert.ToDecimal(textBoxPrecioDeCompra.Text) > 0)
                    {
                        if (!hasErrors[10])
                        {
                            if (Convert.ToDecimal(textBoxPrecioDeCompra.Text.Trim()) < Convert.ToDecimal(textBoxPrecioDeVenta.Text.Trim()))
                            {
                                return 0;
                            }
                            else
                            {
                                return 702;
                            }
                        }
                        else
                        {
                            return 0;
                        }
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
                return 1;
            }
        }
        private int validarPrecioDeVenta()
        {
            if (textBoxPrecioDeVenta.Text.Trim() != "")
            {
                if (ValidacionBss.esRealConDosDecimales(textBoxPrecioDeVenta.Text.Trim()))
                {
                    if (Convert.ToDecimal(textBoxPrecioDeVenta.Text) > 0)
                    {
                        if (!hasErrors[9])
                        {
                            if (Convert.ToDecimal(textBoxPrecioDeCompra.Text.Trim()) < Convert.ToDecimal(textBoxPrecioDeVenta.Text.Trim()))
                            {
                                return 0;
                            }
                            else
                            {
                                return 702;
                            }
                        }
                        else
                        {
                            return 0;
                        }
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
                return 1;
            }
        }
        private int validarAlias()
        {
            if (textBoxAlias.Text.Trim() != "")
            {
                if (verificarAlias())
                {
                    return 0;
                }
                else
                {
                    return 703;
                }
            }
            else
            {
                return 1;
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
                switch (errorPosition)
                {
                    case 0:
                        comboBoxProveedor.Focus();
                        break;
                    case 1:
                        comboBoxGrupo.Focus();
                        break;
                    case 2:
                        textBoxCodigoDeBarras.Focus();
                        break;
                    case 3:
                        textBoxNombreGenerico.Focus();
                        break;
                    case 4:
                        textBoxMarca.Focus();
                        break;
                    case 5:
                        textBoxPresentacion.Focus();
                        break;
                    case 6:
                        textBoxSaborUOlor.Focus();
                        break;
                    case 7:
                        textBoxCantidadMinima.Focus();
                        break;
                    case 8:
                        textBoxPrecioDeCompra.Focus();
                        break;
                    case 9:
                        textBoxPrecioDeVenta.Focus();
                        break;
                    case 10:
                        textBoxAlias.Focus();
                        break;
                }
                return false;
            }
        }
        #endregion
    }
}