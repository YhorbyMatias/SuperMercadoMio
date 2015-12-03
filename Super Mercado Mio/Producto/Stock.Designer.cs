namespace Super_Mercado_Mio.Producto
{
    partial class Stock
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
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.textBoxSaborUOlor = new System.Windows.Forms.TextBox();
            this.labelSaborUOlor = new System.Windows.Forms.Label();
            this.textBoxPresentacion = new System.Windows.Forms.TextBox();
            this.labelPresentacion = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxNombreGenerico = new System.Windows.Forms.TextBox();
            this.labelNombreGenerico = new System.Windows.Forms.Label();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.labelCodigoDeBarras = new System.Windows.Forms.Label();
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
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1060, 405);
            this.dataGridViewProductos.TabIndex = 7;
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(313, 38);
            this.textBoxGrupo.MaxLength = 6;
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(125, 20);
            this.textBoxGrupo.TabIndex = 106;
            this.textBoxGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGrupo_KeyDown);
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(240, 41);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(39, 13);
            this.labelGrupo.TabIndex = 114;
            this.labelGrupo.Text = "Grupo:";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(109, 38);
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
            this.labelProveedor.TabIndex = 113;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // textBoxSaborUOlor
            // 
            this.textBoxSaborUOlor.Location = new System.Drawing.Point(907, 12);
            this.textBoxSaborUOlor.MaxLength = 100;
            this.textBoxSaborUOlor.Name = "textBoxSaborUOlor";
            this.textBoxSaborUOlor.Size = new System.Drawing.Size(125, 20);
            this.textBoxSaborUOlor.TabIndex = 4;
            this.textBoxSaborUOlor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSaborUOlor_KeyDown);
            // 
            // labelSaborUOlor
            // 
            this.labelSaborUOlor.AutoSize = true;
            this.labelSaborUOlor.Location = new System.Drawing.Point(830, 15);
            this.labelSaborUOlor.Name = "labelSaborUOlor";
            this.labelSaborUOlor.Size = new System.Drawing.Size(71, 13);
            this.labelSaborUOlor.TabIndex = 112;
            this.labelSaborUOlor.Text = "Sabor U Olor:";
            // 
            // textBoxPresentacion
            // 
            this.textBoxPresentacion.Location = new System.Drawing.Point(699, 12);
            this.textBoxPresentacion.MaxLength = 100;
            this.textBoxPresentacion.Name = "textBoxPresentacion";
            this.textBoxPresentacion.Size = new System.Drawing.Size(125, 20);
            this.textBoxPresentacion.TabIndex = 3;
            this.textBoxPresentacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPresentacion_KeyDown);
            // 
            // labelPresentacion
            // 
            this.labelPresentacion.AutoSize = true;
            this.labelPresentacion.Location = new System.Drawing.Point(621, 15);
            this.labelPresentacion.Name = "labelPresentacion";
            this.labelPresentacion.Size = new System.Drawing.Size(72, 13);
            this.labelPresentacion.TabIndex = 111;
            this.labelPresentacion.Text = "Presentación:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(490, 12);
            this.textBoxMarca.MaxLength = 100;
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(125, 20);
            this.textBoxMarca.TabIndex = 2;
            this.textBoxMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMarca_KeyDown);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(444, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 110;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxNombreGenerico
            // 
            this.textBoxNombreGenerico.Location = new System.Drawing.Point(313, 12);
            this.textBoxNombreGenerico.MaxLength = 100;
            this.textBoxNombreGenerico.Name = "textBoxNombreGenerico";
            this.textBoxNombreGenerico.Size = new System.Drawing.Size(125, 20);
            this.textBoxNombreGenerico.TabIndex = 1;
            this.textBoxNombreGenerico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreGenerico_KeyDown);
            // 
            // labelNombreGenerico
            // 
            this.labelNombreGenerico.AutoSize = true;
            this.labelNombreGenerico.Location = new System.Drawing.Point(240, 15);
            this.labelNombreGenerico.Name = "labelNombreGenerico";
            this.labelNombreGenerico.Size = new System.Drawing.Size(67, 13);
            this.labelNombreGenerico.TabIndex = 109;
            this.labelNombreGenerico.Text = "N. Genérico:";
            // 
            // textBoxCodigoDeBarras
            // 
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(109, 12);
            this.textBoxCodigoDeBarras.MaxLength = 100;
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(125, 20);
            this.textBoxCodigoDeBarras.TabIndex = 0;
            this.textBoxCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoDeBarras_KeyDown);
            // 
            // labelCodigoDeBarras
            // 
            this.labelCodigoDeBarras.AutoSize = true;
            this.labelCodigoDeBarras.Location = new System.Drawing.Point(12, 15);
            this.labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            this.labelCodigoDeBarras.Size = new System.Drawing.Size(91, 13);
            this.labelCodigoDeBarras.TabIndex = 108;
            this.labelCodigoDeBarras.Text = "Código de Barras:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 481);
            this.Controls.Add(this.dataGridViewProductos);
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
            this.Controls.Add(this.textBoxCodigoDeBarras);
            this.Controls.Add(this.labelCodigoDeBarras);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Productos";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox textBoxSaborUOlor;
        private System.Windows.Forms.Label labelSaborUOlor;
        private System.Windows.Forms.TextBox textBoxPresentacion;
        private System.Windows.Forms.Label labelPresentacion;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxNombreGenerico;
        private System.Windows.Forms.Label labelNombreGenerico;
        private System.Windows.Forms.TextBox textBoxCodigoDeBarras;
        private System.Windows.Forms.Label labelCodigoDeBarras;
    }
}