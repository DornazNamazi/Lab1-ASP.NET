using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.VALIDATION
{
    public class LoginValidation
    {
        public bool IsUserIdValid(string userId)
        {
            return int.TryParse(userId, out int id) && userId.Length == 4;
        }

        public bool IsPasswordValid(string password)
        {
            return !string.IsNullOrWhiteSpace(password);
        }
    }
}