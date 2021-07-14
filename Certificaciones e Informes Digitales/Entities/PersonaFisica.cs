using Certificaciones_e_Informes_Digitales.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class PersonaFisica
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Genero genero { get; set; }
        public byte[] Foto { get; set; }
        public string email { get; set; }
    }
}
