using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class PersonaJuridicaBLL
    {
        public void Guardar(Entities.PersonaJuridica pj)
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
        public void Editar(string id, string razonSocial, bool estado, DateTime fechaInsc, int tomo, int asiento, string domicilio, string objeto)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona Juridica");
                }
                if (razonSocial == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la razon social");
                }
                if (estado == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el estado");
                }
                if (fechaInsc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de inscripcion");
                }
                if (tomo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tomo");
                }
                if (asiento == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el asiento");
                }
                if (domicilio == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el domicilio");
                }
                if (objeto == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el objeto");
                }


                DAL.PersonaJuridicaDAL.Editar(id, razonSocial, estado, fechaInsc, tomo, asiento, domicilio, objeto);
                MessageBox.Show("Usuario editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
        public void Eliminar(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.PersonaJuridicaDAL.Eliminar(id);
                MessageBox.Show("Persona Juridica eliminada correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.PersonaJuridica> Ver()
        {
            try
            {
                return DAL.PersonaJuridicaDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar las personas Juridicas \n" + ex.Message);
            }
        }
        public Entities.PersonaJuridica VerPorID(string ID)
        {
            try
            {
                return DAL.PersonaJuridicaDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar la persona \n" + ex.Message);
            }
        }
    }
}
