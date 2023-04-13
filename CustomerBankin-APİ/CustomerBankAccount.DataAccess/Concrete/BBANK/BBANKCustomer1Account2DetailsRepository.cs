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
    public class BBANKCustomer1Account2DetailsRepository : BBANKICustomer1Account2DetailsRepository
    {
        BBANKCustomer1Account2Details customer1Account2Details = new BBANKCustomer1Account2Details();

        public void DeleteCustomer1Account2Details(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account2Details_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();
        }

        public List<BBANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1Account2Details_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer1Account2Details> listcustomer1Account2Details = new List<BBANKCustomer1Account2Details>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer1Account2Details customer1Account2Details = new BBANKCustomer1Account2Details();
                    customer1Account2Details.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer1Account2Details.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);
                    customer1Account2Details.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer1Account2Details.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer1Account2Details.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer1Account2Details.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer1Account2Details.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    customer1Account2Details.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer1Account2Details.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer1Account2Details.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    listcustomer1Account2Details.Add(customer1Account2Details);
                }
            }
            if (listcustomer1Account2Details.Count > 0)
            {
                return listcustomer1Account2Details;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1Account2DetailsById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer1Account2Details customer1Account2Details = new BBANKCustomer1Account2Details();
            if (dt.Rows.Count > 0)
            {
                customer1Account2Details.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer1Account2Details.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer1Account2Details.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer1Account2Details.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer1Account2Details.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer1Account2Details.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
                customer1Account2Details.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer1Account2Details.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer1Account2Details.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
            }
            if (customer1Account2Details != null)
            {
                return customer1Account2Details;
            }
            else
            {
                return null;
            }
        }

        public BBANKCustomer1Account2Details PostCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            if (bBANKCustomer1Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account2Details_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer1Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer1Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer1Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer1Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer1Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer1Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer1Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer1Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer1Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer1Account2Details;
        }
        public BBANKCustomer1Account2Details PutCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            if (bBANKCustomer1Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account2Details_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", bBANKCustomer1Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", bBANKCustomer1Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", bBANKCustomer1Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", bBANKCustomer1Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", bBANKCustomer1Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", bBANKCustomer1Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", bBANKCustomer1Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", bBANKCustomer1Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", bBANKCustomer1Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return bBANKCustomer1Account2Details;
        }
    }
}
