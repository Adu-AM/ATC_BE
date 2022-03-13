using ATC_BE.Data.Enums;
using ATC_BE.Models;

namespace ATC_BE.Helpers
{
    static public class ValidateUser
    {
        static public bool ValidateUserDetails(UserRegisterModel user)
        {
            if (user.FirstName.Any(c => char.IsDigit(c)) || user.LastName.Any(c => char.IsDigit(c)))
                return false;

            if (!Enum.IsDefined(typeof(Gender), user.Gender) || !Enum.IsDefined(typeof(Nationality), user.Nationality))
                return false;

            return true;
        }



    }
}
