namespace Proyecto_Primer_trimestre
{
    partial class Login
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
            System.Windows.Forms.PictureBox imagenLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnMostrar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnOcultarLogin = new FontAwesome.Sharp.IconButton();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            imagenLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imagenLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenLogin
            // 
            imagenLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogin.BackgroundImage")));
            imagenLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imagenLogin.Location = new System.Drawing.Point(-2, -3);
            imagenLogin.Name = "imagenLogin";
            imagenLogin.Size = new System.Drawing.Size(401, 611);
            imagenLogin.TabIndex = 76;
            imagenLogin.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Silver;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrar.IconColor = System.Drawing.Color.Black;
            this.btnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrar.IconSize = 25;
            this.btnMostrar.Location = new System.Drawing.Point(653, 382);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(29, 23);
            this.btnMostrar.TabIndex = 84;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.btnMaximizar.IconColor = System.Drawing.Color.Black;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 30;
            this.btnMaximizar.Location = new System.Drawing.Point(642, -3);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(46, 39);
            this.btnMaximizar.TabIndex = 83;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Location = new System.Drawing.Point(636, -3);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(52, 39);
            this.btnNormal.TabIndex = 82;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.ArrowsToCircle;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(587, -3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 39);
            this.btnMinimizar.TabIndex = 81;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnOcultarLogin
            // 
            this.btnOcultarLogin.BackColor = System.Drawing.Color.Silver;
            this.btnOcultarLogin.FlatAppearance.BorderSize = 0;
            this.btnOcultarLogin.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnOcultarLogin.IconColor = System.Drawing.Color.Black;
            this.btnOcultarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcultarLogin.IconSize = 25;
            this.btnOcultarLogin.Location = new System.Drawing.Point(653, 382);
            this.btnOcultarLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnOcultarLogin.Name = "btnOcultarLogin";
            this.btnOcultarLogin.Size = new System.Drawing.Size(29, 23);
            this.btnOcultarLogin.TabIndex = 80;
            this.btnOcultarLogin.UseVisualStyleBackColor = false;
            this.btnOcultarLogin.Click += new System.EventHandler(this.btnOcultarLogin_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnIngresar.FlatAppearance.BorderSize = 5;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.Location = new System.Drawing.Point(484, 443);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(172, 59);
            this.btnIngresar.TabIndex = 79;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtUsuario.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(445, 344);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 21);
            this.txtUsuario.TabIndex = 78;
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave_1);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Silver;
            this.txtContrasena.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasena.Location = new System.Drawing.Point(445, 381);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(211, 21);
            this.txtContrasena.TabIndex = 77;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(445, 90);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 212);
            this.logo.TabIndex = 75;
            this.logo.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnRegresar.IconColor = System.Drawing.Color.Black;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 30;
            this.btnRegresar.Location = new System.Drawing.Point(541, -3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 39);
            this.btnRegresar.TabIndex = 74;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(689, -3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 39);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 565);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnOcultarLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(imagenLogin);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(imagenLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnMostrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private PictureBox btnNormal;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnOcultarLogin;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private PictureBox logo;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}