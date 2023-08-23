
namespace MaxiKiosco
{
    partial class frmCompras
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
            this.dgvProductosProveedor = new System.Windows.Forms.DataGridView();
            this.cmbCargarProvedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dgvListaCompra = new System.Windows.Forms.DataGridView();
            this.txtPrecioFinalCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioFinalCompra = new System.Windows.Forms.Label();
            this.btnAltaCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosProveedor
            // 
            this.dgvProductosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductosProveedor.Location = new System.Drawing.Point(107, 96);
            this.dgvProductosProveedor.Name = "dgvProductosProveedor";
            this.dgvProductosProveedor.Size = new System.Drawing.Size(562, 178);
            this.dgvProductosProveedor.TabIndex = 0;
            this.dgvProductosProveedor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductosProveedor_CellMouseDoubleClick);
            // 
            // cmbCargarProvedor
            // 
            this.cmbCargarProvedor.FormattingEnabled = true;
            this.cmbCargarProvedor.Location = new System.Drawing.Point(107, 48);
            this.cmbCargarProvedor.Name = "cmbCargarProvedor";
            this.cmbCargarProvedor.Size = new System.Drawing.Size(121, 21);
            this.cmbCargarProvedor.TabIndex = 1;
            this.cmbCargarProvedor.SelectedIndexChanged += new System.EventHandler(this.cmbCargarProvedor_SelectedIndexChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(104, 21);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(67, 13);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedores";
            // 
            // dgvListaCompra
            // 
            this.dgvListaCompra.AllowUserToAddRows = false;
            this.dgvListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompra.Location = new System.Drawing.Point(107, 307);
            this.dgvListaCompra.Name = "dgvListaCompra";
            this.dgvListaCompra.Size = new System.Drawing.Size(562, 178);
            this.dgvListaCompra.TabIndex = 3;
            this.dgvListaCompra.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvListaCompra_CellBeginEdit);
            this.dgvListaCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCompra_CellEndEdit);
            this.dgvListaCompra.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvListaCompra_CellValidating);
            // 
            // txtPrecioFinalCompra
            // 
            this.txtPrecioFinalCompra.Location = new System.Drawing.Point(741, 307);
            this.txtPrecioFinalCompra.Name = "txtPrecioFinalCompra";
            this.txtPrecioFinalCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFinalCompra.TabIndex = 4;
            // 
            // lblPrecioFinalCompra
            // 
            this.lblPrecioFinalCompra.AutoSize = true;
            this.lblPrecioFinalCompra.Location = new System.Drawing.Point(741, 270);
            this.lblPrecioFinalCompra.Name = "lblPrecioFinalCompra";
            this.lblPrecioFinalCompra.Size = new System.Drawing.Size(101, 13);
            this.lblPrecioFinalCompra.TabIndex = 5;
            this.lblPrecioFinalCompra.Text = "Precio Final Compra";
            // 
            // btnAltaCompra
            // 
            this.btnAltaCompra.Location = new System.Drawing.Point(744, 356);
            this.btnAltaCompra.Name = "btnAltaCompra";
            this.btnAltaCompra.Size = new System.Drawing.Size(75, 23);
            this.btnAltaCompra.TabIndex = 6;
            this.btnAltaCompra.Text = "AltaCompra";
            this.btnAltaCompra.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 517);
            this.Controls.Add(this.btnAltaCompra);
            this.Controls.Add(this.lblPrecioFinalCompra);
            this.Controls.Add(this.txtPrecioFinalCompra);
            this.Controls.Add(this.dgvListaCompra);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbCargarProvedor);
            this.Controls.Add(this.dgvProductosProveedor);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosProveedor;
        private System.Windows.Forms.ComboBox cmbCargarProvedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView dgvListaCompra;
        private System.Windows.Forms.TextBox txtPrecioFinalCompra;
        private System.Windows.Forms.Label lblPrecioFinalCompra;
        private System.Windows.Forms.Button btnAltaCompra;
    }
}