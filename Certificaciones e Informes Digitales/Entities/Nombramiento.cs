using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class Nombramiento
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInsc { get; set; }
        public DateTime VigenciaIni { get; set; }
        public DateTime VigenciaVenc { get; set; }
        public string idPersonaJuridica { get; set; }


    }
}
