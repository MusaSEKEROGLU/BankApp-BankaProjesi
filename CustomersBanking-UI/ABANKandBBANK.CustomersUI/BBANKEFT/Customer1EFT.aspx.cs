using ABANKandBBANK.CustomersUI.Models;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI.BBANKEFT
{
    public partial class Customer1EFT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox'a girilen Verileri Onay sayfasına aktarır
            Session.Add("GönderilenTarih:", txtTarih.Text);
            Session.Add("İşlemAçıklaması:", txtAciklama.Text);
            Session.Add("GöndericiHesapNo:", txtHesapNoGön.Text);
            Session.Add("AliciHesapNo:", txtHesapNo.Text);
            Session.Add("GöndericiIbanNo:", txtIbanNoGön.Text);
            Session.Add("AliciIbanNo:", txtIbanNo.Text);
            Session.Add("AliciSubeKodu:", txtSubeKodu.Text);
            Session.Add("AliciAdSoyad:", txtAdSoyad.Text);
            Session.Add("GönderilenTutar:", txtTutar.Text);
            Session.Add("İslemTipi:", txtislemtipi.Text);
        }
        protected void btnTemizle_Click(object sender, EventArgs e)
        {
            txtislemtipi.Text = string.Empty;
            lblislemtipi.Text = string.Empty;

            txtTarih.Text = string.Empty;
            lblTarih.Text = string.Empty;

            txtHesapNoGön.Text = string.Empty;
            lblHesapNoGön.Text = string.Empty;

            txtHesapNo.Text = string.Empty;
            lblHesapNo.Text = string.Empty;

            txtIbanNoGön.Text = string.Empty;
            lblIbanNoGön.Text = string.Empty;

            txtIbanNo.Text = string.Empty;
            lblIbanNo.Text = string.Empty;
            lblIbanNo1.Text = string.Empty;
            lblIbanNo2.Text = String.Empty;

            txtSubeKodu.Text = string.Empty;
            lblSubeKodu.Text = string.Empty;

            txtAdSoyad.Text = string.Empty;
            lblAdSoyad.Text = string.Empty;

            txtTutar.Text = string.Empty;
            lblTutar.Text = string.Empty;

            txtAciklama.Text = string.Empty;
            lblAçıklama.Text = string.Empty;

            lblDrpSecimi.Text = "Lütfen Transfer Türünü Belirleyiniz.";
            DrpHesapSec.SelectedIndex = 0;
            //GridView içindeki ChecBox işaretlemesini kaldırır.
            for (int i = 0; i < GrdHesaplarıGetir.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplarıGetir.Rows[i];
                (((CheckBox)row.FindControl("chkHesaplar")).Checked) = false;
            }
            for (int i = 1; i < GrdHesaplarıGetir.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplarıGetir.Rows[i];
                (((CheckBox)row.FindControl("chkHesaplar")).Checked) = false;
            }
            lblHesapSeçimi.Text = "Lütfen Hesap Seçimi yapınız.";
        }
        protected void btnGönder_Click(object sender, EventArgs e)
        {   //ABANKHata
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/1").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response);

            var httpClient2 = new HttpClient();
            var request2 = httpClient2.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/2").Result;
            var response2 = request2.Content.ReadAsStringAsync().Result;
            var value2 = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response2);

            if (txtTutar.Text != string.Empty)
            {
                //HesapNo Gönderen
                if (value.HesapNo == txtHesapNoGön.Text)
                {
                    if (Convert.ToDecimal(txtTutar.Text) > value.GünlükTransferLimiti)
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Günlük Transfer Limitinden Fazla Tutar Gönderemezsiniz! Lütfen Tekrar Deneyiniz...");
                    }
                    if (value.HesapBakiye < Convert.ToDecimal(txtTutar.Text))
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Hesap Bakiyeniz Yetersizdir!");
                    }
                }
                else if (value2.HesapNo == txtHesapNoGön.Text)
                {
                    if (value2.HesapBakiye < Convert.ToDecimal(txtTutar.Text))
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Hesap Bakiyeniz Yetersizdir!");
                    }
                    if (Convert.ToDecimal(txtTutar.Text) > value2.GünlükTransferLimiti)
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Günlük Transfer Limitinden Fazla Tutar Gönderemezsiniz! Lütfen Tekrar Deneyiniz...");
                    }
                }
                //IbanNo Gönderen
                if (value.IbanNo == txtIbanNoGön.Text)
                {
                    if (Convert.ToDecimal(txtTutar.Text) > value.GünlükTransferLimiti)
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Günlük Transfer Limitinden Fazla Tutar Gönderemezsiniz! Lütfen Tekrar Deneyiniz...");
                    }
                    if (value.HesapBakiye < Convert.ToDecimal(txtTutar.Text))
                    {
                        Server.Transfer("~/Hata/Hata.aspx?Hata= * Hesap Bakiyeniz Yetersizdir!");
                    }
                    else if (value2.IbanNo == txtIbanNoGön.Text)
                    {
                        if (Convert.ToDecimal(txtTutar.Text) > value2.GünlükTransferLimiti)
                        {
                            Server.Transfer("~/Hata/Hata.aspx?Hata= * Günlük Transfer Limitinden Fazla Tutar Gönderemezsiniz! Lütfen Tekrar Deneyiniz...");
                        }
                        if (value2.HesapBakiye < Convert.ToDecimal(txtTutar.Text))
                        {
                            Server.Transfer("~/Hata/Hata.aspx?Hata= * Hesap Bakiyeniz Yetersizdir!");
                        }
                    }
                }
            }
            if (txtTarih.Text == string.Empty)
            {
                lblTarih.Text = "*Tarih Alanı Boş Geçilemez!";
            }
            if (txtSubeKodu.Text == string.Empty)
            {
                lblSubeKodu.Text = "Sube Kodu Alanı Boş Geçilemez!";
            }
            if (txtHesapNo.Text == string.Empty)
            {
                lblHesapNo.Text = "*Hesap No Alanı Boş Geçilemez!";
            }
            if (txtHesapNoGön.Text == string.Empty)
            {
                lblHesapNoGön.Text = "*Hesap No Alanı Boş Geçilemez!";
            }
            if (txtIbanNo.Text == string.Empty && txtIbanNo.Visible == true)
            {
                lblIbanNo.Text = "*Iban No Alanı Boş Geçilemez!";
            }
            if (txtIbanNoGön.Text == string.Empty && txtIbanNoGön.Visible == true)
            {
                lblIbanNoGön.Text = "*Iban No Alanı Boş Geçilemez!";
            }
            if (txtAdSoyad.Text == string.Empty)
            {
                lblAdSoyad.Text = "*Ad-Soyad Alanı Boş Geçilemez!";
            }
            if (txtTutar.Text == string.Empty)
            {
                lblTutar.Text = "*Tutar Alanı Boş Geçilemez!";
            }
            if (DrpHesapSec.SelectedIndex == 0)
            {
                lblDrpSecimi.Text = "*Lütfen EFT Türünüzü Belirleyiniz,Boş Geçilemez!";
            }
            if (txtHesapNo.Enabled == false)
            {
                lblHesapNo.Text = string.Empty;
            }
            if (txtIbanNo.Enabled == false)
            {
                lblIbanNo.Text = string.Empty;
            }
            if (txtAciklama.Text == string.Empty)
            {
                lblAçıklama.Text = "*Açıklama Alanı Boş Geçilemez!";
            }
            if (DrpHesapSec.SelectedIndex == 1 && txtHesapNo.Text !=
                string.Empty && txtHesapNoGön.Text != string.Empty && txtAdSoyad.Text != string.Empty && txtTutar.Text != string.Empty
                && txtAciklama.Text != string.Empty && txtTarih.Text != string.Empty && txtislemtipi.Text != string.Empty && txtSubeKodu.Text != string.Empty)
            {
                Response.Redirect("~/Onay/Onay.aspx");
            }
            else
            {
                if (txtTarih.Text == string.Empty)
                {
                    lblTarih.Text = "*Tarih Alanı Boş Geçilemez!";
                }
                if (txtHesapNo.Text == string.Empty)
                {
                    lblHesapNo.Text = "*Hesap No Alanı Boş Geçilemez!";
                }
                if (txtHesapNoGön.Text == string.Empty)
                {
                    lblHesapNoGön.Text = "*Hesap No Alanı Boş Geçilemez!";
                }
                if (txtAdSoyad.Text == string.Empty)
                {
                    lblAdSoyad.Text = "*Ad-Soyad Alanı Boş Geçilemez!";
                }
                if (txtTutar.Text == string.Empty)
                {
                    lblTutar.Text = "*Tutar Alanı Boş Geçilemez!";
                }
                if (txtAciklama.Text == string.Empty)
                {
                    lblAçıklama.Text = "*Açıklama Kısmı Boş Geçilemez!";
                }
                if (txtislemtipi.Text == string.Empty)
                {
                    lblislemtipi.Text = "*Lütfen İşlem Tipini Belirtiniz!";
                }
            }
            if (DrpHesapSec.SelectedIndex == 2 && txtIbanNo.Text !=
                string.Empty && txtIbanNoGön.Text != string.Empty && txtAdSoyad.Text != string.Empty && txtTutar.Text != string.Empty
                && txtAciklama.Text != string.Empty && txtTarih.Text != string.Empty && txtislemtipi.Text != string.Empty && txtSubeKodu.Text != string.Empty)
            {
                Response.Redirect("~/Onay/Onay.aspx");
            }
            else
            {
                if (txtTarih.Text == string.Empty)
                {
                    lblTarih.Text = "*Tarih Alanı Boş Geçilemez!";
                }
                if (txtIbanNo.Text == string.Empty && txtIbanNo.Visible == true)
                {
                    lblIbanNo.Text = "*Iban No Alanı Boş Geçilemez!";
                }
                if (txtIbanNoGön.Text == string.Empty && txtIbanNoGön.Visible == true)
                {
                    lblIbanNoGön.Text = "*Iban No Alanı Boş Geçilemez!";
                }
                if (txtAdSoyad.Text == string.Empty)
                {
                    lblAdSoyad.Text = "*Ad-Soyad Alanı Boş Geçilemez!";
                }
                if (txtTutar.Text == string.Empty)
                {
                    lblTutar.Text = "*Tutar Alanı Boş Geçilemez!";
                }
                if (txtAciklama.Text == string.Empty)
                {
                    lblAçıklama.Text = "*Açıklama Kısmı Boş Geçilemez!";
                }
                if (txtislemtipi.Text == string.Empty)
                {
                    lblislemtipi.Text = "*Lütfen İşlem Tipini Belirtiniz!";
                }
            }
            if (txtHesapNo.Visible == false)
            {
                lblHesapNo.Text = "";
            }
            else if (txtHesapNoGön.Visible == false)
            {
                lblIbanNoGön.Text = "";
            }
            else if (txtIbanNoGön.Visible == false)
            {
                lblIbanNoGön.Text = "";
            }
            else if (txtIbanNo.Visible == false)
            {
                lblIbanNo.Text = "";
            }
        }
        protected void DrpHesapSec_SelectedIndexChanged1(object sender, EventArgs e)
        {    //Dropdown Seçimini Otomatik TextBox'a Doldurma
            if (IsPostBack)
            {
                txtislemtipi.Text = DrpHesapSec.SelectedItem.Text;
            }
            //Dropdown Seçimi ve textBox'ların durumu
            if (DrpHesapSec.SelectedIndex == 1)
            {
                txtIbanNo.Visible = false;
                txtIbanNoGön.Visible = false;
                txtSubeKodu.Visible = true;
                txtIbanNo.Text = string.Empty;
                txtIbanNoGön.Text = string.Empty;

                txtHesapNo.Visible = true;
                txtHesapNoGön.Visible = true;
                txtAdSoyad.Visible = true;
                lblAdSoyad.Text = string.Empty;
                txtTutar.Visible = true;
                lblTutar.Text = string.Empty;
                txtAciklama.Visible = true;
                lblAçıklama.Text = string.Empty;
                lblDrpSecimi.Text = string.Empty;
                txtTarih.Visible = true;
            }
            else if (DrpHesapSec.SelectedIndex == 2)
            {
                txtHesapNo.Visible = false;
                txtHesapNoGön.Visible = false;
                txtSubeKodu.Visible = true;
                txtHesapNo.Text = string.Empty;
                txtHesapNoGön.Text = string.Empty;

                txtIbanNo.Visible = true;
                txtIbanNoGön.Visible = true;
                txtAdSoyad.Visible = true;
                lblAdSoyad.Text = string.Empty;
                txtTutar.Visible = true;
                lblTutar.Text = string.Empty;
                txtAciklama.Visible = true;
                lblAçıklama.Text = string.Empty;
                lblDrpSecimi.Text = string.Empty;
                txtTarih.Visible = true;
            }
            else if (DrpHesapSec.SelectedIndex == 0)
            {
                txtislemtipi.Visible = false;
                txtTarih.Visible = false;
                txtHesapNo.Visible = false;
                txtHesapNoGön.Visible = false;
                txtIbanNo.Visible = false;
                txtIbanNoGön.Visible = false;
                txtAdSoyad.Visible = false;
                txtTutar.Visible = false;
                txtAciklama.Visible = false;
                lblDrpSecimi.Text = "EFT Türü Seçiniz";
            }
        }
        protected void GrdHesaplarıGetir_RowCreated(object sender, GridViewRowEventArgs e)
        {   //Gridview Başlık
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView oGridView = (GridView)sender;
                GridViewRow oGridViewRow = new GridViewRow(0, 0,
                DataControlRowType.Header, DataControlRowState.Insert);
                TableCell oTableCell = new TableCell();
                oTableCell.Text = "GönderenHesap";
                oTableCell.Style.Add("font-weight", "bold");
                oTableCell.Style.Add("background-color", "#ff0000");
                oTableCell.Style.Add("color", "white");
                oTableCell.Style.Add("text-align", "center");
                oTableCell.Style.Add("font-size", "small");
                oGridViewRow.Cells.Add(oTableCell);
                oGridView.Controls[0].Controls.AddAt(0, oGridViewRow);
            }
        }
        protected void GrdHesaplarıGetir_RowDataBound(object sender, GridViewRowEventArgs e)
        {   //checkBox tekli Seçim yapma
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    string strScript = "TekliSecimYap(" + ((CheckBox)e.Row.Cells[0].FindControl("chkHesaplar")).ClientID + ");";
                    ((CheckBox)e.Row.Cells[0].FindControl("chkHesaplar")).Attributes.Add("onclick", strScript);
                }
            }
            catch (Exception)
            {
                //rapor error
            }
        }
        protected void chkHesaplar_CheckedChanged(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/1").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response);

            var httpClient2 = new HttpClient();
            var request2 = httpClient2.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/2").Result;
            var response2 = request2.Content.ReadAsStringAsync().Result;
            var value2 = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response2);

            //checkBox Zorunlu Seçim Otomatik HesapNo veya IbanNo Doldurma
            for (int i = 0; i < GrdHesaplarıGetir.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplarıGetir.Rows[i];
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == false)
                {
                    lblHesapSeçimi.Text = "Hesap Seçimi Zorunludur";
                }
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == true)
                {
                    lblHesapSeçimi.Text = "";
                    txtHesapNoGön.Text = value.HesapNo;
                    if (DrpHesapSec.SelectedIndex == 1)
                    {
                        txtIbanNoGön.Visible = false;
                        txtIbanNo.Visible = false;
                    }
                }
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == true)
                {
                    lblHesapSeçimi.Text = "";
                    txtIbanNoGön.Text = value.IbanNo;
                    if (DrpHesapSec.SelectedIndex == 2)
                    {
                        txtHesapNoGön.Visible = false;
                        txtHesapNo.Visible = false;
                    }
                }
            }
            for (int i = 1; i < GrdHesaplarıGetir.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplarıGetir.Rows[i];
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == false)
                {
                    lblHesapSeçimi.Text = "Hesap Seçimi Zorunludur";
                }
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == true)
                {
                    lblHesapSeçimi.Text = "";
                    txtHesapNoGön.Text = value2.HesapNo;
                    if (DrpHesapSec.SelectedIndex == 1)
                    {
                        txtIbanNoGön.Visible = false;
                        txtIbanNo.Visible = false;
                    }
                }
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked == true)
                {
                    lblHesapSeçimi.Text = "";
                    txtIbanNoGön.Text = value2.IbanNo;
                    if (DrpHesapSec.SelectedIndex == 2)
                    {
                        txtHesapNoGön.Visible = false;
                        txtHesapNo.Visible = false;
                    }
                }
            }
            //checkBox tekli Seçim yapma
            CheckBox chk = sender as CheckBox;
            GridViewRow gvr = (GridViewRow)chk.NamingContainer;
            if (chk.Checked)
            {
                foreach (GridViewRow row in GrdHesaplarıGetir.Rows)
                {
                    if (gvr != row && ((CheckBox)row.FindControl("chkHesaplar")).Checked)
                    {
                        chk.Checked = false;
                    }
                }
                lblHesapSeçimi.Text = "";
                txtAciklama.Visible = true;
                txtAdSoyad.Visible = true;
                txtHesapNo.Visible = true;
                txtHesapNoGön.Visible = true;
                txtIbanNo.Visible = true;
                txtIbanNoGön.Visible = true;
                txtTutar.Visible = true;
            }
        }
        protected void btnHesapGetir_Click(object sender, EventArgs e)
        {   //HesapListesi Getir CoreApi
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/BBANKGetAllCustomer1Account").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<List<ABANKCustomer1Account>>(response);
            GrdHesaplarıGetir.DataSource = value;
            GrdHesaplarıGetir.DataBind();
            lblHesapSeçimi.Text = "Lütfen Hesap Seçiniz";
        }
        protected void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {   //textBox text'ini Büyük harfe çevirme
            txtAdSoyad.Text = txtAdSoyad.Text.ToUpper();
        }
        protected void txtAciklama_TextChanged(object sender, EventArgs e)
        {   //textBox text'ini Büyük harfe çevirme
            txtAciklama.Text = txtAciklama.Text.ToUpper();
        }
        protected void txtTutar_TextChanged(object sender, EventArgs e)
        {


        }
        protected void txtIbanNo_TextChanged(object sender, EventArgs e)
        {    //IbanNo Kontrol Alıcı
            int uzunluk = txtIbanNo.Text.Length;
            string hesapKod = "";
            if (uzunluk > 26)
            {
                lblIbanNo.Text = "*Uzunluk büyük, 26 hane olmalı!";
            }
            if (uzunluk < 26)
            {
                lblIbanNo.Text = "*Uzunluk küçük, 26 hane olmalı!";
            }
            if (uzunluk == 26)
            {
                if (txtIbanNo.Text[0] != 'T' || txtIbanNo.Text[1] != 'R')
                {
                    lblIbanNo.Text = "*İlk iki hanesi TR olmalı";
                }
                else
                {
                    lblIbanNo1.Text = "Banka Kodu :" + txtIbanNo.Text[5].ToString() +
                    txtIbanNo.Text[6].ToString() +
                    txtIbanNo.Text[7].ToString() +
                    txtIbanNo.Text[8].ToString() +
                    txtIbanNo.Text[9].ToString();

                    for (int i = 10; i < 26; i++)
                    {
                        hesapKod += txtIbanNo.Text[i].ToString();
                    }
                    lblIbanNo2.Text = "Hesap Kodu :" + hesapKod;
                }
            }
        }
        protected void txtIbanNoGön_TextChanged(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/BBANKGetAllCustomer1Account").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<List<ABANKCustomer1Account>>(response);

            if (txtIbanNoGön.Text == value.FirstOrDefault().IbanNo || txtIbanNoGön.Text == value.LastOrDefault().IbanNo)
            {
                lblIbanNoGön.Text = string.Empty;
            }
            else
            {
                lblIbanNoGön.Text = "*Iban Numarası Size ait değildir,Lütfen kontrol ediniz";
            }
        }
        protected void txtHesapNoGön_TextChanged(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/BBANKGetAllCustomer1Account").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<List<ABANKCustomer1Account>>(response);
            //HesapNo Kontrol
            if (txtHesapNoGön.Text == value.FirstOrDefault().HesapNo || txtHesapNoGön.Text == value.LastOrDefault().HesapNo)
            {
                lblHesapNoGön.Text = string.Empty;
            }
            else
            {
                lblHesapNoGön.Text = "*Hesap Numarası Size ait değildir,Lütfen kontrol ediniz";
            }
        }
    }
}

