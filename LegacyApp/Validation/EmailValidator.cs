using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp.Validation
{
    public class EmailValidator
    {
        public static bool EmailIsValid(string email)
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }
            return true;
        }
    }
}
