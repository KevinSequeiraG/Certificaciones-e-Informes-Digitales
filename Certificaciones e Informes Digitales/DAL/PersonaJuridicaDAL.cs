using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class PersonaJuridicaDAL
    {
        /// <summary>
        /// Funcion que permite guardar una persona juridica
        /// </summary>
        /// <param name="pj">persona juridica a guardar</param>
        public static void Guardar(Entities.PersonaJuridica pj)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarPersonaJuridica";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", pj.id);
                    comando.Parameters.AddWithValue("@RazonSocial", pj.razonSocial);
                    comando.Parameters.AddWithValue("@Estado", pj.estado);
                    comando.Parameters.AddWithValue("@FechaInsc", pj.FechaInsc);
                    comando.Parameters.AddWithValue("@tomo", pj.tomo);
                    comando.Parameters.AddWithValue("@asiento", pj.asiento);
                    comando.Parameters.AddWithValue("@Domicilio", pj.domicilio);
                    comando.Parameters.AddWithValue("@Objeto", pj.objeto);

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
        /// Funcion que permite editar una persona juridica
        /// </summary>
        /// <param name="id">id de persona</param>
        /// <param name="razonSocial">razon social</param>
        /// <param name="estado">Estado de persona juridica</param>
        /// <param name="fechaInsc">Fecha de inscripcion</param>
        /// <param name="tomo">Tomo</param>
        /// <param name="asiento">Asiento</param>
        /// <param name="domicilio">Domicilio</param>
        /// <param name="objeto">Objeto de persona juridica</param>
        public static void Editar(string id, string razonSocial, bool estado, DateTime fechaInsc, int tomo, int asiento, string domicilio, string objeto)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarPersonaJuridica";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@RazonSocial", razonSocial);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@FechaInsc", fechaInsc);
                    comando.Parameters.AddWithValue("@tomo", tomo);
                    comando.Parameters.AddWithValue("@asiento", asiento);
                    comando.Parameters.AddWithValue("@Domicilio", domicilio);
                    comando.Parameters.AddWithValue("@Objeto", objeto);
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
        /// Funcion que permite eliminar una persona juridica de la base de datos
        /// </summary>
        /// <param name="id">id de la persona</param>
        public static void Eliminar(string id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarPersonaJ";

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
        /// Retorna una lista de todas las personas juridicas que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Entities.PersonaJuridica> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.PersonaJuridica> lista = new List<Entities.PersonaJuridica>();
                    string sql = @"SP_VerPersonaJuridica";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.PersonaJuridica persona = new Entities.PersonaJuridica();
                        persona.id = reader["id"].ToString();
                        persona.razonSocial = reader["RazonSocial"].ToString();
                        persona.estado = Convert.ToBoolean(reader["Estado"]);
                        persona.FechaInsc = Convert.ToDateTime(reader["FechaInsc"]);
                        persona.tomo = Convert.ToInt32(reader["tomo"]);
                        persona.asiento = Convert.ToInt32(reader["asiento"]);
                        persona.domicilio = (reader["Domicilio"].ToString());
                        persona.objeto = reader["Objeto"].ToString();
                        lista.Add(persona);
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
        /// Funcion que retorna una persona juridica por id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Entities.PersonaJuridica VerPorID(string ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerPersonaJID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.PersonaJuridica persona = new Entities.PersonaJuridica();
                        persona.id = reader["id"].ToString();
                        persona.razonSocial = reader["RazonSocial"].ToString();
                        persona.estado = Convert.ToBoolean(reader["Estado"]);
                        persona.FechaInsc = Convert.ToDateTime(reader["FechaInsc"]);
                        persona.tomo = Convert.ToInt32(reader["tomo"]);
                        persona.asiento = Convert.ToInt32(reader["asiento"]);
                        persona.domicilio = (reader["Domicilio"].ToString());
                        persona.objeto = reader["Objeto"].ToString();
                        return persona;
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
