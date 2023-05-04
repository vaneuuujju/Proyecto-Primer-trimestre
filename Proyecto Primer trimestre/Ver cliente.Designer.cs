namespace Proyecto_Primer_trimestre
{
    partial class Ver_cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.btnTodos = new FontAwesome.Sharp.IconButton();
            this.btnVerUno = new FontAwesome.Sharp.IconButton();
            this.txtIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDatosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.cedula,
            this.nombreUser,
            this.Apellidos,
            this.correoUser,
            this.telefonoUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosUsuarios.EnableHeadersVisualStyles = false;
            this.dgvDatosUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(83, 207);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.RowTemplate.Height = 25;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(648, 308);
            this.dgvDatosUsuarios.TabIndex = 81;
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
            this.lupa.Location = new System.Drawing.Point(285, 156);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 80;
            this.lupa.UseVisualStyleBackColor = false;
            this.lupa.Visible = false;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(131, 157);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 79;
            this.txtBuscar1.Text = "Ingresar nombre cliente";
            this.txtBuscar1.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnTodos.FlatAppearance.BorderSize = 5;
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTodos.IconColor = System.Drawing.Color.Black;
            this.btnTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTodos.Location = new System.Drawing.Point(456, 85);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(166, 47);
            this.btnTodos.TabIndex = 84;
            this.btnTodos.Text = "Mostrar todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.UseWaitCursor = true;
            // 
            // btnVerUno
            // 
            this.btnVerUno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnVerUno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnVerUno.FlatAppearance.BorderSize = 5;
            this.btnVerUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnVerUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnVerUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerUno.ForeColor = System.Drawing.Color.White;
            this.btnVerUno.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerUno.IconColor = System.Drawing.Color.Black;
            this.btnVerUno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerUno.Location = new System.Drawing.Point(164, 85);
            this.btnVerUno.Name = "btnVerUno";
            this.btnVerUno.Size = new System.Drawing.Size(145, 47);
            this.btnVerUno.TabIndex = 83;
            this.btnVerUno.Text = "Buscar 1";
            this.btnVerUno.UseVisualStyleBackColor = false;
            this.btnVerUno.UseWaitCursor = true;
            this.btnVerUno.Click += new System.EventHandler(this.btnVerUno_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIndex.AutoSize = true;
            this.txtIndex.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtIndex.Location = new System.Drawing.Point(275, 28);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(289, 32);
            this.txtIndex.TabIndex = 82;
            this.txtIndex.Text = "Seleccione la opcion";
            // 
            // Ver_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.dgvDatosUsuarios);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnVerUno);
            this.Controls.Add(this.txtIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_cliente";
            this.Text = "Ver_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDatosUsuarios;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn nombreUser;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn correoUser;
        private DataGridViewTextBoxColumn telefonoUser;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
        private FontAwesome.Sharp.IconButton btnTodos;
        private FontAwesome.Sharp.IconButton btnVerUno;
        private Label txtIndex;
    }
}