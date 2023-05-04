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
    public partial class EditProduc : Form
    {
        public EditProduc()
        {
            InitializeComponent();
        }

        #region Eventos de los text box
        string txtTempo; //para los eventos leave y enter de los textBox
        private void txtPrecioEP_Leave(object sender, EventArgs e)
        {
            if (txtPrecioEP.Text == "")//verifica si el text box esta vacio
            {
                txtPrecioEP.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtPrecioEP_Enter(object sender, EventArgs e)
        {
            txtTempo = txtPrecioEP.Text;
            txtPrecioEP.Text = "";
        }

        private void txtNombreEP_Leave(object sender, EventArgs e)
        {
            if (txtNombreEP.Text == "")//verifica si el text box esta vacio
            {
                txtNombreEP.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtNombreEP_Enter(object sender, EventArgs e)
        {
            txtTempo = txtNombreEP.Text;
            txtNombreEP.Text = "";
        }
        #endregion

        private void btnMarca_Enter(object sender, EventArgs e)
        {
            txtTempo = btnMarca.Text;
            btnMarca.Text = "";
        }

        private void btnMarca_Leave(object sender, EventArgs e)
        {
            if (btnMarca.Text == "")//verifica si el text box esta vacio
            {
                btnMarca.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }
    }
}
