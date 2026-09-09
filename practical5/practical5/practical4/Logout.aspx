<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="practical4.Logut" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <title>Logout</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>You have been logged out.</h2>

    <asp:HyperLink
        NavigateUrl="Login.aspx"
        Text="Login Again"
        runat="server">
    </asp:HyperLink>

</form>

</body>
</html>