using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificaciones_e_Informes_Digitales.Persistencia
{
    public interface IDataBase:IDisposable
    {
        IDbConnection _Conexion { get; set; }
        double ExecuteNonQuery(IDbCommand pCommand);
        int ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel);
        int ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel);
        double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel);
        IDataReader ExecuteReader(IDbCommand pCommand);
        DataSet ExecuteReader(IDbCommand pCommand, string pTabla);
        double ExecuteScalar(IDbCommand pCommand);
    }
}
