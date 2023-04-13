
namespace MaxiKiosco
{
    partial class frmProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvProvedor = new System.Windows.Forms.DataGridView();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.txtFiltroProvedor = new System.Windows.Forms.TextBox();
            this.lblFiltroProducto = new System.Windows.Forms.Label();
            this.lblFiltroProvedor = new System.Windows.Forms.Label();
            this.lblLProductos = new System.Windows.Forms.Label();
            this.lblLProvedor = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnElimiarProvedor = new System.Windows.Forms.Button();
            this.btnModificarProvedor = new System.Windows.Forms.Button();
            this.btnAgregarProvedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(24, 227);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(659, 249);
            this.dgvProductos.TabIndex = 0;
            // 
            // dgvProvedor
            // 
            this.dgvProvedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProvedor.Location = new System.Drawing.Point(742, 227);
            this.dgvProvedor.Name = "dgvProvedor";
            this.dgvProvedor.RowHeadersVisible = false;
            this.dgvProvedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvedor.Size = new System.Drawing.Size(659, 249);
            this.dgvProvedor.TabIndex = 1;
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(205, 176);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProducto.TabIndex = 2;
            this.txtFiltroProducto.TextChanged += new System.EventHandler(this.txtFiltroProducto_TextChanged);
            // 
            // txtFiltroProvedor
            // 
            this.txtFiltroProvedor.Location = new System.Drawing.Point(913, 176);
            this.txtFiltroProvedor.Name = "txtFiltroProvedor";
            this.txtFiltroProvedor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProvedor.TabIndex = 3;
            this.txtFiltroProvedor.TextChanged += new System.EventHandler(this.txtFiltroProvedor_TextChanged);
            // 
            // lblFiltroProducto
            // 
            this.lblFiltroProducto.AutoSize = true;
            this.lblFiltroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProducto.Location = new System.Drawing.Point(46, 176);
            this.lblFiltroProducto.Name = "lblFiltroProducto";
            this.lblFiltroProducto.Size = new System.Drawing.Size(132, 17);
            this.lblFiltroProducto.TabIndex = 4;
            this.lblFiltroProducto.Text = "Filtrar por categoria";
            // 
            // lblFiltroProvedor
            // 
            this.lblFiltroProvedor.AutoSize = true;
            this.lblFiltroProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProvedor.Location = new System.Drawing.Point(748, 176);
            this.lblFiltroProvedor.Name = "lblFiltroProvedor";
            this.lblFiltroProvedor.Size = new System.Drawing.Size(130, 17);
            this.lblFiltroProvedor.TabIndex = 5;
            this.lblFiltroProvedor.Text = "Filtrar por provedor";
            // 
            // lblLProductos
            // 
            this.lblLProductos.AutoSize = true;
            this.lblLProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProductos.Location = new System.Drawing.Point(243, 79);
            this.lblLProductos.Name = "lblLProductos";
            this.lblLProductos.Size = new System.Drawing.Size(162, 26);
            this.lblLProductos.TabIndex = 6;
            this.lblLProductos.Text = "Lista Productos";
            // 
            // lblLProvedor
            // 
            this.lblLProvedor.AutoSize = true;
            this.lblLProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProvedor.Location = new System.Drawing.Point(976, 79);
            this.lblLProvedor.Name = "lblLProvedor";
            this.lblLProvedor.Size = new System.Drawing.Size(175, 26);
            this.lblLProvedor.TabIndex = 7;
            this.lblLProvedor.Text = "Lista Provedores";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(148, 521);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(272, 521);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProducto.TabIndex = 9;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(395, 521);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnElimiarProvedor
            // 
            this.btnElimiarProvedor.Location = new System.Drawing.Point(1160, 521);
            this.btnElimiarProvedor.Name = "btnElimiarProvedor";
            this.btnElimiarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnElimiarProvedor.TabIndex = 13;
            this.btnElimiarProvedor.Text = "Eliminar";
            this.btnElimiarProvedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProvedor
            // 
            this.btnModificarProvedor.Location = new System.Drawing.Point(1037, 521);
            this.btnModificarProvedor.Name = "btnModificarProvedor";
            this.btnModificarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProvedor.TabIndex = 12;
            this.btnModificarProvedor.Text = "Modificar";
            this.btnModificarProvedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Location = new System.Drawing.Point(913, 521);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProvedor.TabIndex = 11;
            this.btnAgregarProvedor.Text = "Agregar";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 646);
            this.Controls.Add(this.btnElimiarProvedor);
            this.Controls.Add(this.btnModificarProvedor);
            this.Controls.Add(this.btnAgregarProvedor);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblLProvedor);
            this.Controls.Add(this.lblLProductos);
            this.Controls.Add(this.lblFiltroProvedor);
            this.Controls.Add(this.lblFiltroProducto);
            this.Controls.Add(this.txtFiltroProvedor);
            this.Controls.Add(this.txtFiltroProducto);
            this.Controls.Add(this.dgvProvedor);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvProvedor;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        private System.Windows.Forms.TextBox txtFiltroProvedor;
        private System.Windows.Forms.Label lblFiltroProducto;
        private System.Windows.Forms.Label lblFiltroProvedor;
        private System.Windows.Forms.Label lblLProductos;
        private System.Windows.Forms.Label lblLProvedor;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnElimiarProvedor;
        private System.Windows.Forms.Button btnModificarProvedor;
        private System.Windows.Forms.Button btnAgregarProvedor;
    }
}