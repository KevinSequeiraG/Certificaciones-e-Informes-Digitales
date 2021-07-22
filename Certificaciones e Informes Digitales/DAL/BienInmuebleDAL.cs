using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class BienInmuebleDAL
    {
        public static void Guardar(Entities.BienesInmuebles bien)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarBienesInmuebles";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", bien.id);
                    comando.Parameters.AddWithValue("@idPersona", bien.idPersona);
                    comando.Parameters.AddWithValue("@Provincia", bien.provincia);
                    comando.Parameters.AddWithValue("@Mide", bien.Mide);
                    comando.Parameters.AddWithValue("@ValorFiscal", bien.valorFiscal);
                    comando.Parameters.AddWithValue("@Naturaleza", bien.naturaleza);

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
