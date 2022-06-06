using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01DatabaseConnection
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL conection is opening");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection is closing");
        }
    }
}
