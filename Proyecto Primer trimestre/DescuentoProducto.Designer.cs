namespace Proyecto_Primer_trimestre
{
    partial class DescuentoProducto
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
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(38, 71);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 91;
            this.txtBuscar1.Text = "Ingresar nombre producto";
            this.txtBuscar1.Enter += new System.EventHandler(this.txtBuscar1_Enter);
            this.txtBuscar1.Leave += new System.EventHandler(this.txtBuscar1_Leave);
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
            this.lupa.Location = new System.Drawing.Point(192, 70);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 92;
            this.lupa.UseVisualStyleBackColor = false;
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.nombreProduc,
            this.PrecioProduc,
            this.MarcaProducto,
            this.Descuento});
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(98, 144);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.RowTemplate.Height = 25;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(544, 46);
            this.dgvDatosUsuarios.TabIndex = 93;
            // 
            // idUser
            // 
            this.idUser.HeaderText = "ID";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            // 
            // nombreProduc
            // 
            this.nombreProduc.HeaderText = "Nombre";
            this.nombreProduc.Name = "nombreProduc";
            this.nombreProduc.ReadOnly = true;
            // 
            // PrecioProduc
            // 
            this.PrecioProduc.HeaderText = "Precio";
            this.PrecioProduc.Name = "PrecioProduc";
            this.PrecioProduc.ReadOnly = true;
            // 
            // MarcaProducto
            // 
            this.MarcaProducto.HeaderText = "Marca";
            this.MarcaProducto.Name = "MarcaProducto";
            this.MarcaProducto.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // DescuentoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.Controls.Add(this.dgvDatosUsuarios);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.txtBuscar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescuentoProducto";
            this.Text = "DescuentoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBuscar1;
        private FontAwesome.Sharp.IconButton lupa;
        private DataGridView dgvDatosUsuarios;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn nombreProduc;
        private DataGridViewTextBoxColumn PrecioProduc;
        private DataGridViewTextBoxColumn MarcaProducto;
        private DataGridViewTextBoxColumn Descuento;
    }
}