using CustomerBankAccount.DataAccess.Abstract.ITransfer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBankAccount.CoreAPI.Controllers.MoneyTransfer
{
    [Route("api/[controller]")]
    [ApiController]
    public class HavaleTransferController : ControllerBase
    {
        private IMoneyTransferHavaleRepository _havaleRepository;

        public HavaleTransferController(IMoneyTransferHavaleRepository havaleRepository)
        {
            this._havaleRepository = havaleRepository;
        }

        [HttpPost("ABANKCustomer1VirmanHesapNo")]
        public void ABANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer1VirmanHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1VirmanIbanNo")]
        public void ABANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer1VirmanIbanNo(GöndericiIbanNo,AliciIbanNo,AliciSubeKodu,Tutar,İslemTipi,İşlemAçıklaması,AliciAdSoyad,GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2VirmanHesapNo")]
        public void ABANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer2VirmanHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2VirmanIbanNo")]
        public void ABANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer2VirmanIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }

        //ABANK HAVALE
        [HttpPost("ABANKCustomer1ABANKCustomer2HavaleHesapNo")]
        public void ABANKCustomer1ABANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer1ABANKCustomer2HavaleHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1ABANKCustomer2HavaleIbanNo")]
        public void ABANKCustomer1ABANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer1ABANKCustomer2HavaleIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2ABANKCustomer1HavaleHesapNo")]
        public void ABANKCustomer2ABANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer2ABANKCustomer1HavaleHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2ABANKCustomer1HavaleIbanNo")]
        public void ABANKCustomer2ABANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.ABANKCustomer2ABANKCustomer1HavaleIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }

        //BBANK VİRMAN
        [HttpPost("BBANKCustomer1VirmanHesapNo")]
        public void BBANKCustomer1VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer1VirmanHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1VirmanIbanNo")]
        public void BBANKCustomer1VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer1VirmanIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2VirmanHesapNo")]
        public void BBANKCustomer2VirmanHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer2VirmanHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2VirmanIbanNo")]
        public void BBANKCustomer2VirmanIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
          string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer2VirmanIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }

        //BBANK HAVALE
        [HttpPost("BBANKCustomer1BBANKCustomer2HavaleHesapNo")]
        public void BBANKCustomer1BBANKCustomer2HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
          string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer1BBANKCustomer2HavaleHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1BBANKCustomer2HavaleIbanNo")]
        public void BBANKCustomer1BBANKCustomer2HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer1BBANKCustomer2HavaleIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2BBANKCustomer1HavaleHesapNo")]
        public void BBANKCustomer2BBANKCustomer1HavaleHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer2BBANKCustomer1HavaleHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2BBANKCustomer1HavaleIbanNo")]
        public void BBANKCustomer2BBANKCustomer1HavaleIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            _havaleRepository.BBANKCustomer2BBANKCustomer1HavaleIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
    }
}
