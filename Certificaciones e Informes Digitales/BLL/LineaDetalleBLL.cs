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
        /// <summary>
        /// Funcion que permite guardar una linea detalle en la base de datos
        /// </summary>
        /// <param name="linea">linea detalle a guardar</param>
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
        /// <summary>
        /// Funcion que permite editar una linea detalle
        /// </summary>
        /// <param name="id">id de la linea detalle</param>
        /// <param name="idCarrito">id del carro a la que pertenece la linea detalle</param>
        /// <param name="idCert">id de la certificacion que se compro</param>
        /// <param name="cant">cantidad de certificaciones compradas</param>
        /// <param name="idPersona">id de la persona a la que pertenece la certificacion</param>
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
        /// <summary>
        /// Funcion que permite eliminar una linea detalle
        /// </summary>
        /// <param name="idCarro">id del carro a la que pertenece la linea detalle</param>
        /// <param name="idCert">id de la certificacion que se compro</param>
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
        /// <summary>
        /// Funcion que permite ver todas las lineas de detalle en la base de datos
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Funcion que permite ver una linea detalle por id
        /// </summary>
        /// <param name="ID">id de la linea de detalle</param>
        /// <returns></returns>
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
