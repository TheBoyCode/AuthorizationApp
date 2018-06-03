using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Npgsql;
namespace AuthorizationApp
{
    static class Data
    {
        public static User user { get; set; }

        public static void ToSigleton(string login)
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
            var userModel = new UserModel();
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

        public static void WriteToFile()
        {

        }
    }
}
