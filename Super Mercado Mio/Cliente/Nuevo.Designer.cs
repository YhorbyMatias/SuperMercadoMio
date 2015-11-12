namespace Super_Mercado_Mio.Cliente
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
            this.labelNombreORazonSocial = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCiONit = new System.Windows.Forms.Label();
            this.textBoxCiONit = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreORazonSocial
            // 
            this.labelNombreORazonSocial.AutoSize = true;
            this.labelNombreORazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreORazonSocial.Location = new System.Drawing.Point(12, 56);
            this.labelNombreORazonSocial.Name = "labelNombreORazonSocial";
            this.labelNombreORazonSocial.Size = new System.Drawing.Size(107, 29);
            this.labelNombreORazonSocial.TabIndex = 167;
            this.labelNombreORazonSocial.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxNombre, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.errorProvider.SetIconPadding(this.textBoxNombre, 5);
            this.textBoxNombre.Location = new System.Drawing.Point(151, 53);
            this.textBoxNombre.MaxLength = 300;
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(400, 155);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // labelCiONit
            // 
            this.labelCiONit.AutoSize = true;
            this.labelCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiONit.Location = new System.Drawing.Point(12, 15);
            this.labelCiONit.Name = "labelCiONit";
            this.labelCiONit.Size = new System.Drawing.Size(108, 29);
            this.labelCiONit.TabIndex = 166;
            this.labelCiONit.Text = "CI ó NIT:";
            // 
            // textBoxCiONit
            // 
            this.textBoxCiONit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.textBoxCiONit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBoxCiONit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxCiONit, 5);
            this.textBoxCiONit.Location = new System.Drawing.Point(151, 12);
            this.textBoxCiONit.MaxLength = 12;
            this.textBoxCiONit.Name = "textBoxCiONit";
            this.textBoxCiONit.Size = new System.Drawing.Size(400, 35);
            this.textBoxCiONit.TabIndex = 0;
            this.textBoxCiONit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCiONit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCiONit_KeyDown);
            this.textBoxCiONit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCiONit_KeyPress);
            this.textBoxCiONit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCiONit_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.AutoSize = true;
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(282, 214);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(91, 41);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.AutoSize = true;
            this.buttonGuardar.Location = new System.Drawing.Point(189, 214);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(87, 41);
            this.buttonGuardar.TabIndex = 2;
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
            // Nuevo
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(563, 267);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombreORazonSocial);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelCiONit);
            this.Controls.Add(this.textBoxCiONit);
            this.MaximizeBox = false;
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreORazonSocial;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelCiONit;
        private System.Windows.Forms.TextBox textBoxCiONit;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
    }
}