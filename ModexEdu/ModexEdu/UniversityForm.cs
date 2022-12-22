using ModexEdu.modexfunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModexEdu
{
    public partial class UniversityForm : Form
    {
        public UniversityForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayControl.display(new LoginForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayControl.display(new UniversityAccountForm());
        }
    }
}
