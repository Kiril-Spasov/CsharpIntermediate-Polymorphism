using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01DatabaseConnection
{
    internal abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan timeout;

        public DbConnection(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
                throw new InvalidOperationException("Link is not valid");
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
