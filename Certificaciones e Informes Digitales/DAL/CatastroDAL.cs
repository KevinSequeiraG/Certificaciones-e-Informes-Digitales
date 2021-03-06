using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CatastroDAL
    {
        /// <summary>
        /// Funcion que permite guardar un catastro en la base de datos
        /// </summary>
        /// <param name="catastro">catastro a guardar</param>
        public static void Guardar(Entities.Catastro catastro)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCatastro";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", catastro.id);
                    if (catastro.idPersonaF == "")
                    {
                        var personaF = DBNull.Value;
                        string personaJ = catastro.idPersonaJ;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    if (catastro.idPersonaJ == "")
                    {
                        var personaJ = DBNull.Value;
                        string personaF = catastro.idPersonaF;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    comando.Parameters.AddWithValue("@localizacion", catastro.localizacion);
                    comando.Parameters.AddWithValue("@usoLocal", catastro.usoLocal);
                    comando.Parameters.AddWithValue("@annoConst", catastro.annoConst);
                    comando.Parameters.AddWithValue("@tamanno", catastro.tamanno);

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
        /// Funcion que permite editar un catastro en la base de datos
        /// </summary>
        /// <param name="id">id del catastro</param>
        /// <param name="idPersonaJ">id de la persona Juridica</param>
        /// <param name="idPersonaF">id de la persona Fisica</param>
        /// <param name="localizacion">localizacion del catastro</param>
        /// <param name="usoLocal">uso local del catastro</param>
        /// <param name="annoConst">año de construccion del catastro</param>
        /// <param name="tamanno">Tamaño del catastro</param>
        public static void Editar(int id, string idPersonaJ, string idPersonaF, string localizacion, string usoLocal, int annoConst, int tamanno)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarCatastro";

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
                    comando.Parameters.AddWithValue("@localizacion", localizacion);
                    comando.Parameters.AddWithValue("@usoLocal", usoLocal);
                    comando.Parameters.AddWithValue("@annoConst", annoConst);
                    comando.Parameters.AddWithValue("@tamanno", tamanno);

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
        /// Funcion que permite eliminar un catastro
        /// </summary>
        /// <param name="id">id del catastro a eliminar</param>
        public static void Eliminar(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarCatastro";

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
        /// Funcion que retorna lista de catastros que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Entities.Catastro> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Catastro> lista = new List<Entities.Catastro>();
                    string sql = @"SP_VerCatastro";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Catastro catastro = new Entities.Catastro();
                        catastro.id = Convert.ToInt32(reader["id"]);
                        catastro.idPersonaJ = reader["idPersonaJ"].ToString();
                        catastro.idPersonaF = reader["idPersonaF"].ToString();
                        catastro.localizacion = reader["localizacion"].ToString();
                        catastro.usoLocal = reader["usoLocal"].ToString();
                        catastro.annoConst = Convert.ToInt32(reader["annoConst"]);
                        catastro.tamanno = Convert.ToInt32(reader["tamanno"]);
                        lista.Add(catastro);
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
        /// Funcion que retorna un catastro por el id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Entities.Catastro VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerCatastroID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Catastro catastro = new Entities.Catastro();
                        catastro.id = Convert.ToInt32(reader["id"]);
                        catastro.idPersonaJ = reader["idPersonaJ"].ToString();
                        catastro.idPersonaF = reader["idPersonaF"].ToString();
                        catastro.localizacion = reader["localizacion"].ToString();
                        catastro.usoLocal = reader["usoLocal"].ToString();
                        catastro.annoConst = Convert.ToInt32(reader["annoConst"]);
                        catastro.tamanno = Convert.ToInt32(reader["tamanno"]);
                        return catastro;
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
