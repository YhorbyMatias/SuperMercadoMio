namespace Super_Mercado_Mio.Empresa
{
    partial class Datos
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
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxActividadEconomica = new System.Windows.Forms.TextBox();
            this.labelActividadEconomica = new System.Windows.Forms.Label();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(128, 64);
            this.textBoxNit.MaxLength = 20;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.ReadOnly = true;
            this.textBoxNit.Size = new System.Drawing.Size(250, 20);
            this.textBoxNit.TabIndex = 2;
            // 
            // textBoxActividadEconomica
            // 
            this.textBoxActividadEconomica.Location = new System.Drawing.Point(128, 90);
            this.textBoxActividadEconomica.Multiline = true;
            this.textBoxActividadEconomica.Name = "textBoxActividadEconomica";
            this.textBoxActividadEconomica.ReadOnly = true;
            this.textBoxActividadEconomica.Size = new System.Drawing.Size(250, 88);
            this.textBoxActividadEconomica.TabIndex = 3;
            // 
            // labelActividadEconomica
            // 
            this.labelActividadEconomica.AutoSize = true;
            this.labelActividadEconomica.Location = new System.Drawing.Point(12, 93);
            this.labelActividadEconomica.Name = "labelActividadEconomica";
            this.labelActividadEconomica.Size = new System.Drawing.Size(110, 13);
            this.labelActividadEconomica.TabIndex = 328;
            this.labelActividadEconomica.Text = "Actividad Económica:";
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(12, 41);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.labelRazonSocial.TabIndex = 325;
            this.labelRazonSocial.Text = "Razón Social:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(12, 67);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(28, 13);
            this.labelNit.TabIndex = 324;
            this.labelNit.Text = "NIT:";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(128, 38);
            this.textBoxRazonSocial.MaxLength = 200;
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.ReadOnly = true;
            this.textBoxRazonSocial.Size = new System.Drawing.Size(250, 20);
            this.textBoxRazonSocial.TabIndex = 1;
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(12, 15);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(60, 13);
            this.labelPropietario.TabIndex = 330;
            this.labelPropietario.Text = "Propietario:";
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.Location = new System.Drawing.Point(128, 12);
            this.textBoxPropietario.MaxLength = 300;
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.ReadOnly = true;
            this.textBoxPropietario.Size = new System.Drawing.Size(250, 20);
            this.textBoxPropietario.TabIndex = 0;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.textBoxActividadEconomica);
            this.Controls.Add(this.labelActividadEconomica);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.textBoxPropietario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 229);
            this.MinimumSize = new System.Drawing.Size(406, 229);
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Empresa";
            this.Load += new System.EventHandler(this.Datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxActividadEconomica;
        private System.Windows.Forms.Label labelActividadEconomica;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.TextBox textBoxPropietario;
    }
}