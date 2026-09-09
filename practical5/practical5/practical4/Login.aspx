<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="practical4.Login" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login</title>

    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .login-box {
            width: 350px;
            margin: 100px auto;
            padding: 30px;
            background: white;
            border-radius: 10px;
        }

        .input {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
        }

        .btn {
            padding: 10px 25px;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <div class="login-box">

        <h2>Student Login</h2>

        <asp:Label ID="lblUsername"
            runat="server"
            Text="Username">
        </asp:Label>

        <br />

        <asp:TextBox ID="txtUsername"
            runat="server"
            CssClass="input">
        </asp:TextBox>

        <asp:Label ID="lblPassword"
            runat="server"
            Text="Password">
        </asp:Label>

        <br />

        <asp:TextBox ID="txtPassword"
            runat="server"
            TextMode="Password"
            CssClass="input">
        </asp:TextBox>

        <asp:CheckBox ID="chkRemember"
            runat="server"
            Text=" Remember Me">
        </asp:CheckBox>

        <br /><br />

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="btn"
            OnClick="btnLogin_Click">
        </asp:Button>

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server"
            ForeColor="Red">
        </asp:Label>

    </div>

</form>

</body>
</html>