using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ModexEdu.modexfunction
{
    public static class DisplayControl
    {
        private static MainForm mainForm = new MainForm();

        public static void display(Form form) 
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            mainForm.Controls.Clear();
            mainForm.Controls.Add(form);
        }

        public static Form getMainForm() 
        {
            display(new LoginForm());
            return mainForm;
        }
    }
}
