﻿namespace Super_Mercado_Mio.Usuario
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxCi = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.checkedListBoxOpciones = new System.Windows.Forms.CheckedListBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.textBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCi = new System.Windows.Forms.Label();
            this.checkBoxSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // textBoxCi
            // 
            this.textBoxCi.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxCi, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxCi, 5);
            this.textBoxCi.Location = new System.Drawing.Point(136, 12);
            this.textBoxCi.MaxLength = 8;
            this.textBoxCi.Name = "textBoxCi";
            this.textBoxCi.Size = new System.Drawing.Size(200, 20);
            this.textBoxCi.TabIndex = 0;
            this.textBoxCi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCi_KeyDown);
            this.textBoxCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCi_KeyPress);
            this.textBoxCi.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCi_Validating);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxTelefono, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxTelefono, 5);
            this.textBoxTelefono.Location = new System.Drawing.Point(136, 116);
            this.textBoxTelefono.MaxLength = 8;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefono_Validating);
            // 
            // checkedListBoxOpciones
            // 
            this.checkedListBoxOpciones.CheckOnClick = true;
            this.checkedListBoxOpciones.ColumnWidth = 200;
            this.checkedListBoxOpciones.FormattingEnabled = true;
            this.checkedListBoxOpciones.HorizontalScrollbar = true;
            this.errorProvider.SetIconAlignment(this.checkedListBoxOpciones, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.errorProvider.SetIconPadding(this.checkedListBoxOpciones, 5);
            this.checkedListBoxOpciones.Location = new System.Drawing.Point(359, 37);
            this.checkedListBoxOpciones.MultiColumn = true;
            this.checkedListBoxOpciones.Name = "checkedListBoxOpciones";
            this.checkedListBoxOpciones.Size = new System.Drawing.Size(605, 154);
            this.checkedListBoxOpciones.TabIndex = 8;
            this.checkedListBoxOpciones.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBoxOpciones_Validating);
            // 
            // textBoxClave
            // 
            this.errorProvider.SetIconAlignment(this.textBoxClave, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxClave, 5);
            this.textBoxClave.Location = new System.Drawing.Point(136, 168);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(200, 20);
            this.textBoxClave.TabIndex = 6;
            // 
            // textBoxNombreDeUsuario
            // 
            this.errorProvider.SetIconAlignment(this.textBoxNombreDeUsuario, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNombreDeUsuario, 5);
            this.textBoxNombreDeUsuario.Location = new System.Drawing.Point(136, 142);
            this.textBoxNombreDeUsuario.MaxLength = 50;
            this.textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            this.textBoxNombreDeUsuario.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreDeUsuario.TabIndex = 5;
            this.textBoxNombreDeUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreDeUsuario_Validating);
            // 
            // textBoxApellidoMaterno
            // 
            this.textBoxApellidoMaterno.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxApellidoMaterno, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxApellidoMaterno, 5);
            this.textBoxApellidoMaterno.Location = new System.Drawing.Point(136, 90);
            this.textBoxApellidoMaterno.MaxLength = 100;
            this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
            this.textBoxApellidoMaterno.Size = new System.Drawing.Size(200, 20);
            this.textBoxApellidoMaterno.TabIndex = 3;
            this.textBoxApellidoMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxApellidoMaterno_KeyDown);
            this.textBoxApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoMaterno_KeyPress);
            this.textBoxApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellidoMaterno_Validating);
            // 
            // textBoxApellidoPaterno
            // 
            this.textBoxApellidoPaterno.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxApellidoPaterno, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxApellidoPaterno, 5);
            this.textBoxApellidoPaterno.Location = new System.Drawing.Point(136, 64);
            this.textBoxApellidoPaterno.MaxLength = 100;
            this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
            this.textBoxApellidoPaterno.Size = new System.Drawing.Size(200, 20);
            this.textBoxApellidoPaterno.TabIndex = 2;
            this.textBoxApellidoPaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxApellidoPaterno_KeyDown);
            this.textBoxApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoPaterno_KeyPress);
            this.textBoxApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellidoPaterno_Validating);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.ContextMenuStrip = this.contextMenuStripEmpty;
            this.errorProvider.SetIconAlignment(this.textBoxNombres, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider.SetIconPadding(this.textBoxNombres, 5);
            this.textBoxNombres.Location = new System.Drawing.Point(136, 38);
            this.textBoxNombres.MaxLength = 100;
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombres.TabIndex = 1;
            this.textBoxNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombres_KeyDown);
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_KeyPress);
            this.textBoxNombres.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombres_Validating);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 119);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 326;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelCi
            // 
            this.labelCi.AutoSize = true;
            this.labelCi.Location = new System.Drawing.Point(12, 15);
            this.labelCi.Name = "labelCi";
            this.labelCi.Size = new System.Drawing.Size(20, 13);
            this.labelCi.TabIndex = 325;
            this.labelCi.Text = "CI:";
            // 
            // checkBoxSeleccionarTodos
            // 
            this.checkBoxSeleccionarTodos.AutoSize = true;
            this.checkBoxSeleccionarTodos.Location = new System.Drawing.Point(359, 14);
            this.checkBoxSeleccionarTodos.Name = "checkBoxSeleccionarTodos";
            this.checkBoxSeleccionarTodos.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSeleccionarTodos.TabIndex = 7;
            this.checkBoxSeleccionarTodos.Text = "Seleccionar Todos";
            this.checkBoxSeleccionarTodos.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionarTodos.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionarTodos_CheckedChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 171);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 324;
            this.lblClave.Text = "Clave:";
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(12, 145);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNombreDeUsuario.TabIndex = 323;
            this.lblNombreDeUsuario.Text = "Nombre de Usuario:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(12, 93);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMaterno.TabIndex = 322;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 67);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaterno.TabIndex = 321;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(12, 41);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 320;
            this.lblNombres.Text = "Nombres:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(396, 197);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 41);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.Location = new System.Drawing.Point(491, 197);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(89, 41);
            this.buttonCerrar.TabIndex = 10;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // Modificar
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCerrar;
            this.ClientSize = new System.Drawing.Size(976, 250);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxCi);
            this.Controls.Add(this.labelCi);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.checkBoxSeleccionarTodos);
            this.Controls.Add(this.checkedListBoxOpciones);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxNombreDeUsuario);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.textBoxApellidoMaterno);
            this.Controls.Add(this.textBoxApellidoPaterno);
            this.Controls.Add(this.textBoxNombres);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(992, 289);
            this.MinimumSize = new System.Drawing.Size(992, 289);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmpty;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxCi;
        private System.Windows.Forms.Label labelCi;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.CheckBox checkBoxSeleccionarTodos;
        private System.Windows.Forms.CheckedListBox checkedListBoxOpciones;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxNombreDeUsuario;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox textBoxApellidoMaterno;
        private System.Windows.Forms.TextBox textBoxApellidoPaterno;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCerrar;
    }
}