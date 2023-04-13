using CustomerBankAccount.DataAccess.Abstract.ITransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Concrete.Transfer
{
    public class MoneyTransferEFTRepository : IMoneyTransferEFTRepository
    {
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1Account1-BBANKCustomer2Account1-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer1-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ABANKCustomer2-BBANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer1-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTHesapNo", CBADbContext.Baglanti);
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
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar, string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_BBANKCustomer2-ABANKCustomer1ve2-EFTIbanNo", CBADbContext.Baglanti);
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
