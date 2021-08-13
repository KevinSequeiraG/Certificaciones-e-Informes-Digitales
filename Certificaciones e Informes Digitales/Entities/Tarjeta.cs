using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    /// <summary>
    /// Representa una tarjeta
    /// </summary>
    class Tarjeta
    {
        public int id { get; set; }
        public string idUser { get; set; }
        public DateTime fechaVenc { get; set; }
        public int cvv { get; set; }
        public Enums.TipoTarjeta tipo { get; set; }
    }
}
