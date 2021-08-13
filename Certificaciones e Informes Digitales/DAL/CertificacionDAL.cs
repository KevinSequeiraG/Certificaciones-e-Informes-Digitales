using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CertificacionDAL
    {
        /// <summary>
        /// Funcion que permite guardar una certificacion en la base de datos
        /// </summary>
        /// <param name="certificacion">certificacion a guardar</param>
        public static void Guardar(Entities.Certificacion certificacion)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCert";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", certificacion.id);
                    comando.Parameters.AddWithValue("@tipo", certificacion.tipo);
                    comando.Parameters.AddWithValue("@detalle", certificacion.detalle);
                    comando.Parameters.AddWithValue("@precio", certificacion.precio);

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
        /// Funcion que permite editar una certificacion en la base de datos
        /// </summary>
        /// <param name="id">id de la certificacion</param>
        /// <param name="tipo">tipo de certificacion</param>
        /// <param name="detalle">detalle de certificacion</param>
        /// <param name="precio">precio de certificacion</param>
        public static void Editar(int id, string tipo, string detalle, double precio)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarCert";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@detalle", detalle);
                    comando.Parameters.AddWithValue("@precio", precio);

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
        /// Funcion que permite eliminar una certificacion
        /// </summary>
        /// <param name="id">id de certificacion</param>
        public static void Eliminar(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarCertificacion";

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
        /// Funcion que permite ver todas las certificaciones de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Entities.Certificacion> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Certificacion> lista = new List<Entities.Certificacion>();
                    string sql = @"SP_VerCert";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Certificacion cert = new Entities.Certificacion();
                        cert.id = Convert.ToInt32(reader["id"]);
                        cert.tipo = reader["Tipo"].ToString();
                        cert.detalle = reader["Detalle"].ToString();
                        cert.precio = Convert.ToDouble(reader["Precio"]);
                        lista.Add(cert);
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
        /// Funcion que permite ver por id una certificacion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Entities.Certificacion VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerCertificacionID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Certificacion cert = new Entities.Certificacion();
                        cert.id = Convert.ToInt32(reader["id"]);
                        cert.tipo = reader["Tipo"].ToString();
                        cert.detalle = reader["Detalle"].ToString();
                        cert.precio = Convert.ToDouble(reader["Precio"]);
                        return cert;
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
        /// Funcion que permite ver las certificaciones por tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static List<Entities.Certificacion> VerPorTipo(string tipo)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Certificacion> lista = new List<Entities.Certificacion>();
                    string sql = @"SP_VerCertTipo";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Tipo", tipo);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Certificacion cert = new Entities.Certificacion();
                        cert.id = Convert.ToInt32(reader["id"]);
                        cert.tipo = reader["Tipo"].ToString();
                        cert.detalle = reader["Detalle"].ToString();
                        cert.precio = Convert.ToDouble(reader["Precio"]);
                        lista.Add(cert);
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
