using System;
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
                datos.SetearConsulta("select id, nom_razonsocial, telefono, mail, direccion, cuit, activo from provedor");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Provedor auxiliar = new Provedor();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Nombre = (string)datos.Lector["nom_razonsocial"];
                    auxiliar.Telefono = (int)datos.Lector["telefono"];
                    auxiliar.Mail = (string)datos.Lector["mail"];
                    auxiliar.Direccion = (string)datos.Lector["direccion"];
                    auxiliar.Cuit = (int)datos.Lector["cuit"];
                    auxiliar.Activo = (bool)datos.Lector["activo"];

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
