using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class TarjetaBLL
    {
        public static void Guardar(Entities.Tarjeta tarjeta)
        {
            try
            {
                if (tarjeta.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la tarjeta");
                }
                if (tarjeta.idUser == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del usuario");
                }
                if (tarjeta.fechaVenc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de vencimiento");
                }
                if (tarjeta.cvv == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el codigo de seguridad (cvv)");
                }
                if (tarjeta.tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de tarjeta");
                }

                DAL.TarjetaDAL.Guardar(tarjeta);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el tarjeta \n" + ex.Message);
            }
        }
    }
}
