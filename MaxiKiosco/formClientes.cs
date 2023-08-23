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
    public partial class formClientes : Form
    {
        private List<Cliente> listaClientes;

        public formClientes()
        {
            InitializeComponent();
            cargarLista();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            frmAltaCliente altaCliente = new frmAltaCliente();
            altaCliente.ShowDialog();
            cargarLista();
        }

        private void cargarLista()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            listaClientes = negocio.listaCliente();
            dgvClientes.DataSource = listaClientes;            
            ocultarColumnas();
            renombrarTitulosDgv();

        }
        private void ocultarColumnas()
        {
            dgvClientes.Columns["Id"].Visible= false;
            dgvClientes.Columns["activo"].Visible = false;

        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente seleccionado;
                seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;


                frmAltaCliente modificarCliente = new frmAltaCliente(seleccionado);
                modificarCliente.ShowDialog();
                cargarLista();
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
                    cargarLista();
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }

        private void renombrarTitulosDgv()
        {
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["dni"].HeaderText = "DNI";
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["cuilCuit"].HeaderText = "Cuil/Cuit";
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["condicioniva"].HeaderText = "Condicion Iva";
            dgvClientes.Columns["fechaNacimiento"].HeaderText = "Fecha Nacimiento";
            dgvClientes.Columns["direccion"].HeaderText = "Direccion";
            dgvClientes.Columns["localidad"].HeaderText = "Localidad";
            dgvClientes.Columns["mail"].HeaderText = "Mail";
            dgvClientes.Columns["telefono"].HeaderText = "Telefono";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal();
            pantalla.Show();
            this.Close();
        }

        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            string filtroCliente = txtFiltroCliente.Text;
            List<Cliente> listaClienteFiltrada = new List<Cliente>();

            if (dgvClientes.DataSource != null)
            {
                listaClienteFiltrada = listaClientes.FindAll(x => x.Nombre.ToUpper().Contains(filtroCliente.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClienteFiltrada;
                ocultarColumnas();
            }
        }
    }


}
