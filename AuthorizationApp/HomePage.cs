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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            AurhorizationModel aurhorization = new AurhorizationModel();
            aurhorization.LogOut();


            Close();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
           var editForm = new EditForm();
            editForm.Show();
        }
    }
}
