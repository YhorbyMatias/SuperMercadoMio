namespace Super_Mercado_Mio.Grupo
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
            this.dataGridViewGrupos = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupos
            // 
            this.dataGridViewGrupos.AllowUserToAddRows = false;
            this.dataGridViewGrupos.AllowUserToDeleteRows = false;
            this.dataGridViewGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupos.ColumnHeadersVisible = false;
            this.dataGridViewGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridViewGrupos.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewGrupos.MultiSelect = false;
            this.dataGridViewGrupos.Name = "dataGridViewGrupos";
            this.dataGridViewGrupos.ReadOnly = true;
            this.dataGridViewGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupos.Size = new System.Drawing.Size(536, 382);
            this.dataGridViewGrupos.TabIndex = 1;
            this.dataGridViewGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupos_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.ActiveLinkColor = System.Drawing.Color.Black;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.LinkColor = System.Drawing.Color.Black;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForLinkValue = true;
            this.Modificar.Visible = false;
            this.Modificar.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(61, 12);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(200, 20);
            this.textBoxBuscar.TabIndex = 0;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 86;
            this.lblBuscar.Text = "Buscar:";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 432);
            this.Controls.Add(this.dataGridViewGrupos);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.MaximumSize = new System.Drawing.Size(576, 471);
            this.MinimumSize = new System.Drawing.Size(576, 471);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Grupos";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrupos;
        private System.Windows.Forms.DataGridViewLinkColumn Modificar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}