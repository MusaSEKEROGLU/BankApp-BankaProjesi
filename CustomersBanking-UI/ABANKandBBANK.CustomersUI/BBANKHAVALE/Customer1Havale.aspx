<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer1Havale.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.BBANKHAVALE.Customer1Havale" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BBANK Customer1Havale</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link href="../Css/Havale.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
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
<body style="font-family: 'Times New Roman', Times, serif; background-color: #808080; opacity: 1.2">
    <form id="form" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" style="position: fixed; top: 0px; left: 0px; right: 0px;">
            <img src="../İmages/BBANK.png" id="logo" style="height: 60px; width: 60px; border-radius: 15px; margin-left: -175px;" />
            <a class="navbar-brand" id="ABANK" runat="server"></a>
            <div style="margin-left: 1200px; height: 25px">
                <a class="btn btn-warning " runat="server" href="~/BBANKAnaSayfa/Customer1AnaSayfa.aspx">Ana Sayfa</a>
            </div>
        </div>
        <br />
        <%--ikinci navbar div--%>
        <div class="navbar navbar-inverse navbar-fixed-top" style="background-color: #e3f2fd; height: 20px; margin-top: 70px; position: fixed; top: 0px; left: 0px; right: 0px;">
            <p style="margin-left: -60px; font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Siz değerli müşterilerimize hizmet vermekten mutluluk duyuyoruz...</p>
            <input type="text" placeholder="search" style="width: 390px; height: 30px; border-radius: 5px; background-color: #de9f9f; margin-left: 400px; color: black" />
        </div>
        <div class="container-fluid col-lg-9" id="Tablo" style="height: 1100px;">
            <div class="row">
                <div class="col-sm">
                    <h4 style="color: black; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold;">BBANK HAVALE İşlemleri</h4>
                    <p style="color: #ffffff; font-family: 'Times New Roman', Times, serif; font-size: medium; font-weight: bold;">&copy; <%: DateTime.Now %></p>
                    <asp:Button CssClass="btn btn-warning" ID="btnHesapGetir" runat="server" Text="Vadesiz Hesaplarım" ToolTip="Hesaplarım" OnClick="btnHesapGetir_Click" Width="250px" />
                    <br />
                    <br />
                    <asp:DropDownList CssClass="btn btn-success" ID="DrpHesapSec" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="DrpHesapSec_SelectedIndexChanged1" ToolTip="HAVALE Seçimi" Width="250px">
                        <asp:ListItem Selected="True" Value="0">HAVALE Türü Seçiniz</asp:ListItem>
                        <asp:ListItem Value="1">HesapNo ile HAVALE</asp:ListItem>
                        <asp:ListItem Value="2">IbanNo ile HAVALE</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div>
                        &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblHDrpSecimi" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
                    </div>
                    <br />
                    <br />
                    <br />
                    <asp:GridView ID="GrdHHesaplarıGetir" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"
                        OnRowDataBound="GrdHesaplarıGetir_RowDataBound" OnRowCreated="GrdHesaplarıGetir_RowCreated" Width="950px" GridLines="Vertical" ForeColor="Black">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Hesap Seçiniz
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkHHesaplar" AutoPostBack="true" OnCheckedChanged="chkHesaplar_CheckedChanged" runat="server" />
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
                    <asp:Label ID="lblHHesapSeçimi" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
                    <br />
                    <br />
                    <div style="width: 300px; height: 750px; background-color: #ffffff; border-radius: 10px; border: 2px solid">
                        <div style="margin-left: 15px; margin-top: 15px">
                            <b style="color: blue">İslem Tipi:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtislemtipi" ToolTip="İşlem Tipi" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="20"></asp:TextBox>
                            </div>
                            <asp:Label ID="lblislemtipi" ForeColor="Red" runat="server" Text=""></asp:Label>
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
                                <asp:Label ID="lblHesapNoGön" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <b style="color: blue">Alici HesapNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtHesapNo" ToolTip="HesapNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="10"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblHesapNo" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">Gönderici IbanNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtIbanNoGön" ToolTip="IbanNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="26" OnTextChanged="txtIbanNoGön_TextChanged"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblIbanNoGön" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">Alici IbanNo:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtIbanNo" ToolTip="IbanNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="26" OnTextChanged="txtIbanNo_TextChanged"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblIbanNo" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                <asp:Label ID="lblIbanNo1" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                                <asp:Label ID="lblIbanNo2" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">Alici Sube Kodu:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtSubeKodu" ToolTip="HesapNo Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" MaxLength="10"></asp:TextBox>
                            </div>
                            <asp:Label ID="lblSubeKodu" ForeColor="Red" runat="server" Text=""></asp:Label>
                            <b style="color: blue">Alici AdSoyad:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtAdSoyad" ToolTip="AdSoyad Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" OnTextChanged="txtAdSoyad_TextChanged" MaxLength="30"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblAdSoyad" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">Gönderilen Tutar:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtTutar" CssClass="numericOnly" onkeypress="return isNumberKey(this,event);" ToolTip="Tutar Giriniz" AutoPostBack="true" Style="height: 20px; width: 250px" runat="server" OnTextChanged="txtTutar_TextChanged"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblTutar" ForeColor="Red" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <b style="color: blue">İşlem Açıklaması:</b>
                            <div class="form-control label-info" style="height: 30px; background-color: #00ffff; width: 267px">
                                <asp:TextBox ID="txtAciklama" Style="height: 20px; width: 250px" runat="server"
                                    OnTextChanged="txtAciklama_TextChanged"
                                    ToolTip="Açıklama Giriniz" AutoPostBack="true" MaxLength="50" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblAçıklama" ForeColor="Red" runat="server" Text=""></asp:Label>
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
        <div class="container col-sm-3" style="height: 1100px; background-color: #7bc1c4; margin-top: 110px; border-radius: 15px;">
            <div class="row">
                <div class="col-sm" style="margin-top: 20px">
                    <h2 style="color: blue">Havale ne demek?</h2>
                    <p style="color: black">
                        Banka hesabında bulunan bir paranın, yine aynı banka içerisindeki diğer hesaba veya başkasına ait bir hesaba gönderilmesi 
                işlemine havale denir. Buradaki kilit nokta, tüm hesapların aynı bankada kayıtlı olmasıdır. 
                Bu nedenle haftanın 7 günü 24 saat havale talimatı verilebilir. Banka havaleleri; banka şubeleri, internet,
                mobil, telefon ve ATM üzerinden yürütülür.
                İstenildiği takdirde yapılan bir havale işlemi kaydedilebilir veya düzenli havale talimatı verilebilir, böylece 
                bir sonraki havale işlemi çok daha kısa sürede gerçekleştirilebilir.
                    </p>
                    <h2 style="color: blue">Havale Nasıl Yapılır?</h2>
                    <p style="color: black">
                        Bir havale işlemi için alıcının 26 haneli IBAN’ına (International Bank Account Number) ya da şube ve hesap numarasına
                ihtiyaç vardır. Dijitalden veya ATM üzerinden havale işlemi, genel olarak ‘para transferi’ kısmında yer alan 'havale'
                seçeneği üzerinden yapılır. Para gönderilecek kişinin IBAN veya hesap numarası girildikten sonra aktarılacak tutar 
                sorulur. Bir sonraki ekranda da para aktarılacak kişinin adı, soyadı veya sadece baş harfleri, işlemin teyit edilmesi 
                için gösterilir.TCMB ve BKM’nin sunduğu yeni altyapı olan “Kolay Adres” ile beraber IBAN bilgisi yerine cep telefonu, TCKN, VKN, e-posta, pasaport numarası eşleştirilmesi de yapılabilir hale gelmiştir.
                Havale işlemiyle yapılmak istenen ödeme miktarı gönderenin hesabında bulunduğu takdirde havale talimatı saniyeler 
                içinde onaylanır ve para alıcının hesabına aktarılır.
                Bir havale işlemi için ne kadar ücret talep edileceği bankalar arasında farklılık gösterir. Ayrıca işlemin hangi 
                kanal aracılığıyla (ATM, mobil bankacılık vs.) gerçekleştirildiği de ücreti değiştirebilir.
                    </p>
                </div>
            </div>
        </div>       
    </form>
</body>
</html>


