using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class NombramientoDAL
    {
        public static void Guardar(Entities.Nombramiento nombramiento)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarNombramiento";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", nombramiento.id);
                    comando.Parameters.AddWithValue("@Nombre", nombramiento.Nombre);
                    comando.Parameters.AddWithValue("@Cargo", nombramiento.Cargo);
                    comando.Parameters.AddWithValue("@FechaInsc", nombramiento.FechaInsc);
                    comando.Parameters.AddWithValue("@VigenciaIni", nombramiento.VigenciaIni);
                    comando.Parameters.AddWithValue("@VigenciaVenc", nombramiento.VigenciaVenc);
                    comando.Parameters.AddWithValue("@idPersonaJuridica", nombramiento.idPersonaJuridica);

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
