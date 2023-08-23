using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> listaUsuario()
        {
            List<Usuario> lista= new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT id, nombreUsuario, contrasenia, idRol FROM Usuario ");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = (int)datos.Lector["id"];
                    aux.NomUsuario = (string)datos.Lector["nombreUsuario"];
                    aux.Password = (string)datos.Lector["contrasenia"];
                    aux.Fk_Rol = (int)datos.Lector["idRol"];
                    lista.Add(aux);
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
    }
}
