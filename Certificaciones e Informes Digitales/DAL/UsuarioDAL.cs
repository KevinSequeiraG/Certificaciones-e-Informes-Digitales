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
    class UsuarioDAL
    {
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

        public static Entities.Usuario TraerUsuario()
        {

        }
    }
}
