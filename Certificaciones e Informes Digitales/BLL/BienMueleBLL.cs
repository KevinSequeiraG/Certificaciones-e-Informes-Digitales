using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class BienMueleBLL
    {
        public static void Guardar(Entities.BienesMuebles bien)
        {
            try
            {
                if (bien.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del Bien Inmueble");
                }
                if (String.IsNullOrEmpty(bien.idPersona))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }
                if (String.IsNullOrEmpty(bien.marca))
                {
                    //warn
                    throw new ApplicationException("Debe indicar la marca del bien mueble");
                }
                if (bien.moneda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de moneda");
                }
                if (bien.serie == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la serie del bien mueble");
                }

                if (bien.traccion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la traccion del Bien mueble");
                }
                if (String.IsNullOrEmpty(bien.idPersona))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }
                if (bien.uso==null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el uso del bien mueble");
                }
                if (bien.valorHacienda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el valor de hacienda");
                }
                if (bien.annoFabricacion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el año de fabricacion del bien mueble");
                }
                if (bien.estado== null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el estado del bien mueble");
                }
                if (bien.Categoria == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar categoria del bien mueble");
                }
                if (bien.capacidad == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la capacidad del bien mueble");
                }

                DAL.BienMuebleDAL.Guardar(bien);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el bien \n" + ex.Message);
            }

        }
    }
}
