using Certificaciones_e_Informes_Digitales.Entities;
using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class BienMuebleDAL
    {
        /// <summary>
        /// Funcion que permite guardar en la base de datos un Bien Mueble
        /// </summary>
        /// <param name="bien">Bien que se va a guardar</param>
        public static void Guardar(Entities.BienesMuebles bien)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarBienesMuebles";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", bien.id); 
                    if (bien.idPersonaF == "")
                    {
                        var personaF = DBNull.Value;
                        string personaJ = bien.idPersonaJ;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    if (bien.idPersonaJ == "")
                    {
                        var personaJ = DBNull.Value;
                        string personaF = bien.idPersonaF;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    comando.Parameters.AddWithValue("@Marca", bien.marca);
                    comando.Parameters.AddWithValue("@Categoria", bien.Categoria);
                    comando.Parameters.AddWithValue("@Serie", bien.serie);
                    comando.Parameters.AddWithValue("@Traccion", bien.traccion);
                    comando.Parameters.AddWithValue("@AnnoFabricacion", bien.annoFabricacion);
                    comando.Parameters.AddWithValue("@Color", bien.Color);
                    comando.Parameters.AddWithValue("@Capacidad", bien.capacidad);
                    comando.Parameters.AddWithValue("@ValorHacienda", bien.valorHacienda);
                    comando.Parameters.AddWithValue("@Estado", bien.estado);
                    comando.Parameters.AddWithValue("@uso", bien.uso);
                    comando.Parameters.AddWithValue("@Moneda", bien.moneda);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Util.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Util.Log.LogGenericException(ex);
                throw;
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
        public static void Editar(int id, string idPersonaJ,string idPersonaF, string marca, string Categoria, string serie, string traccion, int annoFabricacion, Enums.Usos uso, string Color, int capacidad, double valorHacienda, bool estado, Enums.Moneda moneda)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarBienesMuebles";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id); 
                    if (idPersonaF == "")
                    {
                        var personaF = DBNull.Value;
                        string personaJ = idPersonaJ;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    if (idPersonaJ == "")
                    {
                        var personaJ = DBNull.Value;
                        string personaF = idPersonaF;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@Categoria", Categoria);
                    comando.Parameters.AddWithValue("@serie", serie);
                    comando.Parameters.AddWithValue("@traccion", traccion);
                    comando.Parameters.AddWithValue("@annoFabricacion", annoFabricacion);
                    comando.Parameters.AddWithValue("@uso", uso);
                    comando.Parameters.AddWithValue("@Color", Color);
                    comando.Parameters.AddWithValue("@capacidad", capacidad);
                    comando.Parameters.AddWithValue("@valorHacienda", valorHacienda);
                    comando.Parameters.AddWithValue("@estado", estado);
                    comando.Parameters.AddWithValue("@moneda", moneda);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Util.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Util.Log.LogGenericException(ex);
                throw;
            }
        }
        /// <summary>
        /// Funcion para eliminar un bien mueble de la base de datos
        /// </summary>
        /// <param name="id">id del bien mueble</param>
        public static void Eliminar(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarBienMueble";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@id", id);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Util.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Util.Log.LogGenericException(ex);
                throw;
            }
        }
        /// <summary>
        /// Funcion que permite ver todos los bienes muebles que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<BienesMuebles> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<BienesMuebles> lista = new List<BienesMuebles>();
                    string sql = @"SP_VerBienesMuebles";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.BienesMuebles bien = new BienesMuebles();
                        bien.id = Convert.ToInt32(reader["id"]);
                        bien.idPersonaJ = reader["idPersonaJ"].ToString();
                        bien.idPersonaF = reader["idPersonaF"].ToString();
                        bien.marca = reader["Marca"].ToString();
                        bien.Categoria = reader["Categoria"].ToString();
                        bien.serie = reader["Serie"].ToString();
                        bien.traccion = reader["Traccion"].ToString();
                        bien.annoFabricacion = Convert.ToInt32(reader["AnnoFabricacion"]);
                        bien.uso = (Enums.Usos)Convert.ToInt32(reader["uso"]);
                        bien.Color = reader["Color"].ToString();
                        bien.capacidad = Convert.ToInt32(reader["Capacidad"]);
                        bien.valorHacienda = Convert.ToDouble(reader["ValorHacienda"]);
                        bien.estado = Convert.ToBoolean(reader["Estado"]);
                        bien.moneda = (Enums.Moneda)Convert.ToInt32(reader["Moneda"]);
                        lista.Add(bien);
                    }
                    return lista;
                }
            }
            catch (SqlException sqlEx)
            {
                Util.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Util.Log.LogGenericException(ex);
                throw;
            }
        }
        /// <summary>
        /// Funcion que permite ver un bien mueble por id
        /// </summary>
        /// <param name="ID">id del bien mueble</param>
        /// <returns></returns>
        public static Entities.BienesMuebles VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerBienMuebleID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.BienesMuebles bien = new BienesMuebles();
                        bien.id = Convert.ToInt32(reader["id"]);
                        bien.idPersonaJ = reader["idPersonaJ"].ToString();
                        bien.idPersonaF = reader["idPersonaF"].ToString();
                        bien.marca = (reader["Marca"].ToString());
                        bien.Categoria = (reader["Categoria"].ToString());
                        bien.serie = reader["Serie"].ToString();
                        bien.traccion = reader["Traccion"].ToString();
                        bien.annoFabricacion= Convert.ToInt32(reader["AnnoFabricacion"]);
                        bien.Color= reader["Color"].ToString();
                        bien.capacidad= Convert.ToInt32(reader["Capacidad"]);
                        bien.valorHacienda= Convert.ToDouble(reader["ValorHacienda"]);
                        bien.estado= Convert.ToBoolean(reader["Estado"]);
                        bien.uso= (Enums.Usos)Convert.ToInt32(reader["uso"]);
                        bien.moneda= (Enums.Moneda)Convert.ToInt32(reader["Moneda"]);
                        return bien;
                    }
                    return null;
                }
            }
            catch (SqlException sqlEx)
            {
                Util.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Util.Log.LogGenericException(ex);
                throw;
            }

        }
    }
}
