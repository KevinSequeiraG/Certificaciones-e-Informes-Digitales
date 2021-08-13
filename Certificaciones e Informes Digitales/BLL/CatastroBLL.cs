using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CatastroBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar un catastro en la base de datos
        /// </summary>
        /// <param name="catastro">catastro a guardar</param>
        public void Guardar(Entities.Catastro catastro)
        {
            try
            {
                if (catastro.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del catastro");
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
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite editar un catastro en la base de datos
        /// </summary>
        /// <param name="id">id del catastro</param>
        /// <param name="idPersonaJ">id de la persona Juridica</param>
        /// <param name="idPersonaF">id de la persona Fisica</param>
        /// <param name="localizacion">localizacion del catastro</param>
        /// <param name="usoLocal">uso local del catastro</param>
        /// <param name="annoConst">año de construccion del catastro</param>
        /// <param name="tamanno">Tamaño del catastro</param>
        public void Editar(int id, string idPersonaJ, string idPersonaF, string localizacion, string usoLocal, int annoConst, int tamanno)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del ");
                }
                if (localizacion == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la localizacion del ");
                }
                if (usoLocal == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el uso local que tiene el ");
                }
                if (annoConst == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el año de construccion del ");
                }
                if (tamanno == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tamaño del ");
                }


                DAL.CatastroDAL.Editar(id, idPersonaJ, idPersonaF, localizacion, usoLocal, annoConst, tamanno);
                MessageBox.Show("Catastro editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite eliminar un catastro
        /// </summary>
        /// <param name="id">id del catastro a eliminar</param>
        public void Eliminar(int id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.CatastroDAL.Eliminar(id);
                MessageBox.Show("Catastro eliminado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que retorna lista de catastros que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entities.Catastro> Ver()
        {
            try
            {
                return DAL.CatastroDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los catastros \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que retorna un catastro por el id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Entities.Catastro VerPorID(int ID)
        {
            try
            {
                return DAL.CatastroDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el catastro \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
    }
}
