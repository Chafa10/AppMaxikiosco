using CapaDominio;
using CapaNegocio;
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
    public partial class formProveedor : Form
    {
        private List<Provedor> listaProvedor;
        public formProveedor()
        {
            InitializeComponent();
            cargarLista();
        }

        private void btnModificarProvedor_Click(object sender, EventArgs e)
        {
            if (dgvProvedor.CurrentRow != null)
            {
                Provedor seleccionado;
                seleccionado = (Provedor)dgvProvedor.CurrentRow.DataBoundItem;


                frmAltaProvedor modificarProvedor = new frmAltaProvedor(seleccionado);
                modificarProvedor.ShowDialog();
                cargarLista();
            }
        }
        private void cargarLista()
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            listaProvedor = provedorNegocio.listaProvedor();
            dgvProvedor.DataSource = listaProvedor;
            OcultarColumnasProvedor();
        }

        private void OcultarColumnasProvedor()
        {
            dgvProvedor.Columns["id"].Visible = false;
        }

        private void txtFiltroProvedor_TextChanged(object sender, EventArgs e)
        {
            string filtroProvedor = txtFiltroProvedor.Text;
            List<Provedor> listaProvedorFiltrada = new List<Provedor>();

            if (dgvProvedor.DataSource != null)
            {
                listaProvedorFiltrada = listaProvedor.FindAll(x => x.Nombre.ToUpper().Contains(filtroProvedor.ToUpper()));
                dgvProvedor.DataSource = null;
                dgvProvedor.DataSource = listaProvedorFiltrada;
                OcultarColumnasProvedor();
            }
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            frmAltaProvedor altaProvedor = new frmAltaProvedor();
            altaProvedor.ShowDialog();
            cargarLista();
        }

        private void btnElimiarProvedor_Click(object sender, EventArgs e)
        {
            if (dgvProvedor.CurrentRow != null)
            {
                Provedor seleccionado;
                seleccionado = (Provedor)dgvProvedor.CurrentRow.DataBoundItem;

                try
                {
                    ProvedorNegocio provedorNegocio = new ProvedorNegocio();
                    provedorNegocio.eliminadoLogicoProvedor(seleccionado.Id);
                    MessageBox.Show("Producto " + seleccionado.Nombre + " dado de baja", "Baja de producto", MessageBoxButtons.OK);
                    cargarLista();
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal();
            pantalla.Show();
            this.Close();
        }
    }
}
