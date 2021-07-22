using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class BienInmuebleBLL
    {
        public static void Guardar(Entities.BienesInmuebles bien)
        {
            try
            {
                if (bien.id==null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del Bien Inmueble");
                }
                if (String.IsNullOrEmpty(bien.idPersona))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }
                if (String.IsNullOrEmpty(bien.Mide))
                {
                    //warn
                    throw new ApplicationException("Debe indicar cuanto mide el bien inmueble");
                }
                if (String.IsNullOrEmpty(bien.naturaleza))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la naturaleza del bien inmueble");
                }
                if (bien.provincia==null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la provincia a la que pertenece el bien");
                }               

                DAL.BienInmuebleDAL.Guardar(bien);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el bien \n" + ex.Message);
            }
        }
    }
}
