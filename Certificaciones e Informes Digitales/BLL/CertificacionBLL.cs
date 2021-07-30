using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CertificacionBLL
    {
        public void Guardar(Entities.Certificacion certificacion)
        {
            try
            {
                if (certificacion.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del certificacion");
                }
                if (certificacion.tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de certificacion");
                }
                if (certificacion.detalle == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el detalle de la certificacion");
                }
                if (certificacion.precio == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el precio de subtotal del carrito");
                }

                DAL.CertificacionDAL.Guardar(certificacion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el certificacion \n" + ex.Message);
            }
        }
        public void Editar(int id, string tipo, string detalle, double precio)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del certificacion");
                }
                if (tipo == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de certificacion");
                }
                if (detalle == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el detalle de la certificacion");
                }
                if (precio == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el precio de subtotal del carrito");
                }

                DAL.CertificacionDAL.Editar(id, tipo, detalle, precio);
                MessageBox.Show("Certificacion editada correctamente");
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
                DAL.CertificacionDAL.Eliminar(id);
                MessageBox.Show("Certificacion eliminada correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
            }
        }
        public List<Entities.Certificacion> Ver()
        {
            try
            {
                return DAL.CertificacionDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los Bienes \n" + ex.Message);
            }
        }
        public Entities.Certificacion VerPorID(int ID)
        {
            try
            {
                return DAL.CertificacionDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar la certificacion \n" + ex.Message);
            }
        }
        public List<Entities.Certificacion> VerPorTipo(string tipo)
        {
            try
            {
                return DAL.CertificacionDAL.VerPorTipo(tipo);
            }
            catch (Exception)
            {
                throw new ApplicationException("Ocurrio un error al cargar la lista de " + tipo);
            }
        }
    }
}
