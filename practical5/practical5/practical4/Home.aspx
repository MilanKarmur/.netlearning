<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="practical4.Home" %>

<!DOCTYPE html>
<html>
<head runat="server">

    <title>Home</title>

    <style>

        body {
            font-family: Arial;
            margin: 0;
            background-color: #f4f4f4;
        }

        .header {
            background-color: #007bff;
            color: white;
            padding: 20px;
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

        .card {
            background: white;
            padding: 25px;
            margin-bottom: 20px;
            border-radius: 8px;
            box-shadow: 0 0 5px gray;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="header">

        <h1>
            Academic Calendar & Leave Management System
        </h1>

        <asp:Label ID="lblWelcome"
            runat="server">
        </asp:Label>

    </div>

    <div class="menu">

        <a href="Home.aspx">Home</a>

        <a href="AcademicCalender.aspx">
            Academic Calendar
        </a>

     

        <a href="Logout.aspx">
            Logout
        </a>

    </div>

    <div class="container">

        <div class="card">

            <h2>Dashboard</h2>

            <p>
                Welcome to the Academic Calendar
                and Leave Management System.
            </p>

            <asp:Label ID="lblUser"
                runat="server">
            </asp:Label>

            <br />

            <asp:Label ID="lblRole"
                runat="server">
            </asp:Label>

            <br />

            <asp:Label ID="lblLoginTime"
                runat="server">
            </asp:Label>

        </div>

    </div>

</form>

</body>
</html>
