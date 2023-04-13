<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer2.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.ABANKBilgilerim.Customer2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bilgilerim Customer2</title>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body style="background-color:#808080">
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" style="position: fixed; top: 0px; left: 0px; right: 0px;">
            <img src="../İmages/abank.jpg" id="logo" style="height: 60px; width: 60px; border-radius: 15px; margin-left: -175px;" />
            <a class="navbar-brand" id="XBANK" runat="server" href="~/" style="color: blue; font-size: 40px;"></a>
            <div style="margin-left: 1200px; height: 25px">
                <asp:Button ID="btnAnaSayfa" runat="server" Text="AnaSayfa" CssClass="btn btn-warning" OnClick="btnAnaSayfa_Click"/>
            </div>
        </div>
        <div class="container" style="width: 1000px; height: 400px; background-color: #0094ff; border-radius: 20px; margin-top: 75px;">
            <br />
            <br />
            <h3 style="color: black; font-weight: bold">ABANK'a Hoşgeldiniz... </h3>
            <br />
            <%: DateTime.Now %>
            <br />
            <asp:GridView ID="grdBilgilerCustomer1" runat="server" CellPadding="3" Width="966px" GridLines="Horizontal" OnRowCreated="grdBilgilerCustomer1_RowCreated" Height="143px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>        
        </div>
    </form>
</body>
</html>
