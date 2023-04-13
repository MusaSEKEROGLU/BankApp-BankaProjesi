<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sonuç.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.Sonuç.Sonuç" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İşlem Sonuç</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <a class="navbar-brand" runat="server" href="~/" style="color: blue; margin-left: 5px; font-size: 35px"></a>
        </div>
        <div class="container-fluid" style="width: 1000px; height: 400px; background-color: #0094ff; border-radius: 10px">
            <h4 style="color: white; font-weight: bold">İşlem Sonuç</h4>
            <p>&copy; <%: DateTime.Now %></p>
            <br />
            <asp:Label Font-Bold="true" ForeColor="Green" Font-Size="Larger" ID="lblBaşlık" runat="server" Text="İşlem Bilgileri" CssClass="form-control"></asp:Label>
            <br />
            <br />
            <div>
                <b style="color: green; font-size: 15px; font-weight: bold">&nbsp;&nbsp;&nbsp; </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label BackColor="Green" ID="lblİslemTipi" runat="server" Text=""></asp:Label>
                <br />
                <b style="color: green; font-size: 25px; font-weight: bold">İşleminiz Başarı ile Gerçekleşmiştir:&nbsp;&nbsp;&nbsp; </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label BackColor="Green" ID="lblİşlemSonuc" runat="server" Text=""></asp:Label>
                <br />
                <b style="color: green; margin-left: 300px; font-size: 100px; font-weight: bold">✅&nbsp;&nbsp;&nbsp; </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label BackColor="Green" ID="lbltik" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <br />

            <asp:Button ID="btnÇıkış" runat="server" Text="Çıkış Yap" CssClass="btn btn-danger" />
        </div>
    </form>
</body>
</html>
