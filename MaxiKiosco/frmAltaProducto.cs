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
    public partial class frmAltaProducto : Form
    {

        

        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            try
            {
                cmbProvedor.DataSource = provedorNegocio.listaProvedor();
                cmbProvedor.DisplayMember = "Nombre";
                cmbProvedor.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                Producto nuevoProducto = new Producto();

                nuevoProducto.Categoria = txtCategoria.Text;
                nuevoProducto.Marca = txtMarca.Text;
                nuevoProducto.Cantidad = int.Parse(txtCantidad.Text);
                nuevoProducto.StockMinimo = int.Parse(txtStockMinimo.Text);
                nuevoProducto.StockMaximo = int.Parse(txtStockMaximo.Text);
                nuevoProducto.Precio = int.Parse(txtPrecio.Text);
                nuevoProducto.Activo = true;
                nuevoProducto.IdProvedor = (int)cmbProvedor.SelectedValue;

                productoNegocio.agregarProducto(nuevoProducto);

                MessageBox.Show("Agreaste el producto exitosamente!!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
