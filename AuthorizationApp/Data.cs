using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace AuthorizationApp
{
   static class Data
    {
        public static  List<User> Users {get;set;}
        public static void ReadFromFile()
        {
            Users = new List<User>();
            Users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Users.json"));
        }
        public static void WriteToFile()
        {
            File.WriteAllText("Users.json", JsonConvert.SerializeObject(Users));
        }
    }
}
