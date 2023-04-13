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
    public class BBANKCustomer1AccountRepository : BBANKICustomer1AccountRepository
    {
        BBANKCustomer1Account c1a = new BBANKCustomer1Account();
        public List<BBANKCustomer1Account> GetAllCustomer1Account()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1Account_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer1Account> listCustomer1Account = new List<BBANKCustomer1Account>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer1Account customer1Account = new BBANKCustomer1Account();

                    customer1Account.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer1Account.SubeKodu = Convert.ToInt32(dt.Rows[i]["SubeKodu"]);
                    customer1Account.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer1Account.HesapNo = dt.Rows[i]["HesapNo"].ToString();
                    customer1Account.HesapAdi = dt.Rows[i]["HesapAdi"].ToString();
                    customer1Account.IbanNo = dt.Rows[i]["IbanNo"].ToString();
                    customer1Account.SubeAdi = dt.Rows[i]["SubeAdi"].ToString();
                    customer1Account.HesapAktifMi = Convert.ToBoolean(dt.Rows[i]["HesapAktifMi"]);
                    customer1Account.HesapBakiye = Convert.ToDecimal(dt.Rows[i]["HesapBakiye"]);
                    customer1Account.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[i]["GünlükTransferLimiti"]);
                    listCustomer1Account.Add(customer1Account);
                }
            }
            if (listCustomer1Account.Count > 0)
            {
                return listCustomer1Account;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer1Account GetCustomer1AccountById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1AccountById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer1Account customer1Account = new BBANKCustomer1Account();
            if (dt.Rows.Count > 0)
            {
                customer1Account.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer1Account.SubeKodu = Convert.ToInt32(dt.Rows[0]["SubeKodu"]);
                customer1Account.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer1Account.HesapNo = dt.Rows[0]["HesapNo"].ToString();
                customer1Account.HesapAdi = dt.Rows[0]["HesapAdi"].ToString();
                customer1Account.IbanNo = dt.Rows[0]["IbanNo"].ToString();
                customer1Account.SubeAdi = dt.Rows[0]["SubeAdi"].ToString();
                customer1Account.HesapAktifMi = Convert.ToBoolean(dt.Rows[0]["HesapAktifMi"]);
                customer1Account.HesapBakiye = Convert.ToDecimal(dt.Rows[0]["HesapBakiye"]);
                customer1Account.GünlükTransferLimiti = Convert.ToDecimal(dt.Rows[0]["GünlükTransferLimiti"]);
            }
            if (customer1Account != null)
            {
                return customer1Account;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer1Account PostCustomer1Account(BBANKCustomer1Account customer1Account)
        {           
            if (customer1Account == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusteriNo", customer1Account.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapNo", customer1Account.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", customer1Account.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", customer1Account.IbanNo);
                cmd.Parameters.AddWithValue("@SubeAdi", customer1Account.SubeAdi);
                cmd.Parameters.AddWithValue("@HesapBakiye", customer1Account.HesapBakiye);
                cmd.Parameters.AddWithValue("@HesapAktifMi", customer1Account.HesapAktifMi);
                cmd.Parameters.AddWithValue("@SubeKodu", customer1Account.SubeKodu);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", customer1Account.GünlükTransferLimiti);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();            
            }
            return customer1Account;
        }
        public BBANKCustomer1Account PutCustomer1Account(BBANKCustomer1Account customer1Account)
        {            
            if (customer1Account == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@MusteriNo", customer1Account.MusteriNo);
                cmd.Parameters.AddWithValue("@HesapNo", customer1Account.HesapNo);
                cmd.Parameters.AddWithValue("@HesapAdi", customer1Account.HesapAdi);
                cmd.Parameters.AddWithValue("@IbanNo", customer1Account.IbanNo);
                cmd.Parameters.AddWithValue("@SubeAdi", customer1Account.SubeAdi);
                cmd.Parameters.AddWithValue("@HesapBakiye", customer1Account.HesapBakiye);
                cmd.Parameters.AddWithValue("@HesapAktifMi", customer1Account.HesapAktifMi);
                cmd.Parameters.AddWithValue("@SubeKodu", customer1Account.SubeKodu);
                cmd.Parameters.AddWithValue("@GünlükTransferLimiti", customer1Account.GünlükTransferLimiti);
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customer1Account;
        }
        public void DeleteCustomer1Account(int id)
        {           
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1Account_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();            
        }
    }
}

