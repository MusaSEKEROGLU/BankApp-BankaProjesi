<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer2HesapListesi.aspx.cs" Inherits="ABANKandBBANK.CustomersUI.BBANKHesapListesi.Customer2HesapListesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BBANK Customer2HesapListesi</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link href="../Css/HesapListesi.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script>
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
            <a class="navbar-brand" runat="server" href="~/" style="color: blue; margin-left: 5px; font-size: 25px"></a>
            <div style="margin-left: 1200px; height: 25px">
                <a class="btn btn-warning " runat="server" href="~/BBANKAnaSayfa/Customer2AnaSayfa">Ana Sayfa</a>
            </div>
        </div>
        <div class="container-fluid" id="Tablo" style="width: 1600px; height: 750px; border-radius: 10px; margin-left: 10px; margin-top: 75px; background-color: #0094ff; opacity: 1.2; overflow-x: auto; overflow-y: auto;">
            <h4 style="color: black; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold;">BBANK Hesaplarım</h4>
            <p style="color: #ffffff; font-family: 'Times New Roman', Times, serif; font-size: medium; font-weight: bold;">&copy; <%: DateTime.Now %></p>
            <br />
            <div>
                <asp:Button CssClass="btn btn-warning" ID="btnHesapGetir" runat="server" Text="Vadesiz Hesaplarım" OnClick="btnHesapGetir_Click" />
                <br />
                <br />
                <asp:GridView ID="GrdHesaplar" OnRowDataBound="GrdHesaplar_RowDataBound" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" Height="69px" Width="950px" OnRowCreated="GrdHesaplar_RowCreated" CellSpacing="2" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                HesapSeçiniz
                            </HeaderTemplate>
                            <ItemTemplate>

                                <asp:CheckBox ID="chkHesaplar" OnCheckedChanged="chkHesaplar_CheckedChanged" AutoPostBack="true" runat="server" TextAlign="Left" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
            <asp:Label ID="lblchkZorunlu" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
            <br />            
            <div>                
                <asp:GridView ID="GrdHesapDetay" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" Height="90px" Width="950px" OnRowCreated="GrdHesapDetay_RowCreated" CellSpacing="2" ForeColor="Black">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:Label ID="lblGvHesapDetay" runat="server" Text=""></asp:Label>
            </div>
            <br />          
            <div>
                <%--<asp:Button CssClass="btn btn-warning form-control" ID="btnHesapHareketleri" runat="server" Text="Hesap Harketleri" OnClick="btnHesapHareketleri_Click" />--%>
                <br />               
                <div style="height: 350px; width: 1570px; overflow: scroll">
                    <asp:GridView ID="GrdHesapHareketleri" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="264px" Width="1548px" OnRowCreated="GrdHesapHareketleri_RowCreated" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
