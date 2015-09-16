namespace Super_Mercado_Mio.Producto
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxNombreGenerico = new System.Windows.Forms.TextBox();
            this.labelNombreGenerico = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxPresentacion = new System.Windows.Forms.TextBox();
            this.labelPresentacion = new System.Windows.Forms.Label();
            this.textBoxSaborUOlor = new System.Windows.Forms.TextBox();
            this.labelSaborUOlor = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.ColumnHeadersVisible = false;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1060, 405);
            this.dataGridViewProductos.TabIndex = 7;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick);
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
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(77, 12);
            this.textBoxCodigo.MaxLength = 100;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(125, 20);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyDown);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 15);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 88;
            this.labelCodigo.Text = "Código:";
            // 
            // textBoxNombreGenerico
            // 
            this.textBoxNombreGenerico.Location = new System.Drawing.Point(281, 12);
            this.textBoxNombreGenerico.MaxLength = 100;
            this.textBoxNombreGenerico.Name = "textBoxNombreGenerico";
            this.textBoxNombreGenerico.Size = new System.Drawing.Size(125, 20);
            this.textBoxNombreGenerico.TabIndex = 1;
            this.textBoxNombreGenerico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreGenerico_KeyDown);
            // 
            // labelNombreGenerico
            // 
            this.labelNombreGenerico.AutoSize = true;
            this.labelNombreGenerico.Location = new System.Drawing.Point(208, 15);
            this.labelNombreGenerico.Name = "labelNombreGenerico";
            this.labelNombreGenerico.Size = new System.Drawing.Size(67, 13);
            this.labelNombreGenerico.TabIndex = 90;
            this.labelNombreGenerico.Text = "N. Genérico:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(412, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 91;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(458, 12);
            this.textBoxMarca.MaxLength = 100;
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(125, 20);
            this.textBoxMarca.TabIndex = 2;
            this.textBoxMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMarca_KeyDown);
            // 
            // textBoxPresentacion
            // 
            this.textBoxPresentacion.Location = new System.Drawing.Point(667, 12);
            this.textBoxPresentacion.MaxLength = 100;
            this.textBoxPresentacion.Name = "textBoxPresentacion";
            this.textBoxPresentacion.Size = new System.Drawing.Size(125, 20);
            this.textBoxPresentacion.TabIndex = 3;
            this.textBoxPresentacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPresentacion_KeyDown);
            // 
            // labelPresentacion
            // 
            this.labelPresentacion.AutoSize = true;
            this.labelPresentacion.Location = new System.Drawing.Point(589, 15);
            this.labelPresentacion.Name = "labelPresentacion";
            this.labelPresentacion.Size = new System.Drawing.Size(72, 13);
            this.labelPresentacion.TabIndex = 93;
            this.labelPresentacion.Text = "Presentación:";
            // 
            // textBoxSaborUOlor
            // 
            this.textBoxSaborUOlor.Location = new System.Drawing.Point(875, 12);
            this.textBoxSaborUOlor.MaxLength = 100;
            this.textBoxSaborUOlor.Name = "textBoxSaborUOlor";
            this.textBoxSaborUOlor.Size = new System.Drawing.Size(125, 20);
            this.textBoxSaborUOlor.TabIndex = 4;
            this.textBoxSaborUOlor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSaborUOlor_KeyDown);
            // 
            // labelSaborUOlor
            // 
            this.labelSaborUOlor.AutoSize = true;
            this.labelSaborUOlor.Location = new System.Drawing.Point(798, 15);
            this.labelSaborUOlor.Name = "labelSaborUOlor";
            this.labelSaborUOlor.Size = new System.Drawing.Size(71, 13);
            this.labelSaborUOlor.TabIndex = 95;
            this.labelSaborUOlor.Text = "Sabor U Olor:";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(77, 38);
            this.textBoxProveedor.MaxLength = 300;
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(125, 20);
            this.textBoxProveedor.TabIndex = 5;
            this.textBoxProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProveedor_KeyDown);
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(12, 41);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(59, 13);
            this.labelProveedor.TabIndex = 97;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(281, 38);
            this.textBoxGrupo.MaxLength = 100;
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(125, 20);
            this.textBoxGrupo.TabIndex = 6;
            this.textBoxGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGrupo_KeyDown);
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(208, 41);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(39, 13);
            this.labelGrupo.TabIndex = 99;
            this.labelGrupo.Text = "Grupo:";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 481);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.textBoxSaborUOlor);
            this.Controls.Add(this.labelSaborUOlor);
            this.Controls.Add(this.textBoxPresentacion);
            this.Controls.Add(this.labelPresentacion);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxNombreGenerico);
            this.Controls.Add(this.labelNombreGenerico);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.dataGridViewProductos);
            this.MaximizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewLinkColumn Modificar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxNombreGenerico;
        private System.Windows.Forms.Label labelNombreGenerico;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxPresentacion;
        private System.Windows.Forms.Label labelPresentacion;
        private System.Windows.Forms.TextBox textBoxSaborUOlor;
        private System.Windows.Forms.Label labelSaborUOlor;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.Label labelGrupo;
    }
}