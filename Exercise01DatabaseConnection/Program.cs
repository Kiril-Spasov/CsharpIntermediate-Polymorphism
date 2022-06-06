using System;

namespace Exercise01DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("link");

            var oracleConnection = new OracleConnection("link");

            var dbCommand = new DbCommand(oracleConnection, "instruction");
            dbCommand.Execute();

        }
       
    }
}
