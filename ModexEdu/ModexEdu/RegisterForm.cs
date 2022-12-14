using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ModexEdu.modexfunction;

namespace ModexEdu
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayControl.display(new LoginForm());

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModexUser modexUser = new ModexUser();
            modexUser.email = emailInput.Text;
            modexUser.password = passwordInput.Text;
            modexUser.type = typeInput.Text;
            //MessageBox.Show(modexUser.type);
            Database.registeredUsers.Add(modexUser);


            if (modexUser.type == "Administrator")
            {
                DisplayControl.display(new UniversityForm());
            }

            if (modexUser.type == "Student")
            {
                DisplayControl.display(new StudentForm());
            }

            Database.currentUser = modexUser;

            //logout
            //currentUser = null;
            //DisplayControl.display(new LoginForm());
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
