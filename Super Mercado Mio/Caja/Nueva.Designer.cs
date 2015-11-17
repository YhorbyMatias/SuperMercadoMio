namespace Super_Mercado_Mio.Caja
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(12, 15);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 135;
            this.labelNumero.Text = "Número:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxNumero, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNumero, 5);
            this.textBoxNumero.Location = new System.Drawing.Point(82, 12);
            this.textBoxNumero.MaxLength = 3;
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumero.TabIndex = 0;
            this.textBoxNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumero_KeyDown);
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            this.textBoxNumero.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumero_Validating);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(61, 4);
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
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Nueva
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(294, 91);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxNumero);
            this.MaximizeBox = false;
            this.Name = "Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Caja";
            this.Load += new System.EventHandler(this.Nueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}