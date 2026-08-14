<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="PanelControls._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Show Hide Panel</title>
</head>

<body>

    <form id="form1" runat="server">

        <center style="height: 498px">

            <asp:Button
                ID="Button1"
                runat="server"
                Height="82px"
                Width="125px"
                Text="Show"
                OnClick="Button1_Click" />

            <br />
            <br />
            <br />
            <br />
            <br />

            <asp:Panel
                ID="Panel1"
                runat="server"
                BackColor="#FFCC66"
                Height="461px"
                Visible="False">

                <asp:Image
                    ID="Image1"
                    runat="server"
                    Height="170px"
                    Width="248px"
                    ImageUrl="~/images/car.jpg" />

                <br />
                <br />

                <asp:Label
                    ID="Label1"
                    runat="server"
                    Text="BMW M5 CS">
                </asp:Label>

                <br />
                <br />

                <asp:HyperLink
                    ID="HyperLink1"
                    runat="server"
                    NavigateUrl="https://www.google.com/">
                    Click Here
                </asp:HyperLink>

                <br />
                <br />
                <br />

                <asp:Button
                    ID="Button2"
                    runat="server"
                    Height="80px"
                    Width="200px"
                    Text="Hide"
                    OnClick="Button2_Click" />

            </asp:Panel>

        </center>

    </form>

</body>

</html>