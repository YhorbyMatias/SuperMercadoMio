namespace Super_Mercado_Mio.Compra
{
    partial class Resultados
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
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.AllowUserToAddRows = false;
            this.purchasesDataGridView.AllowUserToDeleteRows = false;
            this.purchasesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.purchasesDataGridView.MultiSelect = false;
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.ReadOnly = true;
            this.purchasesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasesDataGridView.Size = new System.Drawing.Size(960, 437);
            this.purchasesDataGridView.TabIndex = 254;
            this.purchasesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasesDataGridView_CellDoubleClick);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.purchasesDataGridView);
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasesDataGridView;
    }
}