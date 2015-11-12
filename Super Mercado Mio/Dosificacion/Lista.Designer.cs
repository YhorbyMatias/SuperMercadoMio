namespace Super_Mercado_Mio.Dosificacion
{
    partial class Lista
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
            this.textBoxNumeroDeAutorizacion = new System.Windows.Forms.TextBox();
            this.lblNumeroDeAutorizacion = new System.Windows.Forms.Label();
            this.dataGridViewDosificaciones = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDosificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumeroDeAutorizacion
            // 
            this.textBoxNumeroDeAutorizacion.Location = new System.Drawing.Point(116, 12);
            this.textBoxNumeroDeAutorizacion.MaxLength = 15;
            this.textBoxNumeroDeAutorizacion.Name = "textBoxNumeroDeAutorizacion";
            this.textBoxNumeroDeAutorizacion.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroDeAutorizacion.TabIndex = 0;
            this.textBoxNumeroDeAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumeroDeAutorizacion_KeyDown);
            this.textBoxNumeroDeAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroDeAutorizacion_KeyPress);
            // 
            // lblNumeroDeAutorizacion
            // 
            this.lblNumeroDeAutorizacion.AutoSize = true;
            this.lblNumeroDeAutorizacion.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroDeAutorizacion.Name = "lblNumeroDeAutorizacion";
            this.lblNumeroDeAutorizacion.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroDeAutorizacion.TabIndex = 207;
            this.lblNumeroDeAutorizacion.Text = "Nº de Autorización:";
            // 
            // dataGridViewDosificaciones
            // 
            this.dataGridViewDosificaciones.AllowUserToAddRows = false;
            this.dataGridViewDosificaciones.AllowUserToDeleteRows = false;
            this.dataGridViewDosificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDosificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDosificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDosificaciones.ColumnHeadersVisible = false;
            this.dataGridViewDosificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridViewDosificaciones.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewDosificaciones.MultiSelect = false;
            this.dataGridViewDosificaciones.Name = "dataGridViewDosificaciones";
            this.dataGridViewDosificaciones.ReadOnly = true;
            this.dataGridViewDosificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDosificaciones.Size = new System.Drawing.Size(760, 337);
            this.dataGridViewDosificaciones.TabIndex = 1;
            this.dataGridViewDosificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDosificaciones_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.ActiveLinkColor = System.Drawing.Color.Black;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.LinkColor = System.Drawing.Color.Black;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForLinkValue = true;
            this.Modificar.Visible = false;
            this.Modificar.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.textBoxNumeroDeAutorizacion);
            this.Controls.Add(this.lblNumeroDeAutorizacion);
            this.Controls.Add(this.dataGridViewDosificaciones);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Dosificaciones";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDosificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroDeAutorizacion;
        private System.Windows.Forms.Label lblNumeroDeAutorizacion;
        private System.Windows.Forms.DataGridView dataGridViewDosificaciones;
        private System.Windows.Forms.DataGridViewLinkColumn Modificar;
    }
}