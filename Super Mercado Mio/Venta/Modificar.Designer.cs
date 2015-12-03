namespace Super_Mercado_Mio.Venta
{
    partial class Modificar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.textBoxMontoPagado = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxCiONit = new System.Windows.Forms.TextBox();
            this.groupBoxDetalleDeVenta = new System.Windows.Forms.GroupBox();
            this.labelCodigoDeBarras = new System.Windows.Forms.Label();
            this.dataGridViewDetalleDeVenta = new System.Windows.Forms.DataGridView();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxNumeroVenta = new System.Windows.Forms.TextBox();
            this.labelNumeroDeVenta = new System.Windows.Forms.Label();
            this.checkBoxFacturaManual = new System.Windows.Forms.CheckBox();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.labelMontoPagado = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCiONit = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxDetalleDeVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxCodigoDeBarras
            // 
            this.textBoxCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxCodigoDeBarras, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxCodigoDeBarras, 5);
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(92, 25);
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(150, 26);
            this.textBoxCodigoDeBarras.TabIndex = 0;
            this.textBoxCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoDeBarras_KeyDown);
            // 
            // textBoxMontoPagado
            // 
            this.textBoxMontoPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMontoPagado.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxMontoPagado, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxMontoPagado, 5);
            this.textBoxMontoPagado.Location = new System.Drawing.Point(909, 235);
            this.textBoxMontoPagado.Name = "textBoxMontoPagado";
            this.textBoxMontoPagado.Size = new System.Drawing.Size(150, 35);
            this.textBoxMontoPagado.TabIndex = 2;
            this.textBoxMontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMontoPagado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMontoPagado_KeyDown);
            this.textBoxMontoPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoPagado_KeyPress);
            this.textBoxMontoPagado.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMontoPagado_Validating);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxCiONit
            // 
            this.textBoxCiONit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCiONit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxCiONit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxCiONit, 5);
            this.textBoxCiONit.Location = new System.Drawing.Point(909, 12);
            this.textBoxCiONit.MaxLength = 12;
            this.textBoxCiONit.Name = "textBoxCiONit";
            this.textBoxCiONit.Size = new System.Drawing.Size(150, 26);
            this.textBoxCiONit.TabIndex = 1;
            this.textBoxCiONit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCiONit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCiONit_KeyDown);
            this.textBoxCiONit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCiONit_KeyPress);
            this.textBoxCiONit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCiONit_Validating);
            // 
            // groupBoxDetalleDeVenta
            // 
            this.groupBoxDetalleDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetalleDeVenta.Controls.Add(this.buttonSearchProduct);
            this.groupBoxDetalleDeVenta.Controls.Add(this.textBoxCodigoDeBarras);
            this.groupBoxDetalleDeVenta.Controls.Add(this.labelCodigoDeBarras);
            this.groupBoxDetalleDeVenta.Controls.Add(this.dataGridViewDetalleDeVenta);
            this.groupBoxDetalleDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalleDeVenta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetalleDeVenta.Name = "groupBoxDetalleDeVenta";
            this.groupBoxDetalleDeVenta.Size = new System.Drawing.Size(714, 376);
            this.groupBoxDetalleDeVenta.TabIndex = 0;
            this.groupBoxDetalleDeVenta.TabStop = false;
            this.groupBoxDetalleDeVenta.Text = "Detalle de Venta";
            // 
            // labelCodigoDeBarras
            // 
            this.labelCodigoDeBarras.AutoSize = true;
            this.labelCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDeBarras.Location = new System.Drawing.Point(6, 28);
            this.labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            this.labelCodigoDeBarras.Size = new System.Drawing.Size(63, 20);
            this.labelCodigoDeBarras.TabIndex = 190;
            this.labelCodigoDeBarras.Text = "Código:";
            // 
            // dataGridViewDetalleDeVenta
            // 
            this.dataGridViewDetalleDeVenta.AllowUserToAddRows = false;
            this.dataGridViewDetalleDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDetalleDeVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleDeVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDetalleDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleDeVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Producto,
            this.Alias,
            this.Cantidad,
            this.Precio_Unitario,
            this.Monto_Total});
            this.dataGridViewDetalleDeVenta.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewDetalleDeVenta.Name = "dataGridViewDetalleDeVenta";
            this.dataGridViewDetalleDeVenta.Size = new System.Drawing.Size(702, 313);
            this.dataGridViewDetalleDeVenta.TabIndex = 203;
            this.dataGridViewDetalleDeVenta.TabStop = false;
            this.dataGridViewDetalleDeVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalleDeVenta_CellEndEdit);
            this.dataGridViewDetalleDeVenta.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetalleDeVenta_CellValidating);
            this.dataGridViewDetalleDeVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewDetalleDeVenta_RowsRemoved);
            this.dataGridViewDetalleDeVenta.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewDetalleDeVenta_UserDeletingRow);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(909, 162);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 26);
            this.textBoxFecha.TabIndex = 260;
            this.textBoxFecha.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFecha.Location = new System.Drawing.Point(732, 165);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(58, 20);
            this.labelFecha.TabIndex = 259;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxNumeroVenta
            // 
            this.textBoxNumeroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroVenta.Location = new System.Drawing.Point(909, 130);
            this.textBoxNumeroVenta.Name = "textBoxNumeroVenta";
            this.textBoxNumeroVenta.ReadOnly = true;
            this.textBoxNumeroVenta.Size = new System.Drawing.Size(150, 26);
            this.textBoxNumeroVenta.TabIndex = 258;
            this.textBoxNumeroVenta.TabStop = false;
            this.textBoxNumeroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumeroDeVenta
            // 
            this.labelNumeroDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumeroDeVenta.AutoSize = true;
            this.labelNumeroDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNumeroDeVenta.Location = new System.Drawing.Point(732, 133);
            this.labelNumeroDeVenta.Name = "labelNumeroDeVenta";
            this.labelNumeroDeVenta.Size = new System.Drawing.Size(141, 20);
            this.labelNumeroDeVenta.TabIndex = 257;
            this.labelNumeroDeVenta.Text = "Número De Venta:";
            // 
            // checkBoxFacturaManual
            // 
            this.checkBoxFacturaManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFacturaManual.AutoSize = true;
            this.checkBoxFacturaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFacturaManual.ForeColor = System.Drawing.Color.Red;
            this.checkBoxFacturaManual.Location = new System.Drawing.Point(812, 317);
            this.checkBoxFacturaManual.Name = "checkBoxFacturaManual";
            this.checkBoxFacturaManual.Size = new System.Drawing.Size(153, 24);
            this.checkBoxFacturaManual.TabIndex = 250;
            this.checkBoxFacturaManual.TabStop = false;
            this.checkBoxFacturaManual.Text = "Factura Manual";
            this.checkBoxFacturaManual.UseVisualStyleBackColor = true;
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(909, 194);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 35);
            this.textBoxMontoTotal.TabIndex = 256;
            this.textBoxMontoTotal.TabStop = false;
            this.textBoxMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMontoPagado
            // 
            this.labelMontoPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontoPagado.AutoSize = true;
            this.labelMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoPagado.Location = new System.Drawing.Point(732, 245);
            this.labelMontoPagado.Name = "labelMontoPagado";
            this.labelMontoPagado.Size = new System.Drawing.Size(154, 20);
            this.labelMontoPagado.TabIndex = 255;
            this.labelMontoPagado.Text = "Monto Pagado (Bs.):";
            this.labelMontoPagado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCambio.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCambio.Location = new System.Drawing.Point(909, 276);
            this.textBoxCambio.MaxLength = 10;
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.ReadOnly = true;
            this.textBoxCambio.Size = new System.Drawing.Size(150, 35);
            this.textBoxCambio.TabIndex = 262;
            this.textBoxCambio.TabStop = false;
            this.textBoxCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCambio
            // 
            this.labelCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(732, 286);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(100, 20);
            this.labelCambio.TabIndex = 254;
            this.labelCambio.Text = "Cambio (Bs.)";
            this.labelCambio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(732, 204);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(134, 20);
            this.labelMontoTotal.TabIndex = 253;
            this.labelMontoTotal.Text = "Monto Total (Bs.):";
            this.labelMontoTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(898, 347);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(909, 44);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(150, 80);
            this.textBoxCliente.TabIndex = 245;
            this.textBoxCliente.TabStop = false;
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCliente.Location = new System.Drawing.Point(732, 41);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(62, 20);
            this.labelCliente.TabIndex = 252;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelCiONit
            // 
            this.labelCiONit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCiONit.AutoSize = true;
            this.labelCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCiONit.Location = new System.Drawing.Point(732, 15);
            this.labelCiONit.Name = "labelCiONit";
            this.labelCiONit.Size = new System.Drawing.Size(71, 20);
            this.labelCiONit.TabIndex = 251;
            this.labelCiONit.Text = "CI ó NIT:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(803, 347);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchClient.FlatAppearance.BorderSize = 0;
            this.buttonSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClient.Image = global::Super_Mercado_Mio.Properties.Resources.search16;
            this.buttonSearchClient.Location = new System.Drawing.Point(1065, 16);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(21, 21);
            this.buttonSearchClient.TabIndex = 261;
            this.buttonSearchClient.TabStop = false;
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.FlatAppearance.BorderSize = 0;
            this.buttonSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchProduct.Image = global::Super_Mercado_Mio.Properties.Resources.search16;
            this.buttonSearchProduct.Location = new System.Drawing.Point(248, 29);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(21, 21);
            this.buttonSearchProduct.TabIndex = 204;
            this.buttonSearchProduct.TabStop = false;
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // Id
            // 
            dataGridViewCellStyle97.BackColor = System.Drawing.Color.Silver;
            this.Id.DefaultCellStyle = dataGridViewCellStyle97;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Id_Producto
            // 
            dataGridViewCellStyle98.BackColor = System.Drawing.Color.Silver;
            this.Id_Producto.DefaultCellStyle = dataGridViewCellStyle98;
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Producto.Visible = false;
            // 
            // Alias
            // 
            dataGridViewCellStyle99.BackColor = System.Drawing.Color.Silver;
            this.Alias.DefaultCellStyle = dataGridViewCellStyle99;
            this.Alias.HeaderText = "Producto";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            this.Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle100;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio_Unitario
            // 
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.Silver;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle101;
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Monto_Total
            // 
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto_Total.DefaultCellStyle = dataGridViewCellStyle102;
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 400);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.groupBoxDetalleDeVenta);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxNumeroVenta);
            this.Controls.Add(this.labelNumeroDeVenta);
            this.Controls.Add(this.checkBoxFacturaManual);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.labelMontoPagado);
            this.Controls.Add(this.textBoxMontoPagado);
            this.Controls.Add(this.textBoxCambio);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.labelMontoTotal);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.textBoxCiONit);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelCiONit);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Venta";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxDetalleDeVenta.ResumeLayout(false);
            this.groupBoxDetalleDeVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeVenta;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.Label labelCodigoDeBarras;
        private System.Windows.Forms.DataGridView dataGridViewDetalleDeVenta;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxNumeroVenta;
        private System.Windows.Forms.Label labelNumeroDeVenta;
        private System.Windows.Forms.CheckBox checkBoxFacturaManual;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.Label labelMontoPagado;
        private System.Windows.Forms.TextBox textBoxMontoPagado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.TextBox textBoxCiONit;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCiONit;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
    }
}