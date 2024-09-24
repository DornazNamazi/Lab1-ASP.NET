<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab1.GUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br /><br />
<asp:Label ID="lblUserId" runat="server" Text="UserId:"></asp:Label>
<asp:TextBox ID="txtUserId" runat="server"></asp:TextBox><br /><br />
<asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

        </div>
    </form>
</body>
</html>
