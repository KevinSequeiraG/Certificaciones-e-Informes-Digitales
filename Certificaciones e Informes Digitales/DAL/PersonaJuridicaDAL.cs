using Certificaciones_e_Informes_Digitales.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.DAL
{
    class PersonaJuridicaDAL
    {
        public static void Guardar(Entities.PersonaJuridica pj)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_AgregarPersonaJuridica";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", pj.id);
                    comando.Parameters.AddWithValue("@RazonSocial", pj.razonSocial);
                    comando.Parameters.AddWithValue("@Estado", pj.estado);
                    comando.Parameters.AddWithValue("@FechaInsc", pj.FechaInsc);
                    comando.Parameters.AddWithValue("@tomo", pj.tomo);
                    comando.Parameters.AddWithValue("@asiento", pj.asiento);
                    comando.Parameters.AddWithValue("@Domicilio", pj.domicilio);
                    comando.Parameters.AddWithValue("@Objeto", pj.objeto);

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
