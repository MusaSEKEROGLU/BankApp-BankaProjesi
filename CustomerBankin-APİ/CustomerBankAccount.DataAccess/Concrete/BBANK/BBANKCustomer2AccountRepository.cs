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
    public class BBANKCustomer2AccountRepository : BBANKICustomer2AccountRepository
    {
        BBANKCustomer2Account c2a = new BBANKCustomer2Account();
        public List<BBANKCustomer2Account> GetAllCustomer2Account()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2Account_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer2Account> listCustomer2Account = new List<BBANKCustomer2Account>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer2Account customer2Account = new BBANKCustomer2Account();

                    customer2Account.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer2Account.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);

                    customer2Account.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer2Account.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer2Account.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer2Account.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer2Account.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer2Account.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    customer2Account.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer2Account.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    listCustomer2Account.Add(customer2Account);
                }
            }
            if (listCustomer2Account.Count > 0)
            {
                return listCustomer2Account;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer2Account GetCustomer2AccountById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2AccountById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer2Account customer2Account = new BBANKCustomer2Account();
            if (dt.Rows.Count > 0)
            {

                customer2Account.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer2Account.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);

                customer2Account.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer2Account.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer2Account.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
                customer2Account.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer2Account.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer2Account.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
                customer2Account.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer2Account.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
            }
            if (customer2Account != null)
            {
                return customer2Account;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer2Account PostCustomer2Account(BBANKCustomer2Account customer2Account)
        {           
            if (customer2Account == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusteriNo", customer2Account.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapNo", customer2Account.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", customer2Account.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", customer2Account.IbanNo);
                cmd.Parameters.AddWithValue("@SubeAdi", customer2Account.SubeAdi);
                cmd.Parameters.AddWithValue("@HesapBakiye", customer2Account.HesapBakiye);
                cmd.Parameters.AddWithValue("@HesapAktifMi", customer2Account.HesapAktifMi);
                cmd.Parameters.AddWithValue("@SubeKodu", customer2Account.SubeKodu);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", customer2Account.GünlükTransferLimiti);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customer2Account;
        }
        public BBANKCustomer2Account PutCustomer2Account(BBANKCustomer2Account customer2Account)
        {           
            if (customer2Account == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;             
                cmd.Parameters.AddWithValue("@MusteriNo", customer2Account.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapNo", customer2Account.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", customer2Account.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", customer2Account.IbanNo);
                cmd.Parameters.AddWithValue("@SubeAdi", customer2Account.SubeAdi);
                cmd.Parameters.AddWithValue("@HesapBakiye", customer2Account.HesapBakiye);
                cmd.Parameters.AddWithValue("@HesapAktifMi", customer2Account.HesapAktifMi);
                cmd.Parameters.AddWithValue("@SubeKodu", customer2Account.SubeKodu);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", customer2Account.GünlükTransferLimiti);
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customer2Account;
        }
        public void DeleteCustomer2Account(int id)
        {            
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2Account_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();            
        }
    }
}

