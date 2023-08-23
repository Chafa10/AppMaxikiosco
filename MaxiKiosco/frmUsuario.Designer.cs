namespace MaxiKiosco
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(35, 167);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(398, 383);
            this.dgvUsuarios.TabIndex = 22;
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnEliminarClientes.FlatAppearance.BorderSize = 0;
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarClientes.Image")));
            this.btnEliminarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarClientes.Location = new System.Drawing.Point(459, 404);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(123, 37);
            this.btnEliminarClientes.TabIndex = 30;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnModificarClientes.FlatAppearance.BorderSize = 0;
            this.btnModificarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarClientes.Image")));
            this.btnModificarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarClientes.Location = new System.Drawing.Point(459, 307);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(123, 37);
            this.btnModificarClientes.TabIndex = 29;
            this.btnModificarClientes.Text = "Modificar";
            this.btnModificarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarClientes.UseVisualStyleBackColor = false;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnAgregarClientes.FlatAppearance.BorderSize = 0;
            this.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarClientes.Image")));
            this.btnAgregarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarClientes.Location = new System.Drawing.Point(462, 213);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(120, 37);
            this.btnAgregarClientes.TabIndex = 28;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lista de usuarios";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(12, 92);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 40);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.brnCerrar);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 56);
            this.panel2.TabIndex = 34;
            // 
            // brnCerrar
            // 
            this.brnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.brnCerrar.FlatAppearance.BorderSize = 0;
            this.brnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCerrar.ForeColor = System.Drawing.Color.White;
            this.brnCerrar.Location = new System.Drawing.Point(555, 7);
            this.brnCerrar.Name = "brnCerrar";
            this.brnCerrar.Size = new System.Drawing.Size(49, 42);
            this.brnCerrar.TabIndex = 2;
            this.brnCerrar.Text = "X";
            this.brnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brnCerrar.UseVisualStyleBackColor = false;
            this.brnCerrar.Click += new System.EventHandler(this.brnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(511, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(49, 42);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maxi Kiosco";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(609, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button brnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label2;
    }
}