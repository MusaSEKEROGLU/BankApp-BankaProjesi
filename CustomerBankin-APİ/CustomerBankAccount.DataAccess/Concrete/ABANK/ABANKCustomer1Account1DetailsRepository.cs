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
    public class ABANKCustomer1Account1DetailsRepository : ABANKICustomer1Account1DetailsRepository
    {
        ABANKCustomer1Account1Details customer1AccountDetails = new ABANKCustomer1Account1Details();

        public void DeleteCustomer1Account1Details(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account1Details_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();
        }

        public List<ABANKCustomer1Account1Details> GetAllCustomer1AccountDetails()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account1Details_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<ABANKCustomer1Account1Details> listcustomer1AccountDetails = new List<ABANKCustomer1Account1Details>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ABANKCustomer1Account1Details customer1AccountDetails = new ABANKCustomer1Account1Details();
                    customer1AccountDetails.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    //customer1AccountDetails.customer1AccountId = Convert.ToInt32(dt.Rows[i]["customer1AccountId"]);
                    customer1AccountDetails.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);
                    customer1AccountDetails.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer1AccountDetails.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer1AccountDetails.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer1AccountDetails.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer1AccountDetails.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    customer1AccountDetails.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer1AccountDetails.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer1AccountDetails.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    listcustomer1AccountDetails.Add(customer1AccountDetails);
                }
            }
            if (listcustomer1AccountDetails.Count > 0)
            {
                return listcustomer1AccountDetails;
            }
            else
            {
                return null;
            }
        }

        public ABANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account1DetailsById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ABANKCustomer1Account1Details customer1AccountDetails = new ABANKCustomer1Account1Details();
            if (dt.Rows.Count > 0)
            {
                customer1AccountDetails.Id = Convert.ToInt32(dt.Rows[0]["Id"]);                
                customer1AccountDetails.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer1AccountDetails.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer1AccountDetails.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
                customer1AccountDetails.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer1AccountDetails.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer1AccountDetails.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
                customer1AccountDetails.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer1AccountDetails.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer1AccountDetails.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
            }
            if (customer1AccountDetails != null)
            {
                return customer1AccountDetails;
            }
            else
            {
                return null;
            }
        }

        public ABANKCustomer1Account1Details PostCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
        {
            if (aBANKCustomer1Account1Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account1Details_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", aBANKCustomer1Account1Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", aBANKCustomer1Account1Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", aBANKCustomer1Account1Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", aBANKCustomer1Account1Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", aBANKCustomer1Account1Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", aBANKCustomer1Account1Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", aBANKCustomer1Account1Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", aBANKCustomer1Account1Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", aBANKCustomer1Account1Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return aBANKCustomer1Account1Details;
        }
            public ABANKCustomer1Account1Details PutCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
            {
            if (aBANKCustomer1Account1Details == null)
            {
                SqlCommand cmd = new SqlCommand("sp_ABANKCustomer1Account1Details_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubeKodu", aBANKCustomer1Account1Details.SubeKodu);
                cmd.Parameters.AddWithValue("@HesapNo", aBANKCustomer1Account1Details.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", aBANKCustomer1Account1Details.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", aBANKCustomer1Account1Details.IbanNo);
                cmd.Parameters.AddWithValue("@HesapBakiye", aBANKCustomer1Account1Details.HesapBakiye);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", aBANKCustomer1Account1Details.GünlükTransferLimiti);
                cmd.Parameters.AddWithValue("@SubeAdi", aBANKCustomer1Account1Details.SubeAdi);
                cmd.Parameters.AddWithValue("@MusteriNo", aBANKCustomer1Account1Details.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapAktifMi", aBANKCustomer1Account1Details.HesapAktifMi);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();
            }
            return aBANKCustomer1Account1Details;
        }
    }
}

