namespace Super_Mercado_Mio.Sucursal
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
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(193, 215);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(98, 215);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(12, 192);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 348;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // textBoxMunicipio
            // 
            this.errorProvider.SetIconAlignment(this.textBoxMunicipio, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxMunicipio, 5);
            this.textBoxMunicipio.Location = new System.Drawing.Point(116, 189);
            this.textBoxMunicipio.MaxLength = 100;
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(250, 20);
            this.textBoxMunicipio.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 166);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 347;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.errorProvider.SetIconAlignment(this.textBoxTelefono, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxTelefono, 5);
            this.textBoxTelefono.Location = new System.Drawing.Point(116, 163);
            this.textBoxTelefono.MaxLength = 8;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(250, 20);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(116, 38);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.ReadOnly = true;
            this.textBoxNit.Size = new System.Drawing.Size(250, 20);
            this.textBoxNit.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 15);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 346;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(12, 41);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(28, 13);
            this.lblNit.TabIndex = 345;
            this.lblNit.Text = "NIT:";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(116, 12);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.ReadOnly = true;
            this.textBoxEmpresa.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmpresa.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 93);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 344;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 67);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 13);
            this.lblNumero.TabIndex = 343;
            this.lblNumero.Text = "Nº de Sucursal:";
            // 
            // textBoxDireccion
            // 
            this.errorProvider.SetIconAlignment(this.textBoxDireccion, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxDireccion, 5);
            this.textBoxDireccion.Location = new System.Drawing.Point(116, 90);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(250, 67);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxNumero, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNumero, 5);
            this.textBoxNumero.Location = new System.Drawing.Point(116, 64);
            this.textBoxNumero.MaxLength = 3;
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(250, 20);
            this.textBoxNumero.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Modificar
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(378, 268);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.textBoxMunicipio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNumero);
            this.MaximumSize = new System.Drawing.Size(394, 307);
            this.MinimumSize = new System.Drawing.Size(394, 307);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Sucursal";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox textBoxMunicipio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}