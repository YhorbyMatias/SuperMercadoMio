namespace Super_Mercado_Mio.Proveedor
{
    partial class Nuevo
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPersonaDeContacto = new System.Windows.Forms.Label();
            this.textBoxPersonaDeContacto = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelCelular = new System.Windows.Forms.Label();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.labelNumeroDeCuenta = new System.Windows.Forms.Label();
            this.textBoxNumeroDeCuenta = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNit = new System.Windows.Forms.Label();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 351;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxNombre, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxNombre, 5);
            this.textBoxNombre.Location = new System.Drawing.Point(145, 38);
            this.textBoxNombre.MaxLength = 300;
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 40);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // labelPersonaDeContacto
            // 
            this.labelPersonaDeContacto.AutoSize = true;
            this.labelPersonaDeContacto.Location = new System.Drawing.Point(12, 87);
            this.labelPersonaDeContacto.Name = "labelPersonaDeContacto";
            this.labelPersonaDeContacto.Size = new System.Drawing.Size(110, 13);
            this.labelPersonaDeContacto.TabIndex = 354;
            this.labelPersonaDeContacto.Text = "Persona de Contacto:";
            // 
            // textBoxPersonaDeContacto
            // 
            this.textBoxPersonaDeContacto.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxPersonaDeContacto, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxPersonaDeContacto, 5);
            this.textBoxPersonaDeContacto.Location = new System.Drawing.Point(145, 84);
            this.textBoxPersonaDeContacto.MaxLength = 300;
            this.textBoxPersonaDeContacto.Multiline = true;
            this.textBoxPersonaDeContacto.Name = "textBoxPersonaDeContacto";
            this.textBoxPersonaDeContacto.Size = new System.Drawing.Size(200, 40);
            this.textBoxPersonaDeContacto.TabIndex = 2;
            this.textBoxPersonaDeContacto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPersonaDeContacto_KeyDown);
            this.textBoxPersonaDeContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonaDeContacto_KeyPress);
            this.textBoxPersonaDeContacto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPersonaDeContacto_Validating);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(12, 133);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 356;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(145, 130);
            this.textBoxDireccion.MaxLength = 500;
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(200, 60);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 199);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 358;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxTelefono, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxTelefono, 5);
            this.textBoxTelefono.Location = new System.Drawing.Point(145, 196);
            this.textBoxTelefono.MaxLength = 8;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTelefono_KeyDown);
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            this.textBoxTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefono_Validating);
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(12, 225);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(42, 13);
            this.labelCelular.TabIndex = 360;
            this.labelCelular.Text = "Celular:";
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxCelular, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxCelular, 5);
            this.textBoxCelular.Location = new System.Drawing.Point(145, 222);
            this.textBoxCelular.MaxLength = 8;
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(200, 20);
            this.textBoxCelular.TabIndex = 5;
            this.textBoxCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCelular_KeyDown);
            this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelular_KeyPress);
            this.textBoxCelular.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCelular_Validating);
            // 
            // labelNumeroDeCuenta
            // 
            this.labelNumeroDeCuenta.AutoSize = true;
            this.labelNumeroDeCuenta.Location = new System.Drawing.Point(12, 251);
            this.labelNumeroDeCuenta.Name = "labelNumeroDeCuenta";
            this.labelNumeroDeCuenta.Size = new System.Drawing.Size(74, 13);
            this.labelNumeroDeCuenta.TabIndex = 362;
            this.labelNumeroDeCuenta.Text = "Nº de Cuenta:";
            // 
            // textBoxNumeroDeCuenta
            // 
            this.textBoxNumeroDeCuenta.Location = new System.Drawing.Point(145, 248);
            this.textBoxNumeroDeCuenta.MaxLength = 100;
            this.textBoxNumeroDeCuenta.Name = "textBoxNumeroDeCuenta";
            this.textBoxNumeroDeCuenta.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroDeCuenta.TabIndex = 6;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(181, 274);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(86, 274);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(12, 15);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(28, 13);
            this.labelNit.TabIndex = 364;
            this.labelNit.Text = "NIT:";
            // 
            // textBoxNit
            // 
            this.textBoxNit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProviderFormulario.SetIconAlignment(this.textBoxNit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxNit, 5);
            this.textBoxNit.Location = new System.Drawing.Point(145, 12);
            this.textBoxNit.MaxLength = 12;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(200, 20);
            this.textBoxNit.TabIndex = 0;
            this.textBoxNit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNit_KeyDown);
            this.textBoxNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNit_KeyPress);
            this.textBoxNit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNit_Validating);
            // 
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
            // 
            // Nuevo
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(357, 327);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNumeroDeCuenta);
            this.Controls.Add(this.textBoxNumeroDeCuenta);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.textBoxCelular);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelPersonaDeContacto);
            this.Controls.Add(this.textBoxPersonaDeContacto);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 366);
            this.MinimumSize = new System.Drawing.Size(373, 366);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proveedor";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPersonaDeContacto;
        private System.Windows.Forms.TextBox textBoxPersonaDeContacto;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.Label labelNumeroDeCuenta;
        private System.Windows.Forms.TextBox textBoxNumeroDeCuenta;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
    }
}