using ABANKandBBANK.CustomersUI.ABANKHAVALE;
using ABANKandBBANK.CustomersUI.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace ABANKandBBANK.CustomersUI.Onay
{
    public partial class Onay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            lblTarih.Text = Session["GönderilenTarih:"].ToString();
            lblİşlemAçıkla.Text = Session["İşlemAçıklaması:"].ToString();
            lblOnayHesapNoGön.Text = Session["GöndericiHesapNo:"].ToString();
            lblOnayHesapNo.Text = Session["AliciHesapNo:"].ToString();
            lblOnayIbanNoGön.Text = Session["GöndericiIbanNo:"].ToString();
            lblOnayIbanNo.Text = Session["AliciIbanNo:"].ToString();
            lblOnaySubeKodu.Text = Session["AliciSubeKodu:"].ToString();
            lblOnayAdSoyad.Text = Session["AliciAdSoyad:"].ToString();
            lblOnayTutar.Text = Session["GönderilenTutar:"].ToString();
            lblİşlemTipi.Text = Session["İslemTipi:"].ToString();            
        }
        protected void btnOnay_Click(object sender, EventArgs e)
        {
            //ABANKCUSTOMER1/1 APİ
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/ABANKCustomer1Account/1").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response);
            //ABANKCUSTOMER1/2 APİ
            var httpClient2 = new HttpClient();
            var request2 = httpClient2.GetAsync("https://localhost:44340/api/ABANKCustomer1Account/2").Result;
            var response2 = request2.Content.ReadAsStringAsync().Result;
            var value2 = JsonConvert.DeserializeObject<ABANKCustomer1Account>(response2);
            //ABANKCUSTOMER2/1 APİ
            var httpClient3 = new HttpClient();
            var request3 = httpClient3.GetAsync("https://localhost:44340/api/ABANKCustomer2Account/1").Result;
            var response3 = request3.Content.ReadAsStringAsync().Result;
            var value3 = JsonConvert.DeserializeObject<ABANKCustomer2Account>(response3);
            //ABANKCUSTOMER2/2 APİ
            var httpClient4 = new HttpClient();
            var request4 = httpClient4.GetAsync("https://localhost:44340/api/ABANKCustomer2Account/2").Result;
            var response4 = request4.Content.ReadAsStringAsync().Result;
            var value4 = JsonConvert.DeserializeObject<ABANKCustomer2Account>(response4);
            //BBANKCUSTOMER1/1 APİ
            var httpClient5 = new HttpClient();
            var request5 = httpClient5.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/1").Result;
            var response5 = request5.Content.ReadAsStringAsync().Result;
            var value5 = JsonConvert.DeserializeObject<BBANKCustomer1Account>(response5);
            //BBANKCUSTOMER1/2 APİ
            var httpClient6 = new HttpClient();
            var request6 = httpClient6.GetAsync("https://localhost:44340/api/BBANKCustomer1Account/2").Result;
            var response6 = request6.Content.ReadAsStringAsync().Result;
            var value6 = JsonConvert.DeserializeObject<BBANKCustomer1Account>(response6);
            //BBANKCUSTOMER2/1 APİ
            var httpClient7 = new HttpClient();
            var request7 = httpClient7.GetAsync("https://localhost:44340/api/BBANKCustomer2Account/1").Result;
            var response7 = request7.Content.ReadAsStringAsync().Result;
            var value7 = JsonConvert.DeserializeObject<BBANKCustomer2Account>(response7);
            //BBANKCUSTOMER2/2 APİ
            var httpClient8 = new HttpClient();
            var request8 = httpClient8.GetAsync("https://localhost:44340/api/BBANKCustomer2Account/2").Result;
            var response8 = request8.Content.ReadAsStringAsync().Result;
            var value8 = JsonConvert.DeserializeObject<BBANKCustomer2Account>(response8);

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-THSSRI7\SQLEXPRESS;Initial Catalog=Dbo_MusteriBankaHesabı;Integrated Security=True;");                                                       
            connection.Open();
            using (SqlTransaction trans = connection.BeginTransaction())
            {
                try
                {                                   
//VİRMAN                      

                    //ABANK HESAPLAR ARASI(VİRMAN)-HESEPNO-CUSTOMER1
                    if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {
                            
                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }                    
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //ABANK HESAPLAR ARASI(VİRMAN)-IBANNO-CUSTOMER1
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //ABANK HESAPLAR ARASI(VİRMAN)-HESAPNO-CUSTOMER2
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }                    
                    //ABANK HESAPLAR ARASI(VİRMAN)-IBANNO-CUSTOMER2
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI(VİRMAN)-HESAPNO-CUSTOMER1
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI(VİRMAN)-IBANNO-CUSTOMER1
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI(VİRMAN)-HESAPNO-CUSTOMER2
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2VirmanHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }                   
                    //BBANK HESAPLAR ARASI(VİRMAN)-IBANNO-CUSTOMER2
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2VirmanIbanNo?GöndericiIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }

//HAVALE

                    //ABANK HESAPLAR ARASI HAVALE-HESEPNO-CUSTOMER1'den CUSTOMER2'ye
                    if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //ABANK HESAPLAR ARASI HAVALE-IBANNO-CUSTOMER1'den CUSTOMER2'ye
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer1ABANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //ABANK HESAPLAR ARASI HAVALE-HESEPNO-CUSTOMER2'den CUSTOMER1'e
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //ABANK HESAPLAR ARASI HAVALE-IBANNO-CUSTOMER2'den CUSTOMER1'e
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/ABANKCustomer2ABANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI HAVALE-HESEPNO-CUSTOMER1'den CUSTOMER2'ye
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI HAVALE-IBANNO-CUSTOMER2'den CUSTOMER1'e
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer1BBANKCustomer2HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI HAVALE-HESEPNO-CUSTOMER2'den CUSTOMER1'e
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    //BBANK HESAPLAR ARASI HAVALE-IBANNO-CUSTOMER2'den CUSTOMER1'e
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url1 = "https://localhost:44340/api";
                        var input1 = new
                        {

                        };
                        string inputJson1 = (new JavaScriptSerializer().Serialize(input1));
                        HttpClient client1 = new HttpClient();
                        HttpContent requestT1 = new StringContent(inputJson1, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client1.PostAsync(Url1 + "/HavaleTransfer/BBANKCustomer2BBANKCustomer1HavaleIbanNo?GöndericiIbanNo=" + lblOnayHesapNoGön.Text +
                            "&AliciIbanNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT1).Result;
                    }

//EFT
                    //ABANK EFT
                    if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text + 
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value2.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value2.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value3.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value3.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value5.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value5.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value6.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value6.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value7.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value7.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value4.HesapNo && lblOnayHesapNo.Text == value8.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value4.IbanNo && lblOnayIbanNo.Text == value8.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    //BBANK EFT
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value5.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value5.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value6.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value6.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value7.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value7.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }

                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value2.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value2.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value3.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value3.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayHesapNoGön.Text == value8.HesapNo && lblOnayHesapNo.Text == value4.HesapNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo?GöndericiHesapNo=" + lblOnayHesapNoGön.Text +
                            "&AliciHesapNo=" + lblOnayHesapNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    else if (lblOnayIbanNoGön.Text == value8.IbanNo && lblOnayIbanNo.Text == value4.IbanNo)
                    {
                        string Url = "https://localhost:44340/api";
                        var input = new
                        {

                        };
                        string inputJson = (new JavaScriptSerializer().Serialize(input));
                        HttpClient client = new HttpClient();
                        HttpContent requestT = new StringContent(inputJson, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseS = client.PostAsync(Url + "/EFTTransfer/BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo?GöndericiIbanNo=" + lblOnayIbanNoGön.Text +
                            "&AliciIbanNo=" + lblOnayIbanNo.Text +
                            "&AliciSubeKodu=" + lblOnaySubeKodu.Text +
                            "&Tutar=" + lblOnayTutar.Text +
                            "&İslemTipi=" + lblİşlemTipi.Text +
                            "&İşlemAçıklaması=" + lblİşlemAçıkla.Text +
                            "&AliciAdSoyad=" + lblOnayAdSoyad.Text +
                            "&GönderilenTarih=" + lblTarih.Text + "", requestT).Result;
                    }
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
                connection.Close();
                Response.Redirect("~/Sonuç/Sonuç.aspx");
            }            
        }
    }
}





 