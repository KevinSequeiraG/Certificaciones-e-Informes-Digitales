using Certificaciones_e_Informes_Digitales.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class BienesInmuebles
    {
        public int id { get; set; }
        public string idPersonaJ { get; set; }
        public string idPersonaF { get; set; }
        public string provincia { get; set; }
        public string Mide { get; set; }
        public double valorFiscal { get; set; }
        public string naturaleza { get; set; }
    }
}
