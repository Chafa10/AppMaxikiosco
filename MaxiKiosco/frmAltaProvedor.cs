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

        private Provedor provedor = null;
        public frmAltaProvedor(Provedor provedor)
        {
            InitializeComponent();
            this.provedor = provedor;
            lblTitulo.Text = "Modificar Provedor";
        }

        public frmAltaProvedor()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Provedor";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ProvedorNegocio provedorNegocio = new ProvedorNegocio();

            try
            {
                if (provedor == null)
                    provedor = new Provedor();

                

                provedor.Nombre = txtNombre.Text;
                provedor.Telefono = int.Parse(txtTelefono.Text);
                provedor.Mail = txtMail.Text;
                provedor.Direccion = txtDireccion.Text;
                provedor.Cuit = int.Parse(txtCuit.Text);
                provedor.Activo = true;

                if(provedor.Id != 0)
                {
                    provedorNegocio.modificarProvedor(provedor);
                    DialogResult resultado = MessageBox.Show("Modificaste el provedor exitosamente!!!", "Modificacion Provedor", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();
                }
                else
                {
                    provedorNegocio.agregarProvedor(provedor);
                    DialogResult resultado = MessageBox.Show("Agregaste el provedor exitosamente!!!", "Nuevo Provedor", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();
                }
                



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmAltaProvedor_Load(object sender, EventArgs e)
        {
            try
            {
                if(provedor != null)
                {
                    txtCuit.Text = provedor.Cuit.ToString();
                    txtDireccion.Text = provedor.Direccion;
                    txtMail.Text = provedor.Mail;
                    txtNombre.Text = provedor.Nombre;
                    txtTelefono.Text = provedor.Telefono.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
