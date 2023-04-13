using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnÇıkış_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerLogin/CustomerLogin.aspx");
        }
    }
}