﻿using System;
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
                datos.SetearConsulta("select Pro.Id, Categoria, Marca , StockMinimo, Cantidad," +
                                      "Precio, PrecioProveedor, PorcentajeGanancia, Pro.Activo, IdProvedor ,Nom_razonsocial from PRODUCTO Pro " +
                                      "inner join PROVEDOR  DOR on Pro.IdProvedor = DOR.Id " +
                                      "Where Pro.Activo = 1");

                /*datos.SetearConsulta("select Id, Categoria, Marca , StockMinimo, " +
                                     "Cantidad, StockMaximo , Precio, Activo, IdProvedor " +
                                     "from PRODUCTO");*/

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Producto auxiliar = new Producto();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Categoria = (string)datos.Lector["Categoria"];
                    auxiliar.Marca = (string)datos.Lector["Marca"];
                    auxiliar.StockMinimo = (int)datos.Lector["StockMinimo"];
                    auxiliar.Cantidad = (int)datos.Lector["Cantidad"];
                    auxiliar.Precio = (decimal)datos.Lector["Precio"];
                    auxiliar.PrecioProveedor = (decimal)datos.Lector["PrecioProveedor"];
                    auxiliar.PorcentajeGanancia = (string)datos.Lector["PorcentajeGanancia"];
                    auxiliar.Activo = (bool)datos.Lector["Activo"];
                    auxiliar.IdProvedor = (int)datos.Lector["IdProvedor"];
                    auxiliar.Nombre_Proveedor = (string)datos.Lector["Nom_razonsocial"];
                    

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

        public List<Producto> listaProductosProveedor(int id_proveedor)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Pro.Id, Categoria, Marca , StockMinimo, Cantidad, PorcentajeGanancia " +
                                     "Precio, Pro.Activo, IdProvedor ,Nom_razonsocial, PrecioProveedor from PRODUCTO Pro " +
                                     "inner join PROVEDOR  DOR on Pro.IdProvedor = DOR.Id " +
                                     "Where Pro.Activo = 1 and DOR.Id = " + id_proveedor);

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Producto auxiliar = new Producto();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Categoria = (string)datos.Lector["Categoria"];
                    auxiliar.Marca = (string)datos.Lector["Marca"];
                    auxiliar.StockMinimo = (int)datos.Lector["StockMinimo"];
                    auxiliar.Cantidad = (int)datos.Lector["Cantidad"];
                    auxiliar.Precio = (decimal)datos.Lector["Precio"];
                    auxiliar.PorcentajeGanancia = (string)datos.Lector["PorcentajeGanancia"];
                    auxiliar.Activo = (bool)datos.Lector["Activo"];
                    auxiliar.IdProvedor = (int)datos.Lector["IdProvedor"];
                    auxiliar.Nombre_Proveedor = (string)datos.Lector["Nom_razonsocial"];
                    auxiliar.PrecioProveedor = (decimal)datos.Lector["PrecioProveedor"];

                    lista.Add(auxiliar);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
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
                datos.SetearConsulta("insert into producto values(@categoria, @marca, @cantidad, @stockMinimo, @precio, @precioProveedor, @activo, @idProvedor, @porcentajeGanancia)");
                datos.SetearParametro("@categoria", nuevo.Categoria);
                datos.SetearParametro("@marca", nuevo.Marca);
                datos.SetearParametro("@cantidad", nuevo.Cantidad);
                datos.SetearParametro("@stockMinimo", nuevo.StockMinimo);
                datos.SetearParametro("@precio", nuevo.Precio);
                datos.SetearParametro("@porcentajeGanancia", nuevo.PorcentajeGanancia);
                datos.SetearParametro("@precioProveedor", nuevo.PrecioProveedor);
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

        public void modificarProducto(Producto productoSeleccionado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE PRODUCTO SET Categoria = @categoria, Marca = @marca, Cantidad = @cantidad, StockMinimo = @stockMinimo, Precio = @precio, PorcentajeGanancia = @porcentajeGanancia, PrecioProveedor = @precioProveedor, Activo = 1 WHERE Id = @id");

                datos.SetearParametro("@categoria", productoSeleccionado.Categoria);
                datos.SetearParametro("@marca", productoSeleccionado.Marca);
                datos.SetearParametro("@cantidad", productoSeleccionado.Cantidad);
                datos.SetearParametro("@stockMinimo", productoSeleccionado.StockMinimo);
                datos.SetearParametro("@precio", productoSeleccionado.Precio);
                datos.SetearParametro("@porcentajeGanancia", productoSeleccionado.PorcentajeGanancia);
                datos.SetearParametro("@precioProveedor", productoSeleccionado.PrecioProveedor);
                datos.SetearParametro("@id", productoSeleccionado.Id);

                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminadoLogicoProducto(int identificacion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE PRODUCTO SET Activo = 0 WHERE Id = @id");
                datos.SetearParametro("@id", identificacion);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
