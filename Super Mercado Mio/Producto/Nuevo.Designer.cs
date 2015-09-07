namespace Super_Mercado_Mio.Producto
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
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.radioButtonTipoDeCodigoDeBarrasManual = new System.Windows.Forms.RadioButton();
            this.radioButtonTipoDeCodigoBarrasSistema = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorGrupo = new System.Windows.Forms.Label();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.textBoxNombreCorto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Location = new System.Drawing.Point(148, 12);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGrupo.TabIndex = 329;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(12, 15);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 330;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 13);
            this.lblCodigo.TabIndex = 340;
            this.lblCodigo.Text = "Código de Barras:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(148, 62);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodigo.TabIndex = 338;
            this.textBoxCodigo.TabStop = false;
            // 
            // radioButtonTipoDeCodigoDeBarrasManual
            // 
            this.radioButtonTipoDeCodigoDeBarrasManual.AutoSize = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Checked = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Location = new System.Drawing.Point(148, 39);
            this.radioButtonTipoDeCodigoDeBarrasManual.Name = "radioButtonTipoDeCodigoDeBarrasManual";
            this.radioButtonTipoDeCodigoDeBarrasManual.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTipoDeCodigoDeBarrasManual.TabIndex = 341;
            this.radioButtonTipoDeCodigoDeBarrasManual.TabStop = true;
            this.radioButtonTipoDeCodigoDeBarrasManual.Text = "Manual";
            this.radioButtonTipoDeCodigoDeBarrasManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoDeCodigoBarrasSistema
            // 
            this.radioButtonTipoDeCodigoBarrasSistema.AutoSize = true;
            this.radioButtonTipoDeCodigoBarrasSistema.Location = new System.Drawing.Point(214, 39);
            this.radioButtonTipoDeCodigoBarrasSistema.Name = "radioButtonTipoDeCodigoBarrasSistema";
            this.radioButtonTipoDeCodigoBarrasSistema.Size = new System.Drawing.Size(62, 17);
            this.radioButtonTipoDeCodigoBarrasSistema.TabIndex = 342;
            this.radioButtonTipoDeCodigoBarrasSistema.Text = "Sistema";
            this.radioButtonTipoDeCodigoBarrasSistema.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 343;
            this.label1.Text = "Tipo de Código de Barras:";
            // 
            // lblErrorGrupo
            // 
            this.lblErrorGrupo.AutoSize = true;
            this.lblErrorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGrupo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGrupo.Location = new System.Drawing.Point(354, 13);
            this.lblErrorGrupo.Name = "lblErrorGrupo";
            this.lblErrorGrupo.Size = new System.Drawing.Size(11, 16);
            this.lblErrorGrupo.TabIndex = 344;
            this.lblErrorGrupo.Text = "!";
            this.lblErrorGrupo.Visible = false;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Location = new System.Drawing.Point(12, 91);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(93, 13);
            this.lblNombreCorto.TabIndex = 346;
            this.lblNombreCorto.Text = "Nombre Genérico:";
            // 
            // textBoxNombreCorto
            // 
            this.textBoxNombreCorto.Location = new System.Drawing.Point(148, 88);
            this.textBoxNombreCorto.MaxLength = 96;
            this.textBoxNombreCorto.Name = "textBoxNombreCorto";
            this.textBoxNombreCorto.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreCorto.TabIndex = 345;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.textBoxNombreCorto);
            this.Controls.Add(this.lblErrorGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonTipoDeCodigoBarrasSistema);
            this.Controls.Add(this.radioButtonTipoDeCodigoDeBarrasManual);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.comboBoxGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.RadioButton radioButtonTipoDeCodigoDeBarrasManual;
        private System.Windows.Forms.RadioButton radioButtonTipoDeCodigoBarrasSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorGrupo;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.TextBox textBoxNombreCorto;
    }
}