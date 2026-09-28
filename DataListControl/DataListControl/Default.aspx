[<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataListControl._Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            height: 634px;
        }
    </style>
</head>
<body style="height: 716px">
    <form id="form1" runat="server">
        = = = = = DataList Controls = = = = =<br />
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="117px">
            <ItemTemplate>
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:viewConnectionString %>" ProviderName="<%$ ConnectionStrings:viewConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [control]">

        </asp:SqlDataSource>
    </form>
</body>
</html>