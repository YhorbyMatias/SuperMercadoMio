namespace Super_Mercado_Mio.Factura
{
    partial class Anular
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
            this.labelSearchCodigoControl = new System.Windows.Forms.Label();
            this.textBoxSearchCodigoDeControl = new System.Windows.Forms.TextBox();
            this.buttonSearchFactura = new System.Windows.Forms.Button();
            this.groupBoxFactura = new System.Windows.Forms.GroupBox();
            this.labelNumeroDeAutorizacionTexto = new System.Windows.Forms.Label();
            this.textBoxNumeroDeAutorizacion = new System.Windows.Forms.TextBox();
            this.labelNumeroDeFactura = new System.Windows.Forms.Label();
            this.textBoxNumeroDeFactura = new System.Windows.Forms.TextBox();
            this.labelCodigoDeControl = new System.Windows.Forms.Label();
            this.textBoxCodigoDeControl = new System.Windows.Forms.TextBox();
            this.labelCiONit = new System.Windows.Forms.Label();
            this.textBoxCiONit = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxFechaLimiteDeEmision = new System.Windows.Forms.TextBox();
            this.labelFechaLimiteDeEmision = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.labelMontoPagado = new System.Windows.Forms.Label();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.textBoxMontoPagado = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.labelCaja = new System.Windows.Forms.Label();
            this.textBoxCaja = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.groupBoxDetalleDeFactura = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetalleFactura = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonAnular = new System.Windows.Forms.Button();
            this.groupBoxFactura.SuspendLayout();
            this.groupBoxDetalleDeFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchCodigoControl
            // 
            this.labelSearchCodigoControl.AutoSize = true;
            this.labelSearchCodigoControl.Location = new System.Drawing.Point(12, 15);
            this.labelSearchCodigoControl.Name = "labelSearchCodigoControl";
            this.labelSearchCodigoControl.Size = new System.Drawing.Size(94, 13);
            this.labelSearchCodigoControl.TabIndex = 236;
            this.labelSearchCodigoControl.Text = "Código de Control:";
            // 
            // textBoxSearchCodigoDeControl
            // 
            this.textBoxSearchCodigoDeControl.Location = new System.Drawing.Point(129, 12);
            this.textBoxSearchCodigoDeControl.Name = "textBoxSearchCodigoDeControl";
            this.textBoxSearchCodigoDeControl.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearchCodigoDeControl.TabIndex = 0;
            this.textBoxSearchCodigoDeControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchCodigoDeControl_KeyDown);
            this.textBoxSearchCodigoDeControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchCodigoDeControl_KeyPress);
            this.textBoxSearchCodigoDeControl.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSearchCodigoDeControl_Validating);
            // 
            // buttonSearchFactura
            // 
            this.buttonSearchFactura.FlatAppearance.BorderSize = 0;
            this.buttonSearchFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchFactura.Image = global::Super_Mercado_Mio.Properties.Resources.search16;
            this.buttonSearchFactura.Location = new System.Drawing.Point(285, 12);
            this.buttonSearchFactura.Name = "buttonSearchFactura";
            this.buttonSearchFactura.Size = new System.Drawing.Size(21, 21);
            this.buttonSearchFactura.TabIndex = 259;
            this.buttonSearchFactura.TabStop = false;
            this.buttonSearchFactura.UseVisualStyleBackColor = true;
            this.buttonSearchFactura.Click += new System.EventHandler(this.buttonSearchFactura_Click);
            // 
            // groupBoxFactura
            // 
            this.groupBoxFactura.Controls.Add(this.groupBoxDetalleDeFactura);
            this.groupBoxFactura.Controls.Add(this.textBoxUsuario);
            this.groupBoxFactura.Controls.Add(this.labelUsuario);
            this.groupBoxFactura.Controls.Add(this.textBoxCaja);
            this.groupBoxFactura.Controls.Add(this.labelCaja);
            this.groupBoxFactura.Controls.Add(this.textBoxCambio);
            this.groupBoxFactura.Controls.Add(this.textBoxMontoTotal);
            this.groupBoxFactura.Controls.Add(this.textBoxHora);
            this.groupBoxFactura.Controls.Add(this.textBoxMontoPagado);
            this.groupBoxFactura.Controls.Add(this.labelCambio);
            this.groupBoxFactura.Controls.Add(this.labelMontoPagado);
            this.groupBoxFactura.Controls.Add(this.labelMontoTotal);
            this.groupBoxFactura.Controls.Add(this.labelHora);
            this.groupBoxFactura.Controls.Add(this.textBoxFecha);
            this.groupBoxFactura.Controls.Add(this.labelFecha);
            this.groupBoxFactura.Controls.Add(this.textBoxFechaLimiteDeEmision);
            this.groupBoxFactura.Controls.Add(this.labelFechaLimiteDeEmision);
            this.groupBoxFactura.Controls.Add(this.textBoxCliente);
            this.groupBoxFactura.Controls.Add(this.labelCliente);
            this.groupBoxFactura.Controls.Add(this.textBoxCiONit);
            this.groupBoxFactura.Controls.Add(this.labelCiONit);
            this.groupBoxFactura.Controls.Add(this.textBoxCodigoDeControl);
            this.groupBoxFactura.Controls.Add(this.labelCodigoDeControl);
            this.groupBoxFactura.Controls.Add(this.textBoxNumeroDeFactura);
            this.groupBoxFactura.Controls.Add(this.labelNumeroDeFactura);
            this.groupBoxFactura.Controls.Add(this.textBoxNumeroDeAutorizacion);
            this.groupBoxFactura.Controls.Add(this.labelNumeroDeAutorizacionTexto);
            this.groupBoxFactura.Location = new System.Drawing.Point(12, 39);
            this.groupBoxFactura.Name = "groupBoxFactura";
            this.groupBoxFactura.Size = new System.Drawing.Size(789, 487);
            this.groupBoxFactura.TabIndex = 260;
            this.groupBoxFactura.TabStop = false;
            this.groupBoxFactura.Text = "Factura";
            // 
            // labelNumeroDeAutorizacionTexto
            // 
            this.labelNumeroDeAutorizacionTexto.AutoSize = true;
            this.labelNumeroDeAutorizacionTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeAutorizacionTexto.Location = new System.Drawing.Point(6, 22);
            this.labelNumeroDeAutorizacionTexto.Name = "labelNumeroDeAutorizacionTexto";
            this.labelNumeroDeAutorizacionTexto.Size = new System.Drawing.Size(142, 15);
            this.labelNumeroDeAutorizacionTexto.TabIndex = 213;
            this.labelNumeroDeAutorizacionTexto.Text = "Número de Autorización:";
            // 
            // textBoxNumeroDeAutorizacion
            // 
            this.textBoxNumeroDeAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDeAutorizacion.Location = new System.Drawing.Point(158, 19);
            this.textBoxNumeroDeAutorizacion.Name = "textBoxNumeroDeAutorizacion";
            this.textBoxNumeroDeAutorizacion.ReadOnly = true;
            this.textBoxNumeroDeAutorizacion.Size = new System.Drawing.Size(150, 21);
            this.textBoxNumeroDeAutorizacion.TabIndex = 261;
            this.textBoxNumeroDeAutorizacion.TabStop = false;
            // 
            // labelNumeroDeFactura
            // 
            this.labelNumeroDeFactura.AutoSize = true;
            this.labelNumeroDeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeFactura.Location = new System.Drawing.Point(6, 49);
            this.labelNumeroDeFactura.Name = "labelNumeroDeFactura";
            this.labelNumeroDeFactura.Size = new System.Drawing.Size(116, 15);
            this.labelNumeroDeFactura.TabIndex = 262;
            this.labelNumeroDeFactura.Text = "Número de Factura:";
            // 
            // textBoxNumeroDeFactura
            // 
            this.textBoxNumeroDeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDeFactura.Location = new System.Drawing.Point(158, 46);
            this.textBoxNumeroDeFactura.Name = "textBoxNumeroDeFactura";
            this.textBoxNumeroDeFactura.ReadOnly = true;
            this.textBoxNumeroDeFactura.Size = new System.Drawing.Size(150, 21);
            this.textBoxNumeroDeFactura.TabIndex = 263;
            this.textBoxNumeroDeFactura.TabStop = false;
            // 
            // labelCodigoDeControl
            // 
            this.labelCodigoDeControl.AutoSize = true;
            this.labelCodigoDeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDeControl.Location = new System.Drawing.Point(6, 76);
            this.labelCodigoDeControl.Name = "labelCodigoDeControl";
            this.labelCodigoDeControl.Size = new System.Drawing.Size(108, 15);
            this.labelCodigoDeControl.TabIndex = 264;
            this.labelCodigoDeControl.Text = "Código de Control:";
            // 
            // textBoxCodigoDeControl
            // 
            this.textBoxCodigoDeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoDeControl.Location = new System.Drawing.Point(158, 73);
            this.textBoxCodigoDeControl.Name = "textBoxCodigoDeControl";
            this.textBoxCodigoDeControl.ReadOnly = true;
            this.textBoxCodigoDeControl.Size = new System.Drawing.Size(150, 21);
            this.textBoxCodigoDeControl.TabIndex = 265;
            this.textBoxCodigoDeControl.TabStop = false;
            // 
            // labelCiONit
            // 
            this.labelCiONit.AutoSize = true;
            this.labelCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiONit.Location = new System.Drawing.Point(314, 49);
            this.labelCiONit.Name = "labelCiONit";
            this.labelCiONit.Size = new System.Drawing.Size(53, 15);
            this.labelCiONit.TabIndex = 266;
            this.labelCiONit.Text = "Ci ó NIT:";
            // 
            // textBoxCiONit
            // 
            this.textBoxCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiONit.Location = new System.Drawing.Point(373, 46);
            this.textBoxCiONit.Name = "textBoxCiONit";
            this.textBoxCiONit.ReadOnly = true;
            this.textBoxCiONit.Size = new System.Drawing.Size(150, 21);
            this.textBoxCiONit.TabIndex = 267;
            this.textBoxCiONit.TabStop = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(314, 76);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(48, 15);
            this.labelCliente.TabIndex = 268;
            this.labelCliente.Text = "Cliente:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(373, 73);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(150, 75);
            this.textBoxCliente.TabIndex = 269;
            this.textBoxCliente.TabStop = false;
            // 
            // textBoxFechaLimiteDeEmision
            // 
            this.textBoxFechaLimiteDeEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaLimiteDeEmision.Location = new System.Drawing.Point(158, 100);
            this.textBoxFechaLimiteDeEmision.Name = "textBoxFechaLimiteDeEmision";
            this.textBoxFechaLimiteDeEmision.ReadOnly = true;
            this.textBoxFechaLimiteDeEmision.Size = new System.Drawing.Size(150, 21);
            this.textBoxFechaLimiteDeEmision.TabIndex = 271;
            this.textBoxFechaLimiteDeEmision.TabStop = false;
            // 
            // labelFechaLimiteDeEmision
            // 
            this.labelFechaLimiteDeEmision.AutoSize = true;
            this.labelFechaLimiteDeEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLimiteDeEmision.Location = new System.Drawing.Point(6, 103);
            this.labelFechaLimiteDeEmision.Name = "labelFechaLimiteDeEmision";
            this.labelFechaLimiteDeEmision.Size = new System.Drawing.Size(146, 15);
            this.labelFechaLimiteDeEmision.TabIndex = 270;
            this.labelFechaLimiteDeEmision.Text = "Fecha Límite de Emisión:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(529, 22);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(44, 15);
            this.labelFecha.TabIndex = 272;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(626, 19);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 21);
            this.textBoxFecha.TabIndex = 273;
            this.textBoxFecha.TabStop = false;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(529, 130);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(53, 15);
            this.labelCambio.TabIndex = 277;
            this.labelCambio.Text = "Cambio:";
            // 
            // labelMontoPagado
            // 
            this.labelMontoPagado.AutoSize = true;
            this.labelMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoPagado.Location = new System.Drawing.Point(529, 103);
            this.labelMontoPagado.Name = "labelMontoPagado";
            this.labelMontoPagado.Size = new System.Drawing.Size(91, 15);
            this.labelMontoPagado.TabIndex = 276;
            this.labelMontoPagado.Text = "Monto Pagado:";
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(529, 76);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(75, 15);
            this.labelMontoTotal.TabIndex = 275;
            this.labelMontoTotal.Text = "Monto Total:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(529, 49);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(37, 15);
            this.labelHora.TabIndex = 274;
            this.labelHora.Text = "Hora:";
            // 
            // textBoxMontoPagado
            // 
            this.textBoxMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoPagado.Location = new System.Drawing.Point(626, 100);
            this.textBoxMontoPagado.Name = "textBoxMontoPagado";
            this.textBoxMontoPagado.ReadOnly = true;
            this.textBoxMontoPagado.Size = new System.Drawing.Size(150, 21);
            this.textBoxMontoPagado.TabIndex = 278;
            this.textBoxMontoPagado.TabStop = false;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(626, 46);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.ReadOnly = true;
            this.textBoxHora.Size = new System.Drawing.Size(150, 21);
            this.textBoxHora.TabIndex = 279;
            this.textBoxHora.TabStop = false;
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(626, 73);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 21);
            this.textBoxMontoTotal.TabIndex = 280;
            this.textBoxMontoTotal.TabStop = false;
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.Location = new System.Drawing.Point(626, 127);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.ReadOnly = true;
            this.textBoxCambio.Size = new System.Drawing.Size(150, 21);
            this.textBoxCambio.TabIndex = 281;
            this.textBoxCambio.TabStop = false;
            // 
            // labelCaja
            // 
            this.labelCaja.AutoSize = true;
            this.labelCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaja.Location = new System.Drawing.Point(314, 22);
            this.labelCaja.Name = "labelCaja";
            this.labelCaja.Size = new System.Drawing.Size(35, 15);
            this.labelCaja.TabIndex = 282;
            this.labelCaja.Text = "Caja:";
            // 
            // textBoxCaja
            // 
            this.textBoxCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaja.Location = new System.Drawing.Point(373, 19);
            this.textBoxCaja.Name = "textBoxCaja";
            this.textBoxCaja.ReadOnly = true;
            this.textBoxCaja.Size = new System.Drawing.Size(150, 21);
            this.textBoxCaja.TabIndex = 283;
            this.textBoxCaja.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(6, 130);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(53, 15);
            this.labelUsuario.TabIndex = 284;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(158, 127);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 21);
            this.textBoxUsuario.TabIndex = 285;
            this.textBoxUsuario.TabStop = false;
            // 
            // groupBoxDetalleDeFactura
            // 
            this.groupBoxDetalleDeFactura.Controls.Add(this.dataGridViewDetalleFactura);
            this.groupBoxDetalleDeFactura.Location = new System.Drawing.Point(9, 154);
            this.groupBoxDetalleDeFactura.Name = "groupBoxDetalleDeFactura";
            this.groupBoxDetalleDeFactura.Size = new System.Drawing.Size(774, 327);
            this.groupBoxDetalleDeFactura.TabIndex = 286;
            this.groupBoxDetalleDeFactura.TabStop = false;
            this.groupBoxDetalleDeFactura.Text = "Detalle";
            // 
            // dataGridViewDetalleFactura
            // 
            this.dataGridViewDetalleFactura.AllowUserToAddRows = false;
            this.dataGridViewDetalleFactura.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFactura.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDetalleFactura.MultiSelect = false;
            this.dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            this.dataGridViewDetalleFactura.ReadOnly = true;
            this.dataGridViewDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleFactura.Size = new System.Drawing.Size(762, 302);
            this.dataGridViewDetalleFactura.TabIndex = 287;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(409, 532);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(100, 41);
            this.buttonCerrar.TabIndex = 262;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonAnular
            // 
            this.buttonAnular.Location = new System.Drawing.Point(303, 532);
            this.buttonAnular.Name = "buttonAnular";
            this.buttonAnular.Size = new System.Drawing.Size(100, 41);
            this.buttonAnular.TabIndex = 261;
            this.buttonAnular.Text = "Anular";
            this.buttonAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnular.UseVisualStyleBackColor = true;
            this.buttonAnular.Click += new System.EventHandler(this.buttonAnular_Click);
            // 
            // Anular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 585);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonAnular);
            this.Controls.Add(this.groupBoxFactura);
            this.Controls.Add(this.buttonSearchFactura);
            this.Controls.Add(this.labelSearchCodigoControl);
            this.Controls.Add(this.textBoxSearchCodigoDeControl);
            this.Name = "Anular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular Factura";
            this.Load += new System.EventHandler(this.Anular_Load);
            this.groupBoxFactura.ResumeLayout(false);
            this.groupBoxFactura.PerformLayout();
            this.groupBoxDetalleDeFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchCodigoControl;
        private System.Windows.Forms.TextBox textBoxSearchCodigoDeControl;
        private System.Windows.Forms.Button buttonSearchFactura;
        private System.Windows.Forms.GroupBox groupBoxFactura;
        private System.Windows.Forms.TextBox textBoxNumeroDeAutorizacion;
        private System.Windows.Forms.Label labelNumeroDeAutorizacionTexto;
        private System.Windows.Forms.Label labelNumeroDeFactura;
        private System.Windows.Forms.TextBox textBoxNumeroDeFactura;
        private System.Windows.Forms.TextBox textBoxCodigoDeControl;
        private System.Windows.Forms.Label labelCodigoDeControl;
        private System.Windows.Forms.TextBox textBoxCiONit;
        private System.Windows.Forms.Label labelCiONit;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxFechaLimiteDeEmision;
        private System.Windows.Forms.Label labelFechaLimiteDeEmision;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label labelMontoPagado;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxMontoPagado;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label labelCaja;
        private System.Windows.Forms.TextBox textBoxCaja;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeFactura;
        private System.Windows.Forms.DataGridView dataGridViewDetalleFactura;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonAnular;
    }
}