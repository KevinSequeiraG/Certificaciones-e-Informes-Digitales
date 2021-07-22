using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class NombramientoBLL
    {
        public static void Guardar(Entities.Nombramiento nombramiento)
        {
            try
            {
                if (nombramiento.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del nombramiento");
                }
                if (nombramiento.Nombre == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el Nombre");
                }
                if (nombramiento.Cargo == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el Cargo");
                }
                if (nombramiento.FechaInsc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de inscripcion");
                }
                if (nombramiento.VigenciaVenc == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de vencimiento de vigencia");
                }
                if (nombramiento.VigenciaIni == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de inicio de vigencia");
                }
                if (nombramiento.idPersonaJuridica == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona Juridica");
                }

                DAL.NombramientoDAL.Guardar(nombramiento);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el nombramiento \n" + ex.Message);
            }
        }
    }
}
