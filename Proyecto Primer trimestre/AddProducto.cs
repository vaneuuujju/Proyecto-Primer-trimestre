using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Primer_trimestre
{
    public partial class AddProducto : Form
    {
        public AddProducto()
        {
            InitializeComponent();
        }

        #region Eventos de los text box
        string txtTempo; //para los eventos leave y enter de los textBox
        private void txtNombreAñadirProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreAñadirProducto.Text == "")//verifica si el text box esta vacio
            {
                txtNombreAñadirProducto.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtNombreAñadirProducto_Enter(object sender, EventArgs e)
        {
            txtTempo = txtNombreAñadirProducto.Text;
            txtNombreAñadirProducto.Text = "";
        }

        private void txtPrecioAñadirProducto_Leave(object sender, EventArgs e)
        {
            if (txtPrecioAñadirProducto.Text == "")//verifica si el text box esta vacio
            {
                txtPrecioAñadirProducto.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtPrecioAñadirProducto_Enter(object sender, EventArgs e)
        {
            txtTempo = txtPrecioAñadirProducto.Text;
            txtPrecioAñadirProducto.Text = "";
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")//verifica si el text box esta vacio
            {
                txtMarca.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            txtTempo = txtMarca.Text;
            txtMarca.Text = "";
        }
        #endregion
    }
}
