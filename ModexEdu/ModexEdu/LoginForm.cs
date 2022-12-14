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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //DisplayControl.display(new LoginForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {


            foreach(ModexUser modexUser in Database.registeredUsers)
            {

                if (modexUser.email == emailInput.Text )
                {
                    if (modexUser.password == passwordInput.Text)
                    {

                        if (modexUser.type == "Administrator")
                        {
                            DisplayControl.display(new UniversityForm());
                        }

                        if (modexUser.type == "Student")
                        {
                            DisplayControl.display(new StudentForm());
                        }

                        Database.currentUser = modexUser;
                        break;
                    }

                    
                }


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayControl.display(new RegisterForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
