<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.CustomerLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Sayfası</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <link href="../Css/Login.css" rel="stylesheet" />
    <script type="text/javascript">             
        $(function ()
        {
            $('#txtTCKimlikNo').keydown(function (e)
            {
                if (e.shiftKey || e.ctrlKey || e.altKey)
                {
                    e.preventDefault();
                } else
                {
                    var key = e.keyCode;
                    if (!((key == 8) || (key == 46) || (key >= 35 && key <= 40) || (key >= 48 && key <= 57) || (key >= 96 && key <= 105)))
                    {
                        e.preventDefault();
                    }
                } 
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" style="position: fixed; top: 0px; left: 0px; right: 0px;">
            <img src="../İmages/user.jpg" id="logo" style="height: 60px; width: 60px; border-radius: 15px; margin-left: -940px;" />
            <a class="navbar-brand" runat="server" href="~/" style="color: #0094ff; margin-left: -350px; font-size: 35px">Müşteri Girişi</a>
        </div>
        <div class="cerceve">
            <div class="container" style="border: 2px solid purple; border-radius: 30px; height: 400px; width: 500px; margin-left: 600px; margin-top: 150px; background-color: #00ffff; opacity: 1.0;">
                <br />
                <p>&copy; <%: DateTime.Now %></p>
                <h2>Müşteri Girişi</h2>
                <img id="Kullanıci" src="../İmages/user.jpg" style=" margin-left: 220px;" />
                <br />
                <div>
                    <b id="txtbaslık">TCKimlikNo:</b>
                    <asp:TextBox ID="txtTCKimlikNo" ToolTip="TCKimlikNo Giriniz" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
                <asp:Label ID="lblTCKimlikNoOk" ForeColor="Green" Font-Bold="true" runat="server" Text=""></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Font-Bold="true" ForeColor="Red" ErrorMessage="*TCKimlikNo Alanı Boş Geçilemez!" ControlToValidate="txtTCKimlikNo">
                </asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lblTCKimlikNo" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                <br />
                <div>
                    <b id="txtbaşlık">Şifre:</b>
                    <asp:TextBox ID="txtŞifre" ToolTip="Şifrenizi Giriniz" TextMode="Password" runat="server" CssClass="form-control" MaxLength="6"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Font-Bold="true" ForeColor="Red" ErrorMessage="*Şifre Alanı Boş Geçilemez!" ControlToValidate="txtŞifre"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="lblŞifre" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <div>
                    <asp:Button ID="btnGrsYap" runat="server" Text="Giriş Yap" CssClass="btn btn-primary form-control" OnClick="btnGrsYap_Click" />
                </div>
                <br />
                <asp:Label ID="lblhata" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                <br />
                <a href="#" class="fa fa-facebook"></a>
                <a href="#" class="fa fa-twitter"></a>
                <a href="#" class="fa fa-google"></a>
                <a href="#" class="fa fa-linkedin"></a>
                <a href="#" class="fa fa-youtube"></a>
                <a href="#" class="fa fa-instagram"></a>
            </div>
        </div>
    </form>
</body>
</html>
