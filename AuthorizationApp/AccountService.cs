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

        public int Registration(string name, string lastname, string login, string passw,
             string email, string numb, string course, string group, string fuculty, string university,
             string haveGrand, string gender, string studentTicket)
        {
            var IsValid = new ValidatorService( name, lastname, login,  passw,
             email, numb, course,  group, fuculty,  university,
              haveGrand,  gender,  studentTicket);
            if (IsValid.Validation() != 0)
            {
                return IsValid.Validation();
            }

            else return 0;
        }
    }
}
