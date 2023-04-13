using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI.Hata
{
    public partial class Hata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLimit.Text = Request.QueryString["Hata"].ToString();
        }
        protected void btnCıkıs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerLogin/CustomerLogin.aspx");
        }
    }
}