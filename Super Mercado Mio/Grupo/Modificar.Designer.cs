namespace Super_Mercado_Mio.Grupo
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.errorProviderFormulario = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.errorProviderFormulario.SetIconAlignment(this.textBoxNombre, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProviderFormulario.SetIconPadding(this.textBoxNombre, 5);
            this.textBoxNombre.Location = new System.Drawing.Point(82, 12);
            this.textBoxNombre.MaxLength = 100;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            // 
            // errorProviderFormulario
            // 
            this.errorProviderFormulario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFormulario.ContainerControl = this;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(150, 38);
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
            this.buttonGuardar.Location = new System.Drawing.Point(55, 38);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Modificar
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(294, 91);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 130);
            this.MinimumSize = new System.Drawing.Size(310, 130);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Grupo";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ErrorProvider errorProviderFormulario;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCerrar;
    }
}