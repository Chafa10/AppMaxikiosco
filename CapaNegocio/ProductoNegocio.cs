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
                datos.SetearConsulta("select Id, Categoria, Marca , StockMinimo, " +
                                     "Cantidad, StockMaximo , Precio, Activo, IdProvedor " +
                                     "from PRODUCTO");

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Producto auxiliar = new Producto();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Categoria = (string)datos.Lector["Categoria"];
                    auxiliar.Marca = (string)datos.Lector["Marca"];
                    auxiliar.StockMinimo = (int)datos.Lector["StockMinimo"];
                    auxiliar.StockMaximo = (int)datos.Lector["StockMaximo"];
                    auxiliar.Cantidad = (int)datos.Lector["Cantidad"];
                    auxiliar.Precio = (int)datos.Lector["Precio"];
                    auxiliar.Activo = (bool)datos.Lector["Activo"];
                    auxiliar.IdProvedor = (int)datos.Lector["IdProvedor"];

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

        public void agregarProducto(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("insert into producto values(@categoria, @marca, @cantidad, @stockMinimo, @stockMaximo, @precio, @activo, @idProvedor)");
                datos.SetearParametro("@categoria", nuevo.Categoria);
                datos.SetearParametro("@marca", nuevo.Marca);
                datos.SetearParametro("@cantidad", nuevo.Cantidad);
                datos.SetearParametro("@stockMinimo", nuevo.StockMinimo);
                datos.SetearParametro("@stockMaximo", nuevo.StockMaximo);
                datos.SetearParametro("@precio", nuevo.Precio);
                datos.SetearParametro("@activo", nuevo.Activo);
                datos.SetearParametro("@idProvedor", nuevo.IdProvedor);

                datos.EjecutarAccion();
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
