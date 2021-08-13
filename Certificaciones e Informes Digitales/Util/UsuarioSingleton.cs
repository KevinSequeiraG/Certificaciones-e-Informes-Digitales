using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Util
{
    /// <summary>
    /// Representa una unica instanciacion de un usuario
    /// </summary>
    class UsuarioSingleton
    {
        private static Entities.Usuario usuario;
        /// <summary>
        /// Funcion que permite obtener el usuario o bien crearlo
        /// </summary>
        /// <returns></returns>
        public static Entities.Usuario GetInstance()
        {
            if (usuario == null)
            {
                usuario = new Entities.Usuario();
            }
            return usuario;
        }
        /// <summary>
        /// Funcion que permite instanciar un usuario
        /// </summary>
        /// <param name="user">usuario a instanciar</param>
        public static void setUser(Entities.Usuario user)
        {
            usuario = user;
        }
    }
}
