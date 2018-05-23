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

        public void Registration(RegistrationModel model )
        {
            User user = new User();
            user.Name = model.name;
            user.LastName = model.lastname;
            user.Login = model.login;
            user.Password = model.passw;
            user.Email = model.email;
            user.Number = model.numb;
            user.Cours = Convert.ToInt32(model.cours);
            user.Group = model.group;
            user.Faculty = model.faculty;
            user.University = model.university;
            user.HaveGrand = Convert.ToBoolean(Convert.ToInt32(model.haveGrand));
            user.Sex = (Gender)Convert.ToInt32(model.gender);
            user.StudentTicket = model.studentTicket;
            user.Id = Guid.NewGuid().ToString();
            Data.ReadFromFile();
            Data.Users.Add(user);
            Data.WriteToFile();
        }

        public void Authorization(AurhorizationModel model)
        {
            Data.ReadFromFile();
            foreach (User el in Data.Users)
            {
                if (el.Login == model.Login && el.Password == model.Password)
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
