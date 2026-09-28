<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuizForm._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 880px;
        }
    </style>
</head>
<body style="height: 804px">
    <form id="form1" runat="server">   
        = = = = = Quiz Form = = = = =<br />
        <br />
        1. What is the full form of CLR?<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>common language runtime</asp:ListItem>
            <asp:ListItem>command language runtime</asp:ListItem>
            <asp:ListItem>common list runtime</asp:ListItem>
            <asp:ListItem>non of above</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        2. What is the extention of ASP.NET file?<br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>.aspx</asp:ListItem>
            <asp:ListItem>.asp</asp:ListItem>
            <asp:ListItem>.cs</asp:ListItem>
            <asp:ListItem>.csx</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        3. What is the extention of C# file?<br />
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>.cs</asp:ListItem>
            <asp:ListItem>.csd</asp:ListItem>
            <asp:ListItem>.asp</asp:ListItem>
            <asp:ListItem>.asmx</asp:ListItem>
        </asp:RadioButtonList>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
