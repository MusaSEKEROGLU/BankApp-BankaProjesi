<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Onay.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.Onay.Onay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İşlem Onay</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script>
        //Geri Butonuna basınca diğer sayfalardaki textboxlar dolu döner
        //function historyback()
        //{
        //    window.history.back()
        //}
    </script>
</head>
<body style="font-family: 'Times New Roman', Times, serif; background-color: white">
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <a class="navbar-brand" runat="server" href="~/" style="color: blue; margin-left: 5px; font-size: 35px"></a>
            <div style="margin-left: 1200px; height: 25px">
                <asp:Button ID="btnCustomer" CssClass="btn btn-warning" runat="server" Text="AnaSayfa"/>

            </div>
        </div>
        <div class="container-fluid" style="width: 1000px; height: 400px; background-color: #0094ff; border-radius: 10px">
            <h4 style="color: white">İşlem Onay</h4>
            <p><%: DateTime.Now %></p>
            <br />
            <asp:Label Font-Bold="true" Font-Size="Larger" ID="lblBaşlık" runat="server" Text="Gerçekleşecek İşlem" CssClass="form-control"></asp:Label>
            <br />
            <div>
                <b style="color: green">İslem Tipi:&nbsp;</b>&nbsp;
                <asp:Label ID="lblİşlemTipi" runat="server" Text=""></asp:Label>
            </div>
             <br />
            <div>
                <b style="color: green">Gönderilen Tarih:&nbsp;</b>&nbsp;
                <asp:Label ID="lblTarih" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">İşlem Açıklaması:&nbsp;</b>&nbsp;
                <asp:Label ID="lblİşlemAçıkla" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Gönderici HesapNo:&nbsp;</b>&nbsp;
                 <asp:Label ID="lblOnayHesapNoGön" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Alici HesapNo:&nbsp;</b>&nbsp;
                 <asp:Label ID="lblOnayHesapNo" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Gönderici IbanNo:&nbsp;</b>&nbsp;
                 <asp:Label ID="lblOnayIbanNoGön" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Alici IbanNo:&nbsp;&nbsp;&nbsp; </b>&nbsp;
                <asp:Label ID="lblOnayIbanNo" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Alici Sube Kodu:&nbsp;&nbsp;</b>
                <asp:Label ID="lblOnaySubeKodu" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Alici AdSoyad:&nbsp;&nbsp;</b>
                <asp:Label ID="lblOnayAdSoyad" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div>
                <b style="color: green">Gönderilen Tutar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
                &nbsp;<asp:Label ID="lblOnayTutar" runat="server" Text=""></asp:Label>
            </div>
            <br />                      
                <div style="margin-left: 80px">
                    <asp:Button ID="btnOnay" runat="server" Text="Onayla" CssClass="btn btn-success" OnClick="btnOnay_Click"/>
                    <input onclick="window.history.go(-1); return false;" class="btn btn-danger" type="button" value="Vazgeç" />
                </div>            
        </div>
    </form>
</body>
</html>
