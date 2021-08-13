using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class LineaDetalleDAL
    {
        /// <summary>
        /// Funcion que permite guardar una linea detalle en la base de datos
        /// </summary>
        /// <param name="linea">linea detalle a guardar</param>
        public static void Guardar(Entities.LineaDetalle linea)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarLineaDetalle";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@idCarrito", linea.idCarrito);
                    comando.Parameters.AddWithValue("@idCert", linea.idCert);
                    comando.Parameters.AddWithValue("@cant", linea.cant); 
                    if (linea.idPersonaF == "")
                    {
                        var personaF = DBNull.Value;
                        string personaJ = linea.idPersonaJ;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    if (linea.idPersonaJ == "")
                    {
                        var personaJ = DBNull.Value;
                        string personaF = linea.idPersonaF;
                        comando.Parameters.AddWithValue("@idPersonaJ", personaJ);
                        comando.Parameters.AddWithValue("@idPersonaF", personaF);
                    }
                    comando.Parameters.AddWithValue("@idBien", linea.idBien);

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
        /// Funcion que permite editar una linea detalle
        /// </summary>
        /// <param name="id">id de la linea detalle</param>
        /// <param name="idCarrito">id del carro a la que pertenece la linea detalle</param>
        /// <param name="idCert">id de la certificacion que se compro</param>
        /// <param name="cant">cantidad de certificaciones compradas</param>
        /// <param name="idPersona">id de la persona a la que pertenece la certificacion</param>
        public static void Editar(int id, int idCarrito, int idCert, int cant, string idPersona)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarLineaDetalle";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@idCarrito", idCarrito);
                    comando.Parameters.AddWithValue("@idCert", idCert);
                    comando.Parameters.AddWithValue("@cant", cant);
                    comando.Parameters.AddWithValue("@idPersona", idPersona);

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
        /// Funcion que permite eliminar una linea detalle
        /// </summary>
        /// <param name="idCarro">id del carro a la que pertenece la linea detalle</param>
        /// <param name="idCert">id de la certificacion que se compro</param>
        public static void Eliminar(int idCarro, int idCert)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarLineaDetalle";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@idCarro", idCarro);
                    comando.Parameters.AddWithValue("@idCert", idCert);

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
        /// Funcion que permite ver todas las lineas de detalle en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Entities.LineaDetalle> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.LineaDetalle> lista = new List<Entities.LineaDetalle>();
                    string sql = @"SP_VerLineaDetalle";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.LineaDetalle linea = new Entities.LineaDetalle();
                        linea.id = Convert.ToInt32(reader["id"]);
                        linea.idCarrito = Convert.ToInt32(reader["idCarrito"]);
                        linea.idCert = Convert.ToInt32(reader["idCert"]);
                        linea.cant = Convert.ToInt32(reader["cant"]);
                        linea.idPersonaJ = reader["idPersonaJ"].ToString();
                        linea.idPersonaF = reader["idPersonaF"].ToString();
                        linea.idBien = Convert.ToInt32(reader["idBien"]);
                        lista.Add(linea);
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
        /// Funcion que permite ver una linea detalle por id
        /// </summary>
        /// <param name="ID">id de la linea de detalle</param>
        /// <returns></returns>
        public static Entities.LineaDetalle VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerLineaDetalleID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.LineaDetalle linea = new Entities.LineaDetalle();
                        linea.id = Convert.ToInt32(reader["id"]);
                        linea.idCarrito = Convert.ToInt32(reader["idCarrito"]);
                        linea.idCert = Convert.ToInt32(reader["idCert"]);
                        linea.cant = Convert.ToInt32(reader["cant"]);
                        linea.idPersonaJ = reader["idPersonaJ"].ToString();
                        linea.idPersonaF = reader["idPersonaF"].ToString();
                        linea.idBien = Convert.ToInt32(reader["idBien"]);
                        return linea;
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
