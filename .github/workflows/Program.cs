using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = @"Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = ORCL))); ;user id = xx; Password = xxx";
           
            OracleConnection conn = new OracleConnection(sqlConnection);
            OracleCommand cmd = new OracleCommand("pkg_rebellionrider.proc_superhero ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
         
            cmd.Parameters.Add("f_name", "varchar2").Value = "Julia";
            cmd.Parameters.Add("l_name", "varchar2").Value = "Roberts";

            conn.Open();
            cmd.ExecuteNonQuery();
            Console.ReadLine();



        }
    }
}
