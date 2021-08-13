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
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar una persona juridica
        /// </summary>
        /// <param name="pj">persona juridica a guardar</param>
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
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al guardar el pj \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite editar una persona juridica
        /// </summary>
        /// <param name="id">id de persona</param>
        /// <param name="razonSocial">razon social</param>
        /// <param name="estado">Estado de persona juridica</param>
        /// <param name="fechaInsc">Fecha de inscripcion</param>
        /// <param name="tomo">Tomo</param>
        /// <param name="asiento">Asiento</param>
        /// <param name="domicilio">Domicilio</param>
        /// <param name="objeto">Objeto de persona juridica</param>
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
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite eliminar una persona juridica de la base de datos
        /// </summary>
        /// <param name="id">id de la persona</param>
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
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        /// <summary>
        /// Retorna una lista de todas las personas juridicas que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entities.PersonaJuridica> Ver()
        {
            try
            {
                return DAL.PersonaJuridicaDAL.Ver();
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar las personas Juridicas \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que retorna una persona juridica por id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Entities.PersonaJuridica VerPorID(string ID)
        {
            try
            {
                return DAL.PersonaJuridicaDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar la persona \n" + ex.Message);
            }
        }
    }
}
