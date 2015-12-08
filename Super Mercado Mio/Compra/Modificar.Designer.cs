namespace Super_Mercado_Mio.Compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxNumeroDeNotaDeEntrega = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxDetalleDeCompra = new System.Windows.Forms.GroupBox();
            this.labelCodigoDeBarras = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.dataGridViewDetalleDeIngreso = new System.Windows.Forms.DataGridView();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelNumeroDeNotaDeEntrega = new System.Windows.Forms.Label();
            this.textBoxNumeroDeRegistro = new System.Windows.Forms.TextBox();
            this.labelNumeroDeRegistro = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_De_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Generico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor_U_Olor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_De_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_De_Utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_De_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.groupBoxDetalleDeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // textBoxNumeroDeNotaDeEntrega
            // 
            this.errorProviderFormulario.SetIconPadding(this.textBoxNumeroDeNotaDeEntrega, 5);
            this.textBoxNumeroDeNotaDeEntrega.Location = new System.Drawing.Point(565, 12);
            this.textBoxNumeroDeNotaDeEntrega.MaxLength = 50;
            this.textBoxNumeroDeNotaDeEntrega.Name = "textBoxNumeroDeNotaDeEntrega";
            this.textBoxNumeroDeNotaDeEntrega.Size = new System.Drawing.Size(150, 20);
            this.textBoxNumeroDeNotaDeEntrega.TabIndex = 1;
            this.textBoxNumeroDeNotaDeEntrega.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeroDeNotaDeEntrega_Validating);
            // 
            // textBoxNit
            // 
            this.textBoxNit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProviderFormulario.SetIconPadding(this.textBoxNit, 5);
            this.textBoxNit.Location = new System.Drawing.Point(77, 12);
            this.textBoxNit.MaxLength = 12;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(150, 20);
            this.textBoxNit.TabIndex = 0;
            this.textBoxNit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNit_KeyDown);
            this.textBoxNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNit_KeyPress);
            this.textBoxNit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNit_Validating);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripEmpty";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(521, 438);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(426, 438);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxDetalleDeCompra
            // 
            this.groupBoxDetalleDeCompra.Controls.Add(this.searchProductButton);
            this.groupBoxDetalleDeCompra.Controls.Add(this.labelCodigoDeBarras);
            this.groupBoxDetalleDeCompra.Controls.Add(this.textBoxCodigoDeBarras);
            this.groupBoxDetalleDeCompra.Controls.Add(this.dataGridViewDetalleDeIngreso);
            this.groupBoxDetalleDeCompra.Location = new System.Drawing.Point(12, 84);
            this.groupBoxDetalleDeCompra.Name = "groupBoxDetalleDeCompra";
            this.groupBoxDetalleDeCompra.Size = new System.Drawing.Size(1013, 348);
            this.groupBoxDetalleDeCompra.TabIndex = 3;
            this.groupBoxDetalleDeCompra.TabStop = false;
            this.groupBoxDetalleDeCompra.Text = "Detalle de Compra";
            // 
            // labelCodigoDeBarras
            // 
            this.labelCodigoDeBarras.AutoSize = true;
            this.labelCodigoDeBarras.Location = new System.Drawing.Point(6, 22);
            this.labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            this.labelCodigoDeBarras.Size = new System.Drawing.Size(91, 13);
            this.labelCodigoDeBarras.TabIndex = 256;
            this.labelCodigoDeBarras.Text = "Código de Barras:";
            // 
            // textBoxCodigoDeBarras
            // 
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(103, 19);
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(150, 20);
            this.textBoxCodigoDeBarras.TabIndex = 3;
            this.textBoxCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoDeBarras_KeyDown);
            // 
            // dataGridViewDetalleDeIngreso
            // 
            this.dataGridViewDetalleDeIngreso.AllowUserToAddRows = false;
            this.dataGridViewDetalleDeIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleDeIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewDetalleDeIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleDeIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Producto,
            this.Codigo_De_Barras,
            this.Nombre_Generico,
            this.Marca,
            this.Presentacion,
            this.Sabor_U_Olor,
            this.Cantidad,
            this.Precio_De_Compra,
            this.Monto_Total,
            this.Porcentaje_De_Utilidad,
            this.Precio_De_Venta});
            this.dataGridViewDetalleDeIngreso.Location = new System.Drawing.Point(9, 46);
            this.dataGridViewDetalleDeIngreso.MultiSelect = false;
            this.dataGridViewDetalleDeIngreso.Name = "dataGridViewDetalleDeIngreso";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleDeIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewDetalleDeIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleDeIngreso.Size = new System.Drawing.Size(998, 296);
            this.dataGridViewDetalleDeIngreso.TabIndex = 4;
            this.dataGridViewDetalleDeIngreso.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetalleDeIngreso_CellValidating);
            this.dataGridViewDetalleDeIngreso.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewDetalleDeIngreso_RowsRemoved);
            this.dataGridViewDetalleDeIngreso.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewDetalleDeIngreso_UserDeletingRow);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(565, 38);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.ReadOnly = true;
            this.textBoxMonto.Size = new System.Drawing.Size(150, 20);
            this.textBoxMonto.TabIndex = 28;
            this.textBoxMonto.TabStop = false;
            this.textBoxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(441, 41);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(40, 13);
            this.labelMonto.TabIndex = 29;
            this.labelMonto.Text = "Monto:";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Location = new System.Drawing.Point(825, 12);
            this.textBoxObservaciones.MaxLength = 500;
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(200, 66);
            this.textBoxObservaciones.TabIndex = 2;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(738, 15);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(81, 13);
            this.labelObservaciones.TabIndex = 27;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelNumeroDeNotaDeEntrega
            // 
            this.labelNumeroDeNotaDeEntrega.AutoSize = true;
            this.labelNumeroDeNotaDeEntrega.Location = new System.Drawing.Point(441, 15);
            this.labelNumeroDeNotaDeEntrega.Name = "labelNumeroDeNotaDeEntrega";
            this.labelNumeroDeNotaDeEntrega.Size = new System.Drawing.Size(118, 13);
            this.labelNumeroDeNotaDeEntrega.TabIndex = 26;
            this.labelNumeroDeNotaDeEntrega.Text = "Nº de Nota de Entrega:";
            // 
            // textBoxNumeroDeRegistro
            // 
            this.textBoxNumeroDeRegistro.Location = new System.Drawing.Point(335, 38);
            this.textBoxNumeroDeRegistro.Name = "textBoxNumeroDeRegistro";
            this.textBoxNumeroDeRegistro.ReadOnly = true;
            this.textBoxNumeroDeRegistro.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDeRegistro.TabIndex = 21;
            this.textBoxNumeroDeRegistro.TabStop = false;
            this.textBoxNumeroDeRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumeroDeRegistro
            // 
            this.labelNumeroDeRegistro.AutoSize = true;
            this.labelNumeroDeRegistro.Location = new System.Drawing.Point(250, 41);
            this.labelNumeroDeRegistro.Name = "labelNumeroDeRegistro";
            this.labelNumeroDeRegistro.Size = new System.Drawing.Size(79, 13);
            this.labelNumeroDeRegistro.TabIndex = 25;
            this.labelNumeroDeRegistro.Text = "Nº de Registro:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(335, 12);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 18;
            this.textBoxFecha.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(250, 15);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 22;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(77, 38);
            this.textBoxProveedor.Multiline = true;
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.ReadOnly = true;
            this.textBoxProveedor.Size = new System.Drawing.Size(150, 40);
            this.textBoxProveedor.TabIndex = 15;
            this.textBoxProveedor.TabStop = false;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(12, 41);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 19;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(12, 15);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(23, 13);
            this.labelNit.TabIndex = 14;
            this.labelNit.Text = "Nit:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Id_Producto
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            this.Id_Producto.DefaultCellStyle = dataGridViewCellStyle15;
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Visible = false;
            // 
            // Codigo_De_Barras
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            this.Codigo_De_Barras.DefaultCellStyle = dataGridViewCellStyle16;
            this.Codigo_De_Barras.HeaderText = "Código de Barras";
            this.Codigo_De_Barras.Name = "Codigo_De_Barras";
            this.Codigo_De_Barras.ReadOnly = true;
            // 
            // Nombre_Generico
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre_Generico.DefaultCellStyle = dataGridViewCellStyle17;
            this.Nombre_Generico.HeaderText = "Nombre Genérico";
            this.Nombre_Generico.Name = "Nombre_Generico";
            this.Nombre_Generico.ReadOnly = true;
            // 
            // Marca
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle18;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Presentacion
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Presentacion.DefaultCellStyle = dataGridViewCellStyle19;
            this.Presentacion.HeaderText = "Presentación";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Sabor_U_Olor
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sabor_U_Olor.DefaultCellStyle = dataGridViewCellStyle20;
            this.Sabor_U_Olor.HeaderText = "Sabor U Olor";
            this.Sabor_U_Olor.Name = "Sabor_U_Olor";
            this.Sabor_U_Olor.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle21;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_De_Compra
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_De_Compra.DefaultCellStyle = dataGridViewCellStyle22;
            this.Precio_De_Compra.HeaderText = "Precio de Compra";
            this.Precio_De_Compra.Name = "Precio_De_Compra";
            // 
            // Monto_Total
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto_Total.DefaultCellStyle = dataGridViewCellStyle23;
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            // 
            // Porcentaje_De_Utilidad
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Porcentaje_De_Utilidad.DefaultCellStyle = dataGridViewCellStyle24;
            this.Porcentaje_De_Utilidad.HeaderText = "% de Utilidad";
            this.Porcentaje_De_Utilidad.Name = "Porcentaje_De_Utilidad";
            // 
            // Precio_De_Venta
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_De_Venta.DefaultCellStyle = dataGridViewCellStyle25;
            this.Precio_De_Venta.HeaderText = "Precio de Venta";
            this.Precio_De_Venta.Name = "Precio_De_Venta";
            // 
            // searchProductButton
            // 
            this.searchProductButton.FlatAppearance.BorderSize = 0;
            this.searchProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductButton.Image = global::Super_Mercado_Mio.Properties.Resources.search16;
            this.searchProductButton.Location = new System.Drawing.Point(276, 19);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(21, 21);
            this.searchProductButton.TabIndex = 258;
            this.searchProductButton.TabStop = false;
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 491);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxDetalleDeCompra);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.labelObservaciones);
            this.Controls.Add(this.textBoxNumeroDeNotaDeEntrega);
            this.Controls.Add(this.labelNumeroDeNotaDeEntrega);
            this.Controls.Add(this.textBoxNumeroDeRegistro);
            this.Controls.Add(this.labelNumeroDeRegistro);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.labelNit);
            this.MaximizeBox = false;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Compra";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.groupBoxDetalleDeCompra.ResumeLayout(false);
            this.groupBoxDetalleDeCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeCompra;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.Label labelCodigoDeBarras;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.DataGridView dataGridViewDetalleDeIngreso;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.TextBox textBoxNumeroDeNotaDeEntrega;
        private System.Windows.Forms.Label labelNumeroDeNotaDeEntrega;
        private System.Windows.Forms.TextBox textBoxNumeroDeRegistro;
        private System.Windows.Forms.Label labelNumeroDeRegistro;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_De_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Generico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor_U_Olor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_De_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_De_Utilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_De_Venta;
    }
}