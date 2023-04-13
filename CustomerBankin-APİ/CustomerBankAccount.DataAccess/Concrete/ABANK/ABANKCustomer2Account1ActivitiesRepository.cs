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
    public class ABANKCustomer2Account1ActivitiesRepository : ABANKICustomer2Account1ActivitiesRepository
    {
        ABANKCustomer2Account1Activities customer2Account1Activities = new ABANKCustomer2Account1Activities();
        public ABANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2Account1ActivitiesById_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("Id", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ABANKCustomer2Account1Activities customer2Account1Activities = new ABANKCustomer2Account1Activities();
            if (dt.Rows.Count > 0)
            {
                customer2Account1Activities.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                customer2Account1Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[0]["AlıcıSubeKodu"]);
                customer2Account1Activities.GönderenHesapNo = dt.Rows[0]["GönderenHesapNo"].ToString();
                customer2Account1Activities.İslemTipi = dt.Rows[0]["İslemTipi"].ToString();
                customer2Account1Activities.GönderenAdSoyad = dt.Rows[0]["GönderenAdSoyad"].ToString();
                customer2Account1Activities.GönderenIbanNo = dt.Rows[0]["GönderenIbanNo"].ToString();
                customer2Account1Activities.AlıcıHesapNo = dt.Rows[0]["AlıcıHesapNo"].ToString();
                customer2Account1Activities.AlıcıIbanNo = dt.Rows[0]["AlıcıIbanNo"].ToString();
                customer2Account1Activities.AlıcıAdSoyad = dt.Rows[0]["AlıcıAdSoyad"].ToString();
                customer2Account1Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[0]["GönderilenTutar"]);
                customer2Account1Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[0]["GönderilenTarih"]);
                customer2Account1Activities.İşlemAçıklaması = dt.Rows[0]["İşlemAçıklaması"].ToString();
                customer2Account1Activities.GelenTransferHesapNo = dt.Rows[0]["GelenTransferHesapNo"].ToString();
                customer2Account1Activities.GelenTransferIbanNo = dt.Rows[0]["GelenTransferIbanNo"].ToString();               
                customer2Account1Activities.GelenTransferTutarı = Convert.ToDecimal(dt.Rows[0]["GelenTransferTutarı"]);
                customer2Account1Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[0]["GelenTransferTarih"]);
            }
            if (customer2Account1Activities != null)
            {
                return customer2Account1Activities;
            }
            else
            {
                return null;
            }
        }

        public List<ABANKCustomer2Account1Activities> GetAllCustomer2Account1Activities()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2Account1Activities_Select", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<ABANKCustomer2Account1Activities> listcustomer2Account1Activities = new List<ABANKCustomer2Account1Activities>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ABANKCustomer1Account1Activities customer2Account1Activities = new ABANKCustomer1Account1Activities();
                    customer2Account1Activities.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customer2Account1Activities.AlıcıSubeKodu = Convert.ToInt32(dt.Rows[i]["AlıcıSubeKodu"]);
                    customer2Account1Activities.GönderenHesapNo = dt.Rows[i]["GönderenHesapNo"].ToString();
                    customer2Account1Activities.İslemTipi = dt.Rows[i]["İslemTipi"].ToString();
                    customer2Account1Activities.GönderenAdSoyad = dt.Rows[i]["GönderenAdSoyad"].ToString();
                    customer2Account1Activities.GönderenIbanNo = dt.Rows[i]["GönderenIbanNo"].ToString();
                    customer2Account1Activities.AlıcıHesapNo = dt.Rows[i]["AlıcıHesapNo"].ToString();
                    customer2Account1Activities.AlıcıIbanNo = dt.Rows[i]["AlıcıIbanNo"].ToString();
                    customer2Account1Activities.AlıcıAdSoyad = dt.Rows[i]["AlıcıAdSoyad"].ToString();
                    customer2Account1Activities.GönderilenTutar = Convert.ToDecimal(dt.Rows[i]["GönderilenTutar"]);
                    customer2Account1Activities.GönderilenTarih = Convert.ToDateTime(dt.Rows[i]["GönderilenTarih"]);
                    customer2Account1Activities.İşlemAçıklaması = dt.Rows[i]["İşlemAçıklaması"].ToString();
                    customer2Account1Activities.GelenTransferHesapNo = dt.Rows[i]["GelenTransferHesapNo"].ToString();
                    customer2Account1Activities.GelenTransferIbanNo = dt.Rows[i]["GelenTransferIbanNo"].ToString();
                    customer2Account1Activities.GelenTransferTutarı = Convert.ToDecimal(dt.Rows[i]["GelenTransferTutarı"]);
                    customer2Account1Activities.GelenTransferTarih = Convert.ToDateTime(dt.Rows[i]["GelenTransferTarih"]);
                }
            }
            if (listcustomer2Account1Activities.Count > 0)
            {
                return listcustomer2Account1Activities;
            }
            else
            {
                return null;
            }
        }
    }
}
