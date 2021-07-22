using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class PersonaJuridicaBLL
    {
        public static void Guardar(Entities.PersonaJuridica pj)
        {
            try
            {
                if (pj.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona Juridica");
                }
                if (pj.razonSocial == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la razon social");
                }
                if (pj.estado == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el estado");
                }
                if (pj.FechaInsc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de inscripcion");
                }
                if (pj.tomo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tomo");
                }
                if (pj.asiento == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el asiento");
                }
                if (pj.domicilio == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el domicilio");
                }
                if (pj.objeto == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el objeto");
                }

                DAL.PersonaJuridicaDAL.Guardar(pj);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el pj \n" + ex.Message);
            }
        }
    }
}
