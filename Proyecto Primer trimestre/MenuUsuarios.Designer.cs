namespace Proyecto_Primer_trimestre
{
    partial class MenuUsuarios
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
            System.Windows.Forms.PictureBox imagenAñadirUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarios));
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.btnAddUsuario = new FontAwesome.Sharp.IconButton();
            this.tbpUsuarios = new System.Windows.Forms.TabControl();
            this.tbpAdd = new System.Windows.Forms.TabPage();
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.opcTipoUser = new System.Windows.Forms.ComboBox();
            this.txtCorreoAdd = new System.Windows.Forms.TextBox();
            this.txtTelefonoAdd = new System.Windows.Forms.TextBox();
            this.txtAñadirUsuario = new System.Windows.Forms.Label();
            this.btnOcultarAU = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtNombreAdd = new System.Windows.Forms.TextBox();
            this.txtContrasenaAdd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtEditUsuario = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVerUno = new FontAwesome.Sharp.IconButton();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.btnTodos = new FontAwesome.Sharp.IconButton();
            this.txtIndex = new System.Windows.Forms.Label();
            imagenAñadirUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirUser)).BeginInit();
            this.tbpUsuarios.SuspendLayout();
            this.tbpAdd.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenAñadirUser
            // 
            imagenAñadirUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenAñadirUser.BackgroundImage")));
            imagenAñadirUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imagenAñadirUser.Dock = System.Windows.Forms.DockStyle.Left;
            imagenAñadirUser.Location = new System.Drawing.Point(3, 3);
            imagenAñadirUser.Name = "imagenAñadirUser";
            imagenAñadirUser.Size = new System.Drawing.Size(359, 523);
            imagenAñadirUser.TabIndex = 43;
            imagenAñadirUser.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 30;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.Location = new System.Drawing.Point(180, -54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(178, 39);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnVer.IconColor = System.Drawing.Color.Black;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.IconSize = 30;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVer.Location = new System.Drawing.Point(349, -54);
            this.btnVer.Name = "btnVer";
            this.btnVer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVer.Size = new System.Drawing.Size(178, 39);
            this.btnVer.TabIndex = 26;
            this.btnVer.Text = "Ver usuarios";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.FlatAppearance.BorderSize = 0;
            this.btnAddUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnAddUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnAddUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAddUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUsuario.IconSize = 30;
            this.btnAddUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddUsuario.Location = new System.Drawing.Point(8, -54);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddUsuario.Size = new System.Drawing.Size(178, 39);
            this.btnAddUsuario.TabIndex = 25;
            this.btnAddUsuario.Text = "Añadir usuario";
            this.btnAddUsuario.UseVisualStyleBackColor = true;
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.Controls.Add(this.tbpAdd);
            this.tbpUsuarios.Controls.Add(this.tabPage2);
            this.tbpUsuarios.Controls.Add(this.tabPage3);
            this.tbpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.SelectedIndex = 0;
            this.tbpUsuarios.Size = new System.Drawing.Size(800, 559);
            this.tbpUsuarios.TabIndex = 0;
            // 
            // tbpAdd
            // 
            this.tbpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tbpAdd.Controls.Add(this.btnMostrar);
            this.tbpAdd.Controls.Add(this.txtApellidos);
            this.tbpAdd.Controls.Add(this.opcTipoUser);
            this.tbpAdd.Controls.Add(this.txtCorreoAdd);
            this.tbpAdd.Controls.Add(this.txtTelefonoAdd);
            this.tbpAdd.Controls.Add(this.txtAñadirUsuario);
            this.tbpAdd.Controls.Add(this.btnOcultarAU);
            this.tbpAdd.Controls.Add(this.btnAgregar);
            this.tbpAdd.Controls.Add(this.txtNombreAdd);
            this.tbpAdd.Controls.Add(this.txtContrasenaAdd);
            this.tbpAdd.Controls.Add(imagenAñadirUser);
            this.tbpAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbpAdd.Location = new System.Drawing.Point(4, 26);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd.Size = new System.Drawing.Size(792, 529);
            this.tbpAdd.TabIndex = 0;
            this.tbpAdd.Text = "Añadir usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Silver;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrar.IconColor = System.Drawing.Color.Black;
            this.btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrar.IconSize = 25;
            this.btnMostrar.Location = new System.Drawing.Point(679, 290);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(29, 23);
            this.btnMostrar.TabIndex = 64;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Silver;
            this.txtApellidos.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.Location = new System.Drawing.Point(450, 149);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(243, 21);
            this.txtApellidos.TabIndex = 63;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // opcTipoUser
            // 
            this.opcTipoUser.BackColor = System.Drawing.Color.Silver;
            this.opcTipoUser.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opcTipoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opcTipoUser.FormattingEnabled = true;
            this.opcTipoUser.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.opcTipoUser.Location = new System.Drawing.Point(450, 351);
            this.opcTipoUser.Name = "opcTipoUser";
            this.opcTipoUser.Size = new System.Drawing.Size(243, 26);
            this.opcTipoUser.TabIndex = 62;
            this.opcTipoUser.Text = "Tipo Usuario";
            // 
            // txtCorreoAdd
            // 
            this.txtCorreoAdd.BackColor = System.Drawing.Color.Silver;
            this.txtCorreoAdd.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoAdd.Location = new System.Drawing.Point(450, 194);
            this.txtCorreoAdd.Name = "txtCorreoAdd";
            this.txtCorreoAdd.Size = new System.Drawing.Size(243, 21);
            this.txtCorreoAdd.TabIndex = 61;
            this.txtCorreoAdd.Text = "Correo electronico";
            this.txtCorreoAdd.Enter += new System.EventHandler(this.txtCorreoAdd_Enter);
            this.txtCorreoAdd.Leave += new System.EventHandler(this.txtCorreoAdd_Leave);
            // 
            // txtTelefonoAdd
            // 
            this.txtTelefonoAdd.BackColor = System.Drawing.Color.Silver;
            this.txtTelefonoAdd.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefonoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefonoAdd.Location = new System.Drawing.Point(450, 247);
            this.txtTelefonoAdd.Name = "txtTelefonoAdd";
            this.txtTelefonoAdd.Size = new System.Drawing.Size(243, 21);
            this.txtTelefonoAdd.TabIndex = 60;
            this.txtTelefonoAdd.Text = "Numero de telefono";
            this.txtTelefonoAdd.Enter += new System.EventHandler(this.txtTelefonoAdd_Enter);
            this.txtTelefonoAdd.Leave += new System.EventHandler(this.txtTelefonoAdd_Leave);
            // 
            // txtAñadirUsuario
            // 
            this.txtAñadirUsuario.AutoSize = true;
            this.txtAñadirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAñadirUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtAñadirUsuario.Location = new System.Drawing.Point(417, 51);
            this.txtAñadirUsuario.Name = "txtAñadirUsuario";
            this.txtAñadirUsuario.Size = new System.Drawing.Size(167, 29);
            this.txtAñadirUsuario.TabIndex = 59;
            this.txtAñadirUsuario.Text = "Añadir usuario";
            // 
            // btnOcultarAU
            // 
            this.btnOcultarAU.BackColor = System.Drawing.Color.Silver;
            this.btnOcultarAU.FlatAppearance.BorderSize = 0;
            this.btnOcultarAU.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnOcultarAU.IconColor = System.Drawing.Color.Black;
            this.btnOcultarAU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultarAU.IconSize = 25;
            this.btnOcultarAU.Location = new System.Drawing.Point(679, 290);
            this.btnOcultarAU.Margin = new System.Windows.Forms.Padding(0);
            this.btnOcultarAU.Name = "btnOcultarAU";
            this.btnOcultarAU.Size = new System.Drawing.Size(29, 23);
            this.btnOcultarAU.TabIndex = 58;
            this.btnOcultarAU.UseVisualStyleBackColor = false;
            this.btnOcultarAU.Visible = false;
            this.btnOcultarAU.Click += new System.EventHandler(this.btnOcultarAU_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAgregar.FlatAppearance.BorderSize = 5;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(504, 428);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 59);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.UseWaitCursor = true;
            // 
            // txtNombreAdd
            // 
            this.txtNombreAdd.BackColor = System.Drawing.Color.Silver;
            this.txtNombreAdd.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAdd.Location = new System.Drawing.Point(450, 96);
            this.txtNombreAdd.Name = "txtNombreAdd";
            this.txtNombreAdd.Size = new System.Drawing.Size(243, 21);
            this.txtNombreAdd.TabIndex = 56;
            this.txtNombreAdd.Text = "Nombre";
            this.txtNombreAdd.Enter += new System.EventHandler(this.txtNombreAdd_Enter);
            this.txtNombreAdd.Leave += new System.EventHandler(this.txtNombreAdd_Leave);
            // 
            // txtContrasenaAdd
            // 
            this.txtContrasenaAdd.BackColor = System.Drawing.Color.Silver;
            this.txtContrasenaAdd.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasenaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasenaAdd.Location = new System.Drawing.Point(450, 290);
            this.txtContrasenaAdd.Name = "txtContrasenaAdd";
            this.txtContrasenaAdd.Size = new System.Drawing.Size(226, 21);
            this.txtContrasenaAdd.TabIndex = 55;
            this.txtContrasenaAdd.Text = "Contraseña";
            this.txtContrasenaAdd.TextChanged += new System.EventHandler(this.txtContrasenaAdd_TextChanged);
            this.txtContrasenaAdd.Enter += new System.EventHandler(this.txtContrasenaAdd_Enter);
            this.txtContrasenaAdd.Leave += new System.EventHandler(this.txtContrasenaAdd_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tabPage2.Controls.Add(this.iconButton1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.iconButton2);
            this.tabPage2.Controls.Add(this.txtEditUsuario);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar usuario";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.iconButton1.FlatAppearance.BorderSize = 5;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(623, 267);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(145, 47);
            this.iconButton1.TabIndex = 89;
            this.iconButton1.Text = "Buscar 1";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(238)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 72);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo electronico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(220, 51);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(39, 23);
            this.iconButton2.TabIndex = 86;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // txtEditUsuario
            // 
            this.txtEditUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtEditUsuario.Location = new System.Drawing.Point(24, 51);
            this.txtEditUsuario.Name = "txtEditUsuario";
            this.txtEditUsuario.Size = new System.Drawing.Size(193, 23);
            this.txtEditUsuario.TabIndex = 85;
            this.txtEditUsuario.Text = "Ingresar nombre usuario";
            this.txtEditUsuario.Enter += new System.EventHandler(this.txtEditUsuario_Enter);
            this.txtEditUsuario.Leave += new System.EventHandler(this.txtEditUsuario_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tabPage3.Controls.Add(this.btnVerUno);
            this.tabPage3.Controls.Add(this.dgvDatosUsuarios);
            this.tabPage3.Controls.Add(this.lupa);
            this.tabPage3.Controls.Add(this.txtBuscar1);
            this.tabPage3.Controls.Add(this.btnTodos);
            this.tabPage3.Controls.Add(this.txtIndex);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Datos usuarios";
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
            this.btnVerUno.Location = new System.Drawing.Point(160, 80);
            this.btnVerUno.Name = "btnVerUno";
            this.btnVerUno.Size = new System.Drawing.Size(145, 47);
            this.btnVerUno.TabIndex = 83;
            this.btnVerUno.Text = "Buscar 1";
            this.btnVerUno.UseVisualStyleBackColor = false;
            this.btnVerUno.UseWaitCursor = true;
            this.btnVerUno.Click += new System.EventHandler(this.btnVerUno_Click);
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDatosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(238)))));
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.cedula,
            this.nombreUser,
            this.Apellidos,
            this.rolUser,
            this.correoUser,
            this.telefonoUser});
            this.dgvDatosUsuarios.EnableHeadersVisualStyles = false;
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(24, 200);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.RowTemplate.Height = 25;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(744, 293);
            this.dgvDatosUsuarios.TabIndex = 81;
            // 
            // idUser
            // 
            this.idUser.HeaderText = "ID";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
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
            // rolUser
            // 
            this.rolUser.HeaderText = "Rol";
            this.rolUser.Name = "rolUser";
            this.rolUser.ReadOnly = true;
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
            this.lupa.Location = new System.Drawing.Point(323, 152);
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
            this.txtBuscar1.Location = new System.Drawing.Point(127, 152);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 79;
            this.txtBuscar1.Text = "Ingresar nombre usuario";
            this.txtBuscar1.Visible = false;
            this.txtBuscar1.Enter += new System.EventHandler(this.txtBuscar1_Enter);
            this.txtBuscar1.Leave += new System.EventHandler(this.txtBuscar1_Leave);
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
            this.btnTodos.Location = new System.Drawing.Point(452, 80);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(166, 47);
            this.btnTodos.TabIndex = 84;
            this.btnTodos.Text = "Mostrar todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.UseWaitCursor = true;
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIndex.AutoSize = true;
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtIndex.Location = new System.Drawing.Point(262, 22);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(282, 31);
            this.txtIndex.TabIndex = 82;
            this.txtIndex.Text = "Seleccione la opcion";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.tbpUsuarios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAddUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUsuarios";
            this.Text = "MenuUsuarios";
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirUser)).EndInit();
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpAdd.ResumeLayout(false);
            this.tbpAdd.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton btnAddUsuario;
        private TabControl tbpUsuarios;
        private TabPage tbpAdd;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtApellidos;
        private ComboBox opcTipoUser;
        private TextBox txtCorreoAdd;
        private TextBox txtTelefonoAdd;
        private Label txtAñadirUsuario;
        private FontAwesome.Sharp.IconButton btnOcultarAU;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TextBox txtNombreAdd;
        private TextBox txtContrasenaAdd;
        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnVerUno;
        private DataGridView dgvDatosUsuarios;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
        private FontAwesome.Sharp.IconButton btnTodos;
        private Label txtIndex;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txtEditUsuario;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn nombreUser;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn rolUser;
        private DataGridViewTextBoxColumn correoUser;
        private DataGridViewTextBoxColumn telefonoUser;
    }
}