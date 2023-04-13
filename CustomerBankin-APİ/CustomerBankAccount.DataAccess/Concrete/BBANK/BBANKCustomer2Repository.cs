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
    public class BBANKCustomer2Repository : BBANKICustomer2Repository
    {
        BBANKCustomer2 c2 = new BBANKCustomer2();
        public List<BBANKCustomer2> GetAllCustomer2()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer2> listCustomer2 = new List<BBANKCustomer2>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer2 customer2 = new BBANKCustomer2();
                    customer2.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer2.TCKimlikNo = dt.Rows[i]["TCKimlikNo"].ToString();
                    customer2.AdiSoyadi = dt.Rows[i]["AdiSoyadi"].ToString();
                    customer2.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer2.Adres = dt.Rows[i]["Adres"].ToString();
                    customer2.TelefonNo = dt.Rows[i]["TelefonNo"].ToString();
                    customer2.EmailAdres = dt.Rows[i]["EmailAdres"].ToString();
                    customer2.AktifMi = Convert.ToBoolean(dt.Rows[i]["AktifMi"]);

                    listCustomer2.Add(customer2);
                }
            }
            if (listCustomer2.Count > 0)
            {
                return listCustomer2;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer2 GetCustomer2ById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2ById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer2 customer2 = new BBANKCustomer2();
            if (dt.Rows.Count > 0)
            {
                customer2.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer2.TCKimlikNo = dt.Rows[0]["TCKimlikNo"].ToString();
                customer2.AdiSoyadi = dt.Rows[0]["AdiSoyadi"].ToString();

                customer2.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer2.Adres = dt.Rows[0]["Adres"].ToString();
                customer2.TelefonNo = dt.Rows[0]["TelefonNo"].ToString();
                customer2.EmailAdres = dt.Rows[0]["EmailAdres"].ToString();
                customer2.AktifMi = Convert.ToBoolean(dt.Rows[0]["AktifMi"]);

            }
            if (customer2 != null)
            {
                return customer2;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer2 PostCustomer2(BBANKCustomer2 customer2)
        {           
            if (customer2 == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", customer2.TCKimlikNo);
                cmd.Parameters.AddWithValue("@AdiSoyadi", customer2.AdiSoyadi);
                cmd.Parameters.AddWithValue("@MusteriNo", customer2.MusteriNo);
                cmd.Parameters.AddWithValue("@Adres", customer2.Adres);
                cmd.Parameters.AddWithValue("@TelefonNo", customer2.TelefonNo);
                cmd.Parameters.AddWithValue("@AktifMi", customer2.AktifMi);
                cmd.Parameters.AddWithValue("@EmailAdres", customer2.EmailAdres);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customer2;
        }
        public BBANKCustomer2 PutCustomer2(BBANKCustomer2 customer2)
        {            
            if (customer2 == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@TCKimlikNo", customer2.TCKimlikNo);
                cmd.Parameters.AddWithValue("@AdiSoyadi", customer2.AdiSoyadi);
                cmd.Parameters.AddWithValue("@MusteriNo", customer2.MusteriNo);
                cmd.Parameters.AddWithValue("@Adres", customer2.Adres);
                cmd.Parameters.AddWithValue("@TelefonNo", customer2.TelefonNo);
                cmd.Parameters.AddWithValue("@AktifMi", customer2.AktifMi);
                cmd.Parameters.AddWithValue("@EmailAdres", customer2.EmailAdres);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customer2;
        }
        public void DeleteCustomer2(int id)
        {           
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer2_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();            
        }
    }
}
