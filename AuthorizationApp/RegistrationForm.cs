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
        AccountService Service;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private void button_OK_Reg_Click(object sender, EventArgs e)
        {
            Service = new AccountService();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
