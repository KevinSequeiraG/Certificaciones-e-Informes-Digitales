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
        public static void Guardar(Entities.LineaDetalle linea)
        {
            try
            {
                if (linea.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del linea");
                }
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
                if (linea.idPersona == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID de la persona");
                }

                DAL.LineaDetalleDAL.Guardar(linea);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el linea \n" + ex.Message);
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
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.LineaDetalleDAL.Eliminar(id);
                MessageBox.Show("Linea Detalle eliminada correctamente");
            }
            catch (Exception ex)
            {
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
                throw new ApplicationException("Ocurrió un error al buscar la linea detalle \n" + ex.Message);
            }
        }
    }
}
