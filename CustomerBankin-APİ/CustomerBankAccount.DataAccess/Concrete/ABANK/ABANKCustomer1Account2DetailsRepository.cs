using CustomerBankAccount.DataAccess.Abstract.ABANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Concrete.ABANK
{
    public class ABANKCustomer1Account2DetailsRepository : ABANKICustomer1Account2DetailsRepository
    {
        ABANKCustomer1Account2Details customer1Account2Details = new ABANKCustomer1Account2Details();

        public void DeleteCustomer1Account2Details(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account2Details_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();
        }

        public List<ABANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account2Details_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<ABANKCustomer1Account2Details> listcustomer1Account2Details = new List<ABANKCustomer1Account2Details>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ABANKCustomer1Account2Details customer1Account2Details = new ABANKCustomer1Account2Details();
                    customer1Account2Details.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    //customer1Account2Details.customer1AccountId = Convert.ToInt32(dt.Rows[i]["customer1AccountId"]);
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
        public ABANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account2DetailsById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ABANKCustomer1Account2Details customer1Account2Details = new ABANKCustomer1Account2Details();
            if (dt.Rows.Count > 0)
            {
                customer1Account2Details.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                //customer1Account2Details.customer1AccountId = Convert.ToInt32(dt.Rows[0]["customer1AccountId"]);
                customer1Account2Details.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer1Account2Details.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer1Account2Details.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
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

        public ABANKCustomer1Account2Details PostCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            if (aBANKCustomer1Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account2Details_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", aBANKCustomer1Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", aBANKCustomer1Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", aBANKCustomer1Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", aBANKCustomer1Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", aBANKCustomer1Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", aBANKCustomer1Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", aBANKCustomer1Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", aBANKCustomer1Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", aBANKCustomer1Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return aBANKCustomer1Account2Details;
        }
        public ABANKCustomer1Account2Details PutCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            if (aBANKCustomer1Account2Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account2Details_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", aBANKCustomer1Account2Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", aBANKCustomer1Account2Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", aBANKCustomer1Account2Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", aBANKCustomer1Account2Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", aBANKCustomer1Account2Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", aBANKCustomer1Account2Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", aBANKCustomer1Account2Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", aBANKCustomer1Account2Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", aBANKCustomer1Account2Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return aBANKCustomer1Account2Details;
        }
    }
}

