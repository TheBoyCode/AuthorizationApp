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
       public string Login { get; set; }
        public string Password { get; set; }
        public AurhorizationModel (string login, string password)
        {
            Login = login;
            Password = password;
        }
        public bool Authorization()
        {
            if (Login == "" || Password == "") MessageBox.Show("Fill in textbox!");
            else
            {
                int count = 0;
                foreach (User element in Data.Users)
                {
                    if (Data.Users[count].Login == Login && Data.Users[count].Password == Password)
                    {
                        return true;
                    }
                    count++;
                }
            }
            MessageBox.Show("Login or Password is wrong!");
            return false;
        }
    }
}
