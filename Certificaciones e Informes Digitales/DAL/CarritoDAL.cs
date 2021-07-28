using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CarritoDAL
    {
        public static void Guardar(Entities.Carrito carro)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCarrito";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", carro.id);
                    comando.Parameters.AddWithValue("@usuario", carro.usuario);
                    comando.Parameters.AddWithValue("@total", carro.total);
                    comando.Parameters.AddWithValue("@subtotal", carro.subtotal);
                    comando.Parameters.AddWithValue("@impuestos", carro.impuestos);

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
        public static void Editar(int id, Entities.Usuario usuario, double total, double subTotal, double impuestos)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarCarrito";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@total", total);
                    comando.Parameters.AddWithValue("@subTotal", subTotal);
                    comando.Parameters.AddWithValue("@impuestos", impuestos);

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
                    string sql = @"SP_EliminarCarrito";

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
        public static List<Entities.Carrito> Ver()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Carrito> lista = new List<Entities.Carrito>();
                    string sql = @"SP_VerCarrito";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Carrito carro = new Entities.Carrito();
                        carro.id = Convert.ToInt32(reader["id"]);
                        carro.usuario = (Entities.Usuario)reader["usuario"];
                        carro.total = Convert.ToDouble(reader["total"]);
                        carro.subtotal = Convert.ToDouble(reader["subtotal"]);
                        carro.impuestos = Convert.ToDouble(reader["impuestos"]);
                        lista.Add(carro);
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
        public static Entities.Carrito VerPorID(int ID)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"VerCarritoID";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Carrito carro = new Entities.Carrito();
                        carro.id = Convert.ToInt32(reader["id"]);
                        carro.usuario = (Entities.Usuario)reader["usuario"];
                        carro.total = Convert.ToDouble(reader["total"]);
                        carro.subtotal = Convert.ToDouble(reader["subtotal"]);
                        carro.impuestos = Convert.ToDouble(reader["impuestos"]);
                        return carro;
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
