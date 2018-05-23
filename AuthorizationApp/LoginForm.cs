using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationApp
{
    public partial class LoginForm : Form
    {
        AccountService accountService;
        bool IsTheUser;
        public LoginForm()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void button_Login_OK_Click(object sender, EventArgs e)
        {
            IsTheUser = true;
            TextBoxToWhite();
            TextBoxToRed();
            if(IsTheUser)
            {
                accountService.Authorization(CreateLogModel());
                var homePage = new HomePage();
                homePage.Show();
                Close();
            }
        }
        private void TextBoxToWhite()
        {
            Login_LogForm.BackColor = Color.White;
            Password_LogForm.BackColor = Color.White;
        }
        private void TextBoxToRed ()
        {
            if (!(ValidatorService.IsLogin(Login_LogForm.Text.ToString()))) { Login_LogForm.BackColor = Color.Red; IsTheUser = false; }
            if (!(ValidatorService.IsPassword(Password_LogForm.Text.ToString(), Login_LogForm.Text.ToString()))) { Password_LogForm.BackColor = Color.Red; IsTheUser = false; }
        }
        private AurhorizationModel CreateLogModel()
        {
            AurhorizationModel model = new AurhorizationModel();
            model.Login = Login_LogForm.Text;
            model.Password = Password_LogForm.Text;
            return model;
        }

    }
}
