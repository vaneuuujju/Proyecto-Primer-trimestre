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
    public partial class Ver_Productos : Form
    {
        public Ver_Productos()
        {
            InitializeComponent();
        }

        #region Eventos del text box
        //sirven para borrar o aparecer automaticamente dependiendo de lo que hace el usuario
        string txtTempo; //para los eventos leave y enter de los textBox
        private void txtBuscar1_Leave(object sender, EventArgs e)
        {
            if (txtBuscar1.Text == "")//verifica si el text box esta vacio
            {
                txtBuscar1.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtBuscar1_Enter(object sender, EventArgs e)
        {
            txtTempo = txtBuscar1.Text;
            txtBuscar1.Text = "";
        }
        #endregion

        private void btnVerUno_Click(object sender, EventArgs e)
        {
            txtBuscar1.Show();
            lupa.Show();
        }

        private void Ver_Productos_Leave(object sender, EventArgs e)
        {

        }
    }
}
