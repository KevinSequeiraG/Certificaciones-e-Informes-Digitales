using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CertificacionDAL
    {
        public static void Guardar(Entities.Certificacion certificacion)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCert";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", certificacion.id);
                    comando.Parameters.AddWithValue("@tipo", certificacion.tipo);
                    comando.Parameters.AddWithValue("@detalle", certificacion.detalle);
                    comando.Parameters.AddWithValue("@precio", certificacion.precio);

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
