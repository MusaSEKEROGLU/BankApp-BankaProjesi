using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ITransfer
{
    public interface IMoneyTransferHavaleRepository
    {
        //ABANK VİRMAN
        public void ABANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);

        //ABANK HAVALE
        public void ABANKCustomer1ABANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer1ABANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2ABANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void ABANKCustomer2ABANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);

        //BBANK VİRMAN
        public void BBANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);

        public void BBANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
          string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);

        //BBANK HAVALE
        public void BBANKCustomer1BBANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
          string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer1BBANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2BBANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
        public void BBANKCustomer2BBANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih);
    }
}
