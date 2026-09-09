using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical4
{
    public partial class LeaveManagement : System.Web.UI.Page
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
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            // Check Leave Type
            if (ddlLeaveType.SelectedValue == "")
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text =
                    "Please select leave type.";

                return;
            }

            // Check From Date
            if (calFrom.SelectedDate == DateTime.MinValue)
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text =
                    "Please select From Date.";

                return;
            }

            // Check To Date
            if (calTo.SelectedDate == DateTime.MinValue)
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text =
                    "Please select To Date.";

                return;
            }

            // Check Date
            if (calTo.SelectedDate < calFrom.SelectedDate)
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text =
                    "To Date cannot be before From Date.";

                return;
            }

            // Check Reason
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text =
                    "Please enter reason.";

                return;
            }

            // Create Leave object
            Leave leave = new Leave();

            leave.Username =
                Session["Username"].ToString();

            leave.LeaveType =
                ddlLeaveType.SelectedValue;

            leave.FromDate =
                calFrom.SelectedDate;

            leave.ToDate =
                calTo.SelectedDate;

            leave.Reason =
                txtReason.Text;

            leave.Status =
                "Pending";

            // Get leaves from Session
            List<Leave> leaves =
                Session["Leaves"] as List<Leave>;

            if (leaves == null)
            {
                leaves = new List<Leave>();
            }

            // Add leave
            leaves.Add(leave);

            // Store leaves in Session
            Session["Leaves"] = leaves;

            // Success message
            lblMessage.ForeColor = Color.Green;

            lblMessage.Text =
                "Leave applied successfully!";

            // Clear form
            ddlLeaveType.SelectedIndex = 0;
            txtReason.Text = "";
        }
    }

    [Serializable]
    public class Leave
    {
        public string Username { get; set; }

        public string LeaveType { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }
    }
}