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
            var singleton = Singleton.getInstance();
            singleton.WriteToDB(model);
            Singleton.Delete();
        }

        public void Authorization(AurhorizationModel model)
        {
            var singleton = Singleton.getInstance();
            singleton.ToSigleton(model.Login);
        }


        public void Edition(RegistrationModel model)
        {
            User user = new User();
            Singleton singleton = Singleton.getInstance();
            singleton.userModel.cours = Convert.ToInt32(model.cours);
            singleton.userModel.email = model.email;
            singleton.userModel.faculty = model.faculty;
            singleton.userModel.group = model.group;
            singleton.userModel.haveGrand = model.haveGrand;
            singleton.userModel.lastname = model.lastname;
            singleton.userModel.name = model.name;
            singleton.userModel.numb = model.numb;
            singleton.userModel.passw = model.passw;
            singleton.userModel.gender = Convert.ToInt32(model.gender);
            singleton.userModel.studentTicket = model.studentTicket;
            singleton.userModel.university = model.university;
           
        }
    }
}
