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
        int AllIsRed;
        public EditForm()
        {
            AllIsRed = 0;
            InitializeComponent();
            CheakFiled();
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if(IsWhite())
            {
               var accountService = new AccountService();
               accountService.Edition(CreateEditModel());
                Close();
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            User user = new User();
            Singleton singleton = Singleton.getInstance();
            textBox_Edit_University.Text = singleton.userModel.university;
            textBox_Edit_StudentTicket.Text = singleton.userModel.studentTicket;
            textBox_Edit_Cours.Text = Convert.ToString(singleton.userModel.cours);
            textBox_Edit_Password.Text = singleton.userModel.passw;
            textBox_Edit_Number.Text = singleton.userModel.numb;
            textBox_Edit_Email.Text = singleton.userModel.email;
            textBox_Edit_Faculty.Text = singleton.userModel.faculty;
            textBox_Edit_Gender.Text = Convert.ToString(Convert.ToInt32(singleton.userModel.gender));
            textBox_Edit_Group.Text = singleton.userModel.group;
            textBox_Edit_HaveGrand.Text = Convert.ToString(Convert.ToInt32(singleton.userModel.haveGrand));
            textBox_Edit_LastName.Text = singleton.userModel.lastname;
            textBox_Edit_Name.Text = singleton.userModel.name;
        }
        private void CheakFiled()
        {
            IsException = false;
            textBox_Edit_Cours.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidCours(textBox_Edit_Cours.Text.ToString())))
                {
                    textBox_Edit_Cours.BackColor = Color.Red;
                    IsException = true;
                   
                }
                else
                {
                    textBox_Edit_Cours.BackColor = Color.White;
                    
                }
            };
            textBox_Edit_Email.TextChanged += (q, w) =>

            {
                if (!(ValidatorService.ValidEmail(textBox_Edit_Email.Text.ToString())))
                {
                    textBox_Edit_Email.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_Email.BackColor = Color.White;
                }
            };
            textBox_Edit_Faculty.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidStr(textBox_Edit_Faculty.Text.ToString())))
                {
                    textBox_Edit_Faculty.BackColor = Color.Red;
                    IsException = true;

                }
                else
                {
                    textBox_Edit_Faculty.BackColor = Color.White;
                }

            };
            textBox_Edit_Gender.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidGender(textBox_Edit_Gender.Text.ToString())))
                {
                    textBox_Edit_Gender.BackColor = Color.Red;
                }
                else
                {
                    textBox_Edit_Gender.BackColor = Color.White;
                }
            };
            textBox_Edit_Name.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidName(textBox_Edit_Name.Text.ToString())))
                {
                    textBox_Edit_Name.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_Name.BackColor = Color.White;
                }
            };
            textBox_Edit_Group.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidStr(textBox_Edit_Group.Text.ToString())))
                {
                    textBox_Edit_Group.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_Group.BackColor = Color.White;
                }
            };
            textBox_Edit_HaveGrand.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidHaveGrand(textBox_Edit_HaveGrand.Text.ToString())))
                {
                    textBox_Edit_HaveGrand.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_HaveGrand.BackColor = Color.White;
                }
            };
            textBox_Edit_LastName.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidName(textBox_Edit_LastName.Text.ToString())))
                {
                    textBox_Edit_LastName.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_LastName.BackColor = Color.White;
                }
            };
            textBox_Edit_Number.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidNumber(textBox_Edit_Number.Text.ToString())))
                {
                    textBox_Edit_Number.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_Number.BackColor = Color.White;
                }

            };
            textBox_Edit_University.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidStr(textBox_Edit_University.Text.ToString())))
                {
                    textBox_Edit_University.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_University.BackColor = Color.White;
                }

            };
            textBox_Edit_Password.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidStr(textBox_Edit_Password.Text.ToString())))
                {
                    textBox_Edit_Password.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_Password.BackColor = Color.White;
                }

            };
            textBox_Edit_StudentTicket.TextChanged += (q, w) =>
            {
                if (!(ValidatorService.ValidStudentTicket(textBox_Edit_StudentTicket.Text.ToString())))
                {
                    textBox_Edit_StudentTicket.BackColor = Color.Red;
                    IsException = true;
                }
                else
                {
                    textBox_Edit_StudentTicket.BackColor = Color.White;
                }

            };
            
        }
        private bool IsWhite()
        {
            if (textBox_Edit_Cours.BackColor == Color.Red) return false;
            if (textBox_Edit_University.BackColor == Color.Red) return false;
            if (textBox_Edit_StudentTicket.BackColor == Color.Red) return false ;
            if (textBox_Edit_Cours.BackColor == Color.Red) return false;
            if (textBox_Edit_Password.BackColor == Color.Red) return false; ;
            if (textBox_Edit_Number.BackColor == Color.Red) return false; ;
            if(textBox_Edit_Email.BackColor ==Color.Red)return false;
            if(textBox_Edit_Faculty.BackColor == Color.Red)return false;
            if(textBox_Edit_Gender.BackColor == Color.Red)return false;
            if(textBox_Edit_Group.BackColor == Color.Red)return false;
            if(textBox_Edit_HaveGrand.BackColor == Color.Red)return false;
            if (textBox_Edit_LastName.BackColor == Color.Red) return false ;
            if(textBox_Edit_Name.BackColor == Color.Red)return false;
            return true;
        }
        private EditionModel CreateEditModel()
        {
            var model  =new EditionModel();
            var singleton = Singleton.getInstance();
            model.login = singleton.userModel.login;
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
