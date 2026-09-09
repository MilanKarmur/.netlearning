using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                lblWelcome.Text =
                    "Welcome, " + Session["Username"].ToString();
            }
        }

        protected void Calendar1_DayRender(
            object sender,
            DayRenderEventArgs e)
        {
            if (e.Day.Date == new DateTime(2026, 9, 5))
            {
                e.Cell.BackColor = Color.LightGreen;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>College Event</b>"));
            }

            if (e.Day.Date == new DateTime(2026, 9, 15))
            {
                e.Cell.BackColor = Color.LightBlue;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>Internal Exam</b>"));
            }

            if (e.Day.Date == new DateTime(2026, 10, 2))
            {
                e.Cell.BackColor = Color.LightYellow;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>Holiday</b>"));
            }
        }

        protected void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Login.aspx");
        }
    }
}