namespace Super_Mercado_Mio.Caja
{
    partial class Apertura
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelNumeroDeCaja = new System.Windows.Forms.Label();
            this.textBoxNumeroDeCaja = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(12, 43);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(66, 16);
            this.labelUsuario.TabIndex = 210;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(12, 137);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(46, 16);
            this.labelHora.TabIndex = 209;
            this.labelHora.Text = "Hora:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 109);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(55, 16);
            this.labelFecha.TabIndex = 208;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelNumeroDeCaja
            // 
            this.labelNumeroDeCaja.AutoSize = true;
            this.labelNumeroDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeCaja.Location = new System.Drawing.Point(12, 15);
            this.labelNumeroDeCaja.Name = "labelNumeroDeCaja";
            this.labelNumeroDeCaja.Size = new System.Drawing.Size(87, 16);
            this.labelNumeroDeCaja.TabIndex = 207;
            this.labelNumeroDeCaja.Text = "Nº de Caja:";
            // 
            // textBoxNumeroDeCaja
            // 
            this.textBoxNumeroDeCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDeCaja.Location = new System.Drawing.Point(122, 12);
            this.textBoxNumeroDeCaja.Name = "textBoxNumeroDeCaja";
            this.textBoxNumeroDeCaja.ReadOnly = true;
            this.textBoxNumeroDeCaja.Size = new System.Drawing.Size(150, 22);
            this.textBoxNumeroDeCaja.TabIndex = 215;
            this.textBoxNumeroDeCaja.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(122, 40);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 60);
            this.textBoxUsuario.TabIndex = 216;
            this.textBoxUsuario.TabStop = false;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(122, 106);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 22);
            this.textBoxFecha.TabIndex = 217;
            this.textBoxFecha.TabStop = false;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(122, 134);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.ReadOnly = true;
            this.textBoxHora.Size = new System.Drawing.Size(150, 22);
            this.textBoxHora.TabIndex = 218;
            this.textBoxHora.TabStop = false;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonto.Location = new System.Drawing.Point(122, 162);
            this.textBoxMonto.MaxLength = 10;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(150, 22);
            this.textBoxMonto.TabIndex = 0;
            this.textBoxMonto.Text = "0";
            this.textBoxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMonto_KeyDown);
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            this.textBoxMonto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMonto_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 221;
            this.label1.Text = "Monto:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(145, 190);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(50, 190);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Apertura
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxNumeroDeCaja);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumeroDeCaja);
            this.MaximizeBox = false;
            this.Name = "Apertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura de Caja";
            this.Load += new System.EventHandler(this.Apertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNumeroDeCaja;
        private System.Windows.Forms.TextBox textBoxNumeroDeCaja;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timerHora;
    }
}