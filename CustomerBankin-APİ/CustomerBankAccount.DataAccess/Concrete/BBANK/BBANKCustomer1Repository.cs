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
    public class BBANKCustomer1Repository : BBANKICustomer1Repository
    {
        BBANKCustomer1 c1 = new BBANKCustomer1();
        public List<BBANKCustomer1> GetAllCustomer1()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer1> listCustomer1 = new List<BBANKCustomer1>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer1 customer1 = new BBANKCustomer1();
                    customer1.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer1.TCKimlikNo = dt.Rows[i]["TCKimlikNo"].ToString();
                    customer1.AdiSoyadi = dt.Rows[i]["AdiSoyadi"].ToString();
                    customer1.MusteriNo = dt.Rows[i]["MusteriNo"].ToString();
                    customer1.Adres = dt.Rows[i]["Adres"].ToString();
                    customer1.TelefonNo = dt.Rows[i]["TelefonNo"].ToString();
                    customer1.EmailAdres = dt.Rows[i]["EmailAdres"].ToString();
                    customer1.AktifMi = Convert.ToBoolean(dt.Rows[i]["AktifMi"]);

                    listCustomer1.Add(customer1);
                }
            }
            if (listCustomer1.Count > 0)
            {
                return listCustomer1;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer1 GetCustomer1ById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1ById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer1 customer1 = new BBANKCustomer1();
            if (dt.Rows.Count > 0)
            {
                customer1.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer1.TCKimlikNo = dt.Rows[0]["TCKimlikNo"].ToString();
                customer1.AdiSoyadi = dt.Rows[0]["AdiSoyadi"].ToString();
                customer1.MusteriNo = dt.Rows[0]["MusteriNo"].ToString();
                customer1.Adres = dt.Rows[0]["Adres"].ToString();
                customer1.TelefonNo = dt.Rows[0]["TelefonNo"].ToString();
                customer1.EmailAdres = dt.Rows[0]["EmailAdres"].ToString();
                customer1.AktifMi = Convert.ToBoolean(dt.Rows[0]["AktifMi"]);

            }
            if (customer1 != null)
            {
                return customer1;
            }
            else
            {
                return null;
            }
        }
        public BBANKCustomer1 PostCustomer1(BBANKCustomer1 customer1)
        {            
            if (customer1 == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", customer1.TCKimlikNo);
                cmd.Parameters.AddWithValue("@AdiSoyadi", customer1.AdiSoyadi);
                cmd.Parameters.AddWithValue("@MusteriNo", customer1.MusteriNo);
                cmd.Parameters.AddWithValue("@Adres", customer1.Adres);
                cmd.Parameters.AddWithValue("@TelefonNo", customer1.TelefonNo);
                cmd.Parameters.AddWithValue("@AktifMi", customer1.AktifMi);
                cmd.Parameters.AddWithValue("@EmailAdres", customer1.EmailAdres);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();                
            }
            return customer1;
        }
        public BBANKCustomer1 PutCustomer1(BBANKCustomer1 customer1)
        {           
            if (customer1 == null)
            {
                SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@TCKimlikNo", customer1.TCKimlikNo);
                cmd.Parameters.AddWithValue("@AdiSoyadi", customer1.AdiSoyadi);
                cmd.Parameters.AddWithValue("@MusteriNo", customer1.MusteriNo);
                cmd.Parameters.AddWithValue("@Adres", customer1.Adres);
                cmd.Parameters.AddWithValue("@TelefonNo", customer1.TelefonNo);
                cmd.Parameters.AddWithValue("@AktifMi", customer1.AktifMi);
                cmd.Parameters.AddWithValue("@EmailAdres", customer1.EmailAdres);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();                
            }
            return customer1;
        }
        public void DeleteCustomer1(int id)
        {            
            SqlCommand cmd = new SqlCommand("sp_BBANKCustomer1_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();           
        }
    }
}
