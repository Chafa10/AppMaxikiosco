namespace MaxiKiosco
{
    partial class formProductos
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
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblLProductos = new System.Windows.Forms.Label();
            this.lblFiltroProducto = new System.Windows.Forms.Label();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(613, 380);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(477, 380);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProducto.TabIndex = 16;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(347, 380);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblLProductos
            // 
            this.lblLProductos.AutoSize = true;
            this.lblLProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProductos.Location = new System.Drawing.Point(453, 34);
            this.lblLProductos.Name = "lblLProductos";
            this.lblLProductos.Size = new System.Drawing.Size(162, 26);
            this.lblLProductos.TabIndex = 14;
            this.lblLProductos.Text = "Lista Productos";
            // 
            // lblFiltroProducto
            // 
            this.lblFiltroProducto.AutoSize = true;
            this.lblFiltroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProducto.Location = new System.Drawing.Point(246, 88);
            this.lblFiltroProducto.Name = "lblFiltroProducto";
            this.lblFiltroProducto.Size = new System.Drawing.Size(132, 17);
            this.lblFiltroProducto.TabIndex = 13;
            this.lblFiltroProducto.Text = "Filtrar por categoria";
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(384, 88);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProducto.TabIndex = 12;
            this.txtFiltroProducto.TextChanged += new System.EventHandler(this.txtFiltroProducto_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(208, 114);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(659, 249);
            this.dgvProductos.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(71, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 524);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblLProductos);
            this.Controls.Add(this.lblFiltroProducto);
            this.Controls.Add(this.txtFiltroProducto);
            this.Controls.Add(this.dgvProductos);
            this.Name = "formProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblLProductos;
        private System.Windows.Forms.Label lblFiltroProducto;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVolver;
    }
}