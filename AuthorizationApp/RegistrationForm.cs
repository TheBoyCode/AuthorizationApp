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
        
        bool IsException;
        AccountService Service;
        public RegistrationForm()
        {
            
            InitializeComponent();
            Service = new AccountService();
        }
        
        private void button_OK_Reg_Click(object sender, EventArgs e)
        {
            IsException = false;
            ToWhiteTextBox();
            FindException();
            if (!(IsException))
            {
                Service.Registration(CreateRedistModel());
                Close();
            }
        }

        
        private void ToWhiteTextBox()
        {
            textBox_name.BackColor = Color.White;
            textBox_lastname.BackColor = Color.White;
            textBox_login.BackColor = Color.White;
            textBox_passw.BackColor = Color.White;
            textBox_email.BackColor = Color.White;
            textBox_numb.BackColor = Color.White;
            textBox_cours.BackColor = Color.White;
            textBox_group.BackColor = Color.White;
            textBox_faculty.BackColor = Color.White;
            textBox_university.BackColor = Color.White;
            textBox_haveGrand.BackColor = Color.White;
            textBox_gender.BackColor = Color.White;
            textBox_studentTicket.BackColor = Color.White;
        }

        private void FindException()
        {
            if (!(ValidatorService.ValidLogin(textBox_login.Text.ToString()))) { IsException = true; textBox_login.BackColor = Color.Red; }
            if (!(ValidatorService.ValidName(textBox_lastname.Text.ToString()))) { textBox_lastname.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidName(textBox_name.Text.ToString()))) { textBox_name.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_university.Text.ToString()))) { textBox_university.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_faculty.Text.ToString()))) { textBox_faculty.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_group.Text.ToString()))) { textBox_group.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidNumber(textBox_numb.Text.ToString()))) { textBox_numb.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_passw.Text.ToString()))) { textBox_passw.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidEmail(textBox_email.Text.ToString()))) { textBox_email.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidHaveGrand(textBox_haveGrand.Text.ToString()))) { textBox_haveGrand.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStudentTicket(textBox_studentTicket.Text.ToString()))) { textBox_studentTicket.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidGender(textBox_gender.Text.ToString()))) { textBox_gender.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidCours(textBox_cours.Text.ToString()))) { textBox_cours.BackColor = Color.Red; IsException = true; }
   }

        private RegistrationModel CreateRedistModel()
        {
            RegistrationModel model = new RegistrationModel();
            model.cours = textBox_cours.Text;
            model.email = textBox_email.Text;
            model.faculty = textBox_faculty.Text;
            model.gender = textBox_gender.Text;
            model.group = textBox_group.Text;
            model.haveGrand = textBox_haveGrand.Text;
            model.lastname = textBox_lastname.Text;
            model.login = textBox_login.Text;
            model.name = textBox_name.Text;
            model.numb = textBox_numb.Text;
            model.passw = textBox_passw.Text;
            model.studentTicket = textBox_studentTicket.Text;
            model.university = textBox_university.Text;
            return model;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
