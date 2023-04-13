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
    public class BBANKCustomer1Account2ActivitiesController : ControllerBase
    {
        private BBANKICustomer1Account2ActivitiesService customer1Account2ActivitiesSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer1Account2ActivitiesController(BBANKICustomer1Account2ActivitiesService customer1Account2ActivitiesSAervice, IDataProtectionProvider provider)
        {
            this.customer1Account2ActivitiesSAervice = customer1Account2ActivitiesSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account2Activities()
        {
            var customer1Account2 = Customer1Account2Activities();
            var outPut = customer1Account2.Select(x => new
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
        public IActionResult GetUnprotectCustomer1Account2Activities(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account2 = Customer1Account2Activities();
            var ca1 = customer1Account2.Where(x => x.GönderenHesapNo == OriginalMN).First();
            return Ok(customer1Account2);
        }
        private List<BBANKCustomer1Account2Activities> Customer1Account2Activities()
        {
            var customer1Account2 = new List<BBANKCustomer1Account2Activities>();
            customer1Account2.Add(new BBANKCustomer1Account2Activities()
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
            return customer1Account2;
        }
        [HttpGet("BBANKGetAllCustomer1Account2Activities")]
        public List<BBANKCustomer1Account2Activities> GetAllCustomer1Account2Activities()
        {
            return customer1Account2ActivitiesSAervice.GetAllCustomer1Account2Activities();
        }
        [HttpGet("{id}")]
        public BBANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id)
        {
            return customer1Account2ActivitiesSAervice.Customer1Account2ActivitiesById(id);
        }
    }
}
