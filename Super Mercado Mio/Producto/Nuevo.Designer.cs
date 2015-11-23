namespace Super_Mercado_Mio.Producto
{
    partial class Nuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelCodigoDeBarras = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.radioButtonTipoDeCodigoDeBarrasManual = new System.Windows.Forms.RadioButton();
            this.radioButtonTipoDeCodigoDeBarrasSistema = new System.Windows.Forms.RadioButton();
            this.labelTipoDeCodigoDeBarras = new System.Windows.Forms.Label();
            this.labelNombreGenerico = new System.Windows.Forms.Label();
            this.textBoxNombreGenerico = new System.Windows.Forms.TextBox();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelSaborUOlor = new System.Windows.Forms.Label();
            this.textBoxSaborUOlor = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.panelTipoDeProducto = new System.Windows.Forms.Panel();
            this.radioButtonTipoDeProductoBalanza = new System.Windows.Forms.RadioButton();
            this.radioButtonTipoDeProductoInventario = new System.Windows.Forms.RadioButton();
            this.labelCantidadMinima = new System.Windows.Forms.Label();
            this.textBoxCantidadMinima = new System.Windows.Forms.TextBox();
            this.contextMenuStripTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelPrecioDeVenta = new System.Windows.Forms.Label();
            this.textBoxPrecioDeVenta = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.labelPresentacion = new System.Windows.Forms.Label();
            this.textBoxPresentacion = new System.Windows.Forms.TextBox();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.labelPrecioDeCompra = new System.Windows.Forms.Label();
            this.contextMenuStripFormulario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelTipoDeProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGrupo.FormattingEnabled = true;
            this.errorProviderFormulario.SetIconAlignment(this.comboBoxGrupo, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.comboBoxGrupo, 5);
            this.comboBoxGrupo.Location = new System.Drawing.Point(165, 39);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGrupo.TabIndex = 2;
            this.comboBoxGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGrupo_Validating);
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(12, 42);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(39, 13);
            this.labelGrupo.TabIndex = 330;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelCodigoDeBarras
            // 
            this.labelCodigoDeBarras.AutoSize = true;
            this.labelCodigoDeBarras.Location = new System.Drawing.Point(12, 92);
            this.labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            this.labelCodigoDeBarras.Size = new System.Drawing.Size(91, 13);
            this.labelCodigoDeBarras.TabIndex = 340;
            this.labelCodigoDeBarras.Text = "Código de Barras:";
            // 
            // textBoxCodigoDeBarras
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxCodigoDeBarras, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxCodigoDeBarras, 5);
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(165, 89);
            this.textBoxCodigoDeBarras.MaxLength = 100;
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodigoDeBarras.TabIndex = 6;
            this.textBoxCodigoDeBarras.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodigoDeBarras_Validating);
            // 
            // radioButtonTipoDeCodigoDeBarrasManual
            // 
            this.radioButtonTipoDeCodigoDeBarrasManual.AutoSize = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Checked = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Location = new System.Drawing.Point(165, 66);
            this.radioButtonTipoDeCodigoDeBarrasManual.Name = "radioButtonTipoDeCodigoDeBarrasManual";
            this.radioButtonTipoDeCodigoDeBarrasManual.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTipoDeCodigoDeBarrasManual.TabIndex = 4;
            this.radioButtonTipoDeCodigoDeBarrasManual.TabStop = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Text = "Manual";
            this.radioButtonTipoDeCodigoDeBarrasManual.UseVisualStyleBackColor = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.CheckedChanged += new System.EventHandler(this.radioButtonTipoDeCodigoDeBarrasManual_CheckedChanged);
            // 
            // radioButtonTipoDeCodigoDeBarrasSistema
            // 
            this.radioButtonTipoDeCodigoDeBarrasSistema.AutoSize = true;
            this.radioButtonTipoDeCodigoDeBarrasSistema.Location = new System.Drawing.Point(231, 66);
            this.radioButtonTipoDeCodigoDeBarrasSistema.Name = "radioButtonTipoDeCodigoDeBarrasSistema";
            this.radioButtonTipoDeCodigoDeBarrasSistema.Size = new System.Drawing.Size(62, 17);
            this.radioButtonTipoDeCodigoDeBarrasSistema.TabIndex = 5;
            this.radioButtonTipoDeCodigoDeBarrasSistema.Text = "Sistema";
            this.radioButtonTipoDeCodigoDeBarrasSistema.UseVisualStyleBackColor = true;
            this.radioButtonTipoDeCodigoDeBarrasSistema.CheckedChanged += new System.EventHandler(this.radioButtonTipoDeCodigoBarrasSistema_CheckedChanged);
            // 
            // labelTipoDeCodigoDeBarras
            // 
            this.labelTipoDeCodigoDeBarras.AutoSize = true;
            this.labelTipoDeCodigoDeBarras.Location = new System.Drawing.Point(12, 68);
            this.labelTipoDeCodigoDeBarras.Name = "labelTipoDeCodigoDeBarras";
            this.labelTipoDeCodigoDeBarras.Size = new System.Drawing.Size(130, 13);
            this.labelTipoDeCodigoDeBarras.TabIndex = 343;
            this.labelTipoDeCodigoDeBarras.Text = "Tipo de Código de Barras:";
            // 
            // labelNombreGenerico
            // 
            this.labelNombreGenerico.AutoSize = true;
            this.labelNombreGenerico.Location = new System.Drawing.Point(12, 118);
            this.labelNombreGenerico.Name = "labelNombreGenerico";
            this.labelNombreGenerico.Size = new System.Drawing.Size(93, 13);
            this.labelNombreGenerico.TabIndex = 346;
            this.labelNombreGenerico.Text = "Nombre Genérico:";
            // 
            // textBoxNombreGenerico
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxNombreGenerico, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxNombreGenerico, 5);
            this.textBoxNombreGenerico.Location = new System.Drawing.Point(165, 115);
            this.textBoxNombreGenerico.MaxLength = 100;
            this.textBoxNombreGenerico.Name = "textBoxNombreGenerico";
            this.textBoxNombreGenerico.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreGenerico.TabIndex = 7;
            this.textBoxNombreGenerico.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreGenerico_Validating);
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.errorProviderFormulario.SetIconAlignment(this.comboBoxProveedor, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.comboBoxProveedor, 5);
            this.comboBoxProveedor.Location = new System.Drawing.Point(165, 12);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProveedor.TabIndex = 0;
            this.comboBoxProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxProveedor_Validating);
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(12, 15);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 348;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(12, 144);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 350;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxMarca, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxMarca, 5);
            this.textBoxMarca.Location = new System.Drawing.Point(165, 141);
            this.textBoxMarca.MaxLength = 100;
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(200, 20);
            this.textBoxMarca.TabIndex = 8;
            this.textBoxMarca.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMarca_Validating);
            // 
            // labelSaborUOlor
            // 
            this.labelSaborUOlor.AutoSize = true;
            this.labelSaborUOlor.Location = new System.Drawing.Point(12, 196);
            this.labelSaborUOlor.Name = "labelSaborUOlor";
            this.labelSaborUOlor.Size = new System.Drawing.Size(68, 13);
            this.labelSaborUOlor.TabIndex = 352;
            this.labelSaborUOlor.Text = "Sabor / Olor:";
            // 
            // textBoxSaborUOlor
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxSaborUOlor, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.textBoxSaborUOlor.Location = new System.Drawing.Point(165, 193);
            this.textBoxSaborUOlor.MaxLength = 100;
            this.textBoxSaborUOlor.Name = "textBoxSaborUOlor";
            this.textBoxSaborUOlor.Size = new System.Drawing.Size(200, 20);
            this.textBoxSaborUOlor.TabIndex = 10;
            this.textBoxSaborUOlor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSaborUOlor_Validating);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 224);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 353;
            this.labelTipo.Text = "Tipo:";
            // 
            // panelTipoDeProducto
            // 
            this.panelTipoDeProducto.Controls.Add(this.radioButtonTipoDeProductoBalanza);
            this.panelTipoDeProducto.Controls.Add(this.radioButtonTipoDeProductoInventario);
            this.panelTipoDeProducto.Location = new System.Drawing.Point(165, 219);
            this.panelTipoDeProducto.Name = "panelTipoDeProducto";
            this.panelTipoDeProducto.Size = new System.Drawing.Size(200, 23);
            this.panelTipoDeProducto.TabIndex = 11;
            // 
            // radioButtonTipoDeProductoBalanza
            // 
            this.radioButtonTipoDeProductoBalanza.AutoSize = true;
            this.radioButtonTipoDeProductoBalanza.Location = new System.Drawing.Point(81, 3);
            this.radioButtonTipoDeProductoBalanza.Name = "radioButtonTipoDeProductoBalanza";
            this.radioButtonTipoDeProductoBalanza.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTipoDeProductoBalanza.TabIndex = 12;
            this.radioButtonTipoDeProductoBalanza.Text = "Balanza";
            this.radioButtonTipoDeProductoBalanza.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoDeProductoInventario
            // 
            this.radioButtonTipoDeProductoInventario.AutoSize = true;
            this.radioButtonTipoDeProductoInventario.Checked = true;
            this.radioButtonTipoDeProductoInventario.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTipoDeProductoInventario.Name = "radioButtonTipoDeProductoInventario";
            this.radioButtonTipoDeProductoInventario.Size = new System.Drawing.Size(72, 17);
            this.radioButtonTipoDeProductoInventario.TabIndex = 11;
            this.radioButtonTipoDeProductoInventario.TabStop = true;
            this.radioButtonTipoDeProductoInventario.Text = "Inventario";
            this.radioButtonTipoDeProductoInventario.UseVisualStyleBackColor = true;
            // 
            // labelCantidadMinima
            // 
            this.labelCantidadMinima.AutoSize = true;
            this.labelCantidadMinima.Location = new System.Drawing.Point(12, 251);
            this.labelCantidadMinima.Name = "labelCantidadMinima";
            this.labelCantidadMinima.Size = new System.Drawing.Size(90, 13);
            this.labelCantidadMinima.TabIndex = 356;
            this.labelCantidadMinima.Text = "Cantidad Mínima:";
            // 
            // textBoxCantidadMinima
            // 
            this.textBoxCantidadMinima.ContextMenuStrip = this.contextMenuStripTextBox;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxCantidadMinima, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxCantidadMinima, 5);
            this.textBoxCantidadMinima.Location = new System.Drawing.Point(165, 248);
            this.textBoxCantidadMinima.MaxLength = 10;
            this.textBoxCantidadMinima.Name = "textBoxCantidadMinima";
            this.textBoxCantidadMinima.Size = new System.Drawing.Size(200, 20);
            this.textBoxCantidadMinima.TabIndex = 13;
            this.textBoxCantidadMinima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCantidadMinima_KeyDown);
            this.textBoxCantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidadMinima_KeyPress);
            this.textBoxCantidadMinima.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCantidadMinima_Validating);
            // 
            // contextMenuStripTextBox
            // 
            this.contextMenuStripTextBox.Name = "contextMenuStripTextBox";
            this.contextMenuStripTextBox.Size = new System.Drawing.Size(61, 4);
            // 
            // labelPrecioDeVenta
            // 
            this.labelPrecioDeVenta.AutoSize = true;
            this.labelPrecioDeVenta.Location = new System.Drawing.Point(12, 303);
            this.labelPrecioDeVenta.Name = "labelPrecioDeVenta";
            this.labelPrecioDeVenta.Size = new System.Drawing.Size(86, 13);
            this.labelPrecioDeVenta.TabIndex = 358;
            this.labelPrecioDeVenta.Text = "Precio de Venta:";
            // 
            // textBoxPrecioDeVenta
            // 
            this.textBoxPrecioDeVenta.ContextMenuStrip = this.contextMenuStripTextBox;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxPrecioDeVenta, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxPrecioDeVenta, 5);
            this.textBoxPrecioDeVenta.Location = new System.Drawing.Point(165, 300);
            this.textBoxPrecioDeVenta.MaxLength = 10;
            this.textBoxPrecioDeVenta.Name = "textBoxPrecioDeVenta";
            this.textBoxPrecioDeVenta.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrecioDeVenta.TabIndex = 15;
            this.textBoxPrecioDeVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrecioDeVenta_KeyDown);
            this.textBoxPrecioDeVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioDeVenta_KeyPress);
            this.textBoxPrecioDeVenta.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrecioDeVenta_Validating);
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(12, 329);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(32, 13);
            this.labelAlias.TabIndex = 360;
            this.labelAlias.Text = "Alias:";
            // 
            // textBoxAlias
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxAlias, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxAlias, 5);
            this.textBoxAlias.Location = new System.Drawing.Point(165, 326);
            this.textBoxAlias.MaxLength = 24;
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(200, 20);
            this.textBoxAlias.TabIndex = 16;
            this.textBoxAlias.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAlias_Validating);
            // 
            // labelPresentacion
            // 
            this.labelPresentacion.AutoSize = true;
            this.labelPresentacion.Location = new System.Drawing.Point(12, 170);
            this.labelPresentacion.Name = "labelPresentacion";
            this.labelPresentacion.Size = new System.Drawing.Size(72, 13);
            this.labelPresentacion.TabIndex = 362;
            this.labelPresentacion.Text = "Presentación:";
            // 
            // textBoxPresentacion
            // 
            this.textBoxPresentacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxPresentacion, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxPresentacion, 5);
            this.textBoxPresentacion.Location = new System.Drawing.Point(165, 167);
            this.textBoxPresentacion.MaxLength = 100;
            this.textBoxPresentacion.Name = "textBoxPresentacion";
            this.textBoxPresentacion.Size = new System.Drawing.Size(200, 20);
            this.textBoxPresentacion.TabIndex = 9;
            this.textBoxPresentacion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPresentacion_Validating);
            // 
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // textBoxPrecioDeCompra
            // 
            this.textBoxPrecioDeCompra.ContextMenuStrip = this.contextMenuStripTextBox;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxPrecioDeCompra, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxPrecioDeCompra, 5);
            this.textBoxPrecioDeCompra.Location = new System.Drawing.Point(165, 274);
            this.textBoxPrecioDeCompra.MaxLength = 10;
            this.textBoxPrecioDeCompra.Name = "textBoxPrecioDeCompra";
            this.textBoxPrecioDeCompra.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrecioDeCompra.TabIndex = 14;
            this.textBoxPrecioDeCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrecioDeCompra_KeyDown);
            this.textBoxPrecioDeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioDeCompra_KeyPress);
            this.textBoxPrecioDeCompra.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrecioDeCompra_Validating);
            // 
            // labelPrecioDeCompra
            // 
            this.labelPrecioDeCompra.AutoSize = true;
            this.labelPrecioDeCompra.Location = new System.Drawing.Point(12, 277);
            this.labelPrecioDeCompra.Name = "labelPrecioDeCompra";
            this.labelPrecioDeCompra.Size = new System.Drawing.Size(94, 13);
            this.labelPrecioDeCompra.TabIndex = 364;
            this.labelPrecioDeCompra.Text = "Precio de Compra:";
            // 
            // contextMenuStripFormulario
            // 
            this.contextMenuStripFormulario.Name = "contextMenuStripFormulario";
            this.contextMenuStripFormulario.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.FlatAppearance.BorderSize = 0;
            this.buttonAddProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProvider.Image = global::Super_Mercado_Mio.Properties.Resources.add16;
            this.buttonAddProvider.Location = new System.Drawing.Point(371, 12);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(21, 21);
            this.buttonAddProvider.TabIndex = 1;
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            this.buttonAddProvider.Click += new System.EventHandler(this.buttonAddProvider_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Image = global::Super_Mercado_Mio.Properties.Resources.add16;
            this.buttonAddGroup.Location = new System.Drawing.Point(371, 39);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(21, 21);
            this.buttonAddGroup.TabIndex = 3;
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(205, 352);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 18;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(110, 352);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 17;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonAddProvider);
            this.Controls.Add(this.labelPrecioDeCompra);
            this.Controls.Add(this.textBoxPrecioDeCompra);
            this.Controls.Add(this.labelPresentacion);
            this.Controls.Add(this.textBoxPresentacion);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.labelPrecioDeVenta);
            this.Controls.Add(this.textBoxPrecioDeVenta);
            this.Controls.Add(this.labelCantidadMinima);
            this.Controls.Add(this.textBoxCantidadMinima);
            this.Controls.Add(this.panelTipoDeProducto);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelSaborUOlor);
            this.Controls.Add(this.textBoxSaborUOlor);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.comboBoxProveedor);
            this.Controls.Add(this.labelNombreGenerico);
            this.Controls.Add(this.textBoxNombreGenerico);
            this.Controls.Add(this.labelTipoDeCodigoDeBarras);
            this.Controls.Add(this.radioButtonTipoDeCodigoDeBarrasSistema);
            this.Controls.Add(this.radioButtonTipoDeCodigoDeBarrasManual);
            this.Controls.Add(this.labelCodigoDeBarras);
            this.Controls.Add(this.textBoxCodigoDeBarras);
            this.Controls.Add(this.comboBoxGrupo);
            this.Controls.Add(this.labelGrupo);
            this.MaximizeBox = false;
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.panelTipoDeProducto.ResumeLayout(false);
            this.panelTipoDeProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelCodigoDeBarras;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.RadioButton radioButtonTipoDeCodigoDeBarrasManual;
        private System.Windows.Forms.RadioButton radioButtonTipoDeCodigoDeBarrasSistema;
        private System.Windows.Forms.Label labelTipoDeCodigoDeBarras;
        private System.Windows.Forms.Label labelNombreGenerico;
        private System.Windows.Forms.TextBox textBoxNombreGenerico;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelSaborUOlor;
        private System.Windows.Forms.TextBox textBoxSaborUOlor;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Panel panelTipoDeProducto;
        private System.Windows.Forms.RadioButton radioButtonTipoDeProductoInventario;
        private System.Windows.Forms.RadioButton radioButtonTipoDeProductoBalanza;
        private System.Windows.Forms.Label labelCantidadMinima;
        private System.Windows.Forms.TextBox textBoxCantidadMinima;
        private System.Windows.Forms.Label labelPrecioDeVenta;
        private System.Windows.Forms.TextBox textBoxPrecioDeVenta;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Label labelPresentacion;
        private System.Windows.Forms.TextBox textBoxPresentacion;
        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTextBox;
        private System.Windows.Forms.Label labelPrecioDeCompra;
        private System.Windows.Forms.TextBox textBoxPrecioDeCompra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFormulario;
        private System.Windows.Forms.Button buttonAddProvider;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}