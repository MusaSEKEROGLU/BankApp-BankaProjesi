using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI.Sonuç
{
    public partial class Sonuç : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Havale ve EFT Sayfalarından seçilen işlem tipi sonuç sayfasında yazar
            lblİslemTipi.Text = Session["İslemTipi:"].ToString();
        }
    }
}