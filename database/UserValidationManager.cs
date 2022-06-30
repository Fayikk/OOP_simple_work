using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    internal class UserValidationManager : IUserValidaitonService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 
                && gamer.FirstName == "FAYİK" 
                && gamer.lastname == "Veznedaroglu" 
                && gamer.IdentityNumber == 12345)
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
