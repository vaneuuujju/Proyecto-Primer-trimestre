namespace Proyecto_Primer_trimestre
{
    partial class AddProducto
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
            System.Windows.Forms.PictureBox imagenAñadirProducto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducto));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioAñadirProducto = new System.Windows.Forms.TextBox();
            this.txtAñadirProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtNombreAñadirProducto = new System.Windows.Forms.TextBox();
            imagenAñadirProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenAñadirProducto
            // 
            imagenAñadirProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenAñadirProducto.BackgroundImage")));
            imagenAñadirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imagenAñadirProducto.Dock = System.Windows.Forms.DockStyle.Left;
            imagenAñadirProducto.Location = new System.Drawing.Point(0, 0);
            imagenAñadirProducto.Name = "imagenAñadirProducto";
            imagenAñadirProducto.Size = new System.Drawing.Size(401, 501);
            imagenAñadirProducto.TabIndex = 71;
            imagenAñadirProducto.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.BackColor = System.Drawing.Color.Silver;
            this.txtMarca.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.Location = new System.Drawing.Point(454, 310);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(243, 21);
            this.txtMarca.TabIndex = 72;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtPrecioAñadirProducto
            // 
            this.txtPrecioAñadirProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecioAñadirProducto.BackColor = System.Drawing.Color.Silver;
            this.txtPrecioAñadirProducto.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioAñadirProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioAñadirProducto.Location = new System.Drawing.Point(454, 240);
            this.txtPrecioAñadirProducto.Name = "txtPrecioAñadirProducto";
            this.txtPrecioAñadirProducto.Size = new System.Drawing.Size(243, 21);
            this.txtPrecioAñadirProducto.TabIndex = 70;
            this.txtPrecioAñadirProducto.Text = "Precio";
            this.txtPrecioAñadirProducto.Enter += new System.EventHandler(this.txtPrecioAñadirProducto_Enter);
            this.txtPrecioAñadirProducto.Leave += new System.EventHandler(this.txtPrecioAñadirProducto_Leave);
            // 
            // txtAñadirProducto
            // 
            this.txtAñadirProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAñadirProducto.AutoSize = true;
            this.txtAñadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAñadirProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.txtAñadirProducto.Location = new System.Drawing.Point(427, 76);
            this.txtAñadirProducto.Name = "txtAñadirProducto";
            this.txtAñadirProducto.Size = new System.Drawing.Size(220, 31);
            this.txtAñadirProducto.TabIndex = 69;
            this.txtAñadirProducto.Text = "Añadir producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnAgregar.Location = new System.Drawing.Point(479, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 59);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.UseWaitCursor = true;
            // 
            // txtNombreAñadirProducto
            // 
            this.txtNombreAñadirProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreAñadirProducto.BackColor = System.Drawing.Color.Silver;
            this.txtNombreAñadirProducto.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreAñadirProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreAñadirProducto.Location = new System.Drawing.Point(454, 172);
            this.txtNombreAñadirProducto.Name = "txtNombreAñadirProducto";
            this.txtNombreAñadirProducto.Size = new System.Drawing.Size(243, 21);
            this.txtNombreAñadirProducto.TabIndex = 65;
            this.txtNombreAñadirProducto.Text = "Nombre producto";
            this.txtNombreAñadirProducto.Enter += new System.EventHandler(this.txtNombreAñadirProducto_Enter);
            this.txtNombreAñadirProducto.Leave += new System.EventHandler(this.txtNombreAñadirProducto_Leave);
            // 
            // AddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(772, 501);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(imagenAñadirProducto);
            this.Controls.Add(this.txtPrecioAñadirProducto);
            this.Controls.Add(this.txtAñadirProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreAñadirProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProducto";
            this.Text = "AddProducto";
            ((System.ComponentModel.ISupportInitialize)(imagenAñadirProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtPrecioAñadirProducto;
        private Label txtAñadirProducto;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TextBox txtNombreAñadirProducto;
    }
}