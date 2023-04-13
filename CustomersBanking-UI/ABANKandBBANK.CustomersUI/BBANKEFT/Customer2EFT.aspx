<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer2EFT.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.BBANKEFT.Customer2EFT" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BBANK Customer1EFT</title>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Css/EFT.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" language="javascript"> 
        //checkBox tekli Seçim yapma
        function TekliSecimYap(id) {
            var sec = document.getElementsByTagName('input');
            for (var i = 0; i < sec.length; i++) {
                if (sec.item(i).type == "checkbox" && sec.item(i) != id)
                    sec.item(i).checked = false;
            }
        }
    </script>
</head>
<body style="background-color: #808080">
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" style="position: fixed; top: 0px; left: 0px; right: 0px;">
            <img src="../İmages/BBANK.png" id="logo" style="height: 60px; width: 60px; border-radius: 15px; margin-left: -175px;" />
            <a class="navbar-brand" id="XBANK" runat="server" href="~/"></a>
            <div style="margin-left: 1200px; height: 25px">
                <a class="btn btn-warning " runat="server" href="~/BBANKAnaSayfa/Customer2AnaSayfa.aspx">Ana Sayfa</a>
            </div>
        </div>
        <br />
        <%--ikinci navbar div--%>
        <div class="navbar navbar-inverse navbar-fixed-top" style="background-color: #e3f2fd; height: 20px; margin-top: 70px; position: fixed; top: 0px; left: 0px; right: 0px;">
            <p style="margin-left: -60px; font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Siz değerli müşterilerimize hizmet vermekten mutluluk duyuyoruz...</p>
            <input type="text" placeholder="search" style="width: 390px; height: 30px; border-radius: 5px; background-color: #de9f9f; margin-left: 400px; color: black" />
        </div>
        <br />
        <div class="container-fluid col-lg-8" id="Tablo" style="height: 1100px;">
            <div class="row">
                <div class="col-sm">
                    <h4 style="color: black; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold;">BBANK EFT İşlemleri</h4>
                    <p style="color: #ffffff; font-size: medium; font-family: 'Times New Roman', Times, serif; font-weight: bold;">&copy; <%: DateTime.Now %></p>
                    <asp:Button CssClass="btn btn-warning" ID="btnHesapGetir" runat="server" Text="Vadesiz Hesaplarım" ToolTip="Hesaplarım" OnClick="btnHesapGetir_Click" Width="250px" />
                    <br />
                    <br />
                    <asp:DropDownList CssClass="btn btn-success" ID="DrpHesapSec" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpHesapSec_SelectedIndexChanged1" ToolTip="EFT Seçimi" Width="250px">
                        <asp:ListItem Selected="True" Value="0">EFT Türü Seçiniz</asp:ListItem>
                        <asp:ListItem Value="1">HesapNo ile EFT</asp:ListItem>
                        <asp:ListItem Value="2">IbanNo ile EFT</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                    <br />
                    <div>
                        &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDrpSecimi" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
                    </div>
                    <br />
                    <asp:GridView ID="GrdHesaplarıGetir" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" OnRowDataBound="GrdHesaplarıGetir_RowDataBound" OnRowCreated="GrdHesaplarıGetir_RowCreated" Width="950px" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Hesap Seçiniz
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkHesaplar" AutoPostBack="true" OnCheckedChanged="chkHesaplar_CheckedChanged" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:Label ID="lblHesapSeçimi" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
                    <br />
                    <br />
                    <div style="width: 300px; height: 750px; background-color: #ffffff; border-radius: 10px; border: 2px solid">
                        <div style="margin-left: 15px; margin-top: 15px">
                            <b style="color: blue">İslem Tipi:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtislemtipi" ToolTip="İşlem Tipi" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="20"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblislemtipi" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                             <br />
                            <b style="color: blue">Gönderilen Tarih:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtTarih" ToolTip="Tarih Giriniz" TextMode="Date" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="10"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblTarih" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">Gönderici HesapNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtHesapNoGön" ToolTip="HesapNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="10" OnTextChanged="txtHesapNoGön_TextChanged"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblHesapNoGön" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                            </div>

                            <b style="color: blue">Alici HesapNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtHesapNo" ToolTip="HesapNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="10"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblHesapNo" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                            </div>

                            <b style="color: blue">Gönderici IbanNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtIbanNoGön" ToolTip="IbanNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="26" OnTextChanged="txtIbanNoGön_TextChanged"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblIbanNoGön" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>

                            </div>
                            <b style="color: blue">Alici IbanNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtIbanNo" ToolTip="IbanNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="26" OnTextChanged="txtIbanNo_TextChanged"></asp:TextBox>
                            </div>
                            <asp:Label ID="lblIbanNo" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                            <asp:Label ID="lblIbanNo1" ForeColor="Green" Font-Bold="true" runat="server" Text=""></asp:Label>
                            <asp:Label ID="lblIbanNo2" ForeColor="Green" Font-Bold="true" runat="server" Text=""></asp:Label>
                            <div>
                                <br />
                                <b style="color: blue">Alici Sube Kodu:</b>
                                <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                    <asp:TextBox ID="txtSubeKodu" ToolTip="SubeKodu Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="30"></asp:TextBox>
                                </div>
                                <div>
                                    <asp:Label ID="lblSubeKodu" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>
                                <b style="color: blue">Alici AdSoyad:</b>
                                <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                    <asp:TextBox ID="txtAdSoyad" ToolTip="AdSoyad Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" OnTextChanged="txtAdSoyad_TextChanged" MaxLength="30"></asp:TextBox>
                                </div>
                                <div>
                                    <asp:Label ID="lblAdSoyad" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>

                                <b style="color: blue">Gönderilen Tutar:</b>
                                <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                    <asp:TextBox ID="txtTutar" CssClass="numericOnly" onkeypress="return isDecimalNumber(this,event);" ToolTip="Tutar Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" OnTextChanged="txtTutar_TextChanged"></asp:TextBox>
                                </div>
                                <div>
                                    <asp:Label ID="lblTutar" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>

                                <b style="color: blue">İşlem Açıklaması:</b>
                                <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                    <asp:TextBox ID="txtAciklama" Style="height: 20px; width: 250px" runat="server"
                                        OnTextChanged="txtAciklama_TextChanged"
                                        ToolTip="Açıklama Giriniz" AutoPostBack="true" MaxLength="50" TextMode="MultiLine"></asp:TextBox>
                                </div>
                                <div>
                                    <asp:Label ID="lblAçıklama" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>
                                <br />
                                <div style="margin-left: 75px">
                                    <asp:Button CssClass="btn btn-success" ID="btnGönder" runat="server" Text="Gönder" OnClick="btnGönder_Click" />

                                    <asp:Button CssClass="btn btn-danger" ID="btnTemizle" runat="server" Text="Temizle" OnClick="btnTemizle_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid col-lg-4" style="height: 1100px; background-color: #7bc1c4; margin-top: 95px; border-radius: 15px;">
            <div class="row">
                <div class="col-sm" style="margin-top: 20px">
                    <h2 style="color: blue">EFT ne demek?</h2>
                    <p style="color: black">
                        EFT’nin açılımı Elektronik Fon Transferi’dir ve bankalar arası transferi ifade eder. Kısaca A bankasındaki bir hesapta 
                bulunan paranın, B bankasındaki bir hesaba gönderilmesidir. Alıcı ve gönderici farklı bankalarla çalışabildiği gibi, 
                gönderici başka bankalarda bulunan kendisine ait hesaplara da EFT aracılığıyla para transferi yapabilir. 
                Farklı bankalardaki kredi kartı, fatura ve kira gibi ödemeleri için de EFT kullanılabilir. 
                EFT, sadece yurt içinde yapılan TL birimli işlemdir. Banka şubeleri, internet, mobil, telefon ve ATM üzerinden 
                gerçekleştirilebilir.
                    </p>
                    <h2 style="color: blue">EFT nasıl yapılır?</h2>
                    <p style="color: black">
                        EFT işlemleri, alıcı kişinin ya da kurumun adı, banka şubesi ve hesap numarası yazılarak ya da alıcının adı, soyadı ve 
                IBAN’ı (International Bank Account Number) belirtilerek yapılır.
                TCMB ve BKM’nin sunduğu yeni altyapı olan “Kolay Adres” ile beraber IBAN bilgisi yerine cep telefonu, kimlik numarası, 
                vergi numarası, e-posta, pasaport numarası eşleştirilmesi de yapılabilir hale gelmiştir.
                Dijitalden veya ATM üzerinden EFT işlemi yapmak için; ‘Para transferleri’ ekranından 'EFT' seçildikten sonra alıcı 
                ismi ile hesap bilgileri ve transfer edilecek tutar girilir. Bir sonraki ekranda EFT işlemi için alınacak ücret 
                belirtilir ve onay istenir. İşlemi gerçekleştirmek için paranın gönderileceği hesabın bakiyesi, transfer edilmesi istenen 
                tutarı ve işlem ücretini karşılamalıdır.
                EFT işleminde paranın bir diğer hesaba ulaşma süresi bankalar arası yoğunluk ve teknik detaylar nedeniyle değişiklik 
                gösterebilir. Transfer süresi 30 dakikayı bulabilir.
                    </p>
                    <h2 style="color: blue">EFT saatleri nedir?</h2>
                    <p style="color: black">
                        Bu transfer işleminin en önemli ayrıntılarından biri mesai saatidir. “Kolay Adres” ile başka bankaya 1000 TL’ye kadar 
                olan transfer işlemlerinizi artık 7/24 yapabilirsiniz. Ancak banka şubeleri üzerinden EFT yapmak için mesai saatlerini 
                takip etmek gerekir. Hafta sonlarında ya da resmî tatillerde EFT ile para gönderilemez. Bunun nedeni EFT işlemlerinin 
                Merkez Bankası tarafından kontrol edilip onaylanmasıdır. Örneğin Garanti BBVA'daki EFT işlemleri, resmî tatiller dışında, 
                hafta içi 08.00-17.15 saatleri arasında gerçekleştirilir.
               ‘Geç EFT’ olarak adlandırılan bir işlem de vardır. Bu, bankaların mesai saatleri dışında gerçekleşebilen bir işlemdir. 
                Ancak Geç EFT işleminin de bankalar arasında değişkenlik gösterebilen bir zaman sınırlaması bulunur. Ayrıca Geç EFT 
                işlemlerinde genelde transfer limiti uygulanır ve işlem ücreti EFT’den farklı olabilir.
                    </p>
                    <h1 style="color: blue">Geç EFT işlemlerinde genelde transfer limiti uygulanır ve işlem ücreti EFT'den farklı olabilir.</h1>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
