using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaNegocio;

namespace MaxiKiosco
{
    public partial class frmAltaProvedor : Form
    {
        public frmAltaProvedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            try
            {
                ProvedorNegocio provedorNegocio = new ProvedorNegocio();
                Provedor nuevoProvedor = new Provedor();

                nuevoProvedor.Nombre = txtNombre.Text;
                nuevoProvedor.Telefono = int.Parse(txtTelefono.Text);
                nuevoProvedor.Mail = txtMail.Text;
                nuevoProvedor.Direccion = txtDireccion.Text;
                nuevoProvedor.Cuit = int.Parse(txtCuit.Text);
                nuevoProvedor.Activo = true;

                provedorNegocio.agregarProvedor(nuevoProvedor);

                MessageBox.Show("Agregado el provedor exitozamente!!!");



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
