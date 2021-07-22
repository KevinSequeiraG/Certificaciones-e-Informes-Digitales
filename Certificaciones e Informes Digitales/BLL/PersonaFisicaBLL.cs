using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class PersonaFisicaBLL
    {
        public static void Guardar(Entities.PersonaFisica pf)
        {
            try
            {
                if (pf.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona fisica");
                }
                if (pf.Nombre == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el nombre");
                }
                if (pf.Apellido1 == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el primer apellido");
                }
                if (pf.Apellido2 == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el segundo apellido");
                }
                if (pf.FechaNacimiento == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de nacimiento");
                }
                if (pf.genero == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el genero");
                }
                if (pf.Foto == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar una foto");
                }
                if (pf.email == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar un correo electronico");
                }

                DAL.PersonaFisicaDAL.Guardar(pf);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el pf \n" + ex.Message);
            }
        }
    }
}
