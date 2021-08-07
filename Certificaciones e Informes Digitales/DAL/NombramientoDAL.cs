using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class NombramientoDAL
    {
        public static void Guardar(Entities.Nombramiento nombramiento)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarNombramiento";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", nombramiento.id);
                    comando.Parameters.AddWithValue("@Nombre", nombramiento.Nombre);
                    comando.Parameters.AddWithValue("@Cargo", nombramiento.Cargo);
                    comando.Parameters.AddWithValue("@FechaInsc", nombramiento.FechaInsc);
                    comando.Parameters.AddWithValue("@VigenciaIni", nombramiento.VigenciaIni);
                    comando.Parameters.AddWithValue("@VigenciaVenc", nombramiento.VigenciaVenc);
                    comando.Parameters.AddWithValue("@idPersonaJuridica", nombramiento.idPersonaJuridica);

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
        public static void Editar(int id, string Nombre, string cargo, DateTime FechaInsc,DateTime VigenciaIni, DateTime VigenciaVenc, string idPersonaJuridica)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarNombramiento";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Cargo", cargo);
                    comando.Parameters.AddWithValue("@FechaInsc", FechaInsc);
                    comando.Parameters.AddWithValue("@VigenciaIni", VigenciaIni);
                    comando.Parameters.AddWithValue("@VigenciaVenc", VigenciaVenc);
                    comando.Parameters.AddWithValue("@idPersonaJuridica", idPersonaJuridica);

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
        public static void Eliminar(Int64 id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarNombramiento";

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
        public static List<Entities.Nombramiento> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Nombramiento> lista = new List<Entities.Nombramiento>();
                    string sql = @"SP_VerNombramiento";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Nombramiento nombramiento = new Entities.Nombramiento();
                        nombramiento.id = Convert.ToInt32(reader["id"]);
                        nombramiento.Nombre = reader["Nombre"].ToString();
                        nombramiento.Cargo = reader["Cargo"].ToString();
                        nombramiento.FechaInsc =Convert.ToDateTime(reader["FechaInsc"]);
                        nombramiento.VigenciaIni = Convert.ToDateTime(reader["VigenciaIni"]);
                        nombramiento.VigenciaVenc = Convert.ToDateTime(reader["VigenciaVenc"]);
                        nombramiento.idPersonaJuridica = reader["idPersonaJuridica"].ToString();
                        lista.Add(nombramiento);
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
        public static Entities.Nombramiento VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {   
                    string sql = @"VerNombramientoID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Nombramiento nombramiento = new Entities.Nombramiento();
                        nombramiento.id = Convert.ToInt32(reader["id"]);
                        nombramiento.Nombre = reader["Nombre"].ToString();
                        nombramiento.Cargo = reader["Cargo"].ToString();
                        nombramiento.FechaInsc = Convert.ToDateTime(reader["FechaInsc"]);
                        nombramiento.VigenciaIni = Convert.ToDateTime(reader["VigenciaIni"]);
                        nombramiento.VigenciaVenc = Convert.ToDateTime(reader["VigenciaVenc"]);
                        nombramiento.idPersonaJuridica = reader["idPersonaJuridica"].ToString();
                        return nombramiento;
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
        public static List<Entities.Nombramiento> VerPorIDPersona (string ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Nombramiento> lista = new List<Entities.Nombramiento>();

                    string sql = @"VerNombramientoIDPersona";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Nombramiento nombramiento = new Entities.Nombramiento();
                        nombramiento.id = Convert.ToInt32(reader["id"]);
                        nombramiento.Nombre = reader["Nombre"].ToString();
                        nombramiento.Cargo = reader["Cargo"].ToString();
                        nombramiento.FechaInsc = Convert.ToDateTime(reader["FechaInsc"]);
                        nombramiento.VigenciaIni = Convert.ToDateTime(reader["VigenciaIni"]);
                        nombramiento.VigenciaVenc = Convert.ToDateTime(reader["VigenciaVenc"]);
                        nombramiento.idPersonaJuridica = reader["idPersonaJuridica"].ToString();
                        lista.Add(nombramiento);
                    }
                    return lista ;
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
