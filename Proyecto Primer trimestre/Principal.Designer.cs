namespace Proyecto_Primer_trimestre
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.logoA = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlFacturaDescuentos = new System.Windows.Forms.Button();
            this.pnlFacturaMostrar = new System.Windows.Forms.Button();
            this.pnlFacturaVer = new System.Windows.Forms.Button();
            this.pnlFacturaAdd = new System.Windows.Forms.Button();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.pnlCLientes = new System.Windows.Forms.Panel();
            this.pnlCLientesDatos = new System.Windows.Forms.Button();
            this.pnlCLientesEdit = new System.Windows.Forms.Button();
            this.pnlCLientesAdd = new System.Windows.Forms.Button();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlInfoBodega = new System.Windows.Forms.Button();
            this.pnlInfoReportes = new System.Windows.Forms.Button();
            this.pnlInfoUsuarios = new System.Windows.Forms.Button();
            this.btnInformacion = new FontAwesome.Sharp.IconButton();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.pnlProductosMostrar = new System.Windows.Forms.Button();
            this.pnlProductosDescuento = new System.Windows.Forms.Button();
            this.pnlProductosEdit = new System.Windows.Forms.Button();
            this.pnlProductosAdd = new System.Windows.Forms.Button();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoA)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlCLientes.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlFormHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlControles.Controls.Add(this.btnMenu);
            this.pnlControles.Controls.Add(this.btnMaximizar);
            this.pnlControles.Controls.Add(this.btnNormal);
            this.pnlControles.Controls.Add(this.logoA);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnVolver);
            this.pnlControles.Controls.Add(this.btnSalir);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(956, 82);
            this.pnlControles.TabIndex = 27;
            this.pnlControles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControles_MouseDown_1);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 35;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenu.Location = new System.Drawing.Point(-12, 53);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(59, 41);
            this.btnMenu.TabIndex = 32;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximizar.IconColor = System.Drawing.Color.Black;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 30;
            this.btnMaximizar.Location = new System.Drawing.Point(853, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(46, 39);
            this.btnMaximizar.TabIndex = 84;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Location = new System.Drawing.Point(853, 9);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(52, 39);
            this.btnNormal.TabIndex = 83;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // logoA
            // 
            this.logoA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoA.BackgroundImage")));
            this.logoA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoA.Location = new System.Drawing.Point(12, -23);
            this.logoA.Name = "logoA";
            this.logoA.Size = new System.Drawing.Size(185, 130);
            this.logoA.TabIndex = 6;
            this.logoA.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.ArrowsToCircle;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(804, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 39);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnVolver.IconColor = System.Drawing.Color.Black;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.Location = new System.Drawing.Point(758, 9);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(46, 39);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(899, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 39);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 52);
            this.panel2.TabIndex = 15;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenu.Controls.Add(this.pnlFactura);
            this.pnlMenu.Controls.Add(this.btnFactura);
            this.pnlMenu.Controls.Add(this.pnlCLientes);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.pnlInfo);
            this.pnlMenu.Controls.Add(this.btnInformacion);
            this.pnlMenu.Controls.Add(this.pnlProductos);
            this.pnlMenu.Controls.Add(this.btnProductos);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 82);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(171, 555);
            this.pnlMenu.TabIndex = 28;
            this.pnlMenu.Visible = false;
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.pnlFactura.Controls.Add(this.pnlFacturaDescuentos);
            this.pnlFactura.Controls.Add(this.pnlFacturaMostrar);
            this.pnlFactura.Controls.Add(this.pnlFacturaVer);
            this.pnlFactura.Controls.Add(this.pnlFacturaAdd);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFactura.Location = new System.Drawing.Point(0, 498);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(154, 129);
            this.pnlFactura.TabIndex = 31;
            this.pnlFactura.Visible = false;
            // 
            // pnlFacturaDescuentos
            // 
            this.pnlFacturaDescuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacturaDescuentos.FlatAppearance.BorderSize = 0;
            this.pnlFacturaDescuentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlFacturaDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFacturaDescuentos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFacturaDescuentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFacturaDescuentos.Location = new System.Drawing.Point(0, 93);
            this.pnlFacturaDescuentos.Name = "pnlFacturaDescuentos";
            this.pnlFacturaDescuentos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlFacturaDescuentos.Size = new System.Drawing.Size(154, 28);
            this.pnlFacturaDescuentos.TabIndex = 3;
            this.pnlFacturaDescuentos.Text = "Descuentos";
            this.pnlFacturaDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlFacturaDescuentos.UseVisualStyleBackColor = true;
            this.pnlFacturaDescuentos.Click += new System.EventHandler(this.pnlFacturaDescuentos_Click);
            // 
            // pnlFacturaMostrar
            // 
            this.pnlFacturaMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacturaMostrar.FlatAppearance.BorderSize = 0;
            this.pnlFacturaMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlFacturaMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFacturaMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFacturaMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFacturaMostrar.Location = new System.Drawing.Point(0, 66);
            this.pnlFacturaMostrar.Name = "pnlFacturaMostrar";
            this.pnlFacturaMostrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlFacturaMostrar.Size = new System.Drawing.Size(154, 27);
            this.pnlFacturaMostrar.TabIndex = 2;
            this.pnlFacturaMostrar.Text = "Ver facturas";
            this.pnlFacturaMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlFacturaMostrar.UseVisualStyleBackColor = true;
            this.pnlFacturaMostrar.Click += new System.EventHandler(this.pnlFacturaMostrar_Click);
            // 
            // pnlFacturaVer
            // 
            this.pnlFacturaVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacturaVer.FlatAppearance.BorderSize = 0;
            this.pnlFacturaVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlFacturaVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFacturaVer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFacturaVer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFacturaVer.Location = new System.Drawing.Point(0, 34);
            this.pnlFacturaVer.Name = "pnlFacturaVer";
            this.pnlFacturaVer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlFacturaVer.Size = new System.Drawing.Size(154, 32);
            this.pnlFacturaVer.TabIndex = 1;
            this.pnlFacturaVer.Text = "Buscar factura";
            this.pnlFacturaVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlFacturaVer.UseVisualStyleBackColor = true;
            this.pnlFacturaVer.Click += new System.EventHandler(this.pnlFacturaVer_Click);
            // 
            // pnlFacturaAdd
            // 
            this.pnlFacturaAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacturaAdd.FlatAppearance.BorderSize = 0;
            this.pnlFacturaAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlFacturaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFacturaAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFacturaAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFacturaAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlFacturaAdd.Name = "pnlFacturaAdd";
            this.pnlFacturaAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlFacturaAdd.Size = new System.Drawing.Size(154, 34);
            this.pnlFacturaAdd.TabIndex = 0;
            this.pnlFacturaAdd.Text = "Añadir factura";
            this.pnlFacturaAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlFacturaAdd.UseVisualStyleBackColor = true;
            this.pnlFacturaAdd.Click += new System.EventHandler(this.pnlFacturaAdd_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnFactura.IconColor = System.Drawing.Color.Black;
            this.btnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFactura.IconSize = 35;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 458);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFactura.Size = new System.Drawing.Size(154, 40);
            this.btnFactura.TabIndex = 30;
            this.btnFactura.Text = "FACTURAS";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // pnlCLientes
            // 
            this.pnlCLientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.pnlCLientes.Controls.Add(this.pnlCLientesDatos);
            this.pnlCLientes.Controls.Add(this.pnlCLientesEdit);
            this.pnlCLientes.Controls.Add(this.pnlCLientesAdd);
            this.pnlCLientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCLientes.Location = new System.Drawing.Point(0, 367);
            this.pnlCLientes.Name = "pnlCLientes";
            this.pnlCLientes.Size = new System.Drawing.Size(154, 91);
            this.pnlCLientes.TabIndex = 20;
            this.pnlCLientes.Visible = false;
            // 
            // pnlCLientesDatos
            // 
            this.pnlCLientesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCLientesDatos.FlatAppearance.BorderSize = 0;
            this.pnlCLientesDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlCLientesDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlCLientesDatos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlCLientesDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCLientesDatos.Location = new System.Drawing.Point(0, 55);
            this.pnlCLientesDatos.Name = "pnlCLientesDatos";
            this.pnlCLientesDatos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlCLientesDatos.Size = new System.Drawing.Size(154, 28);
            this.pnlCLientesDatos.TabIndex = 2;
            this.pnlCLientesDatos.Text = "Buscar clientes";
            this.pnlCLientesDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCLientesDatos.UseVisualStyleBackColor = true;
            this.pnlCLientesDatos.Click += new System.EventHandler(this.pnlCLientesBuscar1_Click);
            // 
            // pnlCLientesEdit
            // 
            this.pnlCLientesEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCLientesEdit.FlatAppearance.BorderSize = 0;
            this.pnlCLientesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlCLientesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlCLientesEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlCLientesEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCLientesEdit.Location = new System.Drawing.Point(0, 27);
            this.pnlCLientesEdit.Name = "pnlCLientesEdit";
            this.pnlCLientesEdit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlCLientesEdit.Size = new System.Drawing.Size(154, 28);
            this.pnlCLientesEdit.TabIndex = 1;
            this.pnlCLientesEdit.Text = "Editar cliente";
            this.pnlCLientesEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCLientesEdit.UseVisualStyleBackColor = true;
            this.pnlCLientesEdit.Click += new System.EventHandler(this.pnlCLientesEdit_Click);
            // 
            // pnlCLientesAdd
            // 
            this.pnlCLientesAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCLientesAdd.FlatAppearance.BorderSize = 0;
            this.pnlCLientesAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlCLientesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlCLientesAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlCLientesAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCLientesAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlCLientesAdd.Name = "pnlCLientesAdd";
            this.pnlCLientesAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlCLientesAdd.Size = new System.Drawing.Size(154, 27);
            this.pnlCLientesAdd.TabIndex = 0;
            this.pnlCLientesAdd.Text = "Añadir cliente";
            this.pnlCLientesAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCLientesAdd.UseVisualStyleBackColor = true;
            this.pnlCLientesAdd.Click += new System.EventHandler(this.pnlCLientesAdd_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 327);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(154, 40);
            this.btnClientes.TabIndex = 23;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.pnlInfo.Controls.Add(this.pnlInfoBodega);
            this.pnlInfo.Controls.Add(this.pnlInfoReportes);
            this.pnlInfo.Controls.Add(this.pnlInfoUsuarios);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 218);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(154, 109);
            this.pnlInfo.TabIndex = 21;
            this.pnlInfo.Visible = false;
            // 
            // pnlInfoBodega
            // 
            this.pnlInfoBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoBodega.FlatAppearance.BorderSize = 0;
            this.pnlInfoBodega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlInfoBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlInfoBodega.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlInfoBodega.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInfoBodega.Location = new System.Drawing.Point(0, 68);
            this.pnlInfoBodega.Name = "pnlInfoBodega";
            this.pnlInfoBodega.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlInfoBodega.Size = new System.Drawing.Size(154, 34);
            this.pnlInfoBodega.TabIndex = 2;
            this.pnlInfoBodega.Text = "Bodega";
            this.pnlInfoBodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlInfoBodega.UseVisualStyleBackColor = true;
            this.pnlInfoBodega.Click += new System.EventHandler(this.pnlInfoBodega_Click);
            // 
            // pnlInfoReportes
            // 
            this.pnlInfoReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoReportes.FlatAppearance.BorderSize = 0;
            this.pnlInfoReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlInfoReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlInfoReportes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlInfoReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInfoReportes.Location = new System.Drawing.Point(0, 34);
            this.pnlInfoReportes.Name = "pnlInfoReportes";
            this.pnlInfoReportes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlInfoReportes.Size = new System.Drawing.Size(154, 34);
            this.pnlInfoReportes.TabIndex = 1;
            this.pnlInfoReportes.Text = "Reportes";
            this.pnlInfoReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlInfoReportes.UseVisualStyleBackColor = true;
            this.pnlInfoReportes.Click += new System.EventHandler(this.pnlInfoReportes_Click);
            // 
            // pnlInfoUsuarios
            // 
            this.pnlInfoUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoUsuarios.FlatAppearance.BorderSize = 0;
            this.pnlInfoUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlInfoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlInfoUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlInfoUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInfoUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoUsuarios.Name = "pnlInfoUsuarios";
            this.pnlInfoUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlInfoUsuarios.Size = new System.Drawing.Size(154, 34);
            this.pnlInfoUsuarios.TabIndex = 0;
            this.pnlInfoUsuarios.Text = "Usuarios";
            this.pnlInfoUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlInfoUsuarios.UseVisualStyleBackColor = true;
            this.pnlInfoUsuarios.Click += new System.EventHandler(this.pnlInfoUsuarios_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformacion.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.btnInformacion.IconColor = System.Drawing.Color.Black;
            this.btnInformacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformacion.IconSize = 35;
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInformacion.Location = new System.Drawing.Point(0, 178);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInformacion.Size = new System.Drawing.Size(154, 40);
            this.btnInformacion.TabIndex = 21;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.pnlProductos.Controls.Add(this.pnlProductosMostrar);
            this.pnlProductos.Controls.Add(this.pnlProductosDescuento);
            this.pnlProductos.Controls.Add(this.pnlProductosEdit);
            this.pnlProductos.Controls.Add(this.pnlProductosAdd);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductos.Location = new System.Drawing.Point(0, 44);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(154, 134);
            this.pnlProductos.TabIndex = 20;
            this.pnlProductos.Visible = false;
            this.pnlProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProductos_Paint);
            // 
            // pnlProductosMostrar
            // 
            this.pnlProductosMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductosMostrar.FlatAppearance.BorderSize = 0;
            this.pnlProductosMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlProductosMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlProductosMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlProductosMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlProductosMostrar.Location = new System.Drawing.Point(0, 104);
            this.pnlProductosMostrar.Name = "pnlProductosMostrar";
            this.pnlProductosMostrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlProductosMostrar.Size = new System.Drawing.Size(154, 28);
            this.pnlProductosMostrar.TabIndex = 4;
            this.pnlProductosMostrar.Text = "Datos";
            this.pnlProductosMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlProductosMostrar.UseVisualStyleBackColor = true;
            this.pnlProductosMostrar.Click += new System.EventHandler(this.pnlProductosMostrar_Click);
            // 
            // pnlProductosDescuento
            // 
            this.pnlProductosDescuento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductosDescuento.FlatAppearance.BorderSize = 0;
            this.pnlProductosDescuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlProductosDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlProductosDescuento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlProductosDescuento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlProductosDescuento.Location = new System.Drawing.Point(0, 74);
            this.pnlProductosDescuento.Name = "pnlProductosDescuento";
            this.pnlProductosDescuento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlProductosDescuento.Size = new System.Drawing.Size(154, 30);
            this.pnlProductosDescuento.TabIndex = 2;
            this.pnlProductosDescuento.Text = "Descuentos";
            this.pnlProductosDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlProductosDescuento.UseVisualStyleBackColor = true;
            this.pnlProductosDescuento.Click += new System.EventHandler(this.pnlProductosDescuento_Click);
            // 
            // pnlProductosEdit
            // 
            this.pnlProductosEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductosEdit.FlatAppearance.BorderSize = 0;
            this.pnlProductosEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlProductosEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlProductosEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlProductosEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlProductosEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlProductosEdit.Name = "pnlProductosEdit";
            this.pnlProductosEdit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlProductosEdit.Size = new System.Drawing.Size(154, 34);
            this.pnlProductosEdit.TabIndex = 1;
            this.pnlProductosEdit.Text = "Editar producto";
            this.pnlProductosEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlProductosEdit.UseVisualStyleBackColor = true;
            this.pnlProductosEdit.Click += new System.EventHandler(this.pnlProductosEdit_Click);
            // 
            // pnlProductosAdd
            // 
            this.pnlProductosAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductosAdd.FlatAppearance.BorderSize = 0;
            this.pnlProductosAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.pnlProductosAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlProductosAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlProductosAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlProductosAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlProductosAdd.Name = "pnlProductosAdd";
            this.pnlProductosAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pnlProductosAdd.Size = new System.Drawing.Size(154, 40);
            this.pnlProductosAdd.TabIndex = 0;
            this.pnlProductosAdd.Text = "Añadir producto";
            this.pnlProductosAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlProductosAdd.UseVisualStyleBackColor = true;
            this.pnlProductosAdd.Click += new System.EventHandler(this.pnlProductosAdd_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Sprout;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 35;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(154, 44);
            this.btnProductos.TabIndex = 20;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pnlFormHijo
            // 
            this.pnlFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlFormHijo.Controls.Add(this.lblFecha);
            this.pnlFormHijo.Controls.Add(this.lblHora);
            this.pnlFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormHijo.Location = new System.Drawing.Point(171, 82);
            this.pnlFormHijo.Name = "pnlFormHijo";
            this.pnlFormHijo.Size = new System.Drawing.Size(785, 555);
            this.pnlFormHijo.TabIndex = 29;
            this.pnlFormHijo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormHijo_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblFecha.Location = new System.Drawing.Point(380, 217);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 28);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FECHA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblHora.Location = new System.Drawing.Point(365, 134);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(123, 44);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 637);
            this.Controls.Add(this.pnlFormHijo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrincipalAdmin_Load);
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoA)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.pnlCLientes.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlFormHijo.ResumeLayout(false);
            this.pnlFormHijo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControles;
        private PictureBox logoA;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel panel2;
        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnClientes;
        private Panel pnlInfo;
        private Button pnlInfoReportes;
        private Button pnlInfoUsuarios;
        private FontAwesome.Sharp.IconButton btnInformacion;
        private Panel pnlProductos;
        private Button pnlProductosDescuento;
        private Button pnlProductosEdit;
        private Button pnlProductosAdd;
        private FontAwesome.Sharp.IconButton btnProductos;
        private Button pnlInfoBodega;
        private Button pnlProductosMostrar;
        private PictureBox btnNormal;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private Panel pnlFactura;
        private Button pnlFacturaDescuentos;
        private Button pnlFacturaMostrar;
        private Button pnlFacturaVer;
        private Button pnlFacturaAdd;
        private FontAwesome.Sharp.IconButton btnFactura;
        private Panel pnlCLientes;
        private Button pnlCLientesDatos;
        private Button pnlCLientesEdit;
        private Button pnlCLientesAdd;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel pnlFormHijo;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}