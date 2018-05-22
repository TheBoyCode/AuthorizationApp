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
        private User user;
     
        public RegistrationModel(User user)
        {
            this.user = user;
            
        }
        public bool  ValidationOfRegistration(User user)
        {
            foreach (User el in Data.Users)
            {
                if (el.Login == user.Login) return false;

            }


            return true;
        }
    }
}
