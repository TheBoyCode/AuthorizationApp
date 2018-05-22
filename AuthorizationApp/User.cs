using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationApp
{
    class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int Cours { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public bool HaveGrand{ get; set; }
        public Gender Sex { get; set; }
        public string StudentTicket { get; set; }
        public string Id { get; set; }
    }
}
