using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationApp
{
    class Singleton
    {
        private static Singleton instance;
        public User User { get; set; }
        private Singleton(User user)
        {
            User = user;
        }

        public static Singleton getInstance(User user)
        {
            if (instance == null)
            {
                instance = new Singleton(user);
            }
            return instance;
        }
    }
}
