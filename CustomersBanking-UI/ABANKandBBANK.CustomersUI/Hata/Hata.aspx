<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hata.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.Hata.Hata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İşlem Hata</title>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body style="background-color:#0094ff;font-family:'Times New Roman', Times, serif">
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <a class="navbar-brand" runat="server" href="~/" style="color: blue; margin-left: 5px; font-size: 35px"></a>           
        </div>
        <div class="container-fluid" style="width: 1000px; height: 400px; background-color:#b200ff; border-radius: 10px">
            <h4 style="color: white; font-weight: bold">Hata!!!</h4>
            <br />
            <p>&copy; <%: DateTime.Now%></p>
            <asp:Label Font-Bold="true" ForeColor="Red" Font-Size="Larger" ID="lblBaşlık" runat="server" Text="İşleminiz Gerçekleşmedi!" CssClass="form-control alert-danger"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblBakiye" ForeColor="Green" Font-Bold="true" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblLimit" CssClass="form-control alert-danger" runat="server" ForeColor="Green" Font-Bold="true" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblKontrol" CssClass="form-control alert-danger" ForeColor="Green" Font-Bold="true" runat="server" Text="*Lütfen Bilgierinizi Kontrol Ediniz!"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <div style="margin-left: 30px">
                <asp:Button ID="btnCıkıs" runat="server" Text="Çıkış Yap" CssClass="btn btn-danger" OnClick="btnCıkıs_Click" />

            </div>
            <div>
            </div>
        </div>
    </form>
</body>
</html>
