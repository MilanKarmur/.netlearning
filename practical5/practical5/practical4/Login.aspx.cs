using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Read Cookie
                if (Request.Cookies["Username"] != null)
                {
                    txtUsername.Text =
                        Request.Cookies["Username"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Simple login
            if (username == "student" && password == "1234")
            {
                // Create Session
                Session["Username"] = username;

                // Create Cookie
                if (chkRemember.Checked)
                {
                    Response.Cookies["Username"].Value =
                        username;

                    Response.Cookies["Username"].Expires =
                        DateTime.Now.AddDays(7);
                }

                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblMessage.Text =
                    "Invalid username or password.";
            }
        }
    }
}