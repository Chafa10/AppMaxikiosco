
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(21, 65);
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
            this.dgvProvedor.Location = new System.Drawing.Point(699, 65);
            this.dgvProvedor.Name = "dgvProvedor";
            this.dgvProvedor.RowHeadersVisible = false;
            this.dgvProvedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvedor.Size = new System.Drawing.Size(659, 249);
            this.dgvProvedor.TabIndex = 1;
            this.dgvProvedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvedor_CellContentClick);
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(197, 39);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProducto.TabIndex = 2;
            this.txtFiltroProducto.TextChanged += new System.EventHandler(this.txtFiltroProducto_TextChanged);
            // 
            // txtFiltroProvedor
            // 
            this.txtFiltroProvedor.Location = new System.Drawing.Point(1075, 39);
            this.txtFiltroProvedor.Name = "txtFiltroProvedor";
            this.txtFiltroProvedor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProvedor.TabIndex = 3;
            this.txtFiltroProvedor.TextChanged += new System.EventHandler(this.txtFiltroProvedor_TextChanged);
            // 
            // lblFiltroProducto
            // 
            this.lblFiltroProducto.AutoSize = true;
            this.lblFiltroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProducto.Location = new System.Drawing.Point(38, 39);
            this.lblFiltroProducto.Name = "lblFiltroProducto";
            this.lblFiltroProducto.Size = new System.Drawing.Size(132, 17);
            this.lblFiltroProducto.TabIndex = 4;
            this.lblFiltroProducto.Text = "Filtrar por categoria";
            // 
            // lblFiltroProvedor
            // 
            this.lblFiltroProvedor.AutoSize = true;
            this.lblFiltroProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProvedor.Location = new System.Drawing.Point(910, 39);
            this.lblFiltroProvedor.Name = "lblFiltroProvedor";
            this.lblFiltroProvedor.Size = new System.Drawing.Size(130, 17);
            this.lblFiltroProvedor.TabIndex = 5;
            this.lblFiltroProvedor.Text = "Filtrar por provedor";
            // 
            // lblLProductos
            // 
            this.lblLProductos.AutoSize = true;
            this.lblLProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProductos.Location = new System.Drawing.Point(211, 9);
            this.lblLProductos.Name = "lblLProductos";
            this.lblLProductos.Size = new System.Drawing.Size(162, 26);
            this.lblLProductos.TabIndex = 6;
            this.lblLProductos.Text = "Lista Productos";
            // 
            // lblLProvedor
            // 
            this.lblLProvedor.AutoSize = true;
            this.lblLProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProvedor.Location = new System.Drawing.Point(968, 9);
            this.lblLProvedor.Name = "lblLProvedor";
            this.lblLProvedor.Size = new System.Drawing.Size(175, 26);
            this.lblLProvedor.TabIndex = 7;
            this.lblLProvedor.Text = "Lista Provedores";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(161, 320);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(271, 320);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProducto.TabIndex = 9;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(380, 320);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnElimiarProvedor
            // 
            this.btnElimiarProvedor.Location = new System.Drawing.Point(1121, 320);
            this.btnElimiarProvedor.Name = "btnElimiarProvedor";
            this.btnElimiarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnElimiarProvedor.TabIndex = 13;
            this.btnElimiarProvedor.Text = "Eliminar";
            this.btnElimiarProvedor.UseVisualStyleBackColor = true;
            this.btnElimiarProvedor.Click += new System.EventHandler(this.btnElimiarProvedor_Click);
            // 
            // btnModificarProvedor
            // 
            this.btnModificarProvedor.Location = new System.Drawing.Point(1010, 320);
            this.btnModificarProvedor.Name = "btnModificarProvedor";
            this.btnModificarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProvedor.TabIndex = 12;
            this.btnModificarProvedor.Text = "Modificar";
            this.btnModificarProvedor.UseVisualStyleBackColor = true;
            this.btnModificarProvedor.Click += new System.EventHandler(this.btnModificarProvedor_Click);
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Location = new System.Drawing.Point(875, 320);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProvedor.TabIndex = 11;
            this.btnAgregarProvedor.Text = "Agregar";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(250, 442);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(659, 123);
            this.dgvClientes.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(415, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(334, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrar por nombre";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(461, 407);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroCliente.TabIndex = 16;
            this.txtFiltroCliente.TextChanged += new System.EventHandler(this.txtFiltroCliente_TextChanged);
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.Location = new System.Drawing.Point(915, 513);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarClientes.TabIndex = 20;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.UseVisualStyleBackColor = true;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click);
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.Location = new System.Drawing.Point(913, 484);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClientes.TabIndex = 19;
            this.btnModificarClientes.Text = "Modificar";
            this.btnModificarClientes.UseVisualStyleBackColor = true;
            this.btnModificarClientes.Click += new System.EventHandler(this.btnModificarClientes_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Location = new System.Drawing.Point(915, 455);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClientes.TabIndex = 18;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 667);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnAgregarClientes;
    }
}