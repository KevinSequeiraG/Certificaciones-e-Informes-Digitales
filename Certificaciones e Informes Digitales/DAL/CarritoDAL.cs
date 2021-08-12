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
                    comando.Parameters.AddWithValue("@usuario", carro.usuario.email);
                    comando.Parameters.AddWithValue("@total", carro.total);
                    comando.Parameters.AddWithValue("@subtotal", carro.subtotal);
                    comando.Parameters.AddWithValue("@impuestos", carro.impuestos);
                    comando.Parameters.AddWithValue("@fecha", carro.fecha);

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
                    comando.Parameters.AddWithValue("@usuario", usuario.email);
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

                    BLL.UsuarioBLL logicaUsuario = new BLL.UsuarioBLL();

                    while (reader.Read())
                    {
                        Entities.Carrito carro = new Entities.Carrito();
                        carro.id = Convert.ToInt32(reader["id"]);
                        carro.usuario = logicaUsuario.TraerUsuarioPorCorreo(reader["usuario"].ToString())[0];
                        carro.total = Convert.ToDouble(reader["total"]);
                        carro.subtotal = Convert.ToDouble(reader["subtotal"]);
                        carro.impuestos = Convert.ToDouble(reader["impuestos"]);
                        carro.fecha = Convert.ToDateTime(reader["fecha"]);
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
                        carro.fecha = Convert.ToDateTime(reader["fecha"]);
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

        public static Entities.Carrito VerUltimoCarrito(string email)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_UltimoCarroUser";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@email", email);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Carrito carro = new Entities.Carrito();
                        carro.id = Convert.ToInt32(reader["id"]);

                        BLL.UsuarioBLL logicaUser = new BLL.UsuarioBLL();

                        carro.usuario = logicaUser.TraerUsuarioPorCorreo(reader["usuario"].ToString())[0];
                        carro.total = Convert.ToDouble(reader["total"]);
                        carro.subtotal = Convert.ToDouble(reader["subtotal"]);
                        carro.impuestos = Convert.ToDouble(reader["impuestos"]);
                        carro.fecha = Convert.ToDateTime(reader["fecha"]);
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
        public static List<Entities.LineaDetalle> VerInfoCarrito(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.LineaDetalle> lista = new List<Entities.LineaDetalle>();

                    string sql = @"SP_VerInfoCarrito";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.LineaDetalle linea = new Entities.LineaDetalle();
                        linea.id = Convert.ToInt32(reader["id"]);

                        linea.idCarrito = Convert.ToInt32(reader["idCarrito"]);
                        linea.idPersonaJ = reader["idPersonaJ"].ToString();
                        linea.idPersonaF = reader["idPersonaF"].ToString();
                        linea.idCert = Convert.ToInt32(reader["idCert"]);
                        linea.cant = Convert.ToInt32(reader["cant"]);
                        linea.idBien = Convert.ToInt32(reader["idBien"]);

                        BLL.CertificacionBLL logicaCert = new BLL.CertificacionBLL();
                        Entities.Certificacion cert = logicaCert.VerPorID(linea.idCert);

                        linea.PrecioCert = cert.precio;
                        linea.DetalleCert = cert.detalle;
                        linea.TipoCert = cert.tipo;
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
        public static double CalcularTotal(int idCarro)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    double total = 0;

                    string sql = @"SP_CalcularTotalCarro";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@idCarro", idCarro);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    reader.Read();

                    total = Convert.ToInt32(reader["total"]);

                    return total;
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
        public static List<Entities.Carrito> VerComprasDelMes()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Entities.Carrito> lista = new List<Entities.Carrito>();
                    
                    string sql = @"SP_VerCompraMes";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Carrito carro = new Entities.Carrito();
                        carro.id = Convert.ToInt32(reader["id"]);

                        BLL.UsuarioBLL logicaUser = new BLL.UsuarioBLL();

                        carro.usuario = logicaUser.TraerUsuarioPorCorreo(reader["usuario"].ToString())[0];
                        carro.total = Convert.ToDouble(reader["total"]);
                        carro.subtotal = Convert.ToDouble(reader["subtotal"]);
                        carro.impuestos = Convert.ToDouble(reader["impuestos"]);
                        carro.fecha = Convert.ToDateTime(reader["fecha"]);
                        carro.Correo_Usuario = carro.usuario.email;
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

        public static double CalculaTotalConImpuestos(int idCarro)
        {
            return CalcularTotal(idCarro) + (CalcularTotal(idCarro) * 0.13);
        }
    }
}
