using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class HistorialBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite ingresar en el historial del usuario una certificacion
        /// </summary>
        /// <param name="email">correo del usuario</param>
        /// <param name="fecha">fecha de la compra</param>
        /// <param name="detalleCert">detalle de la certificacion</param>
        public void Guardar(string email, DateTime fecha, string detalleCert)
        {
            try
            {
                DAL.HistorialDAL.Guardar(email, fecha, detalleCert);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar la certificacion en el pdf \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver por id la informacion de una certificacion vendida
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entities.Historial VerPorID(int id)
        {
            try
            {
                return DAL.HistorialDAL.VerPorID(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar la certificacion del pdf por id \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// funcion que permite ver el historial de un usuario
        /// </summary>
        /// <param name="idUser">correo del usuario</param>
        /// <returns></returns>
        public List<Entities.Historial> VerHistorialUsuario(string idUser)
        {
            try
            {
                return DAL.HistorialDAL.VerHistorialUsuario(idUser);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar la certificacion del pdf por id \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver el ultimo historial por el correo de usuario
        /// </summary>
        /// <param name="correoUsario">correo del usuario</param>
        /// <returns></returns>
        public Entities.Historial VerUltimoHistorial(string correoUsario)
        {
            try
            {
                return DAL.HistorialDAL.VerUltimoHistorial(correoUsario);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el ultimo historial \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite agregar un pdf a un historial
        /// </summary>
        /// <param name="idHist"></param>
        /// <param name="pdf"></param>
        public void AgregarPdfAHist(int idHist, byte[] pdf)
        {
            try
            {
                DAL.HistorialDAL.AgregarPdfAHist(idHist,pdf);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el ultimo historial \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
    }
}
