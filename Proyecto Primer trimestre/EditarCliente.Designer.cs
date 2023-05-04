namespace Proyecto_Primer_trimestre
{
    partial class EditarCliente
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
            this.txtEditarCliente = new System.Windows.Forms.Label();
            this.btnGuardarCambiosC = new FontAwesome.Sharp.IconButton();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.dgvEditUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditarCliente
            // 
            this.txtEditarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditarCliente.AutoSize = true;
            this.txtEditarCliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtEditarCliente.Location = new System.Drawing.Point(332, 18);
            this.txtEditarCliente.Name = "txtEditarCliente";
            this.txtEditarCliente.Size = new System.Drawing.Size(182, 32);
            this.txtEditarCliente.TabIndex = 75;
            this.txtEditarCliente.Text = "Editar cliente";
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambiosC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnGuardarCambiosC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardarCambiosC.FlatAppearance.BorderSize = 5;
            this.btnGuardarCambiosC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardarCambiosC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnGuardarCambiosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCambiosC.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambiosC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarCambiosC.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCambiosC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(306, 364);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(172, 59);
            this.btnGuardarCambiosC.TabIndex = 73;
            this.btnGuardarCambiosC.Text = "GUARDAR";
            this.btnGuardarCambiosC.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosC.UseWaitCursor = true;
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
            this.lupa.Location = new System.Drawing.Point(273, 102);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 81;
            this.lupa.UseVisualStyleBackColor = false;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(77, 102);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 80;
            this.txtBuscar1.Text = "Ingresar nombre usuario";
            this.txtBuscar1.Enter += new System.EventHandler(this.txtBuscar1_Enter);
            this.txtBuscar1.Leave += new System.EventHandler(this.txtBuscar1_Leave);
            // 
            // dgvEditUsuarios
            // 
            this.dgvEditUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEditUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.dgvEditUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.cedula,
            this.nombreUser,
            this.Apellidos,
            this.correoUser,
            this.telefonoUser});
            this.dgvEditUsuarios.Location = new System.Drawing.Point(77, 171);
            this.dgvEditUsuarios.Name = "dgvEditUsuarios";
            this.dgvEditUsuarios.RowTemplate.Height = 25;
            this.dgvEditUsuarios.Size = new System.Drawing.Size(654, 83);
            this.dgvEditUsuarios.TabIndex = 82;
            // 
            // idUser
            // 
            this.idUser.HeaderText = "ID";
            this.idUser.Name = "idUser";
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // nombreUser
            // 
            this.nombreUser.HeaderText = "Nombre";
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // correoUser
            // 
            this.correoUser.HeaderText = "Correo electronico";
            this.correoUser.Name = "correoUser";
            this.correoUser.ReadOnly = true;
            // 
            // telefonoUser
            // 
            this.telefonoUser.HeaderText = "Telefono";
            this.telefonoUser.Name = "telefonoUser";
            this.telefonoUser.ReadOnly = true;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(785, 480);
            this.Controls.Add(this.dgvEditUsuarios);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.txtEditarCliente);
            this.Controls.Add(this.btnGuardarCambiosC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCliente";
            this.Text = "EditarCli";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label txtEditarCliente;
        private FontAwesome.Sharp.IconButton btnGuardarCambiosC;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
        private DataGridView dgvEditUsuarios;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn nombreUser;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn correoUser;
        private DataGridViewTextBoxColumn telefonoUser;
    }
}