namespace Super_Mercado_Mio.Producto
{
    partial class Busqueda
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
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.tasteOrOrdorTextBox = new System.Windows.Forms.TextBox();
            this.tasteOrOrdorLabel = new System.Windows.Forms.Label();
            this.presentationTextBox = new System.Windows.Forms.TextBox();
            this.presentationLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.genericNameTextBox = new System.Windows.Forms.TextBox();
            this.genericNameLabel = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.ColumnHeadersVisible = false;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 64);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(1060, 405);
            this.productsDataGridView.TabIndex = 7;
            this.productsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellDoubleClick);
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(313, 38);
            this.groupTextBox.MaxLength = 100;
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(125, 20);
            this.groupTextBox.TabIndex = 6;
            this.groupTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.groupTextBox_KeyDown);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(240, 41);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(39, 13);
            this.groupLabel.TabIndex = 114;
            this.groupLabel.Text = "Grupo:";
            // 
            // providerTextBox
            // 
            this.providerTextBox.Location = new System.Drawing.Point(109, 38);
            this.providerTextBox.MaxLength = 300;
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(125, 20);
            this.providerTextBox.TabIndex = 5;
            this.providerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerTextBox_KeyDown);
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(12, 41);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(59, 13);
            this.providerLabel.TabIndex = 113;
            this.providerLabel.Text = "Proveedor:";
            // 
            // tasteOrOrdorTextBox
            // 
            this.tasteOrOrdorTextBox.Location = new System.Drawing.Point(907, 12);
            this.tasteOrOrdorTextBox.MaxLength = 100;
            this.tasteOrOrdorTextBox.Name = "tasteOrOrdorTextBox";
            this.tasteOrOrdorTextBox.Size = new System.Drawing.Size(125, 20);
            this.tasteOrOrdorTextBox.TabIndex = 4;
            this.tasteOrOrdorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasteOrOrdorTextBox_KeyDown);
            // 
            // tasteOrOrdorLabel
            // 
            this.tasteOrOrdorLabel.AutoSize = true;
            this.tasteOrOrdorLabel.Location = new System.Drawing.Point(830, 15);
            this.tasteOrOrdorLabel.Name = "tasteOrOrdorLabel";
            this.tasteOrOrdorLabel.Size = new System.Drawing.Size(71, 13);
            this.tasteOrOrdorLabel.TabIndex = 112;
            this.tasteOrOrdorLabel.Text = "Sabor U Olor:";
            // 
            // presentationTextBox
            // 
            this.presentationTextBox.Location = new System.Drawing.Point(699, 12);
            this.presentationTextBox.MaxLength = 100;
            this.presentationTextBox.Name = "presentationTextBox";
            this.presentationTextBox.Size = new System.Drawing.Size(125, 20);
            this.presentationTextBox.TabIndex = 3;
            this.presentationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presentationTextBox_KeyDown);
            // 
            // presentationLabel
            // 
            this.presentationLabel.AutoSize = true;
            this.presentationLabel.Location = new System.Drawing.Point(621, 15);
            this.presentationLabel.Name = "presentationLabel";
            this.presentationLabel.Size = new System.Drawing.Size(72, 13);
            this.presentationLabel.TabIndex = 111;
            this.presentationLabel.Text = "Presentación:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(490, 12);
            this.brandTextBox.MaxLength = 100;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(125, 20);
            this.brandTextBox.TabIndex = 2;
            this.brandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brandTextBox_KeyDown);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(444, 15);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 110;
            this.brandLabel.Text = "Marca:";
            // 
            // genericNameTextBox
            // 
            this.genericNameTextBox.Location = new System.Drawing.Point(313, 12);
            this.genericNameTextBox.MaxLength = 100;
            this.genericNameTextBox.Name = "genericNameTextBox";
            this.genericNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.genericNameTextBox.TabIndex = 1;
            this.genericNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericNameTextBox_KeyDown);
            // 
            // genericNameLabel
            // 
            this.genericNameLabel.AutoSize = true;
            this.genericNameLabel.Location = new System.Drawing.Point(240, 15);
            this.genericNameLabel.Name = "genericNameLabel";
            this.genericNameLabel.Size = new System.Drawing.Size(67, 13);
            this.genericNameLabel.TabIndex = 109;
            this.genericNameLabel.Text = "N. Genérico:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(109, 12);
            this.barcodeTextBox.MaxLength = 100;
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(125, 20);
            this.barcodeTextBox.TabIndex = 0;
            this.barcodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBox_KeyDown);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(12, 15);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(91, 13);
            this.barcodeLabel.TabIndex = 108;
            this.barcodeLabel.Text = "Código de Barras:";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 481);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.providerTextBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.tasteOrOrdorTextBox);
            this.Controls.Add(this.tasteOrOrdorLabel);
            this.Controls.Add(this.presentationTextBox);
            this.Controls.Add(this.presentationLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.genericNameTextBox);
            this.Controls.Add(this.genericNameLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.barcodeLabel);
            this.MaximizeBox = false;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Productos";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.TextBox tasteOrOrdorTextBox;
        private System.Windows.Forms.Label tasteOrOrdorLabel;
        private System.Windows.Forms.TextBox presentationTextBox;
        private System.Windows.Forms.Label presentationLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox genericNameTextBox;
        private System.Windows.Forms.Label genericNameLabel;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label barcodeLabel;
    }
}