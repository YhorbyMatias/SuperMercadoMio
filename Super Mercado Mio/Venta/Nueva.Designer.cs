namespace Super_Mercado_Mio.Venta
{
    partial class Nueva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textBoxNumeroVenta = new System.Windows.Forms.TextBox();
            this.lblNumeroDeVenta = new System.Windows.Forms.Label();
            this.checkBoxSinFactura = new System.Windows.Forms.CheckBox();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.textBoxMontoPagado = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelCambio = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCiONit = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.lblCIoNIT = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBoxDetalleDeVenta = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBoxDetalleDeVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Alias,
            this.Cantidad,
            this.Precio_Unitario,
            this.Precio_Total});
            this.dataGridViewProductos.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(702, 313);
            this.dataGridViewProductos.TabIndex = 203;
            this.dataGridViewProductos.TabStop = false;
            // 
            // textBoxNumeroVenta
            // 
            this.textBoxNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroVenta.Location = new System.Drawing.Point(909, 130);
            this.textBoxNumeroVenta.Name = "textBoxNumeroVenta";
            this.textBoxNumeroVenta.ReadOnly = true;
            this.textBoxNumeroVenta.Size = new System.Drawing.Size(150, 26);
            this.textBoxNumeroVenta.TabIndex = 202;
            this.textBoxNumeroVenta.TabStop = false;
            this.textBoxNumeroVenta.Text = "N";
            this.textBoxNumeroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumeroDeVenta
            // 
            this.lblNumeroDeVenta.AutoSize = true;
            this.lblNumeroDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumeroDeVenta.Location = new System.Drawing.Point(732, 133);
            this.lblNumeroDeVenta.Name = "lblNumeroDeVenta";
            this.lblNumeroDeVenta.Size = new System.Drawing.Size(141, 20);
            this.lblNumeroDeVenta.TabIndex = 201;
            this.lblNumeroDeVenta.Text = "Número De Venta:";
            // 
            // checkBoxSinFactura
            // 
            this.checkBoxSinFactura.AutoSize = true;
            this.checkBoxSinFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSinFactura.ForeColor = System.Drawing.Color.Red;
            this.checkBoxSinFactura.Location = new System.Drawing.Point(812, 317);
            this.checkBoxSinFactura.Name = "checkBoxSinFactura";
            this.checkBoxSinFactura.Size = new System.Drawing.Size(167, 24);
            this.checkBoxSinFactura.TabIndex = 186;
            this.checkBoxSinFactura.TabStop = false;
            this.checkBoxSinFactura.Text = "Ventas Manuales";
            this.checkBoxSinFactura.UseVisualStyleBackColor = true;
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(909, 194);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 35);
            this.textBoxMontoTotal.TabIndex = 200;
            this.textBoxMontoTotal.TabStop = false;
            this.textBoxMontoTotal.Text = "0";
            this.textBoxMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCambio.Location = new System.Drawing.Point(909, 276);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(150, 35);
            this.textBoxCambio.TabIndex = 199;
            this.textBoxCambio.TabStop = false;
            this.textBoxCambio.Text = "0";
            this.textBoxCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagado.Location = new System.Drawing.Point(732, 245);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(154, 20);
            this.lblMontoPagado.TabIndex = 198;
            this.lblMontoPagado.Text = "Monto Pagado (Bs.):";
            this.lblMontoPagado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMontoPagado
            // 
            this.textBoxMontoPagado.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(732, 286);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(100, 20);
            this.labelCambio.TabIndex = 196;
            this.labelCambio.Text = "Cambio (Bs.)";
            this.labelCambio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(732, 204);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(134, 20);
            this.lblMontoTotal.TabIndex = 195;
            this.lblMontoTotal.Text = "Monto Total (Bs.):";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCerrar
            // 
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
            // buttonGuardar
            // 
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
            // textBoxCiONit
            // 
            this.textBoxCiONit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiONit.Location = new System.Drawing.Point(909, 12);
            this.textBoxCiONit.MaxLength = 12;
            this.textBoxCiONit.Name = "textBoxCiONit";
            this.textBoxCiONit.Size = new System.Drawing.Size(150, 26);
            this.textBoxCiONit.TabIndex = 1;
            this.textBoxCiONit.Text = "0";
            this.textBoxCiONit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCiONit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCiONit_KeyDown);
            this.textBoxCiONit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCiONit_KeyPress);
            this.textBoxCiONit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCiONit_Validating);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(909, 44);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(150, 80);
            this.textBoxCliente.TabIndex = 1;
            this.textBoxCliente.TabStop = false;
            this.textBoxCliente.Text = "VENTAS MENORES";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliente.Location = new System.Drawing.Point(732, 41);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 193;
            this.lblCliente.Text = "Cliente:";
            // 
            // textBoxCodigoDeBarras
            // 
            this.textBoxCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(75, 25);
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(150, 26);
            this.textBoxCodigoDeBarras.TabIndex = 0;
            this.textBoxCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoDeBarras_KeyDown);
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(6, 28);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(63, 20);
            this.lblCodigoDeBarras.TabIndex = 190;
            this.lblCodigoDeBarras.Text = "Código:";
            // 
            // lblCIoNIT
            // 
            this.lblCIoNIT.AutoSize = true;
            this.lblCIoNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCIoNIT.Location = new System.Drawing.Point(732, 15);
            this.lblCIoNIT.Name = "lblCIoNIT";
            this.lblCIoNIT.Size = new System.Drawing.Size(71, 20);
            this.lblCIoNIT.TabIndex = 189;
            this.lblCIoNIT.Text = "CI ó NIT:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(909, 162);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 26);
            this.textBoxFecha.TabIndex = 205;
            this.textBoxFecha.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFecha.Location = new System.Drawing.Point(732, 165);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(58, 20);
            this.labelFecha.TabIndex = 204;
            this.labelFecha.Text = "Fecha:";
            // 
            // groupBoxDetalleDeVenta
            // 
            this.groupBoxDetalleDeVenta.Controls.Add(this.textBoxCodigoDeBarras);
            this.groupBoxDetalleDeVenta.Controls.Add(this.lblCodigoDeBarras);
            this.groupBoxDetalleDeVenta.Controls.Add(this.dataGridViewProductos);
            this.groupBoxDetalleDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalleDeVenta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetalleDeVenta.Name = "groupBoxDetalleDeVenta";
            this.groupBoxDetalleDeVenta.Size = new System.Drawing.Size(714, 376);
            this.groupBoxDetalleDeVenta.TabIndex = 0;
            this.groupBoxDetalleDeVenta.TabStop = false;
            this.groupBoxDetalleDeVenta.Text = "Detalle de Venta";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Id
            // 
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.Silver;
            this.Id.DefaultCellStyle = dataGridViewCellStyle36;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Alias
            // 
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.Silver;
            this.Alias.DefaultCellStyle = dataGridViewCellStyle37;
            this.Alias.HeaderText = "Producto";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            this.Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle38;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio_Unitario
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.Silver;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle39;
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio_Total
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Total.DefaultCellStyle = dataGridViewCellStyle40;
            this.Precio_Total.HeaderText = "Precio Total";
            this.Precio_Total.Name = "Precio_Total";
            this.Precio_Total.ReadOnly = true;
            this.Precio_Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 400);
            this.Controls.Add(this.groupBoxDetalleDeVenta);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxNumeroVenta);
            this.Controls.Add(this.lblNumeroDeVenta);
            this.Controls.Add(this.checkBoxSinFactura);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.textBoxCambio);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.textBoxMontoPagado);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxCiONit);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCIoNIT);
            this.Name = "Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.Nueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBoxDetalleDeVenta.ResumeLayout(false);
            this.groupBoxDetalleDeVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBoxNumeroVenta;
        private System.Windows.Forms.Label lblNumeroDeVenta;
        private System.Windows.Forms.CheckBox checkBoxSinFactura;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.TextBox textBoxMontoPagado;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCiONit;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.Label lblCIoNIT;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeVenta;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Total;
    }
}