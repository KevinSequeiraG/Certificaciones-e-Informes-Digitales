using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class Catastro
    {
        public int id { get; set; }
        public string idPersonaJ { get; set; }
        public string idPersonaF { get; set; }
        public string localizacion { get; set; }
        public string usoLocal { get; set; }
        public int annoConst { get; set; }
        public int tamanno { get; set; }

    }
}
