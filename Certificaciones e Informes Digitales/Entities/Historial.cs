using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class Historial
    {
        public int id { get; set; }
        public byte[] pdf { get; set; }
        public string idUser { get; set; }
        public DateTime fecha { get; set; }
        public string detalleCert { get; set; }
    }
}
