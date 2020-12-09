using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IAcciones<T>
    {
        void Guardar(T save);
        List<T> ConsultarTodo();
        void Eliminar(T delete);
        T DataReaderMapToPerson(OracleDataReader dataReader);
    }
}
