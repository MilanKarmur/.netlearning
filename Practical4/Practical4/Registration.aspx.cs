using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                uname.Text = "";
                uemail.Text = "";
                umbnumber.Text = "";
                ucollage.Text = "";
                udepartment.Text = "";
                uevent.Text = "";
                ugender.Text = "";
                uskills.Text = "";
                uaddress.Text = "";

                // Name
                if (string.IsNullOrWhiteSpace(username.Text))
                    uname.Text = "Please enter your name.";

                // Email
                if (string.IsNullOrWhiteSpace(email.Text))
                    uemail.Text = "Please enter your email.";
                else if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    uemail.Text = "Invalid email.";

                // Mobile
                if (string.IsNullOrWhiteSpace(mbnumber.Text))
                    umbnumber.Text = "Please enter mobile number.";
                else if (mbnumber.Text.Length != 10)
                    umbnumber.Text = "Mobile number must be 10 digits.";

                // College
                if (string.IsNullOrWhiteSpace(collage.Text))
                    ucollage.Text = "Please enter college.";

                // Department
                if (department.SelectedIndex == -1)
                    udepartment.Text = "Please select department.";

                // Event
                if (events.SelectedIndex == -1)
                    uevent.Text = "Please select event.";

                // Gender
                if (!male.Checked && !female.Checked)
                    ugender.Text = "Please select gender.";

                // Skills
                bool selected = false;
                foreach (ListItem item in skills.Items)
                {
                    if (item.Selected)
                    {
                        selected = true;
                        break;
                    }
                }

                if (!selected)
                    uskills.Text = "Please select at least one skill.";

                // Address
                if (string.IsNullOrWhiteSpace(Request.Form["address"]))
                    uaddress.Text = "Please enter address.";
            }


        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";


            string skill = "";

            foreach (ListItem item in skills.Items)
            {
                if (item.Selected)
                {
                    skill += item.Text + " ";
                }
            }

            string address = Request.Form["address"];

            Response.Write("<h2>Registration Details</h2>");
            Response.Write("<b>Name :</b> " + username.Text + "<br/>");
            Response.Write("<b>Email :</b> " + email.Text + "<br/>");
            Response.Write("<b>Mobile Number :</b> " + mbnumber.Text + "<br/>");
            Response.Write("<b>College :</b> " + collage.Text + "<br/>");
            // Response.Write("<b>Department :</b> " + department.SelectedItem.Text + "<br/>");
            Response.Write("<b>Event :</b> " + events.SelectedItem.Text + "<br/>");
            Response.Write("<b>Gender :</b> " + gender + "<br/>");
            Response.Write("<b>Skills :</b> " + skill + "<br/>");
            Response.Write("<b>Address :</b> " + address + "<br/>");

            ClearForm();
        }

        private void ClearForm()
        {
            // TextBoxes
            username.Text = "";
            email.Text = "";
            mbnumber.Text = "";
            collage.Text = "";

            // DropDownList
            department.ClearSelection();
            events.ClearSelection();

            // RadioButtons
            male.Checked = false;
            female.Checked = false;

            // CheckBoxList
            foreach (ListItem item in skills.Items)
            {
                item.Selected = false;
            }

            // Address (if it is an HtmlTextArea)
            //address.Value = "";

            // Validation Labels
            uname.Text = "";
            uemail.Text = "";
            umbnumber.Text = "";
            ucollage.Text = "";
            udepartment.Text = "";
            uevent.Text = "";
            ugender.Text = "";
            uskills.Text = "";
            uaddress.Text = "";
        }


        protected void validation(object sender, EventArgs e)
        {

        }
    }
}