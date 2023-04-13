using CustomerBankAccount.DataAccess.Abstract;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Concrete
{
    public class CustomerLoginRepository :ICustomerLoginRepository
    {
        CustomerLogin cl = new CustomerLogin();
        public void DeleteCustomerLogin(int id)
        {          
            SqlCommand cmd = new SqlCommand("sp_CustomerLogin_Delete", CBADbContext.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            CBADbContext.Baglanti.Open();
            int i = cmd.ExecuteNonQuery();
            CBADbContext.Baglanti.Close();           
        }
        public List<CustomerLogin> GetAllCustomerLogin()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_CustomerLogin_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<CustomerLogin> listCustomerlogin = new List<CustomerLogin>();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CustomerLogin customerLogin = new CustomerLogin();
                    customerLogin.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customerLogin.TCKimlikNo = dt.Rows[i]["TCKimlikNo"].ToString();
                    customerLogin.Sifre = dt.Rows[i]["Sifre"].ToString();
                    customerLogin.Role = dt.Rows[i]["Role"].ToString();
                    listCustomerlogin.Add(customerLogin);
                }
            }
            if (listCustomerlogin.Count > 0)
            {
                return listCustomerlogin;
            }
            else
            {
                return null;
            }
        }
        public CustomerLogin GetCustomerLoginById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_CustomerLoginById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CustomerLogin customerLogin = new CustomerLogin();
            if (dt.Rows.Count > 0)
            {
                customerLogin.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customerLogin.TCKimlikNo = dt.Rows[0]["TCKimlikNo"].ToString();
                customerLogin.Sifre = dt.Rows[0]["Sifre"].ToString();
                customerLogin.Role = dt.Rows[0]["Role"].ToString();
            }
            if (customerLogin != null)
            {
                return customerLogin;
            }
            else
            {
                return null;
            }
        }

        public CustomerLogin PostCustomerLogin(CustomerLogin customerLogin)
        {            
            if (customerLogin == null)
            {
                SqlCommand cmd = new SqlCommand("sp_CustomerLogin_Select", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", customerLogin.TCKimlikNo);
                cmd.Parameters.AddWithValue("@Sifre", customerLogin.Sifre);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();
                CBADbContext.Baglanti.Close();               
            }
            return customerLogin;
        }
        public CustomerLogin PutCustomerLogin(CustomerLogin customerLogin)
        {            
            if (customerLogin == null)
            {
                SqlCommand cmd = new SqlCommand("sp_CustomerLogin_Update", CBADbContext.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@TCKimlikNo", customerLogin.TCKimlikNo);
                cmd.Parameters.AddWithValue("@Sifre", customerLogin.Sifre);
                cmd.Parameters.AddWithValue("@Role", customerLogin.Role);
                CBADbContext.Baglanti.Open();
                int i = cmd.ExecuteNonQuery();                
            }
            return customerLogin;
        }

    }
}

