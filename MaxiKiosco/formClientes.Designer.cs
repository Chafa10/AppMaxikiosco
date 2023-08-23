namespace MaxiKiosco
{
    partial class formClientes
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
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.Location = new System.Drawing.Point(480, 356);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarClientes.TabIndex = 27;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.UseVisualStyleBackColor = true;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click);
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.Location = new System.Drawing.Point(325, 356);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClientes.TabIndex = 26;
            this.btnModificarClientes.Text = "Modificar";
            this.btnModificarClientes.UseVisualStyleBackColor = true;
            this.btnModificarClientes.Click += new System.EventHandler(this.btnModificarClientes_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Location = new System.Drawing.Point(191, 356);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClientes.TabIndex = 25;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(230, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filtrar por nombre";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(357, 91);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroCliente.TabIndex = 23;
            this.txtFiltroCliente.TextChanged += new System.EventHandler(this.txtFiltroCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(320, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lista Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(30, 136);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(659, 192);
            this.dgvClientes.TabIndex = 21;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(30, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "formClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnVolver;
    }
}