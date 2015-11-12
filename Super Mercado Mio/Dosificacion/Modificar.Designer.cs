namespace Super_Mercado_Mio.Dosificacion
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelLeyenda = new System.Windows.Forms.Label();
            this.textBoxLeyenda = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaLimiteDeEmision = new System.Windows.Forms.DateTimePicker();
            this.labelFechaLimiteDeEmision = new System.Windows.Forms.Label();
            this.textBoxLlave = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelLlave = new System.Windows.Forms.Label();
            this.labelNumeroDeSucursal = new System.Windows.Forms.Label();
            this.textBoxNumeroDeSucursal = new System.Windows.Forms.TextBox();
            this.labelNumeroDeAutorizacion = new System.Windows.Forms.Label();
            this.textBoxNumeroDeAutorizacion = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(199, 288);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 173;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(104, 288);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 172;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(12, 263);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(48, 15);
            this.labelEstado.TabIndex = 179;
            this.labelEstado.Text = "Estado:";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(181, 262);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(200, 20);
            this.textBoxEstado.TabIndex = 171;
            // 
            // labelLeyenda
            // 
            this.labelLeyenda.AutoSize = true;
            this.labelLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyenda.Location = new System.Drawing.Point(12, 157);
            this.labelLeyenda.Name = "labelLeyenda";
            this.labelLeyenda.Size = new System.Drawing.Size(57, 15);
            this.labelLeyenda.TabIndex = 178;
            this.labelLeyenda.Text = "Leyenda:";
            // 
            // textBoxLeyenda
            // 
            this.errorProvider.SetIconAlignment(this.textBoxLeyenda, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxLeyenda, 5);
            this.textBoxLeyenda.Location = new System.Drawing.Point(181, 156);
            this.textBoxLeyenda.Multiline = true;
            this.textBoxLeyenda.Name = "textBoxLeyenda";
            this.textBoxLeyenda.Size = new System.Drawing.Size(200, 100);
            this.textBoxLeyenda.TabIndex = 170;
            this.textBoxLeyenda.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLeyenda_Validating);
            // 
            // dateTimePickerFechaLimiteDeEmision
            // 
            this.dateTimePickerFechaLimiteDeEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconAlignment(this.dateTimePickerFechaLimiteDeEmision, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.dateTimePickerFechaLimiteDeEmision, 5);
            this.dateTimePickerFechaLimiteDeEmision.Location = new System.Drawing.Point(181, 130);
            this.dateTimePickerFechaLimiteDeEmision.Name = "dateTimePickerFechaLimiteDeEmision";
            this.dateTimePickerFechaLimiteDeEmision.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaLimiteDeEmision.TabIndex = 169;
            this.dateTimePickerFechaLimiteDeEmision.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerFechaLimiteDeEmision_Validating);
            // 
            // labelFechaLimiteDeEmision
            // 
            this.labelFechaLimiteDeEmision.AutoSize = true;
            this.labelFechaLimiteDeEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLimiteDeEmision.Location = new System.Drawing.Point(12, 130);
            this.labelFechaLimiteDeEmision.Name = "labelFechaLimiteDeEmision";
            this.labelFechaLimiteDeEmision.Size = new System.Drawing.Size(146, 15);
            this.labelFechaLimiteDeEmision.TabIndex = 177;
            this.labelFechaLimiteDeEmision.Text = "Fecha Límite de Emisión:";
            // 
            // textBoxLlave
            // 
            this.textBoxLlave.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxLlave, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxLlave, 5);
            this.textBoxLlave.Location = new System.Drawing.Point(181, 64);
            this.textBoxLlave.MaxLength = 256;
            this.textBoxLlave.Multiline = true;
            this.textBoxLlave.Name = "textBoxLlave";
            this.textBoxLlave.Size = new System.Drawing.Size(200, 60);
            this.textBoxLlave.TabIndex = 168;
            this.textBoxLlave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLlave_KeyDown);
            this.textBoxLlave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLlave_KeyPress);
            this.textBoxLlave.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLlave_Validating);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripEmpty";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // labelLlave
            // 
            this.labelLlave.AutoSize = true;
            this.labelLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLlave.Location = new System.Drawing.Point(12, 65);
            this.labelLlave.Name = "labelLlave";
            this.labelLlave.Size = new System.Drawing.Size(39, 15);
            this.labelLlave.TabIndex = 176;
            this.labelLlave.Text = "Llave:";
            // 
            // labelNumeroDeSucursal
            // 
            this.labelNumeroDeSucursal.AutoSize = true;
            this.labelNumeroDeSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeSucursal.Location = new System.Drawing.Point(12, 13);
            this.labelNumeroDeSucursal.Name = "labelNumeroDeSucursal";
            this.labelNumeroDeSucursal.Size = new System.Drawing.Size(91, 15);
            this.labelNumeroDeSucursal.TabIndex = 175;
            this.labelNumeroDeSucursal.Text = "Nº de Sucursal:";
            // 
            // textBoxNumeroDeSucursal
            // 
            this.textBoxNumeroDeSucursal.Location = new System.Drawing.Point(181, 12);
            this.textBoxNumeroDeSucursal.Name = "textBoxNumeroDeSucursal";
            this.textBoxNumeroDeSucursal.ReadOnly = true;
            this.textBoxNumeroDeSucursal.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroDeSucursal.TabIndex = 166;
            // 
            // labelNumeroDeAutorizacion
            // 
            this.labelNumeroDeAutorizacion.AutoSize = true;
            this.labelNumeroDeAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeAutorizacion.Location = new System.Drawing.Point(12, 39);
            this.labelNumeroDeAutorizacion.Name = "labelNumeroDeAutorizacion";
            this.labelNumeroDeAutorizacion.Size = new System.Drawing.Size(110, 15);
            this.labelNumeroDeAutorizacion.TabIndex = 174;
            this.labelNumeroDeAutorizacion.Text = "Nº de Autorización:";
            // 
            // textBoxNumeroDeAutorizacion
            // 
            this.textBoxNumeroDeAutorizacion.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxNumeroDeAutorizacion, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNumeroDeAutorizacion, 5);
            this.textBoxNumeroDeAutorizacion.Location = new System.Drawing.Point(181, 38);
            this.textBoxNumeroDeAutorizacion.MaxLength = 15;
            this.textBoxNumeroDeAutorizacion.Name = "textBoxNumeroDeAutorizacion";
            this.textBoxNumeroDeAutorizacion.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroDeAutorizacion.TabIndex = 167;
            this.textBoxNumeroDeAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumeroDeAutorizacion_KeyDown);
            this.textBoxNumeroDeAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroDeAutorizacion_KeyPress);
            this.textBoxNumeroDeAutorizacion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeroDeAutorizacion_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 341);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.labelLeyenda);
            this.Controls.Add(this.textBoxLeyenda);
            this.Controls.Add(this.dateTimePickerFechaLimiteDeEmision);
            this.Controls.Add(this.labelFechaLimiteDeEmision);
            this.Controls.Add(this.textBoxLlave);
            this.Controls.Add(this.labelLlave);
            this.Controls.Add(this.labelNumeroDeSucursal);
            this.Controls.Add(this.textBoxNumeroDeSucursal);
            this.Controls.Add(this.labelNumeroDeAutorizacion);
            this.Controls.Add(this.textBoxNumeroDeAutorizacion);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Dosificación";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelLeyenda;
        private System.Windows.Forms.TextBox textBoxLeyenda;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaLimiteDeEmision;
        private System.Windows.Forms.Label labelFechaLimiteDeEmision;
        private System.Windows.Forms.TextBox textBoxLlave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.Label labelLlave;
        private System.Windows.Forms.Label labelNumeroDeSucursal;
        private System.Windows.Forms.TextBox textBoxNumeroDeSucursal;
        private System.Windows.Forms.Label labelNumeroDeAutorizacion;
        private System.Windows.Forms.TextBox textBoxNumeroDeAutorizacion;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}