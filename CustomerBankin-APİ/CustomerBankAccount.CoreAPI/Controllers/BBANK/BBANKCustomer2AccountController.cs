using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.BBANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BBANKCustomer2AccountController : ControllerBase
    {
        private BBANKICustomer2AccountService customer2AccountSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer2AccountController(BBANKICustomer2AccountService customer2AccountSAervice, IDataProtectionProvider provider)
        {
            this.customer2AccountSAervice = customer2AccountSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account()
        {
            var customer2Account = Customer2Account();
            var outPut = customer2Account.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),

                HesapNo = dataProtector.Protect(x.HesapNo.ToString()),
                HesapAdi = dataProtector.Protect(x.HesapAdi.ToString()),
                IbanNo = dataProtector.Protect(x.IbanNo.ToString()),
                SubeAdi = dataProtector.Protect(x.SubeAdi.ToString()),
                SubeKodu = dataProtector.Protect(x.SubeKodu.ToString()),
                HesapBakiye = dataProtector.Protect(x.HesapBakiye.ToString()),
                AktifMi = dataProtector.Protect(x.HesapAktifMi.ToString()),
                GünlükTransferLimiti = dataProtector.Protect(x.GünlükTransferLimiti.ToString()),
            });
            return Ok(outPut);
        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer2Account(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account = Customer2Account();
            var ca2 = customer2Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer2Account);
        }
        private List<BBANKCustomer2Account> Customer2Account()
        {
            var customer2Account = new List<BBANKCustomer2Account>();
            customer2Account.Add(new BBANKCustomer2Account()
            {

                Id = 1,

                MusteriNo = "90807060",
                HesapNo = "2204881106",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204881106",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 2020,
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true
            });
            customer2Account.Add(new BBANKCustomer2Account()
            {
                Id = 2,

                MusteriNo = "90807060",
                HesapNo = "2204114308",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204114308",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 2020,
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true

            });
            return customer2Account;
        }
        [HttpGet]
        public List<BBANKCustomer2Account> GetAllCustomer2Account()
        {
            return customer2AccountSAervice.GetAllCustomer2Account().ToList(); ;
        }
        [HttpGet("{id}")]
        public BBANKCustomer2Account GetCustomer2AccountById(int id)
        {
            return customer2AccountSAervice.GetCustomer2AccountById(id);
        }
        [HttpPost]
        public BBANKCustomer2Account PostCustomer2Account(BBANKCustomer2Account customer2Account)
        {
            return customer2AccountSAervice.PostCustomer2Account(customer2Account);
        }
        [HttpPut]
        public BBANKCustomer2Account PutCustomer2Account(BBANKCustomer2Account customer2Account)
        {
            return customer2AccountSAervice.PutCustomer2Account(customer2Account);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account(int id)
        {
             customer2AccountSAervice.DeleteCustomer2Account(id);
        }

    }
}
