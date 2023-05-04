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
    public partial class EditarCliente : Form  //hereda de una super clase
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }
        #region Eventos de los text box
        string txtTempo;//guarda el texto temporalmente
  
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


    }
}
