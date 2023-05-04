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
    public partial class Ver_cliente : Form
    {
        public Ver_cliente()
        {
            InitializeComponent();
        }

        private void btnVerUno_Click(object sender, EventArgs e)
        {
            txtBuscar1.Show();
            lupa.Show();
        }
    }
}
