using Certificaciones_e_Informes_Digitales.Entities;
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
    class UsuarioDAL
    {
        /// <summary>
        /// Funcion que permite guardar un usuario
        /// </summary>
        /// <param name="usuario">usuario a guardar</param>
        public static void InsertarUsuario(Usuario usuario)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarUser";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", usuario.Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", usuario.Apellido2);
                    comando.Parameters.AddWithValue("@telefono", usuario.telefono);
                    comando.Parameters.AddWithValue("@email", usuario.email);
                    comando.Parameters.AddWithValue("@password", usuario.password);
                    comando.Parameters.AddWithValue("@Change_password", usuario.changePassword);
                    comando.Parameters.AddWithValue("@Tipo", usuario.tipo);

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
        /// Funcion que permite editar la contraseña de un usuario
        /// </summary>
        /// <param name="email">coreo de usuario</param>
        /// <param name="password">constraseña nueva</param>
        /// <param name="cambioAutomatico">Permite al sistema conocer si el usuario debe o no hacer un cambio de contraseña al ingresar</param>
        public static void EditarContrasenna(string email, string password, bool cambioAutomatico)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarContrasennaUser";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@contra", password);

                    //cambioAutomatico permite saber si es un password temporal(true) o bien uno creado por el usuario(false)
                    comando.Parameters.AddWithValue("@change", cambioAutomatico);

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
        /// Funcion que permite ver usuario
        /// </summary>
        /// <param name="email">correo de usuario</param>
        /// <param name="passw">contraseña de usuario</param>
        /// <returns></returns>
        public static Entities.Usuario TraerUsuario(string email, string passw)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_UsuarioPorEmail";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@contra", passw);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Usuario user = new Usuario();
                        user.Nombre = reader["Nombre"].ToString();
                        user.Apellido1 = reader["Apellido1"].ToString();
                        user.Apellido2 = reader["Apellido2"].ToString();
                        user.telefono = Convert.ToInt32(reader["Telefono"]);
                        user.email = reader["Email"].ToString();
                        user.password = reader["Password"].ToString();
                        user.changePassword = Convert.ToBoolean(reader["ChangePassword"]);
                        user.tipo = (Enums.TipoUsuario)(Convert.ToInt32(reader["Tipo"]));
                        return user;
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
        /// Funcion que permite ver todos los usuarios de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> TraerUsuarioPorCorreo(string email)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Usuario> lista = new List<Usuario>();
                    string sql = @"SP_TraerUserEmail";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@email", email);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.Usuario user = new Usuario();
                        user.Nombre = reader["Nombre"].ToString();
                        user.Apellido1 = reader["Apellido1"].ToString();
                        user.Apellido2 = reader["Apellido2"].ToString();
                        user.telefono = Convert.ToInt32(reader["Telefono"]);
                        user.email = reader["Email"].ToString();
                        user.password = reader["Password"].ToString();
                        user.changePassword = Convert.ToBoolean(reader["ChangePassword"]);
                        user.tipo = (Enums.TipoUsuario)(Convert.ToInt32(reader["Tipo"]));
                        lista.Add(user);
                        return lista;
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
        /// Retorna un usario por correo electronico
        /// </summary>
        /// <param name="email">correo de usuario</param>
        /// <returns></returns>
        public static List<Usuario> VerUsuarios()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    List<Usuario> lista = new List<Usuario>();
                    string sql = @"SP_VerUsuario";

                    var comando = new SqlCommand(sql);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entities.Usuario user = new Usuario();
                        user.Nombre = reader["Nombre"].ToString();
                        user.Apellido1 = reader["Apellido1"].ToString();
                        user.Apellido2 = reader["Apellido2"].ToString();
                        user.telefono = Convert.ToInt32(reader["Telefono"]);
                        user.email = reader["Email"].ToString();
                        user.password = reader["Password"].ToString();
                        user.changePassword = Convert.ToBoolean(reader["ChangePassword"]);
                        user.tipo = (Enums.TipoUsuario)(Convert.ToInt32(reader["Tipo"]));
                        lista.Add(user);
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
        /// Permite eliminar un usuario
        /// </summary>
        /// <param name="email">correo de usuario a eliminar</param>
        public static void EliminarUsuario(string email)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarUser";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@email", email);

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
        /// Funcion que permite editar un usuario
        /// </summary>
        /// <param name="Nombre">Nomre de usuario</param>
        /// <param name="Apellido1">Primer apellido de usuario</param>
        /// <param name="Apellido2">Segundo apellido de usuario</param>
        /// <param name="telefono">telefono de usuario</param>
        /// <param name="email">correo de usuario</param>
        /// <param name="password">Contraseña de usuario</param>
        /// <param name="changePassword">Permite conocer al sistema si el usuario debe hacer cambio de contraseña o no</param>
        /// <param name="tipo">tipo de usuario</param>
        public static void editarUsuario(string Nombre, string Apellido1, string Apellido2, int telefono, string email, string password, bool changePassword, Enums.TipoUsuario tipo)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EditarUser";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", Apellido2);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@password", password);
                    comando.Parameters.AddWithValue("@Change_password", changePassword);
                    comando.Parameters.AddWithValue("@Tipo", tipo);

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
    }
}
