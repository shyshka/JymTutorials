using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les009_Events
{
    class AccountChecker
    {
        public static bool CheckAccountInfo(string firstName, string email, string password)
        {
            if ((firstName == "user") && (email == "user@gmail.com" && password == "123")) return true;
            return false;
        }
    }
}
