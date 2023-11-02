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
    public partial class frmAltaUsuario : Form
    {
        Usuario user = null;
        Usuario usuarioRol = null;
        public frmAltaUsuario(Usuario usuarioRol)
        {
            InitializeComponent();
            this.usuarioRol= usuarioRol;
            lblTitulo.Text = "Agregar usuario";
        }

        public frmAltaUsuario(Usuario usuarioRol, Usuario userModificar)
        {
            InitializeComponent();
            this.usuarioRol = usuarioRol;
            this.user = userModificar;
            lblTitulo.Text = "Modificar usuario";
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            RolNegocio negocio = new RolNegocio();
            try
            {
                cmbRol.DataSource = negocio.listaRoles();
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "id";
                if (usuarioRol.Rol.Id == 2)
                {
                    cmbRol.SelectedIndex = 1;
                    cmbRol.Enabled= false;
                }

                if(user != null)
                {
                    txtApellido.Text = user.Apellido;
                    txtNombre.Text = user.Nombre;
                    txtNombreUsuario.Text = user.NomUsuario;
                    txtPassword.Text = user.Password;
                    cmbRol.SelectedValue = user.Rol.Id;
                }
                
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                if(user == null)
                    user = new Usuario();

                user.NomUsuario = txtNombreUsuario.Text;
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Password = txtPassword.Text;
                user.Rol = (Rol)cmbRol.SelectedItem;

                if(user.activo == false)
                {
                    negocio.NuevoUsuario(user);

                    MessageBox.Show("Usuario dado de alta");

                    frmUsuario ventana = new frmUsuario(usuarioRol);
                    ventana.Show();
                    this.Close();
                }     
                
                else
                {
                    negocio.modificarUsuario(user);

                    MessageBox.Show("Usuario Modificado");

                    frmUsuario ventana = new frmUsuario(usuarioRol);
                    ventana.Show();
                    this.Close();
                }
              

                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmUsuario ventana = new frmUsuario(usuarioRol);
            ventana.Show();
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
