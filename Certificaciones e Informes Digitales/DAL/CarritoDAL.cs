using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class CarritoDAL
    {
        public static void Guardar(Entities.Carrito carro)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarCarrito";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", carro.id);
                    comando.Parameters.AddWithValue("@usuario", carro.usuario);
                    comando.Parameters.AddWithValue("@total", carro.total);
                    comando.Parameters.AddWithValue("@subtotal", carro.subtotal);
                    comando.Parameters.AddWithValue("@impuestos", carro.impuestos);

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
