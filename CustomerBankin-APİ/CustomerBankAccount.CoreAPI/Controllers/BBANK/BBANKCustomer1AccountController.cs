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
    public class BBANKCustomer1AccountController : ControllerBase
    {
        private BBANKICustomer1AccountService customer1AccountSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer1AccountController(BBANKICustomer1AccountService customer1AccountSAervice, IDataProtectionProvider provider)
        {
            this.customer1AccountSAervice = customer1AccountSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account()
        {
            var customer1Account1 = Customer1Account();
            var outPut = customer1Account1.Select(x => new
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

                //Customer1 = dataProtector.Protect(x.Customer1.ToString()),
                //Customer1AccountActivities = dataProtector.Protect(x.Customer1AccountActivities.ToString()),

            });
            return Ok(outPut);
        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer1Account(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account = Customer1Account();
            var ca2 = customer1Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account);
        }
        private List<BBANKCustomer1Account> Customer1Account()
        {
            var customer1Account = new List<BBANKCustomer1Account>();
            customer1Account.Add(new BBANKCustomer1Account()
            {

                Id = 1,
                MusteriNo = "00002222",
                HesapNo = "2204881999",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204881999",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 3030,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
            customer1Account.Add(new BBANKCustomer1Account()
            {
                Id = 2,
                MusteriNo = "00002222",
                HesapNo = "2204114333",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204114333",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 3030,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
            return customer1Account;
        }
        [HttpGet("BBANKGetAllCustomer1Account")]
        public List<BBANKCustomer1Account> GetAllCustomer1Account()
        {
            return customer1AccountSAervice.GetAllCustomer1Account().ToList(); ;
        }
        [HttpGet("{id}")]
        public BBANKCustomer1Account GetCustomer1AccountById(int id)
        {
            return customer1AccountSAervice.GetCustomer1AccountById(id);
        }
        [HttpPost]
        public BBANKCustomer1Account PostCustomer1Account(BBANKCustomer1Account customer1Account)
        {
            return customer1AccountSAervice.PostCustomer1Account(customer1Account);
        }
        [HttpPut]
        public BBANKCustomer1Account PutCustomer1Account(BBANKCustomer1Account customer1Account)
        {
            return customer1AccountSAervice.PutCustomer1Account(customer1Account);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1Account(int id)
        {
             customer1AccountSAervice.DeleteCustomer1Account(id);
        }

    }
}
