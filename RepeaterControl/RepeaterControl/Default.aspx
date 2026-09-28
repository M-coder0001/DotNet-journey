<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RepeaterControl._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 702px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   

        = = = = = Repeater Control = = = = =<br />
        <br />
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>