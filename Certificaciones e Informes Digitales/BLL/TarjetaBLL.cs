using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class TarjetaBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar una tarjeta en la base de datos
        /// </summary>
        /// <param name="tarjeta">tarjeta a guardar</param>
        public void Guardar(Entities.Tarjeta tarjeta)
        {
            try
            {
                if (tarjeta.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la tarjeta");
                }
                if (tarjeta.idUser == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del usuario");
                }
                if (tarjeta.fechaVenc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de vencimiento");
                }
                if (tarjeta.cvv == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el codigo de seguridad (cvv)");
                }
                if (tarjeta.tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de tarjeta");
                }

                DAL.TarjetaDAL.Guardar(tarjeta);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al guardar el tarjeta \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite editar una tarjeta
        /// </summary>
        /// <param name="id">id de tarjeta</param>
        /// <param name="idUser">correo de usuario</param>
        /// <param name="fechaVenc">Fecha vencimiento de tarjeta</param>
        /// <param name="cvv">Codigo de seguridad de tarjeta</param>
        /// <param name="tipo">tipo de tarjeta</param>
        public void Editar(int id, string idUser, DateTime fechaVenc, int cvv, string tipo)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la tarjeta");
                }
                if (idUser == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del usuario");
                }
                if (fechaVenc == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la fecha de vencimiento");
                }
                if (cvv == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el codigo de seguridad (cvv)");
                }
                if (tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de tarjeta");
                }


                DAL.TarjetaDAL.Editar(id, idUser, fechaVenc, cvv, tipo);
                MessageBox.Show("Tarjeta editada correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
            }
        }
        /// <summary>
        /// Funcion que eliminar una tarjeta de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(Int64 id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.TarjetaDAL.Eliminar(id);
                MessageBox.Show("Bien Inmueble eliminado correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        /// <summary>
        /// Retorna lista de tarjetas de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entities.Tarjeta> Ver()
        {
            try
            {
                return DAL.TarjetaDAL.Ver();
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar los usuarios \n" + ex.Message);
            }
        }
        /// <summary>
        /// Retorna tarjeta por id
        /// </summary>
        /// <param name="ID">id de tarjeta</param>
        /// <returns></returns>
        public Entities.Tarjeta VerPorID(int ID)
        {
            try
            {
                return DAL.TarjetaDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar la tarjeta\n" + ex.Message);
            }
        }
        /// <summary>
        /// Retorna todas las tarjetas de un usuario
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public List<Entities.Tarjeta> VerTarjetasUsuario(string userEmail)
        {
            try
            {
                return DAL.TarjetaDAL.VerTarjetasUsuario(userEmail);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar las tarjetas \n" + ex.Message);
            }
        }


    }
}
