namespace Super_Mercado_Mio.Caja
{
    partial class Cierre
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
            this.textBoxMontoDeAperturaDeCaja = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDeCaja = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelNumeroDeCaja = new System.Windows.Forms.Label();
            this.labelMontoDeAperturaDeCaja = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.textBoxMontoDeVentas = new System.Windows.Forms.TextBox();
            this.labelMontoDeVentas = new System.Windows.Forms.Label();
            this.textBoxMontoDeDevoluciones = new System.Windows.Forms.TextBox();
            this.labelMontoDeDevoluciones = new System.Windows.Forms.Label();
            this.textBoxMontoDeVentaDeTarjetas = new System.Windows.Forms.TextBox();
            this.labelMontoDeVentaDeTarjetas = new System.Windows.Forms.Label();
            this.textBoxMontoDePagos = new System.Windows.Forms.TextBox();
            this.labelMontoDePagos = new System.Windows.Forms.Label();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMontoDeAperturaDeCaja
            // 
            this.textBoxMontoDeAperturaDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoDeAperturaDeCaja.Location = new System.Drawing.Point(171, 162);
            this.textBoxMontoDeAperturaDeCaja.MaxLength = 10;
            this.textBoxMontoDeAperturaDeCaja.Name = "textBoxMontoDeAperturaDeCaja";
            this.textBoxMontoDeAperturaDeCaja.ReadOnly = true;
            this.textBoxMontoDeAperturaDeCaja.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoDeAperturaDeCaja.TabIndex = 222;
            this.textBoxMontoDeAperturaDeCaja.TabStop = false;
            this.textBoxMontoDeAperturaDeCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(172, 134);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.ReadOnly = true;
            this.textBoxHora.Size = new System.Drawing.Size(150, 22);
            this.textBoxHora.TabIndex = 232;
            this.textBoxHora.TabStop = false;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(172, 106);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 22);
            this.textBoxFecha.TabIndex = 231;
            this.textBoxFecha.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(172, 40);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 60);
            this.textBoxUsuario.TabIndex = 230;
            this.textBoxUsuario.TabStop = false;
            // 
            // textBoxNumeroDeCaja
            // 
            this.textBoxNumeroDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDeCaja.Location = new System.Drawing.Point(172, 12);
            this.textBoxNumeroDeCaja.Name = "textBoxNumeroDeCaja";
            this.textBoxNumeroDeCaja.ReadOnly = true;
            this.textBoxNumeroDeCaja.Size = new System.Drawing.Size(150, 22);
            this.textBoxNumeroDeCaja.TabIndex = 229;
            this.textBoxNumeroDeCaja.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(12, 43);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(66, 16);
            this.labelUsuario.TabIndex = 228;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(12, 137);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(46, 16);
            this.labelHora.TabIndex = 227;
            this.labelHora.Text = "Hora:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 109);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(55, 16);
            this.labelFecha.TabIndex = 226;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelNumeroDeCaja
            // 
            this.labelNumeroDeCaja.AutoSize = true;
            this.labelNumeroDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeCaja.Location = new System.Drawing.Point(12, 15);
            this.labelNumeroDeCaja.Name = "labelNumeroDeCaja";
            this.labelNumeroDeCaja.Size = new System.Drawing.Size(87, 16);
            this.labelNumeroDeCaja.TabIndex = 225;
            this.labelNumeroDeCaja.Text = "Nº de Caja:";
            // 
            // labelMontoDeAperturaDeCaja
            // 
            this.labelMontoDeAperturaDeCaja.AutoSize = true;
            this.labelMontoDeAperturaDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoDeAperturaDeCaja.Location = new System.Drawing.Point(12, 165);
            this.labelMontoDeAperturaDeCaja.Name = "labelMontoDeAperturaDeCaja";
            this.labelMontoDeAperturaDeCaja.Size = new System.Drawing.Size(129, 16);
            this.labelMontoDeAperturaDeCaja.TabIndex = 233;
            this.labelMontoDeAperturaDeCaja.Text = "Apertura de Caja:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            // 
            // textBoxMontoDeVentas
            // 
            this.textBoxMontoDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoDeVentas.Location = new System.Drawing.Point(172, 190);
            this.textBoxMontoDeVentas.MaxLength = 10;
            this.textBoxMontoDeVentas.Name = "textBoxMontoDeVentas";
            this.textBoxMontoDeVentas.ReadOnly = true;
            this.textBoxMontoDeVentas.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoDeVentas.TabIndex = 234;
            this.textBoxMontoDeVentas.TabStop = false;
            this.textBoxMontoDeVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMontoDeVentas
            // 
            this.labelMontoDeVentas.AutoSize = true;
            this.labelMontoDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoDeVentas.Location = new System.Drawing.Point(13, 193);
            this.labelMontoDeVentas.Name = "labelMontoDeVentas";
            this.labelMontoDeVentas.Size = new System.Drawing.Size(60, 16);
            this.labelMontoDeVentas.TabIndex = 235;
            this.labelMontoDeVentas.Text = "Ventas:";
            // 
            // textBoxMontoDeDevoluciones
            // 
            this.textBoxMontoDeDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoDeDevoluciones.Location = new System.Drawing.Point(172, 218);
            this.textBoxMontoDeDevoluciones.MaxLength = 10;
            this.textBoxMontoDeDevoluciones.Name = "textBoxMontoDeDevoluciones";
            this.textBoxMontoDeDevoluciones.ReadOnly = true;
            this.textBoxMontoDeDevoluciones.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoDeDevoluciones.TabIndex = 236;
            this.textBoxMontoDeDevoluciones.TabStop = false;
            this.textBoxMontoDeDevoluciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMontoDeDevoluciones
            // 
            this.labelMontoDeDevoluciones.AutoSize = true;
            this.labelMontoDeDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoDeDevoluciones.Location = new System.Drawing.Point(12, 221);
            this.labelMontoDeDevoluciones.Name = "labelMontoDeDevoluciones";
            this.labelMontoDeDevoluciones.Size = new System.Drawing.Size(107, 16);
            this.labelMontoDeDevoluciones.TabIndex = 237;
            this.labelMontoDeDevoluciones.Text = "Devoluciones:";
            // 
            // textBoxMontoDeVentaDeTarjetas
            // 
            this.textBoxMontoDeVentaDeTarjetas.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxMontoDeVentaDeTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxMontoDeVentaDeTarjetas, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxMontoDeVentaDeTarjetas, 5);
            this.textBoxMontoDeVentaDeTarjetas.Location = new System.Drawing.Point(172, 246);
            this.textBoxMontoDeVentaDeTarjetas.MaxLength = 10;
            this.textBoxMontoDeVentaDeTarjetas.Name = "textBoxMontoDeVentaDeTarjetas";
            this.textBoxMontoDeVentaDeTarjetas.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoDeVentaDeTarjetas.TabIndex = 0;
            this.textBoxMontoDeVentaDeTarjetas.Text = "0";
            this.textBoxMontoDeVentaDeTarjetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMontoDeVentaDeTarjetas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMontoDeVentaDeTarjetas_KeyDown);
            this.textBoxMontoDeVentaDeTarjetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoDeVentaDeTarjetas_KeyPress);
            this.textBoxMontoDeVentaDeTarjetas.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMontoDeVentaDeTarjetas_Validating);
            // 
            // labelMontoDeVentaDeTarjetas
            // 
            this.labelMontoDeVentaDeTarjetas.AutoSize = true;
            this.labelMontoDeVentaDeTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoDeVentaDeTarjetas.Location = new System.Drawing.Point(12, 249);
            this.labelMontoDeVentaDeTarjetas.Name = "labelMontoDeVentaDeTarjetas";
            this.labelMontoDeVentaDeTarjetas.Size = new System.Drawing.Size(136, 16);
            this.labelMontoDeVentaDeTarjetas.TabIndex = 239;
            this.labelMontoDeVentaDeTarjetas.Text = "Venta de Tarjetas:";
            // 
            // textBoxMontoDePagos
            // 
            this.textBoxMontoDePagos.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxMontoDePagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxMontoDePagos, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxMontoDePagos, 5);
            this.textBoxMontoDePagos.Location = new System.Drawing.Point(172, 274);
            this.textBoxMontoDePagos.MaxLength = 10;
            this.textBoxMontoDePagos.Name = "textBoxMontoDePagos";
            this.textBoxMontoDePagos.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoDePagos.TabIndex = 1;
            this.textBoxMontoDePagos.Text = "0";
            this.textBoxMontoDePagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMontoDePagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMontoDePagos_KeyDown);
            this.textBoxMontoDePagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontoDePagos_KeyPress);
            this.textBoxMontoDePagos.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMontoDePagos_Validating);
            // 
            // labelMontoDePagos
            // 
            this.labelMontoDePagos.AutoSize = true;
            this.labelMontoDePagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoDePagos.Location = new System.Drawing.Point(12, 277);
            this.labelMontoDePagos.Name = "labelMontoDePagos";
            this.labelMontoDePagos.Size = new System.Drawing.Size(57, 16);
            this.labelMontoDePagos.TabIndex = 241;
            this.labelMontoDePagos.Text = "Pagos:";
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(172, 302);
            this.textBoxMontoTotal.MaxLength = 10;
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(150, 22);
            this.textBoxMontoTotal.TabIndex = 242;
            this.textBoxMontoTotal.TabStop = false;
            this.textBoxMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(12, 305);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(48, 16);
            this.labelMontoTotal.TabIndex = 243;
            this.labelMontoTotal.Text = "Total:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(170, 330);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(75, 330);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(334, 383);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.labelMontoTotal);
            this.Controls.Add(this.textBoxMontoDePagos);
            this.Controls.Add(this.labelMontoDePagos);
            this.Controls.Add(this.textBoxMontoDeVentaDeTarjetas);
            this.Controls.Add(this.labelMontoDeVentaDeTarjetas);
            this.Controls.Add(this.textBoxMontoDeDevoluciones);
            this.Controls.Add(this.labelMontoDeDevoluciones);
            this.Controls.Add(this.textBoxMontoDeVentas);
            this.Controls.Add(this.labelMontoDeVentas);
            this.Controls.Add(this.textBoxMontoDeAperturaDeCaja);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxNumeroDeCaja);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumeroDeCaja);
            this.Controls.Add(this.labelMontoDeAperturaDeCaja);
            this.MaximizeBox = false;
            this.Name = "Cierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja";
            this.Load += new System.EventHandler(this.Cierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMontoDeAperturaDeCaja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNumeroDeCaja;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNumeroDeCaja;
        private System.Windows.Forms.Label labelMontoDeAperturaDeCaja;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.TextBox textBoxMontoDeVentas;
        private System.Windows.Forms.Label labelMontoDeVentas;
        private System.Windows.Forms.TextBox textBoxMontoDeDevoluciones;
        private System.Windows.Forms.Label labelMontoDeDevoluciones;
        private System.Windows.Forms.TextBox textBoxMontoDeVentaDeTarjetas;
        private System.Windows.Forms.Label labelMontoDeVentaDeTarjetas;
        private System.Windows.Forms.TextBox textBoxMontoDePagos;
        private System.Windows.Forms.Label labelMontoDePagos;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}