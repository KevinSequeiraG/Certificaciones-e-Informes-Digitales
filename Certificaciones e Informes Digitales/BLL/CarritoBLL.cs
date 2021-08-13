using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class CarritoBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public void Guardar(Entities.Carrito carro)
        {
            try
            {
                if (carro.usuario == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el usuario que es dueño del carrito");
                }
                if (carro.total == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de total del carrito");
                }
                if (carro.subtotal == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de subtotal del carrito");
                }
                if (carro.impuestos == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el total de impuestos");
                }

                DAL.CarritoDAL.Guardar(carro);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el carro \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public void Editar(int id, Entities.Usuario usuario, double total, double subTotal, double impuestos)
        {
            try
            {
                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del carro");
                }
                if (usuario == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el usuario que es dueño del carrito");
                }
                if (total == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de total del carrito");
                }
                if (subTotal == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el monto de subtotal del carrito");
                }
                if (impuestos == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el total de impuestos");
                }


                DAL.CarritoDAL.Editar(id, usuario, total, subTotal, impuestos);
                MessageBox.Show("Carrito editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public void Eliminar(Int64 id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.CarritoDAL.Eliminar(id);
                MessageBox.Show("Carrito eliminado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public List<Entities.Carrito> Ver()
        {
            try
            {
                return DAL.CarritoDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los carritos \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public Entities.Carrito VerPorID(int ID)
        {
            try
            {
                return DAL.CarritoDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Carrito por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public  Entities.Carrito VerUltimoCarrito(string email)
        {
            try
            {
                return DAL.CarritoDAL.VerUltimoCarrito(email);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Carrito por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public List<Entities.LineaDetalle> VerInfoCarrito(int id)
        {
            try
            {
                return DAL.CarritoDAL.VerInfoCarrito(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Carrito por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public double CalcularTotal(int idCarro)
        {
            try
            {
                return DAL.CarritoDAL.CalcularTotal(idCarro);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Carrito por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public static List<Entities.Carrito> VerComprasDelMes()
        {
            try
            {
                return DAL.CarritoDAL.VerComprasDelMes();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Carrito por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        public double CalculaTotalConImpuestos(int idCarro)
        {
            try
            {
                return DAL.CarritoDAL.CalculaTotalConImpuestos(idCarro);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al Calcular el total del Carrito mas impuestos por ID \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
    }
}
