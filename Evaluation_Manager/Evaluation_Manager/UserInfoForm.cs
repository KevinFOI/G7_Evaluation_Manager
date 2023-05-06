using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager
{
    internal class UserInfoForm
    {
        public string Name;
        public string YearofBirth;
        public string City;
        public string Faculty;
        public string Role;
        public string SpecificAttribute;

        public UserInfoForm(string[] param)
        {
            Name = param[0] + " " + param[1];
            YearofBirth = param[2];
            City = param[3];
            Faculty = param[4];
            Role = param[5];
            SpecificAttribute = param[6];

        }
    }
}
