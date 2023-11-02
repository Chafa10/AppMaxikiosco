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
                datos.SetearConsulta("SELECT nombreUsuario, contrasenia, U.nombre as nombreReal, apellido, U.idRol, R.nombre as nombreRol, activo FROM Usuario U inner join Rol R on U.idRol = R.id where activo = 1");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.NomUsuario = (string)datos.Lector["nombreUsuario"];
                    aux.Password = (string)datos.Lector["contrasenia"];
                    aux.Nombre = (string)datos.Lector["nombreReal"];
                    aux.Apellido = (string)datos.Lector["apellido"];
                    aux.Rol = new Rol();
                    aux.Rol.Id = (int)datos.Lector["idRol"];
                    aux.Rol.Nombre = (string)datos.Lector["nombreRol"];
                    aux.activo = (bool)datos.Lector["activo"];
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

        public void NuevoUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into USUARIO Values(@usuario, @nombre, @apellido, @password, @idRol, activo = 1)");
                datos.SetearParametro("@usuario", usuario.NomUsuario);
                datos.SetearParametro("@nombre", usuario.Nombre);
                datos.SetearParametro("@apellido", usuario.Apellido);
                datos.SetearParametro("@password", usuario.Password);
                datos.SetearParametro("@idRol", usuario.Rol.Id);
                

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

        public void modificarUsuario(Usuario usuarioSeleccionado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update Usuario set nombreUsuario = @NombreUsuario, nombre = @Nombre, apellido = @Apellido, contrasenia = @Contrasenia, idRol = @idRol, activo = 1 where nombreUsuario = @id");

                datos.SetearParametro("@NombreUsuario", usuarioSeleccionado.NomUsuario);
                datos.SetearParametro("@Nombre", usuarioSeleccionado.Nombre);
                datos.SetearParametro("@Apellido", usuarioSeleccionado.Apellido);
                datos.SetearParametro("@Contrasenia", usuarioSeleccionado.Password);
                datos.SetearParametro("@idRol", usuarioSeleccionado.Rol.Id);
                datos.SetearParametro("@id", usuarioSeleccionado.NomUsuario);
              

                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminadoLogicoUsuario(string nombreUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE USUARIO SET Activo = 0 WHERE nombreUsuario = @NombreUsuario");
                datos.SetearParametro("@NombreUsuario", nombreUsuario);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
