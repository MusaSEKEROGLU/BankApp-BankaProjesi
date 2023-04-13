using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.ABANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ABANKCustomer1Account2ActivitiesController : ControllerBase
    {

        private ABANKICustomer1Account2ActivitiesService customer1AccountActivitiesSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer1Account2ActivitiesController(ABANKICustomer1Account2ActivitiesService customer1AccountActivitiesSAervice, IDataProtectionProvider provider)
        {
            this.customer1AccountActivitiesSAervice = customer1AccountActivitiesSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account2Activities()
        {
            var customer1Account = Customer1Account2Activities();
            var outPut = customer1Account.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                GönderenHesapNo = dataProtector.Protect(x.GönderenHesapNo.ToString()),
                GönderenAdSoyad = dataProtector.Protect(x.GönderenAdSoyad.ToString()),
                İslemTipi = dataProtector.Protect(x.İslemTipi.ToString()),
                GönderenIbanNo = dataProtector.Protect(x.GönderenIbanNo.ToString()),
                AlıcıSubeKodu = dataProtector.Protect(x.AlıcıSubeKodu.ToString()),
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
        public IActionResult GetUnprotectCustomer1Account2Activities(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account = Customer1Account2Activities();
            var ca1 = customer1Account.Where(x => x.GönderenHesapNo == OriginalMN).First();
            return Ok(customer1Account);
        }
        private List<ABANKCustomer1Account2Activities> Customer1Account2Activities()
        {
            var customer1Account = new List<ABANKCustomer1Account2Activities>();
            customer1Account.Add(new ABANKCustomer1Account2Activities()
            {
                Id = 2,
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
            return customer1Account;
        }
        [HttpGet("GetAllCustomer1Account2Activities")]
        public List<ABANKCustomer1Account2Activities> GetAllCustomer1Account2Activities()
        {
            return customer1AccountActivitiesSAervice.GetAllCustomer1Account2Activities();
        }
        [HttpGet("{id}")]
        public ABANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id)
        {
            return customer1AccountActivitiesSAervice.Customer1Account2ActivitiesById(id);
        }
    }
}
