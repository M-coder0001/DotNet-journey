<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="RegistrationForm._Default" %>


<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 832px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"> 

        <asp:Label ID="Label1" runat="server" Text="==========Registration Form=========="></asp:Label> 
        
        <br />
        <br />
        
        <asp:Label ID="Label" runat="server" Text="Usernamee:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labe2" runat="server" Text="Password:  "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labe3" runat="server" Text="Email Id:  "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labe4" runat="server" Text="Address:  "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labe5" runat="server" Text="Hobbies:  "></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Dancing" />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Singing" />
        <br />
        <br />
        <asp:Label ID="Labe6" runat="server" Text="ID Proof:  "></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="I agree that above information are correct from my side" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
        
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        
    </form>
</body>
</html>