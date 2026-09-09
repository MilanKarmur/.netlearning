<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcademicCalender.aspx.cs" Inherits="practical4.AcademicCalender" %>
<!DOCTYPE html>
<html>

<head runat="server">

    <title>Academic Calendar</title>

    <style>

        body {
            font-family: Arial;
            background-color: #f4f4f4;
        }

        .menu {
            background-color: #333;
            padding: 15px;
        }

        .menu a {
            color: white;
            margin-right: 25px;
            text-decoration: none;
        }

        .container {
            padding: 30px;
        }

        .calendar {
            background-color: white;
            padding: 20px;
            width: 450px;
            box-shadow: 0 0 8px gray;
        }

        .event {
            background-color: white;
            padding: 20px;
            margin-top: 20px;
            width: 450px;
            box-shadow: 0 0 8px gray;
        }

        .holiday {
            color: red;
            font-weight: bold;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="menu">

        <a href="Home.aspx">Home</a>

        <a href="AcademicCalendar.aspx">
            Academic Calendar
        </a>

        <a href="Leave.aspx">
            Leave Management
        </a>

        <a href="Logout.aspx">
            Logout
        </a>

    </div>

    <div class="container">

        <h1>Academic Calendar</h1>

        <div class="calendar">

            <asp:Calendar
                ID="Calendar1"
                runat="server"
                Width="100%"
                Height="350px"
                OnDayRender="Calendar1_DayRender"
                OnSelectionChanged="Calendar1_SelectionChanged">
            </asp:Calendar>

        </div>

        <div class="event">

            <h2>Selected Date</h2>

            <asp:Label ID="lblSelectedDate"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:Label ID="lblEvent"
                runat="server"
                CssClass="holiday">
            </asp:Label>

        </div>

    </div>

</form>

</body>
</html>