<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="practical4.Dashboard" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Dashboard</title>

    <style>
        body {
            font-family: Arial;
            margin: 30px;
        }

        .menu {
            margin-bottom: 20px;
        }

        .menu a {
            margin-right: 20px;
        }

        .calendar {
            margin-top: 20px;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <h1>Academic Calendar & Leave Management</h1>

    <asp:Label ID="lblWelcome"
        runat="server">
    </asp:Label>

    <hr />

    <div class="menu">

        <asp:HyperLink ID="lnkDashboard"
            runat="server"
            NavigateUrl="Dashboard.aspx"
            Text="Dashboard">
        </asp:HyperLink>

        <asp:HyperLink ID="lnkLeave"
            runat="server"
            NavigateUrl="LeaveManagement.aspx"
            Text="Leave Management">
        </asp:HyperLink>

        <asp:HyperLink ID="lnkHistory"
            runat="server"
            NavigateUrl="LeaveHistory.aspx"
            Text="Leave History">
        </asp:HyperLink>

        <asp:Button ID="btnLogout"
            runat="server"
            Text="Logout"
            OnClick="btnLogout_Click">
        </asp:Button>

    </div>

    <h2>Academic Calendar</h2>

    <asp:Calendar ID="Calendar1"
        runat="server"
        OnDayRender="Calendar1_DayRender">
    </asp:Calendar>

</form>

</body>
</html>