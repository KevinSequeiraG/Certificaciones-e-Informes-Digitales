using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class PersonaJuridica
    {
        public string id { get; set; }
        public string razonSocial { get; set; }
        public bool estado { get; set; }
        public DateTime FechaInsc { get; set; }
        public int tomo { get; set; }
        public int asiento { get; set; }
        public string domicilio { get; set; }
        public string objeto { get; set; }
    }
}
