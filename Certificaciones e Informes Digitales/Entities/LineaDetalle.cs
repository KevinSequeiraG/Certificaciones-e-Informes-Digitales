﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class LineaDetalle
    {
        public int id { get; set; }
        public int idCarrito { get; set; }
        public int idCert { get; set; }
        public int cant { get; set; }
        public string idPersona { get; set; }
    }
}
