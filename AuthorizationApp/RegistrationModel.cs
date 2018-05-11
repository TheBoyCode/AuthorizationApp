using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationApp
{
    class RegistrationModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }

        public RegistrationModel(string name, string lastname, string login , string password, string email, string number)
        {
            Name = name;
            LastName = lastname;
            Login = login;
            Password = password;
            Email = email;
            Number = number;
        }
       public void Registration()
        {

            if (
               Name == "" || LastName== "" || Login == "" ||
                Password == "" || Email == "" || Number == ""
                   ) MessageBox.Show("Fill in all information!");
            else
            {
                User user = new User();
                user.Name = Name;
                user.LastName = LastName;
                user.Login = Login;
                user.Password = Password;
                user.Email = Email;
                user.Number = Number;
                Data.Users.Add(user);
            }

        }
    }
}
