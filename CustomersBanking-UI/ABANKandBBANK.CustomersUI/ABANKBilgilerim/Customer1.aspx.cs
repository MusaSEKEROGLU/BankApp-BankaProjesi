
using ABANKandBBANK.CustomersUI.Models;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI.ABANKBilgilerim
{
    public partial class Customer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bilgilerim();
            }
        }
        protected void bilgilerim()
        {
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/ABANKCustomer1/ABANKGetAllCustomer1").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<List<ABANKCustomer1>>(response);
            grdBilgilerCustomer1.DataSource = value;
            grdBilgilerCustomer1.DataBind();
        }
        protected void grdBilgilerCustomer1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //Gridview Başlık
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView oGridView = (GridView)sender;
                GridViewRow oGridViewRow = new GridViewRow(0, 0,
                DataControlRowType.Header, DataControlRowState.Insert);
                TableCell oTableCell = new TableCell();
                oTableCell.Text = "Kişisel Bilgilerim";
                oTableCell.Style.Add("font-weight", "bold");
                oTableCell.Style.Add("background-color", "#ff0000");
                oTableCell.Style.Add("color", "white");
                oTableCell.Style.Add("text-align", "center");
                oTableCell.Style.Add("font-size", "small");
                oGridViewRow.Cells.Add(oTableCell);
                oGridView.Controls[0].Controls.AddAt(0, oGridViewRow);
            }
        }
        protected void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABANKanasayfa/Customer1AnaSayfa.aspx");
        }
    }
}