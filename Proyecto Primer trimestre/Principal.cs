using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Primer_trimestre
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        #region Menu principal
        #region  //Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlCLientes.Visible = (pnlCLientes.Visible) ? false : true;
            
        }
        private void pnlCLientesAdd_Click(object sender, EventArgs e)
        {
            pnlCLientes.Visible = false;
            //para abrir el form de añadir cliente
            openChildForm(new AddCliente());
        }
        private void pnlCLientesEdit_Click(object sender, EventArgs e)
        {
            pnlCLientes.Visible = false;

            openChildForm(new EditarCliente());
        }

        private void pnlCLientesBuscar1_Click(object sender, EventArgs e)
        {
            pnlCLientes.Visible = false;
            openChildForm(new Ver_cliente());
        }


        #endregion

        #region //Factura
        private void btnFactura_Click(object sender, EventArgs e)
        {
            pnlFactura.Visible = (pnlFactura.Visible) ? false : true;
        }
        private void pnlFacturaAdd_Click(object sender, EventArgs e)
        {
            pnlFactura.Visible = false;
            openChildForm(new Factura());
        }

        private void pnlFacturaVer_Click(object sender, EventArgs e)
        {
            pnlFactura.Visible = false;
        }

        private void pnlFacturaMostrar_Click(object sender, EventArgs e)
        {
            pnlFactura.Visible = false;
        }

        private void pnlFacturaDescuentos_Click(object sender, EventArgs e)
        {
            pnlFactura.Visible = false;
        }
        #endregion

        #region  //Informacion
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = (pnlInfo.Visible) ? false : true;
        }
        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }

        private void pnlInfoUsuarios_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            //desplega el sub menu de las opciones para los usuarios
            openChildForm(new MenuUsuarios());

        }

        private void pnlInfoReportes_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            openChildForm(new FormReportes());
        }

        private void pnlInfoBodega_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            openChildForm(new Bodega());
        }
        #endregion

        #region //Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = (pnlProductos.Visible) ? false : true;
        }

        private void pnlProductosAdd_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            //para abrir el form de añadir productos
            openChildForm(new AddProducto()); 

        }

        private void pnlProductosEdit_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            openChildForm(new EditProduc());

        }

        private void pnlProductosDescuento_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            openChildForm(new DescuentoProducto());
        }

        private void pnlProductosMostrar_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;

            openChildForm(new Ver_Productos());
        }
        #endregion

        #endregion

        #region   //Botones manejo de form
        //mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControles_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Enabled = false;
            btnMaximizar.Visible = false;
            btnNormal.Enabled = true;
            btnNormal.Visible = true;
        }
        //hace que el form vuelva a su tamaño normal
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Enabled = true;
            btnMaximizar.Visible = true;
            btnNormal.Enabled = false;
            btnNormal.Visible = false;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Sobre el child form

        private void pnlProductos_Paint(object sender, PaintEventArgs e)
        {

        }
        //oculta el menu principal o lo vuelve a mostrar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = (pnlMenu.Visible) ? false : true;
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false; //hace que se le quite el comportamiento como panel
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private Form activeForm = null;

        private void pnlFormHijo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //indica las horas, minutos y segundos
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt"); //tt es am o pm
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion


        private void pnlFormHijo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
