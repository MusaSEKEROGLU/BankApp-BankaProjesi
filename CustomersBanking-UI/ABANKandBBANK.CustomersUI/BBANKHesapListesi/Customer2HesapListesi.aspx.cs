using ABANKandBBANK.CustomersUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Web.UI.WebControls;

namespace ABANKandBBANK.CustomersUI.BBANKHesapListesi
{
    public partial class Customer2HesapListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnHesapGetir_Click(object sender, EventArgs e)
        {   //Customer1-HesaplarıGetir
            var httpClient = new HttpClient();
            var request = httpClient.GetAsync("https://localhost:44340/api/BBANKCustomer2Account").Result;
            var response = request.Content.ReadAsStringAsync().Result;
            var value = JsonConvert.DeserializeObject<List<BBANKCustomer2Account>>(response);
            GrdHesaplar.DataSource = value;
            GrdHesaplar.DataBind();
        }
        protected void GrdHesaplar_RowDataBound(object sender, GridViewRowEventArgs e)
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
                //report error
            }
        }
        protected void chkHesaplar_CheckedChanged(object sender, EventArgs e)
        {   //checkBox tekli Seçim yapma
            CheckBox chk = sender as CheckBox;
            GridViewRow gvr = (GridViewRow)chk.NamingContainer;
            if (chk.Checked)
            {
                foreach (GridViewRow row in GrdHesaplar.Rows)
                {
                    if (gvr != row && ((CheckBox)row.FindControl("chkHesaplar")).Checked)
                    {
                        chk.Checked = false;
                    }
                }//CheckBox Seçim Zorunlu
                lblchkZorunlu.Text = "";
                GrdHesapDetay.Visible = true;
                GrdHesapHareketleri.Visible = true;
            }
            if (chk.Checked == false)
            {
                GrdHesapDetay.Visible = false;
                GrdHesapHareketleri.Visible = false;
                lblchkZorunlu.Text = "Lütfen Hesap Seçiniz";
            }
            //HesapDetayı CUSTOMER1 Index0 HESAP1
            for (int i = 0; i < GrdHesaplar.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplar.Rows[i];
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked)
                {
                    var httpClient1 = new HttpClient();
                    var request1 = httpClient1.GetAsync("https://localhost:44340/api/BBANKCustomer2Account1Details/BBANKGetAllCustomer2Account1Details").Result;
                    var response1 = request1.Content.ReadAsStringAsync().Result;
                    var value1 = JsonConvert.DeserializeObject<List<BBANKCustomer2Account1Details>>(response1);
                    GrdHesapDetay.DataSource = value1;
                    GrdHesapDetay.DataBind();
                    //Hesap Hareketleri Customer1 Hesap1 
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-THSSRI7\\SQLEXPRESS;Initial Catalog=Dbo_MusteriBankaHesabı;Integrated Security=True;");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM BBANKCustomer2Account1Activities", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GrdHesapHareketleri.DataSource = dt;
                    GrdHesapHareketleri.DataBind();
                    connection.Close();
                }
            }
            //HesapDetayı CUSTOMER1 Index1  HESAP2
            for (int i = 1; i < GrdHesaplar.Rows.Count; i++)
            {
                GridViewRow row = GrdHesaplar.Rows[i];
                if (((CheckBox)row.FindControl("chkHesaplar")).Checked)
                {
                    var httpClient1 = new HttpClient();
                    var request1 = httpClient1.GetAsync("https://localhost:44340/api/BBANKCustomer2Account2Details/GetAllCustomer2Account2Details").Result;
                    var response1 = request1.Content.ReadAsStringAsync().Result;
                    var value1 = JsonConvert.DeserializeObject<List<BBANKCustomer2Account2Details>>(response1);
                    GrdHesapDetay.DataSource = value1;
                    GrdHesapDetay.DataBind();
                    //Hesap Hareketleri Customer1 Hesap2 
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-THSSRI7\\SQLEXPRESS;Initial Catalog=Dbo_MusteriBankaHesabı;Integrated Security=True;");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM BBANKCustomer2Account2Activities", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GrdHesapHareketleri.DataSource = dt;
                    GrdHesapHareketleri.DataBind();
                    connection.Close();
                }
            }
        }
        protected void GrdHesapDetay_RowCreated(object sender, GridViewRowEventArgs e)
        {   //GRİDVİEW BAŞLIK HESAP DETAY
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView oGridView = (GridView)sender;
                GridViewRow oGridViewRow = new GridViewRow(0, 0,
                DataControlRowType.Header, DataControlRowState.Insert);
                TableCell oTableCell = new TableCell();
                oTableCell.Text = "Hesap Detayı";
                oTableCell.Style.Add("font-weight", "bold");
                oTableCell.Style.Add("background-color", "#ff0000");
                oTableCell.Style.Add("color", "white");
                oTableCell.Style.Add("text-align", "center");
                oTableCell.Style.Add("font-size", "small");
                oGridViewRow.Cells.Add(oTableCell);
                oGridView.Controls[0].Controls.AddAt(0, oGridViewRow);
            }
        }
        protected void GrdHesaplar_RowCreated(object sender, GridViewRowEventArgs e)
        {   //GRİDVİEW BAŞLIK HESAPLARI GETİR
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView oGridView = (GridView)sender;
                GridViewRow oGridViewRow = new GridViewRow(0, 0,
                DataControlRowType.Header, DataControlRowState.Insert);
                TableCell oTableCell = new TableCell();
                oTableCell.Text = "Hesaplarım";
                oTableCell.Style.Add("font-weight", "bold");
                oTableCell.Style.Add("background-color", "#ff0000");
                oTableCell.Style.Add("color", "white");
                oTableCell.Style.Add("text-align", "center");
                oTableCell.Style.Add("font-size", "small");
                oGridViewRow.Cells.Add(oTableCell);
                oGridView.Controls[0].Controls.AddAt(0, oGridViewRow);
            }
        }
        protected void GrdHesapHareketleri_RowCreated(object sender, GridViewRowEventArgs e)
        {   //GRİDVİEW BAŞLIK HESAP HAREKETLERİ GETİR
            if (e.Row.RowType == DataControlRowType.Header)
            {
                GridView oGridView = (GridView)sender;
                GridViewRow oGridViewRow = new GridViewRow(0, 0,
                DataControlRowType.Header, DataControlRowState.Insert);
                TableCell oTableCell = new TableCell();
                oTableCell.Text = "Hesap Hareketleri";
                oTableCell.Style.Add("font-weight", "bold");
                oTableCell.Style.Add("background-color", "#ff0000");
                oTableCell.Style.Add("color", "white");
                oTableCell.Style.Add("text-align", "center");
                oTableCell.Style.Add("font-size", "small");
                oGridViewRow.Cells.Add(oTableCell);
                oGridView.Controls[0].Controls.AddAt(0, oGridViewRow);
            }
        }
    }
}