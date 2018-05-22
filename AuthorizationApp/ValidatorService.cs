using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AuthorizationApp
{
    class ValidatorService
    {
        public string name;
        public string lastname;
        public string login;
        public string passw;
        public string email;
        public string numb;
        public string course;
        public string group;
        public string fuculty;
        public string university;
        public string haveGrand;
        public string gender;
        public string studentTicket;



        public ValidatorService(string name, string lastname, string login, string passw,
             string email, string numb, string course, string group, string fuculty, string university,
             string haveGrand, string gender, string studentTicket)
        {
           this.name=name;
            this.lastname=lastname;
            this.login=login;
            this.passw=passw;
            this.email=email;
            this.numb=numb;
            this.course=course;
            this.group=group;
            this.fuculty=fuculty;
            this.university=university;
            this.haveGrand=haveGrand;
            this.gender=gender;
            this.studentTicket=studentTicket;
    }
        public int Validation()
        { 
            var emailRegex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
          
            foreach(User el in Data.Users)
            {
                if (!(emailRegex.IsMatch(user.Email))) return 1;
                if (el.Login == user.Login) return 2;

                /*......*/
            }
            return 0;
        }
    }
}
