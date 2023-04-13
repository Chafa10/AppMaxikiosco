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
    public partial class frmProducto : Form
    {
        private List<Producto> listaProductos;
        private List<Provedor> listaProvedor;
        public frmProducto()
        {
            InitializeComponent();
        }
        
        private void Producto_Load(object sender, EventArgs e)
        {
            cargarListas();
        }

        public void OcultarColumnasProducto()
        {
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns["idProvedor"].Visible = false;

        }

        public void cargarListas()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            listaProductos = negocio.listarProducto();
            dgvProductos.DataSource = listaProductos;
            OcultarColumnasProducto();

            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            listaProvedor = provedorNegocio.listaProvedor();
            dgvProvedor.DataSource = listaProvedor;
            OcultarColumnasProvedor();
        }

        public void OcultarColumnasProvedor()
        {
            dgvProvedor.Columns["id"].Visible = false;
        }

        private void txtFiltroProducto_TextChanged(object sender, EventArgs e)
        {
            string filtroProducto = txtFiltroProducto.Text;
            List<Producto> listaProductosFiltrada = new List<Producto>();

            if(dgvProductos.DataSource != null)
            {
                listaProductosFiltrada = listaProductos.FindAll(x => x.Categoria.ToUpper().Contains(filtroProducto.ToUpper()));

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductosFiltrada;
                OcultarColumnasProducto();
            }
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            altaProducto.ShowDialog();
            cargarListas();
            
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            frmAltaProvedor altaProvedor = new frmAltaProvedor();
            altaProvedor.ShowDialog();
            cargarListas();
        }
    }
}
