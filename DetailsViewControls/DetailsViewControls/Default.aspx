<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DetailsViewControls._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 883px;
        }
    </style>
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">   

        = = = = = DetailsView Controls = = = = =<br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" DataSourceID="SqlDataSource1" 
            Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:viewConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:viewConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [control]">
        </asp:SqlDataSource>

    </form>
</body>
</html>
