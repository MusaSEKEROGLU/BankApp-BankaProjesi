using CustomerBankAccount.DataAccess.Abstract.BBANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Concrete.BBANK
{
    public class BBANKCustomer2Account2DetailsRepository : BBANKICustomer2Account2DetailsRepository
    {
        BBANKCustomer2Account2Details customer2Account2Details = new BBANKCustomer2Account2Details();

        public void DeleteCustomer2Account2Details(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account2Details_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();
        }

        public List<BBANKCustomer2Account2Details> GetAllCustomer2Account2Details()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2Account2Details_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer2Account2Details> listcustomer2Account2Details = new List<BBANKCustomer2Account2Details>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer2Account2Details customer2Account2Details = new BBANKCustomer2Account2Details();
                    customer2Account2Details.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer2Account2Details.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);
                    customer2Account2Details.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer2Account2Details.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer2Account2Details.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer2Account2Details.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer2Account2Details.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    customer2Account2Details.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer2Account2Details.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer2Account2Details.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    listcustomer2Account2Details.Add(customer2Account2Details);
                }
            }
            if (listcustomer2Account2Details.Count > 0)
            {
                return listcustomer2Account2Details;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2Account2DetailsById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer2Account2Details customer2Account2Details = new BBANKCustomer2Account2Details();
            if (dt.Rows.Count > 0)
            {
                customer2Account2Details.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer2Account2Details.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer2Account2Details.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer2Account2Details.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
                customer2Account2Details.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer2Account2Details.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer2Account2Details.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
                customer2Account2Details.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer2Account2Details.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer2Account2Details.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
            }
            if (customer2Account2Details != null)
            {
                return customer2Account2Details;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer2Account2Details PostCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            if (bBANKCustomer2Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account2Details_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer2Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer2Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer2Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer2Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer2Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer2Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer2Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer2Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer2Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer2Account2Details;
        }
        public BBANKCustomer2Account2Details PutCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            if (bBANKCustomer2Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account2Details_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer2Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer2Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer2Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer2Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer2Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer2Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer2Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer2Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer2Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer2Account2Details;
        }
    }
}
