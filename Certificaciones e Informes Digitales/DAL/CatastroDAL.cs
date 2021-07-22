using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CatastroDAL
    {
        public static void Guardar(Entities.Catastro catastro)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCatastro";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", catastro.id);
                    comando.Parameters.AddWithValue("@idPersona", catastro.idPersona);
                    comando.Parameters.AddWithValue("@localizacion", catastro.localizacion);
                    comando.Parameters.AddWithValue("@usoLocal", catastro.usoLocal);
                    comando.Parameters.AddWithValue("@annoConst", catastro.annoConst);
                    comando.Parameters.AddWithValue("@tamanno", catastro.tamanno);

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
