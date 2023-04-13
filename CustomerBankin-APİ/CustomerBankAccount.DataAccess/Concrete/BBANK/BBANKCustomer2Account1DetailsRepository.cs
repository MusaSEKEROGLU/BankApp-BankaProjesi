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
    public class BBANKCustomer2Account1DetailsRepository : BBANKICustomer2Account1DetailsRepository
    {
        BBANKCustomer2Account1Details customer2AccountDetails = new BBANKCustomer2Account1Details();

        public void DeleteCustomer2Account1Details(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account1Details_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();
        }

        public List<BBANKCustomer2Account1Details> GetAllCustomer2Account1Details()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2Account1Details_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer2Account1Details> listcustomer2AccountDetails = new List<BBANKCustomer2Account1Details>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer2Account1Details customer2AccountDetails = new BBANKCustomer2Account1Details();
                    customer2AccountDetails.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer2AccountDetails.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);
                    customer2AccountDetails.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer2AccountDetails.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer2AccountDetails.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer2AccountDetails.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer2AccountDetails.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    customer2AccountDetails.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer2AccountDetails.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer2AccountDetails.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    listcustomer2AccountDetails.Add(customer2AccountDetails);
                }
            }
            if (listcustomer2AccountDetails.Count > 0)
            {
                return listcustomer2AccountDetails;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2Account1DetailsById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer2Account1Details customer2AccountDetails = new BBANKCustomer2Account1Details();
            if (dt.Rows.Count > 0)
            {
                customer2AccountDetails.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer2AccountDetails.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer2AccountDetails.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer2AccountDetails.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
                customer2AccountDetails.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer2AccountDetails.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer2AccountDetails.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
                customer2AccountDetails.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer2AccountDetails.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer2AccountDetails.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
            }
            if (customer2AccountDetails != null)
            {
                return customer2AccountDetails;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer2Account1Details PostCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            if (bBANKCustomer2Account1Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account1Details_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer2Account1Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer2Account1Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer2Account1Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer2Account1Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer2Account1Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer2Account1Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer2Account1Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer2Account1Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer2Account1Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer2Account1Details;
        }
        public BBANKCustomer2Account1Details PutCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            if (bBANKCustomer2Account1Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account1Details_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer2Account1Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer2Account1Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer2Account1Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer2Account1Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer2Account1Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer2Account1Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer2Account1Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer2Account1Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer2Account1Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer2Account1Details;
        }
    }
}
