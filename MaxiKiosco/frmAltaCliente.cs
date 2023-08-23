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
    public partial class frmAltaCliente : Form
    {

        private Cliente cliente = null;

        public frmAltaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lblTitulo.Text = "Modificar Cliente";
        }

        public frmAltaCliente()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Cliente";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            {
                if (cliente == null)
                    cliente = new Cliente();
               

                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = txtDni.Text;
                cliente.CuilCuit = txtCuilCuit.Text;
                cliente.FechaNacimiento = txtFechaNac.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Localidad = txtLocalidad.Text;
                cliente.Mail = txtMail.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.CondicionIva = cmbCondIva.Text;
                cliente.Activo = true;

                if(cliente.Id != 0)
                {
                    clienteNegocio.modificarCliente(cliente);
                    DialogResult resultado = MessageBox.Show("Modificaste el cliente exitosamente!!","Modificacion de Cliente", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();



                }
                else
                {
                    clienteNegocio.agregarCliente(cliente);
                    DialogResult resultado = MessageBox.Show("Agregaste el cliente exitosamente!!", "Modificacion de Cliente", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();
                }
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            try
            {
                cmbCondIva.DataSource = clienteNegocio.listaCliente();
                cmbCondIva.DisplayMember = "condicionIva";
                cmbCondIva.ValueMember = "Id";

                if(cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono;
                    txtMail.Text = cliente.Mail;
                    txtLocalidad.Text = cliente.Localidad;
                    txtFechaNac.Text = cliente.FechaNacimiento;
                    txtDni.Text = cliente.Dni;
                    txtDireccion.Text = cliente.Direccion;
                    txtCuilCuit.Text = cliente.CuilCuit;
                    txtApellido.Text = cliente.Apellido;
                }
              
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
