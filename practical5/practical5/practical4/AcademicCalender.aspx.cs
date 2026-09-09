using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class AcademicCalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        }

        protected void Calendar1_DayRender(
            object sender,
            DayRenderEventArgs e)
        {
            DateTime date = e.Day.Date;

            // Independence Day
            if (date.Day == 15 &&
                date.Month == 8)
            {
                e.Cell.BackColor =
                    System.Drawing.Color.LightPink;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>Independence Day</b>"));
            }

            // Republic Day
            if (date.Day == 26 &&
                date.Month == 1)
            {
                e.Cell.BackColor =
                    System.Drawing.Color.LightPink;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>Republic Day</b>"));
            }

            // Christmas
            if (date.Day == 25 &&
                date.Month == 12)
            {
                e.Cell.BackColor =
                    System.Drawing.Color.LightPink;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>Christmas</b>"));
            }

            // New Year
            if (date.Day == 1 &&
                date.Month == 1)
            {
                e.Cell.BackColor =
                    System.Drawing.Color.LightGreen;

                e.Cell.Controls.Add(
                    new LiteralControl(
                        "<br/><b>New Year</b>"));
            }
        }

        protected void Calendar1_SelectionChanged(
            object sender,
            EventArgs e)
        {
            DateTime selectedDate =
                Calendar1.SelectedDate;

            lblSelectedDate.Text =
                "Selected Date: " +
                selectedDate.ToString("dd-MM-yyyy");

            if (selectedDate.Day == 15 &&
                selectedDate.Month == 8)
            {
                lblEvent.Text =
                    "Event: Independence Day";
            }
            else if (selectedDate.Day == 26 &&
                     selectedDate.Month == 1)
            {
                lblEvent.Text =
                    "Event: Republic Day";
            }
            else if (selectedDate.Day == 25 &&
                     selectedDate.Month == 12)
            {
                lblEvent.Text =
                    "Event: Christmas";
            }
            else if (selectedDate.Day == 1 &&
                     selectedDate.Month == 1)
            {
                lblEvent.Text =
                    "Event: New Year";
            }
            else
            {
                lblEvent.Text =
                    "No academic event on this date.";
            }
        }
    }
}