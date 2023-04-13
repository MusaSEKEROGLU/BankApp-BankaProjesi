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
    public class EFTTransferController : ControllerBase
    {
        private IMoneyTransferEFTRepository eFTRepository;

        public EFTTransferController(IMoneyTransferEFTRepository eFTRepository)
        {
            this.eFTRepository = eFTRepository;
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo")]
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo")]
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo")]
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo")]
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo")]
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo")]
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo")]
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo")]
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo")]
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo")]
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo")]
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo")]
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo")]
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo")]
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo")]
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo")]
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo")]
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo")]
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo")]
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo")]
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo")]
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo")]
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo")]
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo")]
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo")]
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo")]
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo")]
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo")]
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo")]
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer1Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo")]
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer1Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo")]
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer2Account1EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo")]
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo(string GöndericiHesapNo, string AliciHesapNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer2Account2EFTHesapNo(GöndericiHesapNo, AliciHesapNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo")]
        public void ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
          string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo")]
        public void ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo")]
        public void ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo")]
        public void ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account1BBANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo")]
        public void ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo")]
        public void ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo")]
        public void ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo")]
        public void ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer1Account2BBANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo")]
        public void ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo")]
        public void ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo")]
        public void ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo")]
        public void ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account1BBANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo")]
        public void ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo")]
        public void ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo")]
        public void ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo")]
        public void ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.ABANKCustomer2Account2BBANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo")]
        public void BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo")]
        public void BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo")]
        public void BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo")]
        public void BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account1ABANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo")]
        public void BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo")]
        public void BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo")]
        public void BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo")]
        public void BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer1Account2ABANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo")]
        public void BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
           string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo")]
        public void BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo")]
        public void BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo")]
        public void BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account1ABANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo")]
        public void BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer1Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo")]
        public void BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer1Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo")]
        public void BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer2Account1EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
        [HttpPost("BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo")]
        public void BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo(string GöndericiIbanNo, string AliciIbanNo, int AliciSubeKodu, decimal Tutar,
            string İslemTipi, string İşlemAçıklaması, string AliciAdSoyad, DateTime GönderilenTarih)
        {
            eFTRepository.BBANKCustomer2Account2ABANKCustomer2Account2EFTIbanNo(GöndericiIbanNo, AliciIbanNo, AliciSubeKodu, Tutar, İslemTipi, İşlemAçıklaması, AliciAdSoyad, GönderilenTarih);
        }
    }
}
