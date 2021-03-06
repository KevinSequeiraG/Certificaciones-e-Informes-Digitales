using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    /// <summary>
    /// Representa un Historial
    /// </summary>
    class Historial
    {
        public int id { get; set; }
        public byte[] pdf { get; set; }
        public string idUser { get; set; }
        public DateTime fecha { get; set; }
        public string detalleCert { get; set; }
        public Byte[] qr { get; set; }
    }
}
