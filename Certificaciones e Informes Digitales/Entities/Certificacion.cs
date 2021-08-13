using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    /// <summary>
    /// Representa una Certificacion
    /// </summary>
    class Certificacion
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string detalle { get; set; }
        public double precio { get; set; }
    }
}
