namespace MaxiKiosco
{
    partial class formProveedor
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
            this.btnElimiarProvedor = new System.Windows.Forms.Button();
            this.btnModificarProvedor = new System.Windows.Forms.Button();
            this.btnAgregarProvedor = new System.Windows.Forms.Button();
            this.lblLProvedor = new System.Windows.Forms.Label();
            this.lblFiltroProvedor = new System.Windows.Forms.Label();
            this.txtFiltroProvedor = new System.Windows.Forms.TextBox();
            this.dgvProvedor = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElimiarProvedor
            // 
            this.btnElimiarProvedor.Location = new System.Drawing.Point(530, 403);
            this.btnElimiarProvedor.Name = "btnElimiarProvedor";
            this.btnElimiarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnElimiarProvedor.TabIndex = 20;
            this.btnElimiarProvedor.Text = "Eliminar";
            this.btnElimiarProvedor.UseVisualStyleBackColor = true;
            this.btnElimiarProvedor.Click += new System.EventHandler(this.btnElimiarProvedor_Click);
            // 
            // btnModificarProvedor
            // 
            this.btnModificarProvedor.Location = new System.Drawing.Point(407, 403);
            this.btnModificarProvedor.Name = "btnModificarProvedor";
            this.btnModificarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProvedor.TabIndex = 19;
            this.btnModificarProvedor.Text = "Modificar";
            this.btnModificarProvedor.UseVisualStyleBackColor = true;
            this.btnModificarProvedor.Click += new System.EventHandler(this.btnModificarProvedor_Click);
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Location = new System.Drawing.Point(284, 403);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProvedor.TabIndex = 18;
            this.btnAgregarProvedor.Text = "Agregar";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // lblLProvedor
            // 
            this.lblLProvedor.AutoSize = true;
            this.lblLProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLProvedor.Location = new System.Drawing.Point(370, 37);
            this.lblLProvedor.Name = "lblLProvedor";
            this.lblLProvedor.Size = new System.Drawing.Size(175, 26);
            this.lblLProvedor.TabIndex = 17;
            this.lblLProvedor.Text = "Lista Provedores";
            // 
            // lblFiltroProvedor
            // 
            this.lblFiltroProvedor.AutoSize = true;
            this.lblFiltroProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltroProvedor.Location = new System.Drawing.Point(307, 92);
            this.lblFiltroProvedor.Name = "lblFiltroProvedor";
            this.lblFiltroProvedor.Size = new System.Drawing.Size(130, 17);
            this.lblFiltroProvedor.TabIndex = 16;
            this.lblFiltroProvedor.Text = "Filtrar por provedor";
            // 
            // txtFiltroProvedor
            // 
            this.txtFiltroProvedor.Location = new System.Drawing.Point(487, 92);
            this.txtFiltroProvedor.Name = "txtFiltroProvedor";
            this.txtFiltroProvedor.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroProvedor.TabIndex = 15;
            this.txtFiltroProvedor.TextChanged += new System.EventHandler(this.txtFiltroProvedor_TextChanged);
            // 
            // dgvProvedor
            // 
            this.dgvProvedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProvedor.Location = new System.Drawing.Point(117, 127);
            this.dgvProvedor.Name = "dgvProvedor";
            this.dgvProvedor.RowHeadersVisible = false;
            this.dgvProvedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvedor.Size = new System.Drawing.Size(659, 249);
            this.dgvProvedor.TabIndex = 14;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(94, 37);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 546);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnElimiarProvedor);
            this.Controls.Add(this.btnModificarProvedor);
            this.Controls.Add(this.btnAgregarProvedor);
            this.Controls.Add(this.lblLProvedor);
            this.Controls.Add(this.lblFiltroProvedor);
            this.Controls.Add(this.txtFiltroProvedor);
            this.Controls.Add(this.dgvProvedor);
            this.Name = "formProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElimiarProvedor;
        private System.Windows.Forms.Button btnModificarProvedor;
        private System.Windows.Forms.Button btnAgregarProvedor;
        private System.Windows.Forms.Label lblLProvedor;
        private System.Windows.Forms.Label lblFiltroProvedor;
        private System.Windows.Forms.TextBox txtFiltroProvedor;
        private System.Windows.Forms.DataGridView dgvProvedor;
        private System.Windows.Forms.Button btnVolver;
    }
}