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
    public partial class frmCompras : Form
    {

        ProductoNegocio productoNe = null;

        private Provedor provedor;
        
        public frmCompras()
        {
            productoNe = new ProductoNegocio();
            InitializeComponent();      
            cargarcmb();      
            cargarGrilla(provedor.Id);
            
            crearTitulosTabla();

            // Agregamos el evento CellValidating para validar la entrada en la columna "CantidadCompra"
            dgvListaCompra.CellValidating += dgvListaCompra_CellValidating;
            // Agregamos el evento CellBeginEdit para deshabilitar la edición en las demás columnas
            dgvListaCompra.CellBeginEdit += dgvListaCompra_CellBeginEdit;


        }

        private void crearTitulosTabla()
        {
            dgvListaCompra.Columns.Add("NombreProducto", "Categoria");
            dgvListaCompra.Columns.Add("PrecioProducto", "Precio");
            dgvListaCompra.Columns.Add("CantidadCompra", "Cantidad");
            dgvListaCompra.Columns.Add("PrecioTotal", "Precio Total");
        }


        public void cargarcmb()
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            cmbCargarProvedor.DataSource = provedorNegocio.listaProvedor();
            cmbCargarProvedor.DisplayMember = "Nombre";
            cmbCargarProvedor.ValueMember = "Id";
        }

        public void cargarGrilla(int id)
        {
            
            dgvProductosProveedor.DataSource = productoNe.listaProductosProveedor(id);
            ocultarColumnas();
        }

        public void ocultarColumnas()
        {
            dgvProductosProveedor.Columns["Id"].Visible = false;
            dgvProductosProveedor.Columns["StockMinimo"].Visible = false;
            dgvProductosProveedor.Columns["Activo"].Visible = false;
            dgvProductosProveedor.Columns["IdProvedor"].Visible = false;
            dgvProductosProveedor.Columns["Nombre_Proveedor"].Visible = false;
            dgvProductosProveedor.Columns["Precio"].Visible = false;
        }

        private void cmbCargarProvedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCargarProvedor.SelectedValue != null)
            {

                provedor = (Provedor)cmbCargarProvedor.SelectedItem;

                dgvProductosProveedor.DataSource = null;

                cargarGrilla(provedor.Id);
               
            }



        }

        private void dgvProductosProveedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string columna1 = dgvProductosProveedor.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                string columna2 = dgvProductosProveedor.Rows[e.RowIndex].Cells["PrecioProveedor"].Value.ToString();


                dgvListaCompra.Rows.Add(columna1, columna2);

                if(dgvListaCompra.Rows.Count > 0)
                {
                    cmbCargarProvedor.Enabled = false;

                }
            }

            


        }


        private void dgvListaCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verificamos que estemos en la columna "CantidadCompra"
            if (e.ColumnIndex == 2)
            {
                // Verificamos que el valor ingresado sea un número
                if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad))
                {
                    // Si no es un número, cancelamos la edición solo para la celda "CantidadCompra"
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = "Solo se permiten números en la columna 'CantidadCompra'";
                    e.Cancel = true;
                }
                else
                {
                    // Si es un número, limpiamos cualquier mensaje de error previo
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void dgvListaCompra_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Verificamos que NO estemos en la columna "CantidadCompra"
            if (e.ColumnIndex != 2)
            {
                // Cancelamos la edición para las demás columnas
                e.Cancel = true;
            }
        }

        private void dgvListaCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal cantidad = decimal.Parse(dgvListaCompra.Rows[e.RowIndex].Cells[2].Value.ToString());

            decimal precioTotal = (cantidad * decimal.Parse(dgvListaCompra.Rows[e.RowIndex].Cells[1].Value.ToString()));
            decimal precioTotalFinal = 0;
            dgvListaCompra.Rows[e.RowIndex].Cells[3].Value = precioTotal;

            for (int i = 0; i < dgvListaCompra.Rows.Count; i++)
            {

                precioTotalFinal += decimal.Parse(dgvListaCompra.Rows[i].Cells[3].Value.ToString());


            }

            txtPrecioFinalCompra.Text = precioTotalFinal.ToString();
        }
    }
}
