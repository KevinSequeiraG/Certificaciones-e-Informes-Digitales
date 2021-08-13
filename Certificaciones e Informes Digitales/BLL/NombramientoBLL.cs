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
        /// <summary>
        /// Funcion que permite guardar un nombramiento en la base de datos
        /// </summary>
        /// <param name="nombramiento">nombramiento a guardar</param>
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
        /// <summary>
        /// Funcion que permite editar un nombramiento
        /// </summary>
        /// <param name="id">id de nombramiento</param>
        /// <param name="Nombre">Nombre de la persona que pertenece al nombramiento</param>
        /// <param name="cargo">Cargo de la persona que pertenece al nombramiento</param>
        /// <param name="FechaInsc">Fecha de incripcion de la persona que pertenece al nombramiento</param>
        /// <param name="VigenciaIni">Vigencia de inicio de la persona que pertenece al nombramiento</param>
        /// <param name="VigenciaVenc">Vigencia de vencimiento de la persona que pertenece al nombramiento</param>
        /// <param name="idPersonaJuridica">Id de la persona juridica a la que pertenece la persona</param>
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
        /// <summary>
        /// Funcion que permite eliminar una persona de un nombramiento
        /// </summary>
        /// <param name="id">id del nombramiento</param>
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
        /// <summary>
        /// Funcion que permite ver todos los nombramientos de la base de datos
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Permite ver el nombramiento por id
        /// </summary>
        /// <param name="ID">id del nombramiento que se desea ver</param>
        /// <returns></returns>
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
        /// <summary>
        /// Funcion que permite ver un nombramiento por id de persona
        /// </summary>
        /// <param name="ID">id de persona</param>
        /// <returns></returns>
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
