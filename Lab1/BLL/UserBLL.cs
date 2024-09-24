using Lab1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.BLL
{
    public class UserBLL
    {
        private UserDAL userDal = new UserDAL();

        public bool Login(int userId, string password)
        {
            return userDal.ValidateUser(userId, password);
        }
    }
}