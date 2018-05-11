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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Data.Users = new List<User>();
        }

        private void button_Log_Click(object sender, EventArgs e)
        {
           var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            RegistrationForm RegistrationForm = new RegistrationForm();
            RegistrationForm.Show();
        }
    }
}
