namespace Proyecto_Primer_trimestre
{
    partial class MenuReportes
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
            this.tbpAdd = new System.Windows.Forms.TabControl();
            this.tpGenerar = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.lupa = new FontAwesome.Sharp.IconButton();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.DtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.tbpAdd.SuspendLayout();
            this.tpGenerar.SuspendLayout();
            this.tpVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpAdd
            // 
            this.tbpAdd.Controls.Add(this.tpGenerar);
            this.tbpAdd.Controls.Add(this.tpVer);
            this.tbpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpAdd.Location = new System.Drawing.Point(0, 0);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.SelectedIndex = 0;
            this.tbpAdd.Size = new System.Drawing.Size(785, 555);
            this.tbpAdd.TabIndex = 2;
            // 
            // tpGenerar
            // 
            this.tpGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tpGenerar.Controls.Add(this.DtpFechaVenta);
            this.tpGenerar.Controls.Add(this.iconButton1);
            this.tpGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tpGenerar.Location = new System.Drawing.Point(4, 26);
            this.tpGenerar.Name = "tpGenerar";
            this.tpGenerar.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerar.Size = new System.Drawing.Size(777, 525);
            this.tpGenerar.TabIndex = 1;
            this.tpGenerar.Text = "Generar reporte";
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
            this.iconButton1.Location = new System.Drawing.Point(1199, 691);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(145, 47);
            this.iconButton1.TabIndex = 89;
            this.iconButton1.Text = "Buscar 1";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.UseWaitCursor = true;
            // 
            // tpVer
            // 
            this.tpVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.tpVer.Controls.Add(this.lupa);
            this.tpVer.Controls.Add(this.txtBuscar1);
            this.tpVer.Location = new System.Drawing.Point(4, 26);
            this.tpVer.Name = "tpVer";
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Size = new System.Drawing.Size(777, 525);
            this.tpVer.TabIndex = 3;
            this.tpVer.Text = "Buscar reportes";
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
            this.lupa.Location = new System.Drawing.Point(230, 40);
            this.lupa.Margin = new System.Windows.Forms.Padding(0);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(39, 23);
            this.lupa.TabIndex = 94;
            this.lupa.UseVisualStyleBackColor = false;
            this.lupa.Visible = false;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar1.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar1.Location = new System.Drawing.Point(34, 40);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(193, 23);
            this.txtBuscar1.TabIndex = 93;
            this.txtBuscar1.Text = "Ingresar nombre producto";
            this.txtBuscar1.Visible = false;
            // 
            // DtpFechaVenta
            // 
            this.DtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVenta.Location = new System.Drawing.Point(22, 37);
            this.DtpFechaVenta.Name = "DtpFechaVenta";
            this.DtpFechaVenta.Size = new System.Drawing.Size(178, 23);
            this.DtpFechaVenta.TabIndex = 90;
            this.DtpFechaVenta.TabStop = false;
            this.DtpFechaVenta.Value = new System.DateTime(2023, 4, 18, 0, 0, 0, 0);
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.Controls.Add(this.tbpAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuReportes";
            this.Text = "MenuReportes";
            this.tbpAdd.ResumeLayout(false);
            this.tpGenerar.ResumeLayout(false);
            this.tpVer.ResumeLayout(false);
            this.tpVer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpAdd;
        private TabPage tpGenerar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TabPage tpVer;
        private FontAwesome.Sharp.IconButton lupa;
        private TextBox txtBuscar1;
        private DateTimePicker DtpFechaVenta;
    }
}