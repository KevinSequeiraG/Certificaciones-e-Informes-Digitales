using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class TarjetaDAL
    {
        public static void Guardar(Entities.Tarjeta tarjeta)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarTarjeta";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", tarjeta.id);
                    comando.Parameters.AddWithValue("@idUser", tarjeta.idUser);
                    comando.Parameters.AddWithValue("@fechaVenc", tarjeta.fechaVenc);
                    comando.Parameters.AddWithValue("@cvv", tarjeta.cvv);
                    comando.Parameters.AddWithValue("@tipo", tarjeta.tipo);

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
        public static void Editar(int id, string idUser, DateTime fechaVenc, int cvv, string tipo)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarTarjeta";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@idUser", idUser);
                    comando.Parameters.AddWithValue("@fechaVenc", fechaVenc);
                    comando.Parameters.AddWithValue("@cvv", cvv);
                    comando.Parameters.AddWithValue("@tipo", tipo);

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
                    string sql = @"SP_EliminarTarjeta";

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
        public static List<Entities.Tarjeta> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Tarjeta> lista = new List<Entities.Tarjeta>();
                    string sql = @"SP_VerTarjeta";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Tarjeta tarjeta = new Entities.Tarjeta();
                        tarjeta.id = Convert.ToInt32(reader["id"]);
                        tarjeta.idUser = reader["Nombre"].ToString();
                        tarjeta.fechaVenc = Convert.ToDateTime(reader["Apellido1"]);
                        tarjeta.cvv = Convert.ToInt32(reader["Apellido2"]);
                        tarjeta.tipo = (Enums.TipoTarjeta)Convert.ToInt32(reader["FechaNacimiento"].ToString());
                        lista.Add(tarjeta);
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
        public static Entities.Tarjeta VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerTarjetaID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Tarjeta tarjeta = new Entities.Tarjeta();
                        tarjeta.id = Convert.ToInt32(reader["id"]);
                        tarjeta.idUser = reader["Nombre"].ToString();
                        tarjeta.fechaVenc = Convert.ToDateTime(reader["Apellido1"]);
                        tarjeta.cvv = Convert.ToInt32(reader["Apellido2"]);
                        tarjeta.tipo = (Enums.TipoTarjeta)Convert.ToInt32(reader["FechaNacimiento"].ToString());
                        return tarjeta;
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

        public static List<Entities.Tarjeta> VerTarjetasUsuario(string userEmail)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Tarjeta> lista = new List<Entities.Tarjeta>();
                    string sql = @"SP_VerTarjetaUsuario";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@email", userEmail);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Tarjeta tarjeta = new Entities.Tarjeta();
                        tarjeta.id = Convert.ToInt32(reader["id"]);
                        tarjeta.idUser = reader["idUser"].ToString();
                        tarjeta.fechaVenc = Convert.ToDateTime(reader["fechaVenc"]);
                        tarjeta.cvv = Convert.ToInt32(reader["cvv"]);
                        tarjeta.tipo =(Enums.TipoTarjeta)Convert.ToInt32(reader["tipo"].ToString());
                        lista.Add(tarjeta);
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
