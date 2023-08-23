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
    public partial class formProductos : Form
    {
        private List<Producto> listaProductos;

        public formProductos()
        {
            InitializeComponent();
            cargarLista();
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
                    cargarLista();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void cargarLista()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
            listaProductos = productoNegocio.listarProducto();
            dgvProductos.DataSource = listaProductos;
            ocultarColumnas();
           
        }
        private void ocultarColumnas()
        {
            dgvProductos.Columns["Id"].Visible = false;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado;
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;


                frmAltaProducto modificarProducto = new frmAltaProducto(seleccionado);
                modificarProducto.ShowDialog();
                cargarLista();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            altaProducto.ShowDialog();
            cargarLista();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal();
            pantalla.Show();
            this.Close();
        }

        private void txtFiltroProducto_TextChanged(object sender, EventArgs e)
        {
            string filtroProducto = txtFiltroProducto.Text;
            List<Producto> listaProductosFiltrada = new List<Producto>();

            if (dgvProductos.DataSource != null)
            {
                listaProductosFiltrada = listaProductos.FindAll(x => x.Categoria.ToUpper().Contains(filtroProducto.ToUpper()));
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductosFiltrada;
                ocultarColumnas();
            }
        }
    }
}
