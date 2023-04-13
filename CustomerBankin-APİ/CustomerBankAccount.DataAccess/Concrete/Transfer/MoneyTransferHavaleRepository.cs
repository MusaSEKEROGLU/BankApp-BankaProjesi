using CustomerBankAccount.DataAccess.Abstract.ITransfer;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Concrete.Transfer
{
    public class MoneyTransferHavaleRepository : IMoneyTransferHavaleRepository
    {
        public void ABANKCustomer1ABANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
                                                         
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-ABANKCustomer2-HavaleHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer1ABANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-ABANKCustomer2-HavaleIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
                                                        
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-VirmanHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-VirmanIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer2ABANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-ABANKCustomer1-HavaleHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer2ABANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-ABANKCustomer1-HavaleIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-VirmanHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void ABANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-VirmanIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer1BBANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-BBANKCustomer2-HavaleHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer1BBANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-BBANKCustomer2-HavaleIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-VirmanHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-VirmanIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer2BBANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-BBANKCustomer1-HavaleHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer2BBANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-BBANKCustomer1-HavaleIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-VirmanHesapNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiHesapNo", GöndericiHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciHesapNo", AliciHesapNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public void BBANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-VirmanIbanNo", CBADbContext.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("GöndericiIbanNo", GöndericiIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciIbanNo", AliciIbanNo);
            adapter.SelectCommand.Parameters.AddWithValue("AliciSubeKodu", AliciSubeKodu);
            adapter.SelectCommand.Parameters.AddWithValue("Tutar", Tutar);
            adapter.SelectCommand.Parameters.AddWithValue("İslemTipi", İslemTipi);
            adapter.SelectCommand.Parameters.AddWithValue("İşlemAçıklaması", İşlemAçıklaması);
            adapter.SelectCommand.Parameters.AddWithValue("AliciAdSoyad", AliciAdSoyad);
            adapter.SelectCommand.Parameters.AddWithValue("GönderilenTarih", GönderilenTarih);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
    }
}
