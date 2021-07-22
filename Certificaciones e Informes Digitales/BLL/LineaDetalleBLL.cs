using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class LineaDetalleBLL
    {
        public static void Guardar(Entities.LineaDetalle linea)
        {
            try
            {
                if (linea.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del linea");
                }
                if (linea.idCarrito == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del carrito");
                }
                if (linea.idCert == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el ID de la certificacion");
                }
                if (linea.cant == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la cantidad de certificaciones");
                }
                if (linea.idPersona == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }

                DAL.LineaDetalleDAL.Guardar(linea);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el linea \n" + ex.Message);
            }
        }
    }
}
