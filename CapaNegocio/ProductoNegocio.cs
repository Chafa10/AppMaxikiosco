using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        public List<Producto> listarProducto()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select id, categoria, marca , stockMinimo, " +
                                     "cantidad, stockMaximo , precio, activo, idProvedor " +
                                     "from producto");

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Producto auxiliar = new Producto();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Categoria = (string)datos.Lector["categoria"];
                    auxiliar.Marca = (string)datos.Lector["marca"];
                    auxiliar.StockMinimo = (int)datos.Lector["stockMinimo"];
                    auxiliar.StockMaximo = (int)datos.Lector["stockMaximo"];
                    auxiliar.Cantidad = (int)datos.Lector["cantidad"];
                    auxiliar.Precio = (int)datos.Lector["precio"];
                    auxiliar.Activo = (bool)datos.Lector["activo"];
                    auxiliar.IdProvedor = (int)datos.Lector["idProvedor"];

                    lista.Add(auxiliar);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
