namespace Proyecto_Primer_trimestre
{
    partial class AddCliente
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
            System.Windows.Forms.PictureBox imagenAñadirCliente;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCliente));
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.txtNombreAddCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoAddCliente = new System.Windows.Forms.TextBox();
            this.txtTelAddCli = new System.Windows.Forms.TextBox();
            this.txtAñadirCliente = new System.Windows.Forms.Label();
            imagenAñadirCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenAñadirCliente
            // 
            imagenAñadirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenAñadirCliente.BackgroundImage")));
            imagenAñadirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imagenAñadirCliente.Dock = System.Windows.Forms.DockStyle.Left;
            imagenAñadirCliente.Location = new System.Drawing.Point(0, 0);
            imagenAñadirCliente.Name = "imagenAñadirCliente";
            imagenAñadirCliente.Size = new System.Drawing.Size(401, 514);
            imagenAñadirCliente.TabIndex = 43;
            imagenAñadirCliente.TabStop = false;
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
            this.btnAgregarCliente.Location = new System.Drawing.Point(497, 380);
            this.btnAgregarCliente.MaximumSize = new System.Drawing.Size(112, 100);
            this.btnAgregarCliente.MinimumSize = new System.Drawing.Size(172, 59);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(172, 59);
            this.btnAgregarCliente.TabIndex = 46;
            this.btnAgregarCliente.Text = "AGREGAR";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.UseWaitCursor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtNombreAddCliente
            // 
            this.txtNombreAddCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreAddCliente.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreAddCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAddCliente.Location = new System.Drawing.Point(472, 154);
            this.txtNombreAddCliente.Name = "txtNombreAddCliente";
            this.txtNombreAddCliente.Size = new System.Drawing.Size(243, 21);
            this.txtNombreAddCliente.TabIndex = 47;
            this.txtNombreAddCliente.Text = "Nombre completo";
            this.txtNombreAddCliente.TextChanged += new System.EventHandler(this.txtNombreAddCliente_TextChanged);
            this.txtNombreAddCliente.Enter += new System.EventHandler(this.txtNombreAddCliente_Enter);
            this.txtNombreAddCliente.Leave += new System.EventHandler(this.txtNombreAddCliente_Leave);
            // 
            // txtCorreoAddCliente
            // 
            this.txtCorreoAddCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreoAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCorreoAddCliente.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreoAddCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoAddCliente.Location = new System.Drawing.Point(472, 227);
            this.txtCorreoAddCliente.Name = "txtCorreoAddCliente";
            this.txtCorreoAddCliente.Size = new System.Drawing.Size(243, 21);
            this.txtCorreoAddCliente.TabIndex = 53;
            this.txtCorreoAddCliente.Text = "Correo electronico";
            this.txtCorreoAddCliente.Enter += new System.EventHandler(this.txtCorreoAddCliente_Enter);
            this.txtCorreoAddCliente.Leave += new System.EventHandler(this.txtCorreoAddCliente_Leave);
            // 
            // txtTelAddCli
            // 
            this.txtTelAddCli.AcceptsTab = true;
            this.txtTelAddCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelAddCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelAddCli.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelAddCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelAddCli.Location = new System.Drawing.Point(472, 299);
            this.txtTelAddCli.MaximumSize = new System.Drawing.Size(900, 40);
            this.txtTelAddCli.MinimumSize = new System.Drawing.Size(243, 21);
            this.txtTelAddCli.Name = "txtTelAddCli";
            this.txtTelAddCli.Size = new System.Drawing.Size(243, 21);
            this.txtTelAddCli.TabIndex = 54;
            this.txtTelAddCli.Text = "Numero de telefono";
            this.txtTelAddCli.Enter += new System.EventHandler(this.txtTelefonoAddCliente_Enter);
            this.txtTelAddCli.Leave += new System.EventHandler(this.txtTelefonoAddCliente_Leave);
            // 
            // txtAñadirCliente
            // 
            this.txtAñadirCliente.AutoSize = true;
            this.txtAñadirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAñadirCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.txtAñadirCliente.Location = new System.Drawing.Point(432, 80);
            this.txtAñadirCliente.Name = "txtAñadirCliente";
            this.txtAñadirCliente.Size = new System.Drawing.Size(173, 29);
            this.txtAñadirCliente.TabIndex = 55;
            this.txtAñadirCliente.Text = "Añadir cliente";
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.txtAñadirCliente);
            this.Controls.Add(this.txtTelAddCli);
            this.Controls.Add(this.txtCorreoAddCliente);
            this.Controls.Add(this.txtNombreAddCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(imagenAñadirCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCliente";
            this.Opacity = 0.5D;
            this.Text = "AddCliente";
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private TextBox txtNombreAddCliente;
        private TextBox txtCorreoAddCliente;
        private TextBox txtTelAddCli;
        private Label txtAñadirCliente;
    }
}