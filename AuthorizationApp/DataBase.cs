using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace AuthorizationApp
{
    public static class DataBase
    {
        public static NpgsqlConnection conn { get; set; }
        public static void ConectionToDataBase(string connstring)
        {
             conn = new NpgsqlConnection(connstring);
        }
       
    }
}
