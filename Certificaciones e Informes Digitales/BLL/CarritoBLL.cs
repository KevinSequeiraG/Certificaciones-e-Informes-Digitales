using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CarritoBLL
    {
        public static void Guardar(Entities.Carrito carro)
        {
            try
            {
                if (carro.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del carro");
                }
                if (carro.usuario==null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el usuario que es dueño del carrito");
                }
                if (carro.total == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de total del carrito");
                }
                if (carro.subtotal == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de subtotal del carrito");
                }
                if (carro.impuestos == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el total de impuestos");
                }               

                DAL.CarritoDAL.Guardar(carro);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el carro \n" + ex.Message);
            }
        }
    }
}
