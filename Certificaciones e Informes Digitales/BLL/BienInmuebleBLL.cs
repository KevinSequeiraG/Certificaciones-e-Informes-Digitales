using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void Editar(int id, string idPersonaJ, string idPersonaF, string provincia, string mide, double valorFiscal, string naturaleza)
        {
            try
            {
                if (id==null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                if (provincia==null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la provincia");
                }
                if (String.IsNullOrEmpty(mide))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar cuanto mide el bien inmuble");
                }
                if (valorFiscal==null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar un el monto del valor fiscal");
                }
                if (String.IsNullOrEmpty(naturaleza))
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la naturaleza del bien inmueble");
                }


                DAL.BienInmuebleDAL.Editar(id, idPersonaJ, idPersonaF, provincia, mide, valorFiscal, naturaleza);
                MessageBox.Show("Usuario editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.BienInmuebleDAL.Eliminar(id);
                MessageBox.Show("Bien Inmueble eliminado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.BienesInmuebles> Ver()
        {
            try
            {
                return DAL.BienInmuebleDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los Bienes \n" + ex.Message);
            }
        }
        public Entities.BienesInmuebles VerPorID(int ID)
        {
            try
            {
                return DAL.BienInmuebleDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Bien \n" + ex.Message);
            }
        }
    }
}
