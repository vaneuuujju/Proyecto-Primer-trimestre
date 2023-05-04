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
    public partial class MenuBodega : Form
    {
        public MenuBodega()
        {
            InitializeComponent();
        }
        #region Eventos de los text box
        string txtTempo; 
        private void txtCantidadMax_Leave(object sender, EventArgs e)
        {
            if (txtCantidadMax.Text == "")//verifica si el text box esta vacio
            {
                txtCantidadMin.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtCantidadMax_Enter(object sender, EventArgs e)
        {
            txtTempo = txtCantidadMax.Text;
            txtCantidadMax.Text = "";
        }

        private void txtCantidadMin_Leave(object sender, EventArgs e)
        {
            if (txtCantidadMin.Text == "")//verifica si el text box esta vacio
            {
                txtCantidadMin.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtCantidadMin_Enter(object sender, EventArgs e)
        {
            txtTempo = txtCantidadMin.Text;
            txtCantidadMin.Text = "";
        }
        #endregion

        private void btnVerUno_Click(object sender, EventArgs e)
        {
            txtBuscar1.Show();
            lupa.Show();
        }

        private void tpAdd_Click(object sender, EventArgs e)
        {

        }

        private void tbpAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void tpEdit_Click(object sender, EventArgs e)
        {

        }

        private void tpVer_Click(object sender, EventArgs e)
        {

        }

        private void txtAñadirCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lupa_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIndex_Click(object sender, EventArgs e)
        {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

        }
    }
}
