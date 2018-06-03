using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace AuthorizationApp
{
     class Singleton
    {
        public UserModel userModel;
        private static Singleton instance=null;
        private Singleton()
        {
        }
        public static bool IsLogin(string login,string password)
        { 
            string isPass = "";
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
                "User Id=postgres;Password=root;Database=application;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select name From u WHERE login='" + login + "',password='"+password+"';", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                isPass = (string)dr[0];
            }
            if (isPass == "") return false;
            else return true;
        }
        public static bool IsLogin(string login)
        {
            string isNull="";
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
                "User Id=postgres;Password=root;Database=application;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select name From u WHERE login='" + login + "';", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               isNull = (string)dr[0];
            }
            if (isNull == "") return false;
            else return true;
        }
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public static void Delete ()
        {
            instance = null;  
        }
        public void ToSigleton(string login)
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
                "User Id=postgres;Password=root;Database=application;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select name,lastname,login,password,course,faculty,email,numberphone,groupe,university,sex,studentticket From u WHERE login='" + login + "';", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            userModel = new UserModel();
            while (dr.Read())
            {
                userModel.name = (string)dr[0];
                userModel.lastname = (string)dr[1];
                userModel.login = (string)dr[2];
                userModel.passw = (string)dr[3];
                userModel.cours = (int)dr[4];
                userModel.faculty = (string)dr[5];
                userModel.email = (string)dr[6];
                userModel.numb = (string)dr[7];
                userModel.group = (string)dr[8];
                userModel.university = (string)dr[9];
                userModel.gender = (int)dr[10];
                userModel.studentTicket = (string)dr[11];
            }


        }

        public  void WriteToDB(RegistrationModel registrationModel)
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
                "User Id=postgres;Password=root;Database=application;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
            string id = Guid.NewGuid().ToString();
            string info = @"INSERT INTO u(c_no,name,lastname,login,password,course,faculty,email,numberphone," +
                @"groupe,university,sex,studentticket) VALUES('"+Guid.NewGuid().ToString() +"',"+
                "'"+ registrationModel.name+"','"+ registrationModel.lastname +"','"+ registrationModel.login+"','"+ registrationModel.passw+"','"+
               registrationModel.cours+"','"+ registrationModel.faculty+"'," +
                @"'"+ registrationModel.email+"'," +"'"+ registrationModel.numb+"','"+ registrationModel.group+"','"+ registrationModel.university+"',"+
                registrationModel.gender+",'"+ registrationModel.studentTicket+"')";
            NpgsqlCommand cmdW = new NpgsqlCommand(info, conn);
            cmdW.ExecuteNonQuery();

        }

        public void EditDB(EditionModel editionModel)
        {
            string info = @"UPDATE u SET name = '"+editionModel.name+"'," +
                "lastname='"+ editionModel.lastname + "',password= '"+ editionModel .passw+"',"+
                "course= '" + editionModel.cours + "'," + "faculty= '" + editionModel.faculty + "'," +
                "email= '" + editionModel.email + "'," + "numberphone= '" + editionModel.numb + "'," +
                "groupe= '" + editionModel.group + "'," + "university= '" + editionModel.university + "'," +
                "sex= '" + editionModel.gender + "'," + "studentticket= '" + editionModel.studentTicket + "' " +
                " WHERE login = '" +editionModel.login+"';";
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
                "User Id=postgres;Password=root;Database=application;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
            string id = Guid.NewGuid().ToString();
            NpgsqlCommand cmdW = new NpgsqlCommand(info, conn);
            cmdW.ExecuteNonQuery();
            conn.Close();
        }
    }
}
