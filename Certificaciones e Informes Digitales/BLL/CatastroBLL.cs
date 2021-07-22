using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CatastroBLL
    {
        public static void Guardar(Entities.Catastro catastro)
        {
            try
            {
                if (catastro.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del catastro");
                }
                if (catastro.idPersona == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el id de Persona");
                }
                if (catastro.localizacion == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la localizacion del catastro");
                }
                if (catastro.usoLocal == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el uso local que tiene el catastro");
                }
                if (catastro.annoConst == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el año de construccion del catastro");
                }
                if (catastro.tamanno == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tamaño del catastro");
                }

                DAL.CatastroDAL.Guardar(catastro);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el catastro \n" + ex.Message);
            }
        }
    }
}
