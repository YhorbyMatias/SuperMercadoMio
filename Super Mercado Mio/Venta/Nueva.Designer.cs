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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textBoxNumeroVenta = new System.Windows.Forms.TextBox();
            this.lblNumeroDeVenta = new System.Windows.Forms.Label();
            this.checkBoxSinFactura = new System.Windows.Forms.CheckBox();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.textBoxVuelto = new System.Windows.Forms.TextBox();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.textBoxMontoPagado = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCIoNIT = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.lblCIoNIT = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBoxDetalleDeVenta = new System.Windows.Forms.GroupBox();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBoxDetalleDeVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre,
            this.Cantidad,
            this.Precio_Unitario,
            this.Precio_Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProductos.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(702, 296);
            this.dataGridViewProductos.TabIndex = 203;
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
            this.checkBoxSinFactura.Location = new System.Drawing.Point(823, 300);
            this.checkBoxSinFactura.Name = "checkBoxSinFactura";
            this.checkBoxSinFactura.Size = new System.Drawing.Size(167, 24);
            this.checkBoxSinFactura.TabIndex = 186;
            this.checkBoxSinFactura.Text = "Ventas Manuales";
            this.checkBoxSinFactura.UseVisualStyleBackColor = true;
            this.checkBoxSinFactura.Visible = false;
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(909, 194);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 26);
            this.textBoxMontoTotal.TabIndex = 200;
            this.textBoxMontoTotal.TabStop = false;
            this.textBoxMontoTotal.Text = "0";
            this.textBoxMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxVuelto
            // 
            this.textBoxVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVuelto.Location = new System.Drawing.Point(909, 258);
            this.textBoxVuelto.Name = "textBoxVuelto";
            this.textBoxVuelto.ReadOnly = true;
            this.textBoxVuelto.Size = new System.Drawing.Size(150, 26);
            this.textBoxVuelto.TabIndex = 199;
            this.textBoxVuelto.TabStop = false;
            this.textBoxVuelto.Text = "0";
            this.textBoxVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagado.Location = new System.Drawing.Point(732, 229);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(154, 20);
            this.lblMontoPagado.TabIndex = 198;
            this.lblMontoPagado.Text = "Monto Pagado (Bs.):";
            this.lblMontoPagado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMontoPagado
            // 
            this.textBoxMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoPagado.Location = new System.Drawing.Point(909, 226);
            this.textBoxMontoPagado.Name = "textBoxMontoPagado";
            this.textBoxMontoPagado.Size = new System.Drawing.Size(150, 26);
            this.textBoxMontoPagado.TabIndex = 185;
            this.textBoxMontoPagado.Text = "0";
            this.textBoxMontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(732, 261);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(100, 20);
            this.lblCambio.TabIndex = 196;
            this.lblCambio.Text = "Cambio (Bs.)";
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(732, 197);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(134, 20);
            this.lblMontoTotal.TabIndex = 195;
            this.lblMontoTotal.Text = "Monto Total (Bs.):";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(934, 330);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 188;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(839, 330);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 187;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // textBoxCIoNIT
            // 
            this.textBoxCIoNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCIoNIT.Location = new System.Drawing.Point(909, 12);
            this.textBoxCIoNIT.MaxLength = 12;
            this.textBoxCIoNIT.Name = "textBoxCIoNIT";
            this.textBoxCIoNIT.Size = new System.Drawing.Size(150, 26);
            this.textBoxCIoNIT.TabIndex = 180;
            this.textBoxCIoNIT.Text = "0";
            this.textBoxCIoNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.textBoxCodigoDeBarras.TabIndex = 183;
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
            this.groupBoxDetalleDeVenta.Size = new System.Drawing.Size(714, 359);
            this.groupBoxDetalleDeVenta.TabIndex = 206;
            this.groupBoxDetalleDeVenta.TabStop = false;
            this.groupBoxDetalleDeVenta.Text = "Detalle de Venta";
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
            // Nombre
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_Unitario
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.Precio_Unitario.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Precio_Total
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio_Total.HeaderText = "Precio Total";
            this.Precio_Total.Name = "Precio_Total";
            this.Precio_Total.ReadOnly = true;
            // 
            // Nueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 384);
            this.Controls.Add(this.groupBoxDetalleDeVenta);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxNumeroVenta);
            this.Controls.Add(this.lblNumeroDeVenta);
            this.Controls.Add(this.checkBoxSinFactura);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.textBoxVuelto);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.textBoxMontoPagado);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxCIoNIT);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCIoNIT);
            this.MaximizeBox = false;
            this.Name = "Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBoxDetalleDeVenta.ResumeLayout(false);
            this.groupBoxDetalleDeVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBoxNumeroVenta;
        private System.Windows.Forms.Label lblNumeroDeVenta;
        private System.Windows.Forms.CheckBox checkBoxSinFactura;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.TextBox textBoxVuelto;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.TextBox textBoxMontoPagado;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCIoNIT;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.Label lblCIoNIT;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBoxDetalleDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Total;
    }
}