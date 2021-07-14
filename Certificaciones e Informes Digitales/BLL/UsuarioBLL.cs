using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
