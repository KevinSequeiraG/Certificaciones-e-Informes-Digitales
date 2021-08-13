using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class LineaDetalleBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public void Guardar(Entities.LineaDetalle linea)
        {
            try
            {
                if (linea.idCarrito == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del carrito");
                }
                if (linea.idCert == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el ID de la certificacion");
                }
                if (linea.cant == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la cantidad de certificaciones");
                }

                DAL.LineaDetalleDAL.Guardar(linea);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el linea \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public void Editar(int id, int idCarrito, int idCert, int cant, string idPersona)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del linea");
                }
                if (idCarrito == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del carrito");
                }
                if (idCert == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el ID de la certificacion");
                }
                if (cant == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar la cantidad de certificaciones");
                }
                if (idPersona == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }


                DAL.LineaDetalleDAL.Editar(id, idCarrito, idCert, cant, idPersona);
                MessageBox.Show("Linea Detalle editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public void Eliminar(int idCarro, int idCert)
        {
            try
            {
                if (idCarro == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.LineaDetalleDAL.Eliminar(idCarro, idCert);
                MessageBox.Show("Linea Detalle eliminada correctamente");
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.LineaDetalle> Ver()
        {
            try
            {
                return DAL.LineaDetalleDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los Bienes \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public Entities.LineaDetalle VerPorID(int ID)
        {
            try
            {
                return DAL.LineaDetalleDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                _MyLogControlEventos.Error(ex.Message);
                throw new ApplicationException("Ocurrió un error al buscar la linea detalle \n" + ex.Message);
            }
        }
    }
}
