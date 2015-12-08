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
    public partial class Busqueda : Form
    {
        #region Objetos
        int option = 0;
        bool isWritable = true;
        bool isValidDate = true;
        IngresoBss objetoIngreso = new IngresoBss();
        IngresoEnt ingreso = new IngresoEnt();
        ProveedorEnt proveedor = new ProveedorEnt();
        ProductoEnt producto = new ProductoEnt();
        DetalleDeIngresoBss objetoDetalleDeIngreso = new DetalleDeIngresoBss();
        DetalleDeIngresoEnt detalleDeIngreso = new DetalleDeIngresoEnt();
        #endregion
        #region Form
        public Busqueda(int option)
        {
            InitializeComponent();
            this.option = option;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            if (option == 2)
            {
                toolStripButtonEdit.Visible = true;
            }
            else if (option == 3)
            {
                toolStripButtonCancel.Visible = true;
            }
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
            ingreso.TIPO = "COMPRA";
            ingreso.ID = objetoIngreso.getMinId(ingreso);
            if (ingreso.ID > 0)
            {
                loadData(objetoIngreso.getById(ingreso).Rows[0]);
            }
        }
        #endregion
        #region toolStripButtonPrevious
        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            ingreso.TIPO = "COMPRA";
            int firstId = objetoIngreso.getMinId(ingreso);
            if (firstId > 0)
            {
                if (ingreso.ID == firstId)
                {
                    ingreso.ID = objetoIngreso.getMaxId(ingreso);
                    loadData(objetoIngreso.getById(ingreso).Rows[0]);
                }
                else
                {
                    if (ingreso.ID > 0)
                    {
                        bool estado = false;
                        ingreso.ID = ingreso.ID - 1;
                        while (estado == false)
                        {
                            if (objetoIngreso.existsId(ingreso) == 1)
                            {
                                estado = true;
                            }
                            else
                            {
                                ingreso.ID = ingreso.ID - 1;
                            }
                        }
                        loadData(objetoIngreso.getById(ingreso).Rows[0]);
                    }
                    else
                    {
                        ingreso.ID = objetoIngreso.getMaxId(ingreso);
                        loadData(objetoIngreso.getById(ingreso).Rows[0]);
                    }
                }
            }
        }
        #endregion
        #region toolStripButtonNext
        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            ingreso.TIPO = "COMPRA";
            int lastId = objetoIngreso.getMaxId(ingreso);
            if (lastId > 0)
            {
                if (ingreso.ID == lastId)
                {
                    ingreso.ID = objetoIngreso.getMinId(ingreso);
                    loadData(objetoIngreso.getById(ingreso).Rows[0]);
                }
                else
                {
                    bool estado = false;
                    ingreso.ID = ingreso.ID + 1;
                    while (estado == false)
                    {
                        if (objetoIngreso.existsId(ingreso) == 1)
                        {
                            estado = true;
                        }
                        else
                        {
                            ingreso.ID = ingreso.ID + 1;
                        }
                    }
                    loadData(objetoIngreso.getById(ingreso).Rows[0]);
                }
            }
        }
        #endregion
        #region toolStripButtonLast
        private void toolStripButtonLast_Click(object sender, EventArgs e)
        {
            ingreso.TIPO = "COMPRA";
            ingreso.ID = objetoIngreso.getMaxId(ingreso);
            if (ingreso.ID > 0)
            {
                loadData(objetoIngreso.getById(ingreso).Rows[0]);
            }
        }
        #endregion
        #region toolStripButtonEdit
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ingreso.ID != 0 && conditionTextBox.Text == "VIGENTE")
            {
                Compra.Modificar formModificarCompra = new Modificar(ingreso.ID);
                formModificarCompra.MdiParent = this.MdiParent;
                this.Close();
                formModificarCompra.Show();
            }
        }
        #endregion
        #region toolStripButtonCancel
        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            if (ingreso.ID != 0)
            {
                if (conditionTextBox.Text == "VIGENTE")
                {
                    if (MessageBox.Show("¿Está seguro de anular la compra?", "Anular compra", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        objetoIngreso.cancel(ingreso);
                        detalleDeIngreso.ID_INGRESO = ingreso.ID;
                        objetoDetalleDeIngreso.cancel(detalleDeIngreso);
                        conditionTextBox.Text = "ANULADA";
                        MessageBox.Show("La compra fue anulada correctamente.", "Información", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La compra ya fue anulada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                if (!textBoxNit.ReadOnly)
                {
                    searchPurchase();
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
                if (!textBoxProveedor.ReadOnly)
                {
                    searchPurchase();
                }
            }
        }
        #endregion
        #region maskedTextBoxFecha
        private void maskedTextBoxFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!maskedTextBoxFecha.ReadOnly)
                {
                    searchPurchase();
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
            else
            {
                isValidDate = true;
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
            if (e.KeyValue == 13)
            {
                if (!textBoxNumeroDeRegistro.ReadOnly)
                {
                    searchPurchase();
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
        #region textBoxNumeroDeNotaDeEntrega
        private void textBoxNumeroDeNotaDeEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!textBoxNumeroDeNotaDeEntrega.ReadOnly)
                {
                    searchPurchase();
                }
            }
        }
        #endregion
        #region conditionTextBox
        private void conditionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!conditionTextBox.ReadOnly)
                {
                    searchPurchase();
                }
            }
        }
        #endregion
        #region textBoxCodigoDeBarras
        private void textBoxCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!textBoxCodigoDeBarras.ReadOnly)
                {
                    searchPurchase();
                }
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
            conditionTextBox.ResetText();
            textBoxCodigoDeBarras.ResetText();
            textBoxNit.ReadOnly = false;
            textBoxProveedor.ReadOnly = false;
            maskedTextBoxFecha.ReadOnly = false;
            textBoxNumeroDeRegistro.ReadOnly = false;
            textBoxNumeroDeNotaDeEntrega.ReadOnly = false;
            conditionTextBox.ReadOnly = false;
            textBoxCodigoDeBarras.ReadOnly = false;
            textBoxNit.ContextMenuStrip = contextMenuStripEmpty;
            textBoxNumeroDeRegistro.ContextMenuStrip = contextMenuStripEmpty;
            dataGridViewDetalleDeIngreso.Rows.Clear();
            textBoxNit.Focus();
        }
        private void loadData(DataRow purchaseDataRow)
        {
            textBoxNit.ReadOnly = true;
            textBoxProveedor.ReadOnly = true;
            maskedTextBoxFecha.ReadOnly = true;
            textBoxNumeroDeRegistro.ReadOnly = true;
            textBoxNumeroDeNotaDeEntrega.ReadOnly = true;
            conditionTextBox.ReadOnly = true;
            textBoxCodigoDeBarras.ReadOnly = true;
            textBoxCodigoDeBarras.ResetText();
            dataGridViewDetalleDeIngreso.Rows.Clear();
            textBoxNit.Text = purchaseDataRow["Nit"].ToString();
            textBoxProveedor.Text = purchaseDataRow["Proveedor"].ToString();
            maskedTextBoxFecha.Text = Convert.ToDateTime(purchaseDataRow["Fecha"]).ToShortDateString();
            textBoxNumeroDeRegistro.Text = purchaseDataRow["Numero_De_Registro"].ToString();
            textBoxNumeroDeNotaDeEntrega.Text = purchaseDataRow["Numero_De_Nota_De_Entrega"].ToString();
            textBoxMonto.Text = purchaseDataRow["Monto"].ToString();
            textBoxObservaciones.Text = purchaseDataRow["Observaciones"].ToString();
            conditionTextBox.Text = purchaseDataRow["Estado"].ToString();
            detalleDeIngreso.ID_INGRESO = Convert.ToInt32(purchaseDataRow["Id"]);
            DataTable purchaseLines = objetoDetalleDeIngreso.getByIngresoId(detalleDeIngreso);
            for (int index = 0; index < purchaseLines.Rows.Count; index++)
            {
                dataGridViewDetalleDeIngreso.Rows.Add();
                dataGridViewDetalleDeIngreso["Id_Producto", index].Value = purchaseLines.Rows[index]["Id_Producto"].ToString();
                dataGridViewDetalleDeIngreso["Codigo_De_Barras", index].Value = purchaseLines.Rows[index]["Codigo_De_Barras"].ToString();
                dataGridViewDetalleDeIngreso["Nombre_Generico", index].Value = purchaseLines.Rows[index]["Nombre_Generico"].ToString();
                dataGridViewDetalleDeIngreso["Marca", index].Value = purchaseLines.Rows[index]["Marca"].ToString();
                dataGridViewDetalleDeIngreso["Presentacion", index].Value = purchaseLines.Rows[index]["Presentacion"].ToString();
                dataGridViewDetalleDeIngreso["Sabor_U_Olor", index].Value = purchaseLines.Rows[index]["Sabor_U_Olor"].ToString();
                dataGridViewDetalleDeIngreso["Cantidad", index].Value = purchaseLines.Rows[index]["Cantidad"].ToString();
                dataGridViewDetalleDeIngreso["Precio_De_Compra", index].Value = purchaseLines.Rows[index]["Precio_De_Compra"].ToString();
                dataGridViewDetalleDeIngreso["Monto_Total", index].Value = purchaseLines.Rows[index]["Monto_Total"].ToString();
                dataGridViewDetalleDeIngreso["Porcentaje_De_Utilidad", index].Value =
                    purchaseLines.Rows[index]["Porcentaje_De_Utilidad"].ToString();
                dataGridViewDetalleDeIngreso["Precio_De_Venta", index].Value = purchaseLines.Rows[index]["Precio_De_Venta"].ToString();
            }
        }
        private void searchPurchase()
        {
            if (isValidDate)
            {
                proveedor.NIT = textBoxNit.Text.Trim();
                proveedor.NOMBRE = textBoxProveedor.Text.Trim().ToUpper();
                if (maskedTextBoxFecha.Text.Trim() != "/  /")
                {
                    ingreso.FECHA = maskedTextBoxFecha.Text;
                }
                else
                {
                    ingreso.FECHA = "";
                }
                if (textBoxNumeroDeRegistro.Text.Trim() != "")
                {
                    ingreso.NUMERO_DE_REGISTRO = Convert.ToInt32(textBoxNumeroDeRegistro.Text.Trim());
                }
                else
                {
                    ingreso.NUMERO_DE_REGISTRO = 0;
                }
                ingreso.NUMERO_DE_NOTA_DE_ENTREGA = textBoxNumeroDeNotaDeEntrega.Text.Trim().ToUpper();
                ingreso.ESTADO = conditionTextBox.Text.Trim().ToUpper();
                producto.CODIGO_DE_BARRAS = textBoxCodigoDeBarras.Text.Trim();
                DataTable purchasesDataTable = objetoIngreso.search(proveedor, ingreso, producto);
                int records = purchasesDataTable.Rows.Count;
                if (records > 0)
                {
                    if (records == 1)
                    {
                        ingreso.ID = Convert.ToInt32(purchasesDataTable.Rows[0]["Id"]);
                        loadData(purchasesDataTable.Rows[0]);
                    }
                    else
                    {
                        Compra.Resultados formResultadosDeCompras = new Resultados(purchasesDataTable);
                        formResultadosDeCompras.ShowDialog();
                        if (formResultadosDeCompras.index > -1)
                        {
                            ingreso.ID = Convert.ToInt32(purchasesDataTable.Rows[formResultadosDeCompras.index]["Id"]);
                            loadData(purchasesDataTable.Rows[formResultadosDeCompras.index]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                maskedTextBoxFecha.Focus();
            }
        }
        #endregion
    }
}