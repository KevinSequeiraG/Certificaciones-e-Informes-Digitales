using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class PersonaFisicaDAL
    {
        public static void Guardar(Entities.PersonaFisica pf)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarPersonaFisica";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", pf.id);
                    comando.Parameters.AddWithValue("@Nombre", pf.Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", pf.Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", pf.Apellido2);
                    comando.Parameters.AddWithValue("@FechaNacimiento", pf.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Genero", pf.genero);
                    comando.Parameters.AddWithValue("@Foto", pf.Foto);
                    comando.Parameters.AddWithValue("@email", pf.email);

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
