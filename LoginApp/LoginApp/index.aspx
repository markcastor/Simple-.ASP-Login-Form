<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LoginApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="mystyle.css" />
    <title>Simple Login Site</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-form">
            <h1>LOGIN </h1>

            <asp:TextBox ID="username1" TextMode="SingleLine" placeholder="Username" required="required" runat="server"></asp:TextBox>
            <asp:TextBox ID="password1" TextMode="Password" placeholder="Password" required="required" runat="server"></asp:TextBox>

            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
        </div>
    </form>
</body>
</html>