<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FeedbkackFormValidation._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 724px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   

        =====Feedback Form=====<br />
        <br />
        Enter Your Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enter Your Email ID:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Enter Valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Enter Feedback: <asp:TextBox ID="TextBox3" runat="server" Height="72px" TextMode="MultiLine" Width="219px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Enter Your Feedback" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <div style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </form>
</body>
</html>
