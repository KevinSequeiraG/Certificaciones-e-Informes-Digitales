using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Util
{
    /// <summary>
    /// Representa la creacion de un solo carrito
    /// </summary>
    class CarritoSingleton
    {
        private static Entities.Carrito carro;
        /// <summary>
        /// Funcion que permite obtener el carro o bien crearlo
        /// </summary>
        /// <returns></returns>
        public static Entities.Carrito GetInstance()
        {
            if (carro == null)
            {
                carro = new Entities.Carrito();
            }
            return carro;
        }
        /// <summary>
        /// Funcion que permite instanciar un carro
        /// </summary>
        /// <param name="carrito">Carro a instanciar</param>
        public static void setCarro(Entities.Carrito carrito)
        {
            carro = carrito;
        }
    }
}
