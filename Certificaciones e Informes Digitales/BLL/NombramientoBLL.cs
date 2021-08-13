using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class NombramientoBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public void Guardar(Entities.Nombramiento nombramiento)
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
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public void Editar(int id, string Nombre, string cargo, DateTime FechaInsc, DateTime VigenciaIni, DateTime VigenciaVenc, string idPersonaJuridica)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del nombramiento");
                }
                if (Nombre == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el Nombre");
                }
                if (cargo == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el Cargo");
                }
                if (FechaInsc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de inscripcion");
                }
                if (VigenciaVenc == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de vencimiento de vigencia");
                }
                if (VigenciaIni == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la fecha de inicio de vigencia");
                }
                if (idPersonaJuridica == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona Juridica");
                }


                DAL.NombramientoDAL.Editar(id, Nombre, cargo, FechaInsc, VigenciaIni, VigenciaVenc, idPersonaJuridica);
                MessageBox.Show("Usuario editado correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
        public void Eliminar(Int64 id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.NombramientoDAL.Eliminar(id);
                MessageBox.Show("Nombramiento eliminado correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.Nombramiento> Ver()
        {
            try
            {
                return DAL.NombramientoDAL.Ver();
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar los nombramientos \n" + ex.Message);
            }
        }
        public Entities.Nombramiento VerPorID(int ID)
        {
            try
            {
                return DAL.NombramientoDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el nombramiento \n" + ex.Message);
            }
        }
        public List<Entities.Nombramiento> VerPorIDPersona(string ID)
        {
            try
            {
                return DAL.NombramientoDAL.VerPorIDPersona(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el nombramiento \n" + ex.Message);
            }
        }


    }
}
