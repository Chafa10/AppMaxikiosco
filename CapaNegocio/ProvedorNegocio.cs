﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaNegocio;

namespace CapaNegocio
{
    public class ProvedorNegocio
    {
        public List<Provedor> listaProvedor()
        {
            List<Provedor> lista = new List<Provedor>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select Id, Nom_razonsocial, Telefono, Mail, Direccion, Cuit, Activo from PROVEDOR");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Provedor auxiliar = new Provedor();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Nombre = (string)datos.Lector["Nom_razonsocial"];
                    auxiliar.Telefono = (int)datos.Lector["Telefono"];
                    auxiliar.Mail = (string)datos.Lector["Mail"];
                    auxiliar.Direccion = (string)datos.Lector["Direccion"];
                    auxiliar.Cuit = (int)datos.Lector["Cuit"];
                    auxiliar.Activo = (bool)datos.Lector["Activo"];

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

        public void agregarProvedor(Provedor nuevoProvedor)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into PROVEDOR VALUES(@nombre, @telefono, @mail, @direccion, @cuit, @activo)");
                datos.SetearParametro("@nombre",nuevoProvedor.Nombre);
                datos.SetearParametro("@telefono", nuevoProvedor.Telefono);
                datos.SetearParametro("@mail", nuevoProvedor.Mail);
                datos.SetearParametro("@direccion", nuevoProvedor.Direccion);
                datos.SetearParametro("@cuit", nuevoProvedor.Cuit);
                datos.SetearParametro("@activo", nuevoProvedor.Activo);

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
