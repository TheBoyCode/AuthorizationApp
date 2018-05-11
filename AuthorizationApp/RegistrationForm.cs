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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            
        }
        
        private void button_OK_Reg_Click(object sender, EventArgs e)
        {
           RegistrationModel registrationModel = new RegistrationModel(textBox_name.Text,textBox_lastname.Text ,
               textBox_login.Text , textBox_passw.Text , textBox_email.Text ,textBox_numb.Text);
            registrationModel.Registration();
            Close();
        }
        
    }
}
