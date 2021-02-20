using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer gamer)  // yalandan mernis yaptık
        {
            if (gamer.BirthYear == "1984" && gamer.FirstName == "ERKAN" && gamer.LastName == "ERGEN" && gamer.IdentityNumber == 123456)

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
