using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationApp
{
    class AurhorizationModel
    {
        private Singleton singleton;
        public string Login { get; set; }
        public string Password { get; set; }
        public AurhorizationModel (string login, string password)
        {
            Login = login;
            Password = password;
        }
        public AurhorizationModel()
        {
        }
       
        public void LogOut()
        {
            Singleton.Delete();
        }
    }
}
