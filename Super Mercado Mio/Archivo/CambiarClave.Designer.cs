namespace Super_Mercado_Mio.Archivo
{
    partial class CambiarClave
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
            this.labelConfirmarNuevaClave = new System.Windows.Forms.Label();
            this.labelNuevaClave = new System.Windows.Forms.Label();
            this.textBoxConfirmarNuevaClave = new System.Windows.Forms.TextBox();
            this.textBoxNuevaClave = new System.Windows.Forms.TextBox();
            this.textBoxClaveActual = new System.Windows.Forms.TextBox();
            this.labelClaveActual = new System.Windows.Forms.Label();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(163, 90);
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
            this.buttonGuardar.Location = new System.Drawing.Point(68, 90);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelConfirmarNuevaClave
            // 
            this.labelConfirmarNuevaClave.AutoSize = true;
            this.labelConfirmarNuevaClave.Location = new System.Drawing.Point(12, 67);
            this.labelConfirmarNuevaClave.Name = "labelConfirmarNuevaClave";
            this.labelConfirmarNuevaClave.Size = new System.Drawing.Size(124, 13);
            this.labelConfirmarNuevaClave.TabIndex = 167;
            this.labelConfirmarNuevaClave.Text = "Confirme la nueva clave:";
            // 
            // labelNuevaClave
            // 
            this.labelNuevaClave.AutoSize = true;
            this.labelNuevaClave.Location = new System.Drawing.Point(12, 41);
            this.labelNuevaClave.Name = "labelNuevaClave";
            this.labelNuevaClave.Size = new System.Drawing.Size(72, 13);
            this.labelNuevaClave.TabIndex = 166;
            this.labelNuevaClave.Text = "Nueva Clave:";
            // 
            // textBoxConfirmarNuevaClave
            // 
            this.errorProviderFormulario.SetIconPadding(this.textBoxConfirmarNuevaClave, 5);
            this.textBoxConfirmarNuevaClave.Location = new System.Drawing.Point(142, 64);
            this.textBoxConfirmarNuevaClave.Name = "textBoxConfirmarNuevaClave";
            this.textBoxConfirmarNuevaClave.PasswordChar = '*';
            this.textBoxConfirmarNuevaClave.Size = new System.Drawing.Size(150, 20);
            this.textBoxConfirmarNuevaClave.TabIndex = 2;
            this.textBoxConfirmarNuevaClave.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxConfirmarNuevaClave_Validating);
            // 
            // textBoxNuevaClave
            // 
            this.errorProviderFormulario.SetIconPadding(this.textBoxNuevaClave, 5);
            this.textBoxNuevaClave.Location = new System.Drawing.Point(142, 38);
            this.textBoxNuevaClave.Name = "textBoxNuevaClave";
            this.textBoxNuevaClave.PasswordChar = '*';
            this.textBoxNuevaClave.Size = new System.Drawing.Size(150, 20);
            this.textBoxNuevaClave.TabIndex = 1;
            this.textBoxNuevaClave.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNuevaClave_Validating);
            // 
            // textBoxClaveActual
            // 
            this.errorProviderFormulario.SetIconPadding(this.textBoxClaveActual, 5);
            this.textBoxClaveActual.Location = new System.Drawing.Point(142, 12);
            this.textBoxClaveActual.Name = "textBoxClaveActual";
            this.textBoxClaveActual.PasswordChar = '*';
            this.textBoxClaveActual.Size = new System.Drawing.Size(150, 20);
            this.textBoxClaveActual.TabIndex = 0;
            this.textBoxClaveActual.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClaveActual_Validating);
            // 
            // labelClaveActual
            // 
            this.labelClaveActual.AutoSize = true;
            this.labelClaveActual.Location = new System.Drawing.Point(12, 15);
            this.labelClaveActual.Name = "labelClaveActual";
            this.labelClaveActual.Size = new System.Drawing.Size(70, 13);
            this.labelClaveActual.TabIndex = 165;
            this.labelClaveActual.Text = "Clave Actual:";
            // 
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // CambiarClave
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(321, 143);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelConfirmarNuevaClave);
            this.Controls.Add(this.labelNuevaClave);
            this.Controls.Add(this.textBoxConfirmarNuevaClave);
            this.Controls.Add(this.textBoxNuevaClave);
            this.Controls.Add(this.textBoxClaveActual);
            this.Controls.Add(this.labelClaveActual);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 182);
            this.MinimumSize = new System.Drawing.Size(337, 182);
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Clave";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelConfirmarNuevaClave;
        private System.Windows.Forms.Label labelNuevaClave;
        private System.Windows.Forms.TextBox textBoxConfirmarNuevaClave;
        private System.Windows.Forms.TextBox textBoxNuevaClave;
        private System.Windows.Forms.TextBox textBoxClaveActual;
        private System.Windows.Forms.Label labelClaveActual;
        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
    }
}