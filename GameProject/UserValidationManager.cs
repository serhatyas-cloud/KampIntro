using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "SERHAT"&& gamer.LastName == "YAŞ"&& gamer.TcNo=="12345"&& gamer.BirthDay==1994)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
