using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class LineaDetalleDAL
    {
        public static void Guardar(Entities.LineaDetalle linea)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarLineaDetalle";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", linea.id);
                    comando.Parameters.AddWithValue("@idCarrito", linea.idCarrito);
                    comando.Parameters.AddWithValue("@idCert", linea.idCert);
                    comando.Parameters.AddWithValue("@cant", linea.cant);
                    comando.Parameters.AddWithValue("@idPersona", linea.idPersona);

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
