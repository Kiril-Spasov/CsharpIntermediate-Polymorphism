using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01DatabaseConnection
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle conection is opening");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closing");
        }
    }
}
