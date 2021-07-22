using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class TarjetaDAL
    {
        public static void Guardar(Entities.Tarjeta tarjeta)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarTarjeta";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", tarjeta.id);
                    comando.Parameters.AddWithValue("@idUser", tarjeta.idUser);
                    comando.Parameters.AddWithValue("@fechaVenc", tarjeta.fechaVenc);
                    comando.Parameters.AddWithValue("@cvv", tarjeta.cvv);
                    comando.Parameters.AddWithValue("@tipo", tarjeta.tipo);

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
