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
    public class BBANKCustomer1Account1ActivitiesRepository : BBANKICustomer1Account1ActivitiesRepository
    {
        BBANKCustomer1Account1Activities customer1Account1Activities = new BBANKCustomer1Account1Activities();
        public BBANKCustomer1Account1Activities Customer1Account1ActivitiesById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1Account1ActivitiesById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BBANKCustomer1Account1Activities customer1Account1Activities = new BBANKCustomer1Account1Activities();
            if (dt.Rows.Count > 0)
            {
                customer1Account1Activities.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer1Account1Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[0]["AlıcıSubeKodu"]);
                customer1Account1Activities.GönderenHesapNo = dt.Rows[0]["GönderenHesapNo"].ToString();
                customer1Account1Activities.İslemTipi = dt.Rows[0]["İslemTipi"].ToString();
                customer1Account1Activities.GönderenAdSoyad = dt.Rows[0]["GönderenAdSoyad"].ToString();
                customer1Account1Activities.GönderenIbanNo = dt.Rows[0]["GönderenIbanNo"].ToString();
                customer1Account1Activities.AlıcıHesapNo = dt.Rows[0]["AlıcıHesapNo"].ToString();
                customer1Account1Activities.AlıcıIbanNo = dt.Rows[0]["AlıcıIbanNo"].ToString();
                customer1Account1Activities.AlıcıAdSoyad = dt.Rows[0]["AlıcıAdSoyad"].ToString();
                customer1Account1Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[0]["GönderilenTutar"]);
                customer1Account1Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[0]["GönderilenTarih"]);
                customer1Account1Activities.İşlemAçıklaması = dt.Rows[0]["İşlemAçıklaması"].ToString();
                customer1Account1Activities.GelenTransferHesapNo = dt.Rows[0]["GelenTransferHesapNo"].ToString();
                customer1Account1Activities.GelenTransferIbanNo = dt.Rows[0]["GelenTransferIbanNo"].ToString();                              
                customer1Account1Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[0]["GelenTransferTarih"]);
            }
            if (customer1Account1Activities != null)
            {
                return customer1Account1Activities;
            }
            else
            {
                return null;
            }
        }

        public List<BBANKCustomer1Account1Activities> GetAllCustomer1Account1Activities()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1Account1Activities_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<BBANKCustomer1Account1Activities> listcustomer1Account1Activities = new List<BBANKCustomer1Account1Activities>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BBANKCustomer1Account1Activities customer1Account1Activities = new BBANKCustomer1Account1Activities();
                    customer1Account1Activities.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer1Account1Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[i]["AlıcıSubeKodu"]);
                    customer1Account1Activities.GönderenHesapNo = dt.Rows[i]["GönderenHesapNo"].ToString();
                    customer1Account1Activities.İslemTipi = dt.Rows[i]["İslemTipi"].ToString();
                    customer1Account1Activities.GönderenAdSoyad = dt.Rows[i]["GönderenAdSoyad"].ToString();
                    customer1Account1Activities.GönderenIbanNo = dt.Rows[i]["GönderenIbanNo"].ToString();
                    customer1Account1Activities.AlıcıHesapNo = dt.Rows[i]["AlıcıHesapNo"].ToString();
                    customer1Account1Activities.AlıcıIbanNo = dt.Rows[i]["AlıcıIbanNo"].ToString();
                    customer1Account1Activities.AlıcıAdSoyad = dt.Rows[i]["AlıcıAdSoyad"].ToString();
                    customer1Account1Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[i]["GönderilenTutar"]);
                    customer1Account1Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[i]["GönderilenTarih"]);
                    customer1Account1Activities.İşlemAçıklaması = dt.Rows[i]["İşlemAçıklaması"].ToString();
                    customer1Account1Activities.GelenTransferHesapNo = dt.Rows[i]["GelenTransferHesapNo"].ToString();
                    customer1Account1Activities.GelenTransferIbanNo = dt.Rows[i]["GelenTransferIbanNo"].ToString();                  
                    customer1Account1Activities.GelenTransferTutarı = Convert.ToDecimal(dt.Rows[i]["GelenTransferTutarı"]);
                    customer1Account1Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[i]["GelenTransferTarih"]);
                }
            }
            if (listcustomer1Account1Activities.Count > 0)
            {
                return listcustomer1Account1Activities;
            }
            else
            {
                return null;
            }
        }
    }
}
