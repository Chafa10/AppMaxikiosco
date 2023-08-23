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


        private Producto producto = null;
        public frmAltaProducto()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Producto";
        }

        public frmAltaProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            lblTitulo.Text = "Modificar Producto";
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
                if(producto != null)
                {
                    txtCantidad.Text = producto.Cantidad.ToString();
                    txtCategoria.Text = producto.Categoria;
                    txtMarca.Text = producto.Marca;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStockMinimo.Text = producto.StockMinimo.ToString();

                }
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
                if (producto == null)
                    producto = new Producto();

                producto.Categoria = txtCategoria.Text;
                producto.Marca = txtMarca.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.StockMinimo = int.Parse(txtStockMinimo.Text);
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.PrecioProveedor = decimal.Parse(txtPrecioProveedor.Text);
                producto.Activo = true;
                producto.IdProvedor = (int)cmbProvedor.SelectedValue;


                if(producto.Id != 0)
                {
                    productoNegocio.modificarProducto(producto);
                    DialogResult resultado = MessageBox.Show("Modificaste el producto exitosamente!!!", "Modificacion Producto", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();
                }
                else
                {
                    productoNegocio.agregarProducto(producto);
                    DialogResult resultado = MessageBox.Show("Agregaste el producto exitosamente!!", "Nuevo Producto", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                        Close();
                    
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
