<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveHistory.aspx.cs" Inherits="practical4.LeaveHistory" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Leave History</title>

    <style>
        body {
            font-family: Arial;
            margin: 30px;
        }

        .grid {
            margin-top: 20px;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <h1>Leave History</h1>

    <asp:Label ID="lblUser"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:GridView ID="GridView1"
        runat="server"
        CssClass="grid"
        AutoGenerateColumns="False"
        BorderWidth="1"
        CellPadding="8">

        <Columns>

            <asp:BoundField
                DataField="LeaveType"
                HeaderText="Leave Type" />

            <asp:BoundField
                DataField="FromDate"
                HeaderText="From Date"
                DataFormatString="{0:dd-MM-yyyy}" />

            <asp:BoundField
                DataField="ToDate"
                HeaderText="To Date"
                DataFormatString="{0:dd-MM-yyyy}" />

            <asp:BoundField
                DataField="Reason"
                HeaderText="Reason" />

            <asp:BoundField
                DataField="Status"
                HeaderText="Status" />

        </Columns>

    </asp:GridView>

    <br />

    <asp:Label ID="lblNoData"
        runat="server"
        ForeColor="Red">
    </asp:Label>

    <br /><br />

    <asp:HyperLink
        ID="lnkApply"
        runat="server"
        NavigateUrl="LeaveManagement.aspx"
        Text="Apply New Leave">
    </asp:HyperLink>

    &nbsp;&nbsp;&nbsp;

    <asp:HyperLink
        ID="lnkDashboard"
        runat="server"
        NavigateUrl="Dashboard.aspx"
        Text="Back to Dashboard">
    </asp:HyperLink>

</form>

</body>
</html>
