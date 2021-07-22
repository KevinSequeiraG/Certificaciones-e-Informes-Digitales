using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CertificacionBLL
    {
        public static void Guardar(Entities.Certificacion certificacion)
        {
            try
            {
                if (certificacion.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del certificacion");
                }
                if (certificacion.tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de certificacion");
                }
                if (certificacion.detalle == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el detalle de la certificacion");
                }
                if (certificacion.precio == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el precio de subtotal del carrito");
                }

                DAL.CertificacionDAL.Guardar(certificacion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el certificacion \n" + ex.Message);
            }
        }
    }
}
