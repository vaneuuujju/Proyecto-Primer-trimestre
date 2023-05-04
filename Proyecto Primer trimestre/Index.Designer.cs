namespace Proyecto_Primer_trimestre
{
    partial class Index
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
            System.Windows.Forms.PictureBox imagenIndex;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.txtIndex = new System.Windows.Forms.Label();
            this.logoIndex = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            imagenIndex = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imagenIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenIndex
            // 
            imagenIndex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenIndex.BackgroundImage")));
            imagenIndex.Location = new System.Drawing.Point(-7, 0);
            imagenIndex.Name = "imagenIndex";
            imagenIndex.Size = new System.Drawing.Size(455, 601);
            imagenIndex.TabIndex = 16;
            imagenIndex.TabStop = false;
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
            this.btnSalir.Location = new System.Drawing.Point(727, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 39);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtIndex
            // 
            this.txtIndex.AutoSize = true;
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIndex.ForeColor = System.Drawing.Color.Black;
            this.txtIndex.Location = new System.Drawing.Point(522, 326);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(179, 58);
            this.txtIndex.TabIndex = 19;
            this.txtIndex.Text = " Bienvenido al\r\nJardin de Marta";
            // 
            // logoIndex
            // 
            this.logoIndex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoIndex.BackgroundImage")));
            this.logoIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoIndex.Location = new System.Drawing.Point(497, 81);
            this.logoIndex.Name = "logoIndex";
            this.logoIndex.Size = new System.Drawing.Size(234, 219);
            this.logoIndex.TabIndex = 18;
            this.logoIndex.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(174)))), ((int)(((byte)(137)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 5;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.Location = new System.Drawing.Point(532, 426);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 59);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.UseWaitCursor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 558);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.logoIndex);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(imagenIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(imagenIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private Label txtIndex;
        private PictureBox logoIndex;
        private FontAwesome.Sharp.IconButton btnSiguiente;
    }
}