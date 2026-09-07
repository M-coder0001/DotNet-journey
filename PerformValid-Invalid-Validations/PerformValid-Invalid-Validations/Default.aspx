<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PerformValid_Invalid_Validations._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body style="height: 714px">
    <form id="form1" runat="server">   
        Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your Name😒" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Password:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Password😒" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Confirm Password:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Confirm Password😒" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password Does Not Match😒" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        Email:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Enter Valid Email ID😒" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;
        <br />
        <br />
        Birthdate:
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Age Must Be Greater Than 18😒" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
&nbsp;<br />
        <br />
        Mobile no.:
        <asp:TextBox ID="TextBox6" runat="server" MaxLength="10"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Number Should Not More Than 10 Digit😒" ForeColor="Red" ValidationExpression="^[6-9]\d{9}$"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
    </form>
</body>
</html>
