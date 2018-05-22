using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationApp
{
    class AccountService
    {
       
        public AccountService()
        {
           
        }

        public void Registration(string name, string lastname, string login, string passw,
             string email, string numb, string cours, string group, string faculty, string university,
             string haveGrand, string gender, string studentTicket)
        {
            User user = new User();
            user.Name = name;
            user.LastName = lastname;
            user.Login = login;
            user.Password = passw;
            user.Email = email;
            user.Number = numb;
            user.Cours = Convert.ToInt32(cours);
            user.Group = group;
            user.Faculty = faculty;
            user.University = university;
            user.HaveGrand = Convert.ToBoolean(Convert.ToInt32(haveGrand));
            user.Sex = (Gender)Convert.ToInt32(gender);
            user.StudentTicket = studentTicket;
            Data.Users.Add(user);
        }

        public void Authorization(string login, string password)
        {
            User user=new User();
            foreach (User el in Data.Users)
            {
                if (el.Login == login && el.Password == password) user = el;
            }
            var singleton = Singleton.getInstance(user);
        }
    }
}
