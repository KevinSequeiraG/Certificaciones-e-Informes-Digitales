using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    /// <summary>
    /// Representa una Linea de detalle
    /// </summary>
    class LineaDetalle
    {
        public int id { get; set; }
        public int idCarrito { get; set; }
        public int idCert { get; set; }
        public int cant { get; set; }
        public string idPersonaJ { get; set; }
        public string idPersonaF { get; set; }
        public string TipoCert { get; set; }
        public string DetalleCert { get; set; }
        public double PrecioCert { get; set; }
        public int idBien { get; set; }
    }
}
