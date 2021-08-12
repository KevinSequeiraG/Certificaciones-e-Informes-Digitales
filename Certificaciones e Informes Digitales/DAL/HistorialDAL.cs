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
        public static void Guardar(byte[] pdf, string idUser, DateTime fecha, string detalleCert)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarAHistorial";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@PDF", pdf);
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
    }
}
