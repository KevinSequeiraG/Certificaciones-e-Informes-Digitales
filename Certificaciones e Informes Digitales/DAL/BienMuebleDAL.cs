using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class BienMuebleDAL
    {
        public static void Guardar(Entities.BienesMuebles bien)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarBienesMuebles";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", bien.id);
                    comando.Parameters.AddWithValue("@idPersona", bien.idPersona);
                    comando.Parameters.AddWithValue("@Marca", bien.marca);
                    comando.Parameters.AddWithValue("@Categoria", bien.Categoria);
                    comando.Parameters.AddWithValue("@Serie", bien.serie);
                    comando.Parameters.AddWithValue("@Traccion", bien.traccion);
                    comando.Parameters.AddWithValue("@AnnoFabricacion", bien.annoFabricacion);
                    comando.Parameters.AddWithValue("@Color", bien.Color);
                    comando.Parameters.AddWithValue("@Capacidad", bien.capacidad);
                    comando.Parameters.AddWithValue("@ValorHacienda", bien.valorHacienda);
                    comando.Parameters.AddWithValue("@Estado", bien.estado);
                    comando.Parameters.AddWithValue("@uso", bien.uso);
                    comando.Parameters.AddWithValue("@Moneda", bien.moneda);

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
