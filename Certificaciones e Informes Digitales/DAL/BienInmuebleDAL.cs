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
    class BienInmuebleDAL
    {
        /// <summary>
        /// Funcion para guardar un Bien Inmueble en la Base de Datos
        /// </summary>
        /// <param name="bien">Bien que se va a guardar</param>
        public static void Guardar(Entities.BienesInmuebles bien)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarBienesInmuebles";


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
                    
                    comando.Parameters.AddWithValue("@Provincia", bien.provincia);
                    comando.Parameters.AddWithValue("@Mide", bien.Mide);
                    comando.Parameters.AddWithValue("@ValorFiscal", bien.valorFiscal);
                    comando.Parameters.AddWithValue("@Naturaleza", bien.naturaleza);

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
        /// Funcion para editar un bien Inmueble en la base de datos
        /// </summary>
        /// <param name="id">ID Del bien Inmueble</param>
        /// <param name="idPersonaJ">ID de la persona Juridica</param>
        /// <param name="idPersonaF">ID de la persona Fisica</param>
        /// <param name="provincia">Provincia en la que se situa el bien</param>
        /// <param name="mide">Tamaño del bien</param>
        /// <param name="valorFiscal">Valor Fiscal que recibe el Bien</param>
        /// <param name="naturaleza">Naturaleza del Bien</param>
        public static void Editar(int id, string idPersonaJ, string idPersonaF, string provincia, string mide, double valorFiscal, string naturaleza)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarBienesInmuebles";

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
                    comando.Parameters.AddWithValue("@provincia", provincia);
                    comando.Parameters.AddWithValue("@mide", mide);
                    comando.Parameters.AddWithValue("@valorFiscal", valorFiscal);
                    comando.Parameters.AddWithValue("@naturaleza", naturaleza);

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
        /// Funcion para eliminar un Bien Inmueble de la base de datos
        /// </summary>
        /// <param name="id">id del bien a eliminar</param>
        public static void Eliminar(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarBienInmueble";

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
        /// Funcion que devuelve una lista con todos los bienes inmuebles que se encuentran en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<BienesInmuebles> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<BienesInmuebles> lista = new List<BienesInmuebles>();
                    string sql = @"SP_VerBienesInmuebles";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.BienesInmuebles bien = new BienesInmuebles();
                        bien.id = Convert.ToInt32(reader["id"]);
                        bien.idPersonaJ = reader["idPersonaJ"].ToString();
                        bien.idPersonaF = reader["idPersonaF"].ToString();
                        bien.provincia = reader["Provincia"].ToString();
                        bien.Mide = reader["Mide"].ToString();
                        bien.valorFiscal = Convert.ToDouble(reader["ValorFiscal"]);
                        bien.naturaleza = reader["Naturaleza"].ToString();
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
        /// Funcion que permite ver un bien Inmueble por ID
        /// </summary>
        /// <param name="ID">id del bien</param>
        /// <returns></returns>
        public static Entities.BienesInmuebles VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerBienInmuebleID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.BienesInmuebles bien = new BienesInmuebles();
                        bien.id = Convert.ToInt32(reader["id"]);
                        bien.idPersonaJ = reader["idPersonaJ"].ToString();
                        bien.idPersonaF = reader["idPersonaF"].ToString();
                        bien.provincia = reader["Provincia"].ToString();
                        bien.Mide = (reader["Mide"].ToString());
                        bien.valorFiscal = Convert.ToDouble(reader["ValorFiscal"]);
                        bien.naturaleza = reader["Naturaleza"].ToString();
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
