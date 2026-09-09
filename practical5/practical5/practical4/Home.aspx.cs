using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check Session
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                string username =
                    Session["Username"].ToString();

                string role =
                    Session["Role"].ToString();

                string loginTime =
                    Session["LoginTime"].ToString();

                lblWelcome.Text =
                    "Welcome, " + username;

                lblUser.Text =
                    "Username: " + username;

                lblRole.Text =
                    "Role: " + role;

                lblLoginTime.Text =
                    "Login Time: " + loginTime;
            }
        }
    }
}