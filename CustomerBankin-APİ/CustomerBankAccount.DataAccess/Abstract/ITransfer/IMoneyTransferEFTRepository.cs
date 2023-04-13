using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ITransfer
{
    public interface IMoneyTransferEFTRepository
    {
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
    }
}
