using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class LeaveHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check login
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                lblUser.Text =
                    "Welcome, " +
                    Session["Username"].ToString();

                LoadLeaves();
            }
        }

        private void LoadLeaves()
        {
            List<Leave> leaves =
                Session["Leaves"] as List<Leave>;

            if (leaves == null || leaves.Count == 0)
            {
                GridView1.DataSource = null;
                GridView1.DataBind();

                lblNoData.Text =
                    "No leave applications found.";

                return;
            }

            string username =
                Session["Username"].ToString();

            // Show only current user's leaves
            List<Leave> userLeaves =
                leaves.Where(x =>
                    x.Username == username).ToList();

            if (userLeaves.Count == 0)
            {
                lblNoData.Text =
                    "No leave applications found.";

                return;
            }

            GridView1.DataSource = userLeaves;
            GridView1.DataBind();

            lblNoData.Text = "";
        }
    }
}