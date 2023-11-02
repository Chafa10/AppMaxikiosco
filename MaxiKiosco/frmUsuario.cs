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
    public partial class frmUsuario : Form
    {

        Usuario usuario = null;
        public frmUsuario()
        {
            InitializeComponent();

        }

        public frmUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cargarGrillaUsuarios();
            ocultarColumnas();
        }


        private void cargarGrillaUsuarios()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                dgvUsuarios.DataSource = negocio.listaUsuario();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ocultarColumnas()
        {
            dgvUsuarios.Columns["Password"].Visible= false;
            dgvUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
           
                frmAltaUsuario ventana = new frmAltaUsuario(usuario);
                ventana.Show();
                this.Close();
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal(usuario);
            pantalla.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Usuario seleccionado;
                seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

                try
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    usuarioNegocio.eliminadoLogicoUsuario(seleccionado.NomUsuario);
                    MessageBox.Show("Usuario " + seleccionado.NomUsuario + " dado de baja", "Baja de usuario", MessageBoxButtons.OK);
                    cargarGrillaUsuarios();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
           

            if (dgvUsuarios.CurrentRow != null)
            {
                Usuario seleccionado;
                seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;


                frmAltaUsuario ventana = new frmAltaUsuario(usuario, seleccionado);
                ventana.Show();
                this.Close();
            }

        }
    }
}
