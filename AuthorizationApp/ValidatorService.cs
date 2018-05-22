using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AuthorizationApp
{
   static class ValidatorService
    {
        //public string name;
        //public string lastname;
        //public string login;
        //public string passw;
        //public string email;
        //public string numb;
        //public string course;
        //public string group;
        //public string fuculty;
        //public string university;
        //public string haveGrand;
        //public string gender;
        //public string studentTicket;



    //    public ValidatorService(string name, string lastname, string login, string passw,
    //         string email, string numb, string course, string group, string fuculty, string university,
    //         string haveGrand, string gender, string studentTicket)
    //    {
    //       this.name=name;
    //        this.lastname=lastname;
    //        this.login=login;
    //        this.passw=passw;
    //        this.email=email;
    //        this.numb=numb;
    //        this.course=course;
    //        this.group=group;
    //        this.fuculty=fuculty;
    //        this.university=university;
    //        this.haveGrand=haveGrand;
    //        this.gender=gender;
    //        this.studentTicket=studentTicket;
    //}
       public static bool ValidStr(string name)
        {
            if (name == "") return false;
            else return true;
        }
        public static bool ValidName(string name)
        {
            if (!(Regex.IsMatch(name, @"^[\p{L} \.'\-]+$"))) return false;
            return true;
        }
        public static bool ValidEmail(string email)
        {
            if (!(Regex.IsMatch(email, @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)"))) return false;
            return true;
        }
        public static bool ValidNumber(string number)
        {
            if (number == "") return false;
            if (!(Regex.IsMatch(number, @"^\s*\+?\s*([0-9][\s-]*){9,}$"))) return false;
            else return true;
        }
        public static bool ValidLogin(string login)
        {
            if (login == "") return false;
            if (!(Regex.IsMatch(login, "^[a-zA-Z0-9]+$"))) return false;
            foreach (User el in Data.Users)
            {
                if (el.Login == login) return false;
            }
             return true;
        }
        public static bool ValidHaveGrand(string haveGrand)
        {
            if (!(haveGrand == "1" || haveGrand == "0")) return false;
            return true;
        }
        public static bool ValidStudentTicket(string studentTicket)
        {
            if (!(Regex.IsMatch(studentTicket, @"^[0-9]{10,10}$")))return false;
            return true;
        }
        public static bool ValidGender(string sex)
        {
            if (!(sex=="0" || sex=="1")) return false;
            return true;
        }
        public static bool ValidCours(string cours)
        {
            if (!(Regex.IsMatch(cours, @"^[1-6]{1,1}$"))) return false;
            return true;
        }
    }
}
