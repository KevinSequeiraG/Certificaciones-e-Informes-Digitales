using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class HistorialBLL
    {
        public void Guardar(byte[] pdf, string email, DateTime fecha, string detalleCert)
        {
            try
            {
                if (pdf == null)
                {
                    throw new ApplicationException("El pdf no existe");
                }
                DAL.HistorialDAL.Guardar(pdf, email, fecha, detalleCert);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar la certificacion en el pdf \n" + ex.Message);
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
            }
        }
    }
}
