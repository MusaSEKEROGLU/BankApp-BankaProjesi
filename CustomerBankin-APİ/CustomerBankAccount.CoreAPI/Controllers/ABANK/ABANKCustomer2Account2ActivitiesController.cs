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
    public class ABANKCustomer2Account2ActivitiesController : ControllerBase
    {

        private ABANKICustomer2Account2ActivitiesService customer2Account2ActivitiesSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer2Account2ActivitiesController(ABANKICustomer2Account2ActivitiesService customer2Account2ActivitiesSAervice, IDataProtectionProvider provider)
        {
            this.customer2Account2ActivitiesSAervice = customer2Account2ActivitiesSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account2Activities()
        {
            var customer2Account2 = Customer2Account2Activities();
            var outPut = customer2Account2.Select(x => new
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
        public IActionResult GetUnprotectCustomer2Account2Activities(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account2 = Customer2Account2Activities();
            var ca1 = customer2Account2.Where(x => x.GönderenHesapNo == OriginalMN).First();
            return Ok(customer2Account2);
        }
        private List<ABANKCustomer2Account2Activities> Customer2Account2Activities()
        {
            var customer2Account2 = new List<ABANKCustomer2Account2Activities>();
            customer2Account2.Add(new ABANKCustomer2Account2Activities()
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
            return customer2Account2;
        }
        [HttpGet("ABANKGetAllCustomer2Account2Activities")]
        public List<ABANKCustomer2Account2Activities> GetAllCustomer2Account2Activities()
        {
            return customer2Account2ActivitiesSAervice.GetAllCustomer2Account2Activities();
        }
        [HttpGet("{id}")]
        public ABANKCustomer2Account2Activities Customer2Account2ActivitiesById(int id)
        {
            return customer2Account2ActivitiesSAervice.Customer2Account2ActivitiesById(id);
        }
    }
}
