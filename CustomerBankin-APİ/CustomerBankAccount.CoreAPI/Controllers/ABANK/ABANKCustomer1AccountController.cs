using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.ABANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ABANKCustomer1AccountController : ControllerBase
    {
        private ABANKICustomer1AccountService customer1AccountSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer1AccountController(ABANKICustomer1AccountService customer1AccountSAervice, IDataProtectionProvider provider)
        {
            this.customer1AccountSAervice = customer1AccountSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
            
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account()
        {
            var customer1Account = Customer1Account();
            var outPut = customer1Account.Select(x => new
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
            var ca1 = customer1Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account);
        }
        private List<ABANKCustomer1Account> Customer1Account()
        {
            var customer1Account = new List<ABANKCustomer1Account>();
            customer1Account.Add(new ABANKCustomer1Account()
            {
                Id = 1,
                MusteriNo = "10203040",
                HesapNo = "1101177809",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177809",
                SubeAdi = "DENİZBANK",
                HesapBakiye = 10000,
                SubeKodu = 1010,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
            customer1Account.Add(new ABANKCustomer1Account()
            {
                Id = 2,
                MusteriNo = "10203040",
                HesapNo = "1101166820",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101166820",
                SubeAdi = "DENİZBANK",
                HesapBakiye = 10000,
                SubeKodu = 1010,
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true
            });
            return customer1Account;
        }
        [HttpGet("GetAllCustomer1Account")]
        public List<ABANKCustomer1Account> GetAllCustomer1Account()
        {
            return customer1AccountSAervice.GetAllCustomer1Account().ToList();
        }
        [HttpGet("{id}")]
        public ABANKCustomer1Account GetCustomer1AccountById(int id)
        {
            return customer1AccountSAervice.GetCustomer1AccountById(id);
        }
        [HttpPost]
        public ABANKCustomer1Account PostCustomer1Account(ABANKCustomer1Account customer1Account)
        {
            
            return customer1AccountSAervice.PostCustomer1Account(customer1Account);
        }
        [HttpPut]
        public ABANKCustomer1Account PutCustomer1Account(ABANKCustomer1Account customer1Account)
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
