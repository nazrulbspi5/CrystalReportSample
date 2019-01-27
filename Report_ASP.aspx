<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report_ASP.aspx.cs" Inherits="Report.Report_ASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <label>Address:</label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
         <label>Phone:</label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <asp:Button ID="BtnReport" runat="server" Text="Show Report" OnClick="BtnReport_OnClick"/>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
