using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGrsYap_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:44340/api";
            var input = new
            {
                TCKimlikNo = txtTCKimlikNo.Text.Trim(),
                Sifre = txtŞifre.Text.Trim()
            };
            string inputJson = (new JavaScriptSerializer().Serialize(input));
            HttpClient client = new HttpClient();
            HttpContent request = new StringContent(inputJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(apiUrl + "/CustomerLogin", request).Result;

            if (response.IsSuccessStatusCode && input.TCKimlikNo == "63862401392")
            {
                Response.Redirect("~/ABANKAnaSayfa/Customer1AnaSayfa.aspx");
            }
            else if (response.IsSuccessStatusCode && input.TCKimlikNo == "60601536186")
            {
                Response.Redirect("~/ABANKAnaSayfa/Customer2AnaSayfa.aspx");
            }
            else if (response.IsSuccessStatusCode && input.TCKimlikNo == "66775304200")
            {
                Response.Redirect("~/BBANKAnaSayfa/Customer1AnaSayfa.aspx");
            }
            else if (response.IsSuccessStatusCode && input.TCKimlikNo == "62800491280")
            {
                Response.Redirect("~/BBANKAnaSayfa/Customer1AnaSayfa.aspx");
            }
            else
            {
                lblhata.Text = "*Şifreniz Hatalı.Lütfen Kontrol Ediniz";
                txtŞifre.Focus();
                lblTCKimlikNo.Text = "";
                lblTCKimlikNoOk.Text = "✓";
            }
            if (string.IsNullOrEmpty(txtTCKimlikNo.Text))
            {
                lblTCKimlikNo.Text = "*TCKimlik Numarası Alanı Boş Geçilemez";
                txtTCKimlikNo.Focus();
            }
            else if (txtTCKimlikNo.Text.Length != 11)
            {
                lblTCKimlikNo.Text = "*TCKimlik Numarası 11 Haneli Olmalıdır.Lütfen Kontrol Ediniz";
                txtTCKimlikNo.Focus();
            }
            else if (txtTCKimlikNo.Text.StartsWith("0"))
            {
                lblTCKimlikNo.Text = "*TCKimlik Numarasının İlk Hanesi Sıfır ile başlayamaz.Lütfen Kontrol Ediniz";
                txtTCKimlikNo.Focus();
            }
            else
            {
                // Her hanesi rakamsal değer içerir.
                var isValidChars = "0123456789";
                if (txtTCKimlikNo.Text.Any(a => !isValidChars.Contains(a)))
                {
                    lblTCKimlikNo.Text = "*TCKimlik Numarası Hatalıdır.Lütfen Kontrol Ediniz";
                    txtTCKimlikNo.Focus();
                }
                var tekHaneliler = 0;
                var ciftHaneliler = 0;
                for (int i = 0; i < 9; i++)
                {
                    var value = Convert.ToInt32(txtTCKimlikNo.Text[i].ToString());
                    if (i % 2 == 0)
                        tekHaneliler += value;
                    else
                        ciftHaneliler += value;
                }
                // 1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında,
                // elde edilen sonucun 10’a bölümünden kalan, yani Mod10’u bize 10. haneyi verir.
                if ((((tekHaneliler * 7) - ciftHaneliler) % 10).ToString() != txtTCKimlikNo.Text[9].ToString())
                {
                    lblTCKimlikNo.Text = "*TCKimlik Numarası Hatalıdır.Lütfen Kontrol Ediniz";
                    txtTCKimlikNo.Focus();
                }
                // 1. 2. 3. 4. 5. 6. 7. 8. 9. ve 10. hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, yani Mod10’u bize 11. haneyi verir.
                if (((tekHaneliler + ciftHaneliler + Convert.ToInt32(txtTCKimlikNo.Text[9].ToString())) % 10).ToString() != txtTCKimlikNo.Text[10].ToString())
                {
                    lblTCKimlikNo.Text = "*TCKimlik Numarası Hatalıdır.Lütfen Kontrol Ediniz";
                    txtTCKimlikNo.Focus();
                }
            }
        }
    }
}