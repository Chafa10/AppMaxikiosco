using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosco
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            formProveedor pantalla = new formProveedor();
            pantalla.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            formProductos pantalla = new formProductos();
            pantalla.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formClientes pantalla = new formClientes();
            pantalla.Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras pantalla = new frmCompras();
            pantalla.Show();
            this.Close();
        }
    }
}
