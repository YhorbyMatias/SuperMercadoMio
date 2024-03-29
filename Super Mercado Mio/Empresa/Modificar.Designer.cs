﻿namespace Super_Mercado_Mio.Empresa
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
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.contextMenuStripEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxActividadEconomica = new System.Windows.Forms.TextBox();
            this.labelActividadEconomica = new System.Windows.Forms.Label();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNit
            // 
            this.textBoxNit.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxNit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNit, 5);
            this.textBoxNit.Location = new System.Drawing.Point(145, 64);
            this.textBoxNit.MaxLength = 12;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(250, 20);
            this.textBoxNit.TabIndex = 2;
            this.textBoxNit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNit_KeyDown);
            this.textBoxNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNit_KeyPress);
            this.textBoxNit.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNit_Validating);
            // 
            // contextMenuStripEmpty
            // 
            this.contextMenuStripEmpty.Name = "contextMenuStripTextBox";
            this.contextMenuStripEmpty.Size = new System.Drawing.Size(153, 26);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(206, 184);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(111, 184);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxActividadEconomica
            // 
            this.textBoxActividadEconomica.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxActividadEconomica, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxActividadEconomica, 5);
            this.textBoxActividadEconomica.Location = new System.Drawing.Point(145, 90);
            this.textBoxActividadEconomica.Multiline = true;
            this.textBoxActividadEconomica.Name = "textBoxActividadEconomica";
            this.textBoxActividadEconomica.Size = new System.Drawing.Size(250, 88);
            this.textBoxActividadEconomica.TabIndex = 3;
            this.textBoxActividadEconomica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxActividadEconomica_KeyDown);
            this.textBoxActividadEconomica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxActividadEconomica_KeyPress);
            this.textBoxActividadEconomica.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxActividadEconomica_Validating);
            // 
            // labelActividadEconomica
            // 
            this.labelActividadEconomica.AutoSize = true;
            this.labelActividadEconomica.Location = new System.Drawing.Point(12, 93);
            this.labelActividadEconomica.Name = "labelActividadEconomica";
            this.labelActividadEconomica.Size = new System.Drawing.Size(110, 13);
            this.labelActividadEconomica.TabIndex = 314;
            this.labelActividadEconomica.Text = "Actividad Económica:";
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(12, 41);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.labelRazonSocial.TabIndex = 311;
            this.labelRazonSocial.Text = "Razón Social:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(12, 67);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(28, 13);
            this.labelNit.TabIndex = 310;
            this.labelNit.Text = "NIT:";
            // 
            // textBoxRazonSocial
            // 
            this.errorProvider.SetIconAlignment(this.textBoxRazonSocial, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxRazonSocial, 5);
            this.textBoxRazonSocial.Location = new System.Drawing.Point(145, 38);
            this.textBoxRazonSocial.MaxLength = 200;
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(250, 20);
            this.textBoxRazonSocial.TabIndex = 1;
            this.textBoxRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRazonSocial_Validating);
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(12, 15);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(60, 13);
            this.labelPropietario.TabIndex = 316;
            this.labelPropietario.Text = "Propietario:";
            // 
            // textBoxPropietario
            // 
            this.errorProvider.SetIconAlignment(this.textBoxPropietario, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxPropietario, 5);
            this.textBoxPropietario.Location = new System.Drawing.Point(145, 12);
            this.textBoxPropietario.MaxLength = 300;
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(250, 20);
            this.textBoxPropietario.TabIndex = 0;
            this.textBoxPropietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPropietario_KeyDown);
            this.textBoxPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPropietario_KeyPress);
            this.textBoxPropietario.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPropietario_Validating);
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
            this.ClientSize = new System.Drawing.Size(407, 237);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxActividadEconomica);
            this.Controls.Add(this.labelActividadEconomica);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.textBoxPropietario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 276);
            this.MinimumSize = new System.Drawing.Size(423, 276);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Empresa";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxActividadEconomica;
        private System.Windows.Forms.Label labelActividadEconomica;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}