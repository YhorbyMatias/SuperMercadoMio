namespace Super_Mercado_Mio.Compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNit = new System.Windows.Forms.Label();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxNumeroDeRegistro = new System.Windows.Forms.TextBox();
            this.labelNumeroDeRegistro = new System.Windows.Forms.Label();
            this.textBoxNumeroDeNotaDeEntrega = new System.Windows.Forms.TextBox();
            this.labelNumeroDeNotaDeEntrega = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.groupBoxDetalleDeCompra = new System.Windows.Forms.GroupBox();
            this.labelCodigoDeBarras = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.dataGridViewDetalleDeIngreso = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.groupBoxDetalleDeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(12, 15);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(23, 13);
            this.labelNit.TabIndex = 0;
            this.labelNit.Text = "Nit:";
            // 
            // textBoxNit
            // 
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
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(77, 38);
            this.textBoxProveedor.Multiline = true;
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.ReadOnly = true;
            this.textBoxProveedor.Size = new System.Drawing.Size(150, 40);
            this.textBoxProveedor.TabIndex = 1;
            this.textBoxProveedor.TabStop = false;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(12, 41);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 2;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(335, 12);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 2;
            this.textBoxFecha.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(250, 15);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxNumeroDeRegistro
            // 
            this.textBoxNumeroDeRegistro.Location = new System.Drawing.Point(335, 38);
            this.textBoxNumeroDeRegistro.Name = "textBoxNumeroDeRegistro";
            this.textBoxNumeroDeRegistro.ReadOnly = true;
            this.textBoxNumeroDeRegistro.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDeRegistro.TabIndex = 3;
            this.textBoxNumeroDeRegistro.TabStop = false;
            this.textBoxNumeroDeRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumeroDeRegistro
            // 
            this.labelNumeroDeRegistro.AutoSize = true;
            this.labelNumeroDeRegistro.Location = new System.Drawing.Point(250, 41);
            this.labelNumeroDeRegistro.Name = "labelNumeroDeRegistro";
            this.labelNumeroDeRegistro.Size = new System.Drawing.Size(79, 13);
            this.labelNumeroDeRegistro.TabIndex = 6;
            this.labelNumeroDeRegistro.Text = "Nº de Registro:";
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
            // labelNumeroDeNotaDeEntrega
            // 
            this.labelNumeroDeNotaDeEntrega.AutoSize = true;
            this.labelNumeroDeNotaDeEntrega.Location = new System.Drawing.Point(441, 15);
            this.labelNumeroDeNotaDeEntrega.Name = "labelNumeroDeNotaDeEntrega";
            this.labelNumeroDeNotaDeEntrega.Size = new System.Drawing.Size(118, 13);
            this.labelNumeroDeNotaDeEntrega.TabIndex = 8;
            this.labelNumeroDeNotaDeEntrega.Text = "Nº de Nota de Entrega:";
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
            this.labelObservaciones.TabIndex = 10;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(565, 38);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.ReadOnly = true;
            this.textBoxMonto.Size = new System.Drawing.Size(150, 20);
            this.textBoxMonto.TabIndex = 11;
            this.textBoxMonto.TabStop = false;
            this.textBoxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(441, 41);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(40, 13);
            this.labelMonto.TabIndex = 12;
            this.labelMonto.Text = "Monto:";
            // 
            // groupBoxDetalleDeCompra
            // 
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleDeIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalleDeIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleDeIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewDetalleDeIngreso.Location = new System.Drawing.Point(9, 45);
            this.dataGridViewDetalleDeIngreso.MultiSelect = false;
            this.dataGridViewDetalleDeIngreso.Name = "dataGridViewDetalleDeIngreso";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleDeIngreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewDetalleDeIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleDeIngreso.Size = new System.Drawing.Size(998, 297);
            this.dataGridViewDetalleDeIngreso.TabIndex = 4;
            this.dataGridViewDetalleDeIngreso.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetalleDeIngreso_CellValidating);
            this.dataGridViewDetalleDeIngreso.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewDetalleDeIngreso_UserDeletingRow);
            this.dataGridViewDetalleDeIngreso.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridViewDetalleDeIngreso_Validating);
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
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // Id_Producto
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.Id_Producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Visible = false;
            // 
            // Codigo_De_Barras
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.Codigo_De_Barras.DefaultCellStyle = dataGridViewCellStyle3;
            this.Codigo_De_Barras.HeaderText = "Código de Barras";
            this.Codigo_De_Barras.Name = "Codigo_De_Barras";
            this.Codigo_De_Barras.ReadOnly = true;
            // 
            // Nombre_Generico
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre_Generico.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre_Generico.HeaderText = "Nombre Genérico";
            this.Nombre_Generico.Name = "Nombre_Generico";
            this.Nombre_Generico.ReadOnly = true;
            // 
            // Marca
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle5;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Presentacion
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Presentacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Presentacion.HeaderText = "Presentación";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Sabor_U_Olor
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sabor_U_Olor.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sabor_U_Olor.HeaderText = "Sabor U Olor";
            this.Sabor_U_Olor.Name = "Sabor_U_Olor";
            this.Sabor_U_Olor.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_De_Compra
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_De_Compra.DefaultCellStyle = dataGridViewCellStyle9;
            this.Precio_De_Compra.HeaderText = "Precio de Compra";
            this.Precio_De_Compra.Name = "Precio_De_Compra";
            // 
            // Monto_Total
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto_Total.DefaultCellStyle = dataGridViewCellStyle10;
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            // 
            // Porcentaje_De_Utilidad
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Porcentaje_De_Utilidad.DefaultCellStyle = dataGridViewCellStyle11;
            this.Porcentaje_De_Utilidad.HeaderText = "% de Utilidad";
            this.Porcentaje_De_Utilidad.Name = "Porcentaje_De_Utilidad";
            // 
            // Precio_De_Venta
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_De_Venta.DefaultCellStyle = dataGridViewCellStyle12;
            this.Precio_De_Venta.HeaderText = "Precio de Venta";
            this.Precio_De_Venta.Name = "Precio_De_Venta";
            // 
            // Nueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
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
            this.Name = "Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Compra";
            this.Load += new System.EventHandler(this.Nueva_Load);
            this.groupBoxDetalleDeCompra.ResumeLayout(false);
            this.groupBoxDetalleDeCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleDeIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxNumeroDeRegistro;
        private System.Windows.Forms.Label labelNumeroDeRegistro;
        private System.Windows.Forms.TextBox textBoxNumeroDeNotaDeEntrega;
        private System.Windows.Forms.Label labelNumeroDeNotaDeEntrega;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeCompra;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelCodigoDeBarras;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.DataGridView dataGridViewDetalleDeIngreso;
        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
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