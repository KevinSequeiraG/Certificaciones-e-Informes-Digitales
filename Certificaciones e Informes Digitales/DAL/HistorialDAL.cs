using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class HistorialDAL
    {
        /// <summary>
        /// Funcion que permite ingresar en el historial del usuario una certificacion
        /// </summary>
        /// <param name="email">correo del usuario</param>
        /// <param name="fecha">fecha de la compra</param>
        /// <param name="detalleCert">detalle de la certificacion</param>
        public static void Guardar(string idUser, DateTime fecha, string detalleCert)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarAHistorial";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@idUser", idUser);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@detalleCert", detalleCert);
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
        /// Funcion que permite ver por id la informacion de una certificacion vendida
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Entities.Historial VerPorID(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_VerHistorialID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", id);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);                    

                    while (reader.Read())
                    {
                        Entities.Historial hist = new Entities.Historial();
                        hist.id = Convert.ToInt32(reader["id"]);
                        hist.pdf = (byte[])(reader["pdf"]);
                        hist.idUser = (reader["idUsuario"].ToString());
                        hist.fecha = Convert.ToDateTime(reader["fecha"]);
                        hist.detalleCert = (reader["detalleCert"].ToString());
                        return hist;
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
        /// <summary>
        /// funcion que permite ver el historial de un usuario
        /// </summary>
        /// <param name="idUser">correo del usuario</param>
        /// <returns></returns>
        public static List<Entities.Historial> VerHistorialUsuario(string idUser)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_VerHistorialUsusario";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", idUser);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    List<Entities.Historial> lista = new List<Entities.Historial>();

                    while (reader.Read())
                    {
                        Entities.Historial hist = new Entities.Historial();
                        hist.id = Convert.ToInt32(reader["id"]);
                        hist.pdf = (byte[])(reader["pdf"]);
                        hist.idUser = (reader["idUsuario"].ToString());
                        hist.fecha = Convert.ToDateTime(reader["fecha"]);
                        hist.detalleCert = (reader["detalleCert"].ToString());
                        lista.Add(hist);
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
        /// Funcion que permite ver el ultimo historial por el correo de usuario
        /// </summary>
        /// <param name="correoUsario">correo del usuario</param>
        /// <returns></returns>
        public static Entities.Historial VerUltimoHistorial(string correoUsario)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"sp_VerUltimoHistorial";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@ID", correoUsario);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Historial hist = new Entities.Historial();
                        hist.id = Convert.ToInt32(reader["id"]);
                        hist.idUser = (reader["idUsuario"].ToString());
                        hist.fecha = Convert.ToDateTime(reader["fecha"]);
                        hist.detalleCert = (reader["detalleCert"].ToString());
                        return hist;
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
        /// <summary>
        /// Funcion que permite agregar un pdf a un historial
        /// </summary>
        /// <param name="idHist"></param>
        /// <param name="pdf"></param>
        public static void AgregarPdfAHist(int idHist, byte[] pdf)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarPDFaHist";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@idHist", idHist);
                    comando.Parameters.AddWithValue("@pdf", pdf);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);
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
