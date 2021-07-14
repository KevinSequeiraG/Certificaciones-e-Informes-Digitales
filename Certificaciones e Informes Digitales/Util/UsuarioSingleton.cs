using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Util
{
    class UsuarioSingleton
    {
        private static Entities.Usuario usuario;
        public static Entities.Usuario GetInstance()
        {
            if (usuario == null)
            {
                usuario = new Entities.Usuario();
            }
            return usuario;
        }
    }
}
