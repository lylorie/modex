using ModexEdu.modexfunction;
using ModexEdu.universityModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModexEdu
{
    public partial class UniversityAccountForm : Form
    {
        public UniversityAccountForm()
        {
            InitializeComponent();
            intializeUniversity();
        }

        private void intializeUniversity()
        {
            {
                foreach (ModexUniversity modexUniversity in Database.modexUniversities)
                {

                    if (Database.currentUser.email == modexUniversity.email)
                    {


                        Database.modexUniversity = modexUniversity;
                        break;
                    }


                }
            }
            {
                ModexUniversity modexUniversity = Database.getCurrentUniversity();
                uniNameInput.Text = modexUniversity.universityName;
                streetNameInput.Text = modexUniversity.uniStreetName;
                streetNameInput.Text = modexUniversity.uniBuildingNumber;
                postalCodeInput.Text = modexUniversity.uniPostalCode;
                cityInput.Text = modexUniversity.uniCity;
                countryInput.Text = modexUniversity.uniCountry;
                contactNumberUniInput.Text = modexUniversity.uniContact;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ModexUniversity modexUniversity = new ModexUniversity();
            ModexUser currentUser = Database.getCurrentUser(); 
            modexUniversity.universityName = uniNameInput.Text;
            modexUniversity.uniStreetName = streetNameInput.Text;
            modexUniversity.uniBuildingNumber = buildingNumberInput.Text;
            modexUniversity.uniPostalCode = postalCodeInput.Text;
            modexUniversity.uniCity = cityInput.Text;
            modexUniversity.uniCountry = countryInput.Text;
            modexUniversity.uniContact = contactNumberUniInput.Text;

            modexUniversity.email = currentUser.email;
            Database.modexUniversities.Add(modexUniversity);


        }
    }
}
