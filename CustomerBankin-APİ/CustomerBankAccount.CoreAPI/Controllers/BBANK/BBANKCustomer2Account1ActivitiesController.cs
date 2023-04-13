using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.BBANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BBANKCustomer2Account1ActivitiesController : ControllerBase
    {
        private BBANKICustomer2Account1ActivitiesService customer2AccountActivitiesSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer2Account1ActivitiesController(BBANKICustomer2Account1ActivitiesService customer2AccountActivitiesSAervice, IDataProtectionProvider provider)
        {
            this.customer2AccountActivitiesSAervice = customer2AccountActivitiesSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account1Activities()
        {
            var customer2Account = Customer2Account1Activities();
            var outPut = customer2Account.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                GönderenHesapNo = dataProtector.Protect(x.GönderenHesapNo.ToString()),
                GönderenAdSoyad = dataProtector.Protect(x.GönderenAdSoyad.ToString()),
                İslemTipi = dataProtector.Protect(x.İslemTipi.ToString()),
                GönderenIbanNo = dataProtector.Protect(x.GönderenIbanNo.ToString()),
                GönderilenSubeKodu = dataProtector.Protect(x.AlıcıSubeKodu.ToString()),
                AlıcıHesapNo = dataProtector.Protect(x.AlıcıHesapNo.ToString()),
                AlıcıAdSoyad = dataProtector.Protect(x.AlıcıAdSoyad.ToString()),
                GönderilenTutar = dataProtector.Protect(x.GönderilenTutar.ToString()),
                İşlemAçıklaması = dataProtector.Protect(x.İşlemAçıklaması.ToString()),
                GönderilenTarih = dataProtector.Protect(x.GönderilenTarih.ToString()),
                GelenTransferHesapNo = dataProtector.Protect(x.GelenTransferHesapNo.ToString()),
                GelenTransferIbanNo = dataProtector.Protect(x.GelenTransferIbanNo.ToString()),
                GelenTransferTutarı = dataProtector.Protect(x.GelenTransferTutarı.ToString()),                
                GelenTransferTarih = dataProtector.Protect(x.GelenTransferTarih.ToString()),
            });
            return Ok(outPut);
        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer2Account1Activities(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account = Customer2Account1Activities();
            var ca1 = customer2Account.Where(x => x.GönderenHesapNo == OriginalMN).First();
            return Ok(customer2Account);
        }
        private List<BBANKCustomer2Account1Activities> Customer2Account1Activities()
        {
            var customer2Account = new List<BBANKCustomer2Account1Activities>();
            customer2Account.Add(new BBANKCustomer2Account1Activities()
            {
                Id = 1,
                İslemTipi = "",
                GönderenAdSoyad="",
                GönderenHesapNo = "",
                GönderenIbanNo = "",
                AlıcıHesapNo = "",
                AlıcıIbanNo = "",
                AlıcıAdSoyad = "",
                GönderilenTutar = 0,
                AlıcıSubeKodu = Convert.ToInt32(0),
                İşlemAçıklaması = "",
                GönderilenTarih = DateTime.Now,
                GelenTransferHesapNo = "",
                GelenTransferIbanNo = "",               
                GelenTransferTutarı = 0,
                GelenTransferTarih = DateTime.Now
            });
            return customer2Account;
        }
        [HttpGet("BBANKGetAllCustomer2Account1Activities")]
        public List<BBANKCustomer2Account1Activities> GetAllCustomer2Account1Activities()
        {
            return customer2AccountActivitiesSAervice.GetAllCustomer2Account1Activities();
        }
        [HttpGet("{id}")]
        public BBANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id)
        {
            return customer2AccountActivitiesSAervice.Customer2Account1ActivitiesById(id);
        }
    }
}
