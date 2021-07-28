using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class PersonaFisicaDAL
    {
        public static void Guardar(Entities.PersonaFisica pf)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarPersonaFisica";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", pf.id);
                    comando.Parameters.AddWithValue("@Nombre", pf.Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", pf.Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", pf.Apellido2);
                    comando.Parameters.AddWithValue("@FechaNacimiento", pf.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Genero", pf.genero);
                    comando.Parameters.AddWithValue("@Foto", pf.Foto);
                    comando.Parameters.AddWithValue("@email", pf.email);

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
        public static void Editar(string id, string Nombre, string Apellido1, string Apellido2, DateTime FechaNacimiento, Enums.Genero genero, byte[] Foto, string email)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarPersonaFisica";

                    var comando = new SqlCommand(sql); comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", Apellido2);
                    comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    comando.Parameters.AddWithValue("@Genero", genero);
                    comando.Parameters.AddWithValue("@Foto", Foto);
                    comando.Parameters.AddWithValue("@email", email);

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
        public static void Eliminar(string id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarPersonaF";

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
        public static List<Entities.PersonaFisica> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.PersonaFisica> lista = new List<Entities.PersonaFisica>();
                    string sql = @"SP_VerPersonaFisica";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.PersonaFisica persona = new Entities.PersonaFisica();
                        persona.id = reader["id"].ToString();
                        persona.Nombre = reader["Nombre"].ToString();
                        persona.Apellido1 = reader["Apellido1"].ToString();
                        persona.Apellido2 = reader["Apellido2"].ToString();
                        persona.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        persona.genero = (Enums.Genero)Convert.ToInt32(reader["Genero"]);
                        persona.Foto = (byte[])reader["Foto"];
                        persona.email = reader["Email"].ToString();
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
        public static Entities.PersonaFisica VerPorID(string ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerPersonaFID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.PersonaFisica persona = new Entities.PersonaFisica();
                        persona.id = reader["id"].ToString();
                        persona.Nombre = reader["Nombre"].ToString();
                        persona.Apellido1 = reader["Apellido1"].ToString();
                        persona.Apellido2 = reader["Apellido2"].ToString();
                        persona.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        persona.genero = (Enums.Genero)Convert.ToInt32(reader["Genero"]);
                        persona.Foto = (byte[])reader["Foto"];
                        persona.email = reader["Email"].ToString();
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
