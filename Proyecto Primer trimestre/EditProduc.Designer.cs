namespace Proyecto_Primer_trimestre
{
    partial class EditProduc
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
            this.txtEditarProducto = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.dgvEditUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditarProducto
            // 
            this.txtEditarProducto.AutoSize = true;
            this.txtEditarProducto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEditarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtEditarProducto.Location = new System.Drawing.Point(31, 36);
            this.txtEditarProducto.Name = "txtEditarProducto";
            this.txtEditarProducto.Size = new System.Drawing.Size(215, 32);
            this.txtEditarProducto.TabIndex = 74;
            this.txtEditarProducto.Text = "Editar producto";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 5;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.Location = new System.Drawing.Point(484, 388);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(172, 59);
            this.btnGuardarCambios.TabIndex = 71;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.UseWaitCursor = true;
            // 
            // dgvEditUsuarios
            // 
            this.dgvEditUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEditUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.dgvEditUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.Nombre,
            this.marca,
            this.precioProduc});
            this.dgvEditUsuarios.Location = new System.Drawing.Point(163, 206);
            this.dgvEditUsuarios.Name = "dgvEditUsuarios";
            this.dgvEditUsuarios.RowTemplate.Height = 25;
            this.dgvEditUsuarios.Size = new System.Drawing.Size(445, 83);
            this.dgvEditUsuarios.TabIndex = 83;
            // 
            // idUser
            // 
            this.idUser.HeaderText = "ID";
            this.idUser.Name = "idUser";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // precioProduc
            // 
            this.precioProduc.HeaderText = "Precio";
            this.precioProduc.Name = "precioProduc";
            this.precioProduc.ReadOnly = true;
            // 
            // lupa
            // 
            this.lupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lupa.BackColor = System.Drawing.Color.Transparent;
            this.lupa.FlatAppearance.BorderSize = 0;
            this.lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lupa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.lupa.IconColor = System.Drawing.Color.Black;
            this.lupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lupa.IconSize = 25;
            this.lupa.Location = new System.Drawing.Point(227, 108);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 85;
            this.lupa.UseVisualStyleBackColor = false;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(31, 108);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 84;
            this.txtBuscar1.Text = "Ingresar nombre usuario";
            // 
            // EditProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.dgvEditUsuarios);
            this.Controls.Add(this.txtEditarProducto);
            this.Controls.Add(this.btnGuardarCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProduc";
            this.Text = "EditProduc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label txtEditarProducto;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private DataGridView dgvEditUsuarios;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn precioProduc;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
    }
}