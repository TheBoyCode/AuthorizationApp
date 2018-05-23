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
            user.Id = Guid.NewGuid().ToString();
            Data.ReadFromFile();
            Data.Users.Add(user);
            Data.WriteToFile();
        }

        public void Authorization(string login, string password)
        {
            Data.ReadFromFile();
            foreach (User el in Data.Users)
            {
                if (el.Login == login && el.Password == password)
                {
                    var singleton = Singleton.getInstance(el);
                }
            }
        }


        public void Edition(RegistrationModel model)
        {
            User user = new User();
            Singleton singleton = Singleton.getInstance(user);

            singleton.User.Cours = Convert.ToInt32(model.cours);
            singleton.User.Email = model.email;
            singleton.User.Faculty = model.faculty;
            singleton.User.Group = model.group;
            singleton.User.HaveGrand = Convert.ToBoolean(Convert.ToInt32(model.haveGrand));
            singleton.User.LastName = model.lastname;
            singleton.User.Name = model.name;
            singleton.User.Number = model.numb;
            singleton.User.Password = model.passw;
            singleton.User.Sex = (Gender)Convert.ToInt32(model.gender);
            singleton.User.StudentTicket = model.studentTicket;
            singleton.User.University = model.university;
            Data.WriteToFile();
        }
    }
}
