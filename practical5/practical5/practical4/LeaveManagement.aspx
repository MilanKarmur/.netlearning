<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveManagement.aspx.cs" Inherits="practical4.LeaveManagement" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Leave Management</title>

    <style>
        body {
            font-family: Arial;
            margin: 30px;
        }

        .box {
            width: 600px;
            padding: 25px;
            border: 1px solid #ccc;
            border-radius: 10px;
        }

        .message {
            font-weight: bold;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <h1>Leave Management</h1>

    <asp:Label ID="lblUser"
        runat="server">
    </asp:Label>

    <hr />

    <div class="box">

        <h2>Apply for Leave</h2>

        <b>Leave Type</b>

        <br /><br />

        <asp:DropDownList ID="ddlLeaveType"
            runat="server">

            <asp:ListItem
                Text="-- Select Leave Type --"
                Value="">
            </asp:ListItem>

            <asp:ListItem
                Text="Sick Leave"
                Value="Sick Leave">
            </asp:ListItem>

            <asp:ListItem
                Text="Casual Leave"
                Value="Casual Leave">
            </asp:ListItem>

            <asp:ListItem
                Text="Emergency Leave"
                Value="Emergency Leave">
            </asp:ListItem>

            <asp:ListItem
                Text="Other"
                Value="Other">
            </asp:ListItem>

        </asp:DropDownList>

        <br /><br />

        <b>From Date</b>

        <br /><br />

        <asp:Calendar ID="calFrom"
            runat="server">
        </asp:Calendar>

        <br />

        <b>To Date</b>

        <br /><br />

        <asp:Calendar ID="calTo"
            runat="server">
        </asp:Calendar>

        <br />

        <b>Reason</b>

        <br /><br />

        <asp:TextBox ID="txtReason"
            runat="server"
            TextMode="MultiLine"
            Rows="5"
            Columns="50">
        </asp:TextBox>

        <br />

        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            runat="server"
            ControlToValidate="txtReason"
            ErrorMessage="Please enter reason."
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br /><br />

        <asp:Button ID="btnApply"
            runat="server"
            Text="Apply Leave"
            OnClick="btnApply_Click">
        </asp:Button>

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server"
            CssClass="message">
        </asp:Label>

        <br /><br />

        <asp:HyperLink ID="lnkHistory"
            runat="server"
            NavigateUrl="LeaveHistory.aspx"
            Text="View Leave History">
        </asp:HyperLink>

        <br /><br />

        <asp:HyperLink ID="lnkDashboard"
            runat="server"
            NavigateUrl="Dashboard.aspx"
            Text="Back to Dashboard">
        </asp:HyperLink>

    </div>

</form>

</body>
</html>