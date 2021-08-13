using Certificaciones_e_Informes_Digitales.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    /// <summary>
    /// Representa un usuario
    /// </summary>
    class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool changePassword { get; set; }
        public TipoUsuario tipo { get; set; }
    }
}
