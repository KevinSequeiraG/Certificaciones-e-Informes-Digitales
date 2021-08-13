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
        public Entities.Historial VerUltimoHistorial()
        {
            try
            {
                return DAL.HistorialDAL.VerUltimoHistorial();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el ultimo historial \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
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
