using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

        [DisplayName("Stock Minimo")]
        public int StockMinimo { get; set; }

        [DisplayName ("Precio De Venta")]
        public decimal Precio { get; set; }

        [DisplayName("Precio De Compra")]
        public decimal PrecioProveedor { get; set; }

        [DisplayName("Porcentaje De Ganancia")]
        public string PorcentajeGanancia { get; set; }
        public bool Activo { get; set; }
        public int IdProvedor { get; set; }

        [DisplayName("Nombre Del Proveedor")]
        public string Nombre_Proveedor { get; set; }
        


    }

    
}
