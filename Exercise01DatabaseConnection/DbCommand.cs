using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01DatabaseConnection
{
    internal class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;
        public DbCommand(DbConnection dbconnection, string instruction)
        {
            if (dbconnection == null)
                throw new InvalidOperationException("Link is not valid");

            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Instruction is not valid");

            _dbConnection = dbconnection;
            _instruction = instruction;

        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Instruction");
            _dbConnection.CloseConnection();
        }

    }
}
