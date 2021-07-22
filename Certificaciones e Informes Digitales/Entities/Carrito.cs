using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class Carrito
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public double total { get; set; }
        public double subtotal { get; set; }
        public double impuestos { get; set; }
    }
}
