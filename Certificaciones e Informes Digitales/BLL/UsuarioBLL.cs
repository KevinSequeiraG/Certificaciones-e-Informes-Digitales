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
                throw new ApplicationException("Ocurrió un error al guardar el usuario \n"+ex.Message );
            }
        }
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
                throw new ApplicationException("Ocurrió un error al editar la contraseña \n" + ex.Message);
            }
        }
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
                throw new ApplicationException("Ocurrió un error al buscar el usuario \n" + ex.Message);
            }
        }

        public List<Entities.Usuario> VerUsuarios()
        {
            try
            {
                return DAL.UsuarioDAL.VerUsuarios();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }
        }

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
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }
            
        }

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
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }            
        }

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
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
    }
}
