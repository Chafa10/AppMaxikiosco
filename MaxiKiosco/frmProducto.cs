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
        private List<Cliente> listaCliente;
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
        public void OcultarColumnasProvedor()
        {
            dgvProvedor.Columns["id"].Visible = false;
        }
        public void OcultarColumnasCliente()
        {
            dgvClientes.Columns["id"].Visible = false;
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

            ClienteNegocio cliente = new ClienteNegocio();
            listaCliente = cliente.listaCliente();
            dgvClientes.DataSource = listaCliente;
            OcultarColumnasCliente();
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
        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            string filtroCliente = txtFiltroCliente.Text;
            List<Cliente> listaClienteFiltrada = new List<Cliente>();

            if (dgvClientes.DataSource != null)
            {
                listaClienteFiltrada = listaCliente.FindAll(x => x.Nombre.ToUpper().Contains(filtroCliente.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClienteFiltrada;
                OcultarColumnasCliente();
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

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            frmAltaCliente altaCliente = new frmAltaCliente();
            altaCliente.ShowDialog();
            cargarListas();
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            if(dgvClientes.CurrentRow != null)
            {
                Cliente seleccionado;
                seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;


                frmAltaCliente modificarCliente = new frmAltaCliente(seleccionado);
                modificarCliente.ShowDialog();
                cargarListas();
            }

            
        }

        private void dgvProvedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado;
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;


                frmAltaProducto modificarProducto = new frmAltaProducto(seleccionado);
                modificarProducto.ShowDialog();
                cargarListas();
            }
        }

        private void btnModificarProvedor_Click(object sender, EventArgs e)
        {
            if (dgvProvedor.CurrentRow != null)
            {
                Provedor seleccionado;
                seleccionado = (Provedor)dgvProvedor.CurrentRow.DataBoundItem;


                frmAltaProvedor modificarProvedor = new frmAltaProvedor(seleccionado);
                modificarProvedor.ShowDialog();
                cargarListas();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado;
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                try
                {
                    ProductoNegocio productoNegocio = new ProductoNegocio();
                    productoNegocio.eliminadoLogicoProducto(seleccionado.Id);
                    MessageBox.Show("Producto " + seleccionado.Categoria + " dado de baja", "Baja de producto", MessageBoxButtons.OK);
                    cargarListas();
                }
                catch (Exception)
                {

                    throw;
                }
                
             
                
            }
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
                    cargarListas();
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente seleccionado;
                seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                try
                {
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteNegocio.eliminadoLogicoCliente(seleccionado.Id);
                    MessageBox.Show("Producto " + seleccionado.Nombre + " dado de baja", "Baja de producto", MessageBoxButtons.OK);
                    cargarListas();
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }
    }
}
