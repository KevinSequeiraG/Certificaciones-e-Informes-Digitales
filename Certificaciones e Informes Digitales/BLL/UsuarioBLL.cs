using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class UsuarioBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar un usuario
        /// </summary>
        /// <param name="usuario">usuario a guardar</param>
        public void Guardar(Entities.Usuario usuario)
        {
            try
            {
                if (String.IsNullOrEmpty(usuario.Nombre))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar su nombre");
                }
                if (String.IsNullOrEmpty(usuario.Apellido1))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar su primer apellido");
                }
                if (String.IsNullOrEmpty(usuario.Apellido2))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar su segundo apellido");
                }
                if (String.IsNullOrEmpty(usuario.email))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar un correo electronico");
                }
                if (String.IsNullOrEmpty(usuario.password))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar una contraseña");
                }
                if (String.IsNullOrEmpty(usuario.telefono.ToString()))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar numero telefonico");
                }
                if (usuario.tipo == null)
                {
                    throw new ApplicationException("No se indicó el tipo de ususario");
                }

                DAL.UsuarioDAL.InsertarUsuario(usuario);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al guardar el usuario \n"+ex.Message );
            }
        }
        /// <summary>
        /// Funcion que permite editar la contraseña de un usuario
        /// </summary>
        /// <param name="email">coreo de usuario</param>
        /// <param name="password">constraseña nueva</param>
        /// <param name="cambioAutomatico">Permite al sistema conocer si el usuario debe o no hacer un cambio de contraseña al ingresar</param>
        public void editarContrasenna(string email, string password, bool cambioAutomatico)
        {
            try
            {
                if (String.IsNullOrEmpty(email))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar email");
                }
                if (String.IsNullOrEmpty(password))
                {
                    //warn
                    throw new ApplicationException("Error al cambiar contraseña");
                }
                if (cambioAutomatico == null)
                {
                    //warn
                    throw new ApplicationException("No se indico si fue un cambio automatico o por eleccin de usuario.");
                }
                DAL.UsuarioDAL.EditarContrasenna(email, password, cambioAutomatico);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al editar la contraseña \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver usuario
        /// </summary>
        /// <param name="email">correo de usuario</param>
        /// <param name="passw">contraseña de usuario</param>
        /// <returns></returns>
        public Entities.Usuario TraerUsuario(string email, string passw)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new ApplicationException("Debe ingresar el correo");
                }
                if (string.IsNullOrEmpty(passw))
                {
                    throw new ApplicationException("Debe ingresar una contraseña"); 
                }
                Entities.Usuario user = DAL.UsuarioDAL.TraerUsuario(email, passw);
                return user;
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el usuario \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver todos los usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entities.Usuario> VerUsuarios()
        {
            try
            {
                return DAL.UsuarioDAL.VerUsuarios();
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }
        }
        /// <summary>
        /// Retorna un usario por correo electronico
        /// </summary>
        /// <param name="email">correo de usuario</param>
        /// <returns></returns>
        public List<Entities.Usuario> TraerUsuarioPorCorreo(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new ApplicationException("Debe ingresar una correo electronico.");
                }
                List < Entities.Usuario > lista = DAL.UsuarioDAL.TraerUsuarioPorCorreo(email);

                return lista;
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }
            
        }
        /// <summary>
        /// Permite eliminar un usuario
        /// </summary>
        /// <param name="email">correo de usuario a eliminar</param>
        public void EliminarUsuario(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new ApplicationException("Debe ingresar una correo electronico.");
                }
                DAL.UsuarioDAL.EliminarUsuario(email);
                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }            
        }
        /// <summary>
        /// Funcion que permite editar un usuario
        /// </summary>
        /// <param name="Nombre">Nomre de usuario</param>
        /// <param name="Apellido1">Primer apellido de usuario</param>
        /// <param name="Apellido2">Segundo apellido de usuario</param>
        /// <param name="telefono">telefono de usuario</param>
        /// <param name="email">correo de usuario</param>
        /// <param name="password">Contraseña de usuario</param>
        /// <param name="changePassword">Permite conocer al sistema si el usuario debe hacer cambio de contraseña o no</param>
        /// <param name="tipo">tipo de usuario</param>
        public void editarUsuario(string Nombre, string Apellido1, string Apellido2, int telefono, string email, string password, bool changePassword, Enums.TipoUsuario tipo)
        {
            try
            {
                if (string.IsNullOrEmpty(Nombre))
                {
                    throw new ApplicationException("debe ingresar el nombre");
                }
                if (String.IsNullOrEmpty(Apellido1))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar su primer apellido");
                }
                if (String.IsNullOrEmpty(Apellido2))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar su segundo apellido");
                }
                if (String.IsNullOrEmpty(email))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar un correo electronico");
                }
                if (String.IsNullOrEmpty(password))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar una contraseña");
                }
                if (String.IsNullOrEmpty(telefono.ToString()))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar numero telefonico");
                }
                if (tipo == null)
                {
                    throw new ApplicationException("No se indicó el tipo de ususario");
                }


                DAL.UsuarioDAL.editarUsuario(Nombre, Apellido1, Apellido2, telefono, email,  password, changePassword, tipo);
                MessageBox.Show("Usuario editado correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
    }
}
