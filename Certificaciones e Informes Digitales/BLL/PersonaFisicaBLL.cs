using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class PersonaFisicaBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public void Guardar(Entities.PersonaFisica pf)
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
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al guardar el pf \n" + ex.Message);
            }
        }
        public void Editar(string id, string Nombre, string Apellido1,string Apellido2, DateTime FechaNacimiento, Enums.Genero genero, byte[] Foto, string email)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona fisica");
                }
                if (Nombre == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el nombre");
                }
                if (Apellido1 == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el primer apellido");
                }
                if (Apellido2 == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el segundo apellido");
                }
                if (FechaNacimiento == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de nacimiento");
                }
                if (genero == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el genero");
                }
                if (Foto == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar una foto");
                }
                if (email == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar un correo electronico");
                }


                DAL.PersonaFisicaDAL.Editar(id, Nombre, Apellido1, Apellido2, FechaNacimiento, genero, Foto, email);
                MessageBox.Show("Persona Fisica editada correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
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
                DAL.PersonaFisicaDAL.Eliminar(id);
                MessageBox.Show("Persona fisica eliminada correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.PersonaFisica> Ver()
        {
            try
            {
                return DAL.PersonaFisicaDAL.Ver();
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar las personas Fisicas \n" + ex.Message);
            }
        }
        public Entities.PersonaFisica VerPorID(String ID)
        {
            try
            {
                return DAL.PersonaFisicaDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar la persona \n" + ex.Message);
            }
        }
    }
}
