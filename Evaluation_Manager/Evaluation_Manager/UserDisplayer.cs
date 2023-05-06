using Evaluation_Manager;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager
{
    internal class UserDisplayer
    {
        public void DisplayInfo(Form1 form, UserFormInfo current_UserForm)
        {
            if (current_UserForm != null && form != null)
            {
                form.Controls["NameTextBox"].Text = current_UserForm.Name;
                form.Controls["YearOfBirthTextBox"].Text = current_UserForm.YearofBirth;
                form.Controls["CityTextBox"].Text = current_UserForm.City;
                form.Controls["FacultyTextBox"].Text = current_UserForm.Faculty;
                form.Controls["RoleTextBox"].Text = current_UserForm.Role;
                form.Controls["SpecificAttributeTextBox"].Text = current_UserForm.SpecificAttribute;
            }
            else
            {
                Console.WriteLine("There is nothing to display");
            }
        }
    }
}
