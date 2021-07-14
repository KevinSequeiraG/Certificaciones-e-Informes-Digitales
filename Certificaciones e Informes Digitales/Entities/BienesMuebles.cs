﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Entities
{
    class BienesMuebles
    {
        public int id { get; set; }
        public string idPersona { get; set; }
        public string marca { get; set; }
        public string Categoria { get; set; }
        public string serie { get; set; }
        public string traccion { get; set; }
        public int annoFabricacion { get; set; }
        public string Color { get; set; }
        public int capacidad { get; set; }
        public double valorHacienda { get; set; }
        public bool estado { get; set; }
    }
}