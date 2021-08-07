using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Util
{
    class CarritoSingleton
    {
        private static Entities.Carrito carro;
        public static Entities.Carrito GetInstance()
        {
            if (carro == null)
            {
                carro = new Entities.Carrito();
            }
            return carro;
        }
        public static void setCarro(Entities.Carrito carrito)
        {
            carro = carrito;
        }
    }
}
