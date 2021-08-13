using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.BLL
{
    class BienMueleBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar en la base de datos un Bien Mueble
        /// </summary>
        /// <param name="bien">Bien que se va a guardar</param>
        public static void Guardar(Entities.BienesMuebles bien)
        {
            try
            {
                if (bien.id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del Bien Inmueble");
                }
                if (String.IsNullOrEmpty(bien.marca))
                {
                    //warn
                    throw new ApplicationException("Debe indicar la marca del bien mueble");
                }
                if (bien.moneda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de moneda");
                }
                if (bien.serie == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la serie del bien mueble");
                }

                if (bien.traccion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la traccion del Bien mueble");
                }
                if (bien.uso==null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el uso del bien mueble");
                }
                if (bien.valorHacienda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el valor de hacienda");
                }
                if (bien.annoFabricacion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el año de fabricacion del bien mueble");
                }
                if (bien.estado== null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el estado del bien mueble");
                }
                if (bien.Categoria == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar categoria del bien mueble");
                }
                if (bien.capacidad == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la capacidad del bien mueble");
                }

                DAL.BienMuebleDAL.Guardar(bien);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al guardar el bien \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion para editar un bien mueble en la base de datos
        /// </summary>
        /// <param name="id">ID Del bien mueble</param>
        /// <param name="idPersonaJ">ID de la persona Juridica</param>
        /// <param name="idPersonaF">ID de la persona Fisica</param>
        /// <param name="marca">Marca del bien</param>
        /// <param name="Categoria">Categoria del bien</param>
        /// <param name="serie">serie del bien</param>
        /// <param name="traccion">traccion del bien</param>
        /// <param name="annoFabricacion">Año de fabricacion del bien</param>
        /// <param name="uso">Uso del bien</param>
        /// <param name="Color">Color del bien</param>
        /// <param name="capacidad">Capacidad del Bien</param>
        /// <param name="valorHacienda">Valor de haciendo del bien</param>
        /// <param name="estado">Estado del bien</param>
        /// <param name="moneda">Moneda del bien</param>
        public void Editar(int id, string idPersonaJ, string idPersonaF, string marca, string Categoria, string serie, string traccion, int annoFabricacion, Enums.Usos uso, string Color, int capacidad, double valorHacienda, bool estado, Enums.Moneda moneda)
        {
            try
            {

                if (id == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el ID del Bien Inmueble");
                } 
                if (String.IsNullOrEmpty(marca))
                {
                    //warn
                    throw new ApplicationException("Debe indicar la marca del bien mueble");
                }
                if (moneda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el tipo de moneda");
                }
                if (serie == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la serie del bien mueble");
                }

                if (traccion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la traccion del Bien mueble");
                }
                if (uso == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el uso del bien mueble");
                }
                if (valorHacienda == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el valor de hacienda");
                }
                if (annoFabricacion == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar el año de fabricacion del bien mueble");
                }
                if (estado == null)
                {
                    //warn
                    throw new ApplicationException("Debe indicar el estado del bien mueble");
                }
                if (Categoria == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar categoria del bien mueble");
                }
                if (capacidad == null)
                {
                    //warn
                    throw new ApplicationException("Debe ingresar la capacidad del bien mueble");
                }

                DAL.BienMuebleDAL.Editar(id, idPersonaJ, idPersonaF, marca, Categoria, serie, traccion, annoFabricacion, uso, Color, capacidad, valorHacienda, estado, moneda);
                MessageBox.Show("Usuario editado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al editar el usuario \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion para eliminar un bien mueble de la base de datos
        /// </summary>
        /// <param name="id">id del bien mueble</param>
        public void Eliminar(int id)
        {
            try
            {
                if (id == null)
                {
                    throw new ApplicationException("Debe ingresar el ID");
                }
                DAL.BienMuebleDAL.Eliminar(id);
                MessageBox.Show("Bien mueble eliminado correctamente");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el bien \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver todos los bienes muebles que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Entities.BienesMuebles> Ver()
        {
            try
            {
                return DAL.BienMuebleDAL.Ver();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar los Bienes \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
        /// <summary>
        /// Funcion que permite ver un bien mueble por id
        /// </summary>
        /// <param name="ID">id del bien mueble</param>
        /// <returns></returns>
        public Entities.BienesMuebles VerPorID(int ID)
        {
            try
            {
                return DAL.BienMuebleDAL.VerPorID(ID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el Bien \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }
        }
    }
}
