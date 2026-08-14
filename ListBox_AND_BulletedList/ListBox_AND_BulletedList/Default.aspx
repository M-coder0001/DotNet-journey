<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListBox_AND_BulletedList._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>Multi View Control</title>    
    <style type="text/css">
        #form1 {
            height: 750px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   
        
        Enter Item Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Position:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <b>=====ListBox Operation=====<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert At Position" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        <br />
        <br />
        </b>
        <asp:ListBox ID="ListBox1" runat="server" Height="107px" Width="114px"></asp:ListBox>
        <br />
        <br />
        <b>=====Bulleted List Operation=====<br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Addd" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insert At Position" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Delete" />
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
        <br />
        <br />
        </b></form>
</body>
</html>

