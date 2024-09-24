using Lab1.BLL;
using Lab1.VALIDATION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        private static int attemptCount = 0;
        UserBLL userBll = new UserBLL();
        LoginValidation validation = new LoginValidation();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string password = txtPassword.Text;

            if (!validation.IsUserIdValid(userId) || !validation.IsPasswordValid(password))
            {
                lblMessage.Text = "Invalid UserId or Password. Try again.";
                return;
            }

            if (userBll.Login(int.Parse(userId), password))
            {
                Response.Redirect("https://lasallecollege.lcieducation.com/en");
            }
            else
            {
                attemptCount++;
                if (attemptCount >= 3)
                {
                    lblMessage.Text = "Please contact the system administrator!";
                    Response.Redirect("https://www.w3schools.com/");
                }
                else
                {
                    lblMessage.Text = "Invalid UserId or Password. Try again.";
                }
            }
        }
    }
}