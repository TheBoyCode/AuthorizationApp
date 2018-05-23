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
    public partial class EditForm : Form
    {
        bool IsException;
        public EditForm()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            IsException = false;
            CheakFiled();
            if(!(IsException))
            {
               var accountService = new AccountService();
               accountService.Edition(CreateRegisterModel());
                Close();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            User user = new User();
            Singleton singleton = Singleton.getInstance(user);
            textBox_Edit_University.Text = singleton.User.University;
            textBox_Edit_StudentTicket.Text = singleton.User.StudentTicket;
            textBox_Edit_Cours.Text = Convert.ToString(singleton.User.Cours);
            textBox_Edit_Password.Text = singleton.User.Password;
            textBox_Edit_Number.Text = singleton.User.Number;
            textBox_Edit_Email.Text = singleton.User.Email;
            textBox_Edit_Faculty.Text = singleton.User.Faculty;
            textBox_Edit_Gender.Text = Convert.ToString(Convert.ToInt32(singleton.User.Sex));
            textBox_Edit_Group.Text = singleton.User.Group;
            textBox_Edit_HaveGrand.Text = Convert.ToString(Convert.ToInt32(singleton.User.HaveGrand));
            textBox_Edit_LastName.Text = singleton.User.LastName;
            textBox_Edit_Name.Text = singleton.User.Name;
        }
        private void CheakFiled()
        {
            if (!(ValidatorService.ValidName(textBox_Edit_LastName.Text.ToString()))) { textBox_Edit_LastName.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidName(textBox_Edit_Name.Text.ToString()))) { textBox_Edit_Name.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_Edit_University.Text.ToString()))) { textBox_Edit_University.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_Edit_Faculty.Text.ToString()))) { textBox_Edit_Faculty.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_Edit_Group.Text.ToString()))) { textBox_Edit_Group.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidNumber(textBox_Edit_Number.Text.ToString()))) { textBox_Edit_Number.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStr(textBox_Edit_Password.Text.ToString()))) { textBox_Edit_Password.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidEmail(textBox_Edit_Email.Text.ToString()))) { textBox_Edit_Email.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidHaveGrand(textBox_Edit_HaveGrand.Text.ToString()))) { textBox_Edit_HaveGrand.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidStudentTicket(textBox_Edit_StudentTicket.Text.ToString()))) { textBox_Edit_StudentTicket.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidGender(textBox_Edit_Gender.Text.ToString()))) { textBox_Edit_Gender.BackColor = Color.Red; IsException = true; }
            if (!(ValidatorService.ValidCours(textBox_Edit_Cours.Text.ToString()))) { textBox_Edit_Cours.BackColor = Color.Red; IsException = true; }
        }

        private RegistrationModel CreateRegisterModel()
        {
           var model  =new RegistrationModel();
            model.cours = textBox_Edit_Cours.Text;
            model.email = textBox_Edit_Email.Text;
            model.faculty = textBox_Edit_Faculty.Text;
            model.gender = textBox_Edit_Gender.Text;
            model.group = textBox_Edit_Group.Text;
            model.haveGrand = textBox_Edit_HaveGrand.Text;
            model.lastname = textBox_Edit_LastName.Text;
            model.name = textBox_Edit_Name.Text;
            model.numb = textBox_Edit_Number.Text;
            model.passw = textBox_Edit_Password.Text;
            model.studentTicket = textBox_Edit_StudentTicket.Text;
            model.university = textBox_Edit_University.Text;
            return model;
        }
    }
}
