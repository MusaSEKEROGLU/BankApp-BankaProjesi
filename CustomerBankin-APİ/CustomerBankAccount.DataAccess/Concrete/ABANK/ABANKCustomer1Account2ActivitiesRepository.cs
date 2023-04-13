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
    public class ABANKCustomer1Account2ActivitiesRepository : ABANKICustomer1Account2ActivitiesRepository
    {
        ABANKCustomer1Account2Activities customer1Account2Activities = new ABANKCustomer1Account2Activities();
        public ABANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account2ActivitiesById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ABANKCustomer1Account2Activities customer1Account2Activities = new ABANKCustomer1Account2Activities();
            if (dt.Rows.Count > 0)
            {
                customer1Account2Activities.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer1Account2Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[0]["AlıcıSubeKodu"]);
                customer1Account2Activities.GönderenHesapNo = dt.Rows[0]["GönderenHesapNo"].ToString();
                customer1Account2Activities.İslemTipi = dt.Rows[0]["İslemTipi"].ToString();
                customer1Account2Activities.GönderenAdSoyad = dt.Rows[0]["GönderenAdSoyad"].ToString();
                customer1Account2Activities.GönderenIbanNo = dt.Rows[0]["GönderenIbanNo"].ToString();
                customer1Account2Activities.AlıcıHesapNo = dt.Rows[0]["AlıcıHesapNo"].ToString();
                customer1Account2Activities.AlıcıIbanNo = dt.Rows[0]["AlıcıIbanNo"].ToString();
                customer1Account2Activities.AlıcıAdSoyad = dt.Rows[0]["AlıcıAdSoyad"].ToString();
                customer1Account2Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[0]["GönderilenTutar"]);
                customer1Account2Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[0]["GönderilenTarih"]);
                customer1Account2Activities.İşlemAçıklaması = dt.Rows[0]["İşlemAçıklaması"].ToString();
                customer1Account2Activities.GelenTransferHesapNo = dt.Rows[0]["GelenTransferHesapNo"].ToString();
                customer1Account2Activities.GelenTransferIbanNo = dt.Rows[0]["GelenTransferIbanNo"].ToString();
                customer1Account2Activities.GelenTransferTutarı = Convert.ToDecimal(dt.Rows[0]["GelenTransferTutarı"]);
                customer1Account2Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[0]["GelenTransferTarih"]);
            }
            if (customer1Account2Activities != null)
            {
                return customer1Account2Activities;
            }
            else
            {
                return null;
            }
        }

        public List<ABANKCustomer1Account2Activities> GetAllCustomer1Account2Activities()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account2Activities_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<ABANKCustomer1Account2Activities> listcustomer1Account2Activities = new List<ABANKCustomer1Account2Activities>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ABANKCustomer1Account2Activities customer1Account2Activities = new ABANKCustomer1Account2Activities();
                    customer1Account2Activities.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer1Account2Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[i]["AlıcıSubeKodu"]);
                    customer1Account2Activities.GönderenHesapNo = dt.Rows[i]["GönderenHesapNo"].ToString();
                    customer1Account2Activities.İslemTipi = dt.Rows[i]["İslemTipi"].ToString();
                    customer1Account2Activities.GönderenAdSoyad = dt.Rows[i]["GönderenAdSoyad"].ToString();
                    customer1Account2Activities.GönderenIbanNo = dt.Rows[i]["GönderenIbanNo"].ToString();
                    customer1Account2Activities.AlıcıHesapNo = dt.Rows[i]["AlıcıHesapNo"].ToString();
                    customer1Account2Activities.AlıcıIbanNo = dt.Rows[i]["AlıcıIbanNo"].ToString();
                    customer1Account2Activities.AlıcıAdSoyad = dt.Rows[i]["AlıcıAdSoyad"].ToString();
                    customer1Account2Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[i]["GönderilenTutar"]);
                    customer1Account2Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[i]["GönderilenTarih"]);
                    customer1Account2Activities.İşlemAçıklaması = dt.Rows[i]["İşlemAçıklaması"].ToString();
                    customer1Account2Activities.GelenTransferHesapNo = dt.Rows[i]["GelenTransferHesapNo"].ToString();
                    customer1Account2Activities.GelenTransferIbanNo = dt.Rows[i]["GelenTransferIbanNo"].ToString();
                    customer1Account2Activities.GelenTransferTutarı = Convert.ToDecimal(dt.Rows[i]["GelenTransferTutarı"]);
                    customer1Account2Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[i]["GelenTransferTarih"]);
                }
            }
            if (listcustomer1Account2Activities.Count > 0)
            {
                return listcustomer1Account2Activities;
            }
            else
            {
                return null;
            }
        }
    }
}
