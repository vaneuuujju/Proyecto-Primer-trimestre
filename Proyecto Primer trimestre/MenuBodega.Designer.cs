namespace Proyecto_Primer_trimestre
{
    partial class MenuBodega
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
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.txtAñadirCliente = new System.Windows.Forms.Label();
            this.txtCantidadMin = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtCantidadMax = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.tbpAdd = new System.Windows.Forms.TabControl();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.btnTodos = new FontAwesome.Sharp.IconButton();
            this.btnVerUno = new FontAwesome.Sharp.IconButton();
            this.txtIndex = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpAdd.SuspendLayout();
            this.tbpAdd.SuspendLayout();
            this.tpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tpAdd.Controls.Add(this.txtAñadirCliente);
            this.tpAdd.Controls.Add(this.txtCantidadMin);
            this.tpAdd.Controls.Add(this.iconButton1);
            this.tpAdd.Controls.Add(this.txtCantidadMax);
            this.tpAdd.Controls.Add(this.btnAgregarCliente);
            this.tpAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tpAdd.Location = new System.Drawing.Point(4, 26);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(777, 525);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "Añadir bodega";
            this.tpAdd.Click += new System.EventHandler(this.tpAdd_Click);
            // 
            // txtAñadirCliente
            // 
            this.txtAñadirCliente.AutoSize = true;
            this.txtAñadirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAñadirCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.txtAñadirCliente.Location = new System.Drawing.Point(35, 39);
            this.txtAñadirCliente.Name = "txtAñadirCliente";
            this.txtAñadirCliente.Size = new System.Drawing.Size(184, 29);
            this.txtAñadirCliente.TabIndex = 60;
            this.txtAñadirCliente.Text = "Añadir bodega";
            this.txtAñadirCliente.Click += new System.EventHandler(this.txtAñadirCliente_Click);
            // 
            // txtCantidadMin
            // 
            this.txtCantidadMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidadMin.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidadMin.Location = new System.Drawing.Point(75, 186);
            this.txtCantidadMin.Name = "txtCantidadMin";
            this.txtCantidadMin.Size = new System.Drawing.Size(243, 21);
            this.txtCantidadMin.TabIndex = 58;
            this.txtCantidadMin.Text = "Cantidad minima";
            this.txtCantidadMin.TextChanged += new System.EventHandler(this.txtCantidadMin_TextChanged);
            this.txtCantidadMin.Enter += new System.EventHandler(this.txtCantidadMin_Enter);
            this.txtCantidadMin.Leave += new System.EventHandler(this.txtCantidadMin_Leave);
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
            this.iconButton1.Location = new System.Drawing.Point(911, 479);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(145, 47);
            this.iconButton1.TabIndex = 89;
            this.iconButton1.Text = "Buscar 1";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.UseWaitCursor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtCantidadMax
            // 
            this.txtCantidadMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidadMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidadMax.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidadMax.Location = new System.Drawing.Point(75, 113);
            this.txtCantidadMax.Name = "txtCantidadMax";
            this.txtCantidadMax.Size = new System.Drawing.Size(243, 21);
            this.txtCantidadMax.TabIndex = 57;
            this.txtCantidadMax.Text = "Cantidad maxima";
            this.txtCantidadMax.TextChanged += new System.EventHandler(this.txtCantidadMax_TextChanged);
            this.txtCantidadMax.Enter += new System.EventHandler(this.txtCantidadMax_Enter);
            this.txtCantidadMax.Leave += new System.EventHandler(this.txtCantidadMax_Leave);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAgregarCliente.FlatAppearance.BorderSize = 5;
            this.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.Location = new System.Drawing.Point(105, 294);
            this.btnAgregarCliente.MaximumSize = new System.Drawing.Size(112, 100);
            this.btnAgregarCliente.MinimumSize = new System.Drawing.Size(172, 59);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(172, 59);
            this.btnAgregarCliente.TabIndex = 56;
            this.btnAgregarCliente.Text = "AGREGAR";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.UseWaitCursor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // tbpAdd
            // 
            this.tbpAdd.Controls.Add(this.tpAdd);
            this.tbpAdd.Controls.Add(this.tpEdit);
            this.tbpAdd.Controls.Add(this.tpVer);
            this.tbpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpAdd.Location = new System.Drawing.Point(0, 0);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.SelectedIndex = 0;
            this.tbpAdd.Size = new System.Drawing.Size(785, 555);
            this.tbpAdd.TabIndex = 1;
            this.tbpAdd.SelectedIndexChanged += new System.EventHandler(this.tbpAdd_SelectedIndexChanged);
            // 
            // tpEdit
            // 
            this.tpEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tpEdit.Controls.Add(this.textBox1);
            this.tpEdit.Controls.Add(this.dataGridView1);
            this.tpEdit.Controls.Add(this.btnGuardar);
            this.tpEdit.Location = new System.Drawing.Point(4, 26);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(777, 525);
            this.tpEdit.TabIndex = 2;
            this.tpEdit.Text = "Editar bodega";
            this.tpEdit.Click += new System.EventHandler(this.tpEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(169, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(356, 71);
            this.dataGridView1.TabIndex = 99;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Productos en bodega";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad maxima";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardar.FlatAppearance.BorderSize = 5;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(514, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 47);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.UseWaitCursor = true;
            // 
            // tpVer
            // 
            this.tpVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tpVer.Controls.Add(this.dgvDatosUsuarios);
            this.tpVer.Controls.Add(this.lupa);
            this.tpVer.Controls.Add(this.txtBuscar1);
            this.tpVer.Controls.Add(this.btnTodos);
            this.tpVer.Controls.Add(this.btnVerUno);
            this.tpVer.Controls.Add(this.txtIndex);
            this.tpVer.Location = new System.Drawing.Point(4, 26);
            this.tpVer.Name = "tpVer";
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Size = new System.Drawing.Size(777, 525);
            this.tpVer.TabIndex = 3;
            this.tpVer.Text = "Ver productos en bodega";
            this.tpVer.Click += new System.EventHandler(this.tpVer_Click);
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDatosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.nombreProduc,
            this.PrecioProduc,
            this.MarcaProducto,
            this.CantidadProducStock});
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(135, 205);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.RowTemplate.Height = 25;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(546, 293);
            this.dgvDatosUsuarios.TabIndex = 93;
            this.dgvDatosUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosUsuarios_CellContentClick);
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
            // CantidadProducStock
            // 
            this.CantidadProducStock.HeaderText = "Cantidad";
            this.CantidadProducStock.Name = "CantidadProducStock";
            this.CantidadProducStock.ReadOnly = true;
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
            this.lupa.Location = new System.Drawing.Point(331, 157);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 92;
            this.lupa.UseVisualStyleBackColor = false;
            this.lupa.Visible = false;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(135, 157);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 91;
            this.txtBuscar1.Text = "Ingresar nombre producto";
            this.txtBuscar1.Visible = false;
            this.txtBuscar1.TextChanged += new System.EventHandler(this.txtBuscar1_TextChanged);
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
            this.btnTodos.Location = new System.Drawing.Point(460, 82);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(166, 47);
            this.btnTodos.TabIndex = 96;
            this.btnTodos.Text = "Mostrar todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.UseWaitCursor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
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
            this.btnVerUno.Location = new System.Drawing.Point(168, 82);
            this.btnVerUno.Name = "btnVerUno";
            this.btnVerUno.Size = new System.Drawing.Size(145, 47);
            this.btnVerUno.TabIndex = 95;
            this.btnVerUno.Text = "Buscar 1";
            this.btnVerUno.UseVisualStyleBackColor = false;
            this.btnVerUno.UseWaitCursor = true;
            this.btnVerUno.Click += new System.EventHandler(this.btnVerUno_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIndex.AutoSize = true;
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIndex.ForeColor = System.Drawing.Color.Black;
            this.txtIndex.Location = new System.Drawing.Point(289, 26);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(238, 29);
            this.txtIndex.TabIndex = 94;
            this.txtIndex.Text = "Seleccione la opcion";
            this.txtIndex.Click += new System.EventHandler(this.txtIndex_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(35, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 21);
            this.textBox1.TabIndex = 102;
            this.textBox1.Text = "Ingresar nombre de bodega";
            // 
            // MenuBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.Controls.Add(this.tbpAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBodega";
            this.Text = "MenuBodega";
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tbpAdd.ResumeLayout(false);
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpVer.ResumeLayout(false);
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tpAdd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TabControl tbpAdd;
        private TabPage tpEdit;
        private TabPage tpVer;
        private Label txtAñadirCliente;
        private TextBox txtCantidadMin;
        private TextBox txtCantidadMax;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private DataGridView dgvDatosUsuarios;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn nombreProduc;
        private DataGridViewTextBoxColumn PrecioProduc;
        private DataGridViewTextBoxColumn MarcaProducto;
        private DataGridViewTextBoxColumn CantidadProducStock;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
        private FontAwesome.Sharp.IconButton btnTodos;
        private FontAwesome.Sharp.IconButton btnVerUno;
        private Label txtIndex;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox textBox1;
    }
}