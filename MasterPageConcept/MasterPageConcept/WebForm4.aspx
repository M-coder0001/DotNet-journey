<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="MasterPageConcept.WebForm4" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
    Enter Your Name:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Enter Your Feedback:
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
</p>
<p style="margin-left: 120px">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
</p>
<p style="margin-left: 120px">
    <asp:Label ID="Label2" runat="server"></asp:Label>
</p>
<p style="margin-left: 120px">
    &nbsp;</p>

</asp:Content>
